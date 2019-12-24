using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.XtraReports.UI;
using DevExpress.ExpressApp.Security;
using ReportV2Demo.Module.BusinessObjects;
#if !DXCORE3
using ReportV2Demo.Module.PredefinedEditableReports;
#endif
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReportV2Demo.Module.DatabaseUpdate
{
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Position developerPosition = ObjectSpace.FindObject<Position>(CriteriaOperator.Parse("Title == 'Developer'"));
            if(developerPosition == null) {
                developerPosition = ObjectSpace.CreateObject<Position>();
                developerPosition.Title = "Developer";
            }
            Position managerPosition = ObjectSpace.FindObject<Position>(CriteriaOperator.Parse("Title == 'Manager'"));
            if(managerPosition == null) {
                managerPosition = ObjectSpace.CreateObject<Position>();
                managerPosition.Title = "Manager";
            }

            Contact contactJohn = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if(contactJohn == null) {
                contactJohn = ObjectSpace.CreateObject<Contact>();
                contactJohn.FirstName = "John";
                contactJohn.LastName = "Nilsen";
                contactJohn.Email = "john_nilsen@md.com";
                contactJohn.Birthday = new DateTime(1981, 10, 3);
                contactJohn.Position = developerPosition;
            }
            PhoneNumber johnPhoneNumber_1 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '888-111-222'"));
            if(johnPhoneNumber_1 == null) {
                johnPhoneNumber_1 = ObjectSpace.CreateObject<PhoneNumber>();
                johnPhoneNumber_1.Number = "888-111-222";
                contactJohn.PhoneNumbers.Add(johnPhoneNumber_1);
            }
            PhoneNumber johnPhoneNumber_2 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '888-333-222'"));
            if(johnPhoneNumber_2 == null) {
                johnPhoneNumber_2 = ObjectSpace.CreateObject<PhoneNumber>();
                johnPhoneNumber_2.Number = "888-333-222";
                contactJohn.PhoneNumbers.Add(johnPhoneNumber_2);
            }

            ObjectSpace.CommitChanges();

            Contact contactMary = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if(contactMary == null) {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "mary_tellitson@md.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
                contactMary.Position = managerPosition;
            }
            PhoneNumber maryPhoneNumber_1 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '999-999-999'"));
            if(maryPhoneNumber_1 == null) {
                maryPhoneNumber_1 = ObjectSpace.CreateObject<PhoneNumber>();
                maryPhoneNumber_1.Number = "999-999-999";
                contactMary.PhoneNumbers.Add(maryPhoneNumber_1);
            }
            PhoneNumber maryPhoneNumber_2 = ObjectSpace.FindObject<PhoneNumber>(CriteriaOperator.Parse("Number == '999-999-777'"));
            if(maryPhoneNumber_2 == null) {
                maryPhoneNumber_2 = ObjectSpace.CreateObject<PhoneNumber>();
                maryPhoneNumber_2.Number = "999-999-777";
                contactMary.PhoneNumbers.Add(maryPhoneNumber_2);
            }

            ObjectSpace.CommitChanges();

            Company myOrg = ObjectSpace.FindObject<Company>(CriteriaOperator.Parse("Name == 'Demo Company'"));
            if(myOrg == null) {
                myOrg = ObjectSpace.CreateObject<Company>();
                myOrg.Name = "Demo Company";
                myOrg.City = "DefaultCity";
            }
#if !DXCORE3
            CreateReport("OrdinalReport", OrdinalReportResource.ReportLayout, "ReportWithParametersObject", typeof(DemoParameters));
            ReportDataV2 reportData = CreateReport("SubreportCompany", SubreportCompanyLayout.ReportLayout);
            string reportWithSubReportLayout = ReportWithSubReportLayout.ReportLayout.Replace("SubReportKEY", ObjectSpace.GetObjectHandle(reportData));
            ReportDataV2 simpleSubReportData = CreateReport("SimpleSubReport", SimpleSubReportLayout.ReportLayout);
            string reportWithSubReportDifferentEnumsLayout = ReportWithSubReportDifferentEnumsLayout.ReportLayout.Replace("SubReportKEY", ObjectSpace.GetObjectHandle(simpleSubReportData));
            CreateReport("ReportWithSecurity", ReportWithSecurity.ReportLayout);
            CreateReport("ReportWithSubReportDifferentEnums", reportWithSubReportDifferentEnumsLayout);
            CreateReport("ReportWithSubReport", reportWithSubReportLayout);
            CreateReport("ReportWithViewDataSource", ReportWithViewDataSourceLayout.ReportLayout);
            CreateReport("OrdinalReport", OrdinalReportResource.ReportLayout);
#else
            CreateReport("OrdinalReport", "OrdinalReport.repx");
            CreateReport("ReportWithSecurity", "ReportWithSecurity.repx");
            CreateReport("OrdinalReport", "OrdinalReport.repx", "ReportWithParametersObject", typeof(DemoParameters));
            ReportDataV2 simpleSubReportData = CreateReport("SimpleSubReport", "SimpleSubReport.repx");
            CreateReport("ReportWithSubReportDifferentEnums", "ReportWithSubReportDifferentEnums.repx", subReportUrl: ObjectSpace.GetObjectHandle(simpleSubReportData));
            ReportDataV2 reportData = CreateReport("SubreportCompany", "SubreportCompany.repx");
            CreateReport("ReportWithSubReport", "ReportWithSubReport.repx", subReportUrl: ObjectSpace.GetObjectHandle(reportData));
            CreateReport("ReportWithViewDataSource", "ReportWithViewDataSource.repx");

#endif
            CreateReportParameters();
            CreateReportMultiValueParameters();
            CreateReportWithBookmark();
            CreateUser();
            SimpleObjectWithEnum simpleObjectWithEnum = ObjectSpace.FindObject<SimpleObjectWithEnum>(CriteriaOperator.Parse("Name == 'One'"));
            if(simpleObjectWithEnum == null) {
                simpleObjectWithEnum = ObjectSpace.CreateObject<SimpleObjectWithEnum>();
                simpleObjectWithEnum.Name = "One";
                simpleObjectWithEnum.SimpleEnum = SimpleEnum.One;
            }
            ObjectWithSecurity objectWithSecurity = ObjectSpace.FindObject<ObjectWithSecurity>(new BinaryOperator("Name", "TestObject"));
            if(objectWithSecurity == null) {
                objectWithSecurity = ObjectSpace.CreateObject<ObjectWithSecurity>();
                objectWithSecurity.Name = "TestObject";
                PermissionPolicyUser user = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "User"));
                objectWithSecurity.User = user;
            }


            ObjectSpace.CommitChanges();
        }
        private void CreateUser() {
            PermissionPolicyUser user = ObjectSpace.FindObject<PermissionPolicyUser>(new BinaryOperator("UserName", "User"));
            if(user == null) {
                user = ObjectSpace.CreateObject<PermissionPolicyUser>();
                user.UserName = "User";
                user.IsActive = true;
            }

            PermissionPolicyRole role = ObjectSpace.FindObject<PermissionPolicyRole>(new BinaryOperator("Name", "UserRole"));
            if(role == null) {
                role = ObjectSpace.CreateObject<PermissionPolicyRole>();
                role.IsAdministrative = false;
                role.Name = "UserRole";
                role.PermissionPolicy = DevExpress.Persistent.Base.SecurityPermissionPolicy.AllowAllByDefault;
                role.AddTypePermission<ObjectWithSecurity>(SecurityOperations.Read, DevExpress.Persistent.Base.SecurityPermissionState.Deny);
                role.AddObjectPermission<ObjectWithSecurity>(SecurityOperations.Read, "[User.Oid] = CurrentUserID()", DevExpress.Persistent.Base.SecurityPermissionState.Allow);
                role.Users.Add(user);
            }
        }
