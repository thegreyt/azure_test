using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportV2Demo.Module.PredefinedEditableReports {
    public class ReportWithViewDataSourceLayout {
        public static string ReportLayout = @"
/// <XRTypeInfo>
///   <AssemblyFullName>DevExpress.XtraReports.v17.2, Version=17.2.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a</AssemblyFullName>
///   <AssemblyLocation>C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraReports.v17.2\v4.0_17.2.2.0__b88d1754d700e49a\DevExpress.XtraReports.v17.2.dll</AssemblyLocation>
///   <TypeName>DevExpress.XtraReports.UI.XtraReport</TypeName>
///   <Localization>en-US</Localization>
///   <Version>17.2</Version>
///   <References>
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.Persistent.Base.v17.2\v4.0_17.2.2.0__b88d1754d700e49a\DevExpress.Persistent.Base.v17.2.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.SqlXml\v4.0_4.0.0.0__b77a5c561934e089\System.Data.SqlXml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Security\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Security.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Numerics\v4.0_4.0.0.0__b77a5c561934e089\System.Numerics.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.ExpressApp.v17.2\v4.0_17.2.2.0__b88d1754d700e49a\DevExpress.ExpressApp.v17.2.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml\v4.0_4.0.0.0__b77a5c561934e089\System.Xaml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Internals\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Internals.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\SMDiagnostics\v4.0_4.0.0.0__b77a5c561934e089\SMDiagnostics.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Transactions\v4.0_4.0.0.0__b77a5c561934e089\System.Transactions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.EnterpriseServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.EnterpriseServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Remoting\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Remoting.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.RegularExpressions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Forms\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Forms.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Accessibility\v4.0_4.0.0.0__b03f5f7f11d50a3a\Accessibility.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Deployment\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Deployment.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization.Formatters.Soap\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Serialization.Formatters.Soap.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Data.OracleClient\v4.0_4.0.0.0__b77a5c561934e089\System.Data.OracleClient.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices.Protocols\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.Protocols.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceProcess\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.ServiceProcess.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration.Install\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.Install.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Services\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.Services.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Utilities.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Utilities.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Framework\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Framework.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Tasks.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Tasks.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Transactions.Bridge\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Transactions.Bridge.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel.Selectors\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.Selectors.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Messaging\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Messaging.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.DurableInstancing\v4.0_4.0.0.0__31bf3856ad364e35\System.Runtime.DurableInstancing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Net.Http\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Net.Http.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activation\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activation.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activities.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.Activities.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\Microsoft.VisualBasic.Activities.Compiler\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.VisualBasic.Activities.Compiler.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.VisualBasic\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.VisualBasic.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Management\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Management.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.JScript\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.JScript.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Activities.DurableInstancing\v4.0_4.0.0.0__31bf3856ad364e35\System.Activities.DurableInstancing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml.Hosting\v4.0_4.0.0.0__31bf3856ad364e35\System.Xaml.Hosting.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.Utils.v17.2\v4.0_17.2.2.0__b88d1754d700e49a\DevExpress.Utils.v17.2.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\PresentationCore\v4.0_4.0.0.0__31bf3856ad364e35\PresentationCore.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\WindowsBase\v4.0_4.0.0.0__31bf3856ad364e35\WindowsBase.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationTypes\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationTypes.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Input.Manipulations\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Input.Manipulations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationProvider\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationProvider.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationClient\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationClient.dll"" />
///   </References>
///   <Resources>
///     <Resource Name=""XtraReportSerialization.xtraReport1"">
/// zsrvvgEAAACRAAAAbFN5c3RlbS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTQuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVzb3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAAAAAAAAAAAAFBBRFBBRFC0AAAA</Resource>
///   </Resources>
/// </XRTypeInfo>
namespace XtraReportSerialization {
    
    public class xtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.Persistent.Base.ReportsV2.ViewDataSource viewDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private System.Resources.ResourceManager _resources;
        private string _resourceString;
        public xtraReport1() {
            this._resourceString = DevExpress.XtraReports.Serialization.XRResourceManager.GetResourceFor(""XtraReportSerialization.xtraReport1"");
            this.InitializeComponent();
        }
        private System.Resources.ResourceManager resources {
            get {
                if (_resources == null) {
                    this._resources = new DevExpress.XtraReports.Serialization.XRResourceManager(this._resourceString);
                }
                return this._resources;
            }
        }
        private void InitializeComponent() {
            DevExpress.Persistent.Base.ReportsV2.ViewProperty viewProperty1 = new DevExpress.Persistent.Base.ReportsV2.ViewProperty();
            DevExpress.Persistent.Base.ReportsV2.ViewProperty viewProperty2 = new DevExpress.Persistent.Base.ReportsV2.ViewProperty();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.viewDataSource1 = new DevExpress.Persistent.Base.ReportsV2.ViewDataSource();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.label4,
                        this.label5,
                        this.label1,
                        this.label2,
                        this.line1});
            this.detailBand1.HeightF = 62.20834F;
            this.detailBand1.Name = ""detailBand1"";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
                        new DevExpress.XtraReports.UI.GroupField(""Demo1"", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.label3});
            this.reportHeaderBand1.HeightF = 51F;
            this.reportHeaderBand1.Name = ""reportHeaderBand1"";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = ""topMarginBand1"";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 100.1667F;
            this.bottomMarginBand1.Name = ""bottomMarginBand1"";
            // 
            // label4
            // 
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(6.000042F, 34.20833F);
            this.label4.Name = ""label4"";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label4.StyleName = ""FieldCaption"";
            this.label4.Text = ""LastName"";
            // 
            // label5
            // 
            this.label5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[Demo2]"")});
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(174F, 34.20833F);
            this.label5.Name = ""label5"";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label5.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label5.StyleName = ""DataField"";
            this.label5.Text = ""label5"";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 9F);
            this.label1.Name = ""label1"";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label1.StyleName = ""FieldCaption"";
            this.label1.Text = ""FirstName"";
            // 
            // label2
            // 
            this.label2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[Demo1]"")});
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(174F, 9F);
            this.label2.Name = ""label2"";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label2.StyleName = ""DataField"";
            this.label2.Text = ""label2"";
            // 
            // line1
            // 
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 3F);
            this.line1.Name = ""line1"";
            this.line1.SizeF = new System.Drawing.SizeF(638F, 2F);
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.label3.Name = ""label3"";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(638F, 33F);
            this.label3.StyleName = ""Title"";
            this.label3.Text = ""Report ViewDataSource"";
            // 
            // viewDataSource1
            // 
            this.viewDataSource1.Name = ""viewDataSource1"";
            this.viewDataSource1.ObjectTypeName = ""ReportV2Demo.Module.BusinessObjects.Contact"";
            viewProperty1.DisplayName = ""Demo1"";
            viewProperty1.Expression = ""[FirstName]"";
            viewProperty2.DisplayName = ""Demo2"";
            viewProperty2.Expression = ""[LastName]"";
            this.viewDataSource1.Properties.AddRange(new DevExpress.Persistent.Base.ReportsV2.ViewProperty[] {
                        viewProperty1,
                        viewProperty2});
            this.viewDataSource1.TopReturnedRecords = 0;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font(""Times New Roman"", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = ""Title"";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font(""Arial"", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = ""FieldCaption"";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font(""Times New Roman"", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = ""PageInfo"";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font(""Times New Roman"", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = ""DataField"";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                        this.detailBand1,
                        this.reportHeaderBand1,
                        this.topMarginBand1,
                        this.bottomMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
                        this.viewDataSource1});
            this.DataSource = this.viewDataSource1;
            this.DisplayName = ""ReportWithViewDataSource"";
            this.Extensions.Add(""DataSerializationExtension"", ""XtraReport"");
            this.Extensions.Add(""DataEditorExtension"", ""XtraReport"");
            this.Extensions.Add(""ParameterEditorExtension"", ""XtraReport"");
            this.Name = ""xtraReport1"";
            this.PageHeight = 1100;
            this.PageWidth = 850;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
                        this.Title,
                        this.FieldCaption,
                        this.PageInfo,
                        this.DataField});
            this.Version = ""17.2"";
            ((System.ComponentModel.ISupportInitialize)(this.viewDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
";
    }
}