#if !DXCORE3
        private ReportDataV2 CreateReport(string reportName, string layout, string displayName = null, Type parameters = null) {
            if(displayName == null)
                displayName = reportName;
            ReportDataV2 reportData = ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", displayName));
            if(reportData == null) {
                reportData = ObjectSpace.CreateObject<ReportDataV2>();
                XtraReport rep = new XtraReport();
                byte[] byteArray = Encoding.UTF8.GetBytes(ConvertVersion(layout));
                MemoryStream stream = new MemoryStream(byteArray);
                rep.LoadLayout(stream);
                rep.DisplayName = displayName;
                if(parameters != null) {
                    reportData.ParametersObjectType = parameters;
                }
                ReportDataProvider.ReportsStorage.SaveReport(reportData, rep);
                reportData.IsInplaceReport = true;
            }
            ObjectSpace.CommitChanges();

            return reportData;
        }
        private string ConvertVersion(string reportLayout) {
            string result = reportLayout;
            result = result.Replace("VSuffix", AssemblyInfo.VSuffix);
            result = result.Replace("dllVersion", AssemblyInfo.Version);
            result = result.Replace("dllPublicKeyToken", AssemblyInfo.PublicKeyToken);
            result = result.Replace("VersionShort", AssemblyInfo.VersionShort);
            return result;
        }
#else
        private ReportDataV2 CreateReport(string reportName, string layoutName, string displayName = null, Type parameters = null, string subReportUrl = null) {
            if(displayName == null)
                displayName = reportName;
            ReportDataV2 reportData = ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", displayName));
            if(reportData == null) {
                reportData = ObjectSpace.CreateObject<ReportDataV2>();
                XtraReport rep = new XtraReport();
                var assembly = Assembly.GetExecutingAssembly();
                var resourceNames = assembly.GetManifestResourceNames();
                var resourceName = resourceNames.FirstOrDefault(p => p.Contains(layoutName));

                using(Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                    rep.LoadLayout(stream);
                }
                var subreport = rep.AllControls<XRSubreport>().FirstOrDefault();
                if(subreport != null && subReportUrl != null) {
                    subreport.ReportSourceUrl = subReportUrl;
                }
                rep.DisplayName = displayName;
                if(parameters != null) {
                    reportData.ParametersObjectType = parameters;
                }
                ReportDataProvider.ReportsStorage.SaveReport(reportData, rep);
                reportData.IsInplaceReport = true;
            }
            ObjectSpace.CommitChanges();

            return reportData;

        }
#endif
        public void CreateReportWithBookmark() {
            ReportDataV2 reportData = ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "ReportWithBookmark"));
            if(reportData == null) {
                reportData = ObjectSpace.CreateObject<ReportDataV2>();
                XtraReport rep = new XtraReport();
#if !DXCORE3
                byte[] byteArray = Encoding.UTF8.GetBytes(ConvertVersion(OrdinalReportResource.ReportLayout));
                MemoryStream stream = new MemoryStream(byteArray);
                rep.LoadLayout(stream);
#else
                var assembly = Assembly.GetExecutingAssembly();
                var resourceNames = assembly.GetManifestResourceNames();
                var resourceName = resourceNames.FirstOrDefault(p => p.Contains("OrdinalReport.repx"));

                using(Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                    rep.LoadLayout(stream);
                }
#endif
                rep.DisplayName = "ReportWithBookmark";
                rep.Bookmark = "Names";
                XRControl control = rep.FindControl("label5", true);
                if(control != null) {
                    control.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "FirstName"));
                }
                control = rep.FindControl("label9", true);
                if(control != null) {
                    control.Text = "Report with bookmarks";
                }
                ReportDataProvider.ReportsStorage.SaveReport(reportData, rep);
            }
        }
        public void CreateReportParameters() {
            ReportDataV2 reportData = ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "ReportWithParameters"));
            if(reportData == null) {
                reportData = ObjectSpace.CreateObject<ReportDataV2>();
                XtraReport rep = new XtraReport();
#if !DXCORE3
                byte[] byteArray = Encoding.UTF8.GetBytes(ConvertVersion(OrdinalReportResource.ReportLayout));
                MemoryStream stream = new MemoryStream(byteArray);
                rep.LoadLayout(stream);
#else
                var assembly = Assembly.GetExecutingAssembly();
                var resourceNames = assembly.GetManifestResourceNames();
                var resourceName = resourceNames.FirstOrDefault(p => p.Contains("OrdinalReport.repx"));

                using(Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                    rep.LoadLayout(stream);
                }
#endif
                rep.DisplayName = "ReportWithParameters";
                rep.FilterString = "StartsWith([FirstName], ?parameterName) And [Position] = ?parameterPosition";
                DevExpress.XtraReports.Parameters.Parameter parameterName = new DevExpress.XtraReports.Parameters.Parameter();
                DevExpress.XtraReports.Parameters.Parameter parameterPosition = new DevExpress.XtraReports.Parameters.Parameter();
                parameterName.Description = "FirstName";
                parameterName.Name = "parameterName";
                parameterPosition.Description = "Position";
                parameterPosition.Name = "parameterPosition";
                parameterPosition.Type = typeof(ReportV2Demo.Module.BusinessObjects.Position);
                rep.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
                        parameterName,
                        parameterPosition});
                XRControl control = rep.FindControl("label9", true);
                if(control != null) {
                    control.Text = "Contacts with parameters";
                }
                ReportDataProvider.ReportsStorage.SaveReport(reportData, rep);
            }
        }
        public void CreateReportMultiValueParameters() {
            ReportDataV2 reportData = ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "ReportWithMultiValueParameters"));
            if(reportData == null) {
                reportData = ObjectSpace.CreateObject<ReportDataV2>();
                XtraReport rep = new XtraReport();
#if !DXCORE3
                byte[] byteArray = Encoding.UTF8.GetBytes(ConvertVersion(OrdinalReportResource.ReportLayout));
                MemoryStream stream = new MemoryStream(byteArray);
                rep.LoadLayout(stream);
#else
                var assembly = Assembly.GetExecutingAssembly();
                var resourceNames = assembly.GetManifestResourceNames();
                var resourceName = resourceNames.FirstOrDefault(p => p.Contains("OrdinalReport.repx"));

                using(Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                    rep.LoadLayout(stream);
                }
#endif
                rep.DisplayName = "ReportWithMultiValueParameters";
                rep.FilterString = "[Title Of Courtesy] In (?parameterTitle) Or [Position] In (?parameterPosition)";
                DevExpress.XtraReports.Parameters.Parameter parameterTitle = new DevExpress.XtraReports.Parameters.Parameter();
                DevExpress.XtraReports.Parameters.Parameter parameterPosition = new DevExpress.XtraReports.Parameters.Parameter();
                parameterTitle.Description = "Title";
                parameterTitle.Type = typeof(TitleOfCourtesy);
                parameterTitle.Name = "parameterTitle";
                parameterTitle.MultiValue = true;
                parameterPosition.Description = "Position";
                parameterPosition.Name = "parameterPosition";
                parameterPosition.Type = typeof(Position);
                parameterPosition.MultiValue = true;
                rep.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
                        parameterTitle,
                        parameterPosition});
                XRControl control = rep.FindControl("label9", true);
                if(control != null) {
                    control.Text = "Contacts with parameters";
                }
                ReportDataProvider.ReportsStorage.SaveReport(reportData, rep);
            }
        }

    }
  

}
