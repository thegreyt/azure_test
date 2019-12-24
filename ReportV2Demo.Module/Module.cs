using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.XtraReports.UI;
using ReportV2Demo.Module.BusinessObjects;
using ReportV2Demo.Module.PredefinedReadonlyReports;

namespace ReportV2Demo.Module {
        public sealed partial class ReportV2DemoModule : ModuleBase {
        public ReportV2DemoModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            PredefinedReportsUpdater predefinedReportsUpdater = new PredefinedReportsUpdater(Application, objectSpace, versionFromDB);
            predefinedReportsUpdater.AddPredefinedReport<XtraReportOrdinary>("Inplace Report", typeof(Contact), isInplaceReport: true);
            predefinedReportsUpdater.AddPredefinedReport<XtraReportView>("Report with ViewDataSource", null);
            predefinedReportsUpdater.AddPredefinedReport<ContactReportWithSubreportMappedToViewDataSource>("Contact report with subreport mapped to ViewDataSource", typeof(Contact), true);
#region DEMO_REMOVE
#if DEBUG
            predefinedReportsUpdater.AddPredefinedReport<XtraReportOrdinary>("Ordinal Report", null);
            predefinedReportsUpdater.AddPredefinedReport<XtraReportWithSubReport>("Report with sub report", null);
            predefinedReportsUpdater.AddPredefinedReport<XtraReportOrdinary>("Report with object parameters", typeof(Contact), typeof(DemoParameters), isInplaceReport: false);
#endif
#endregion
            return new ModuleUpdater[] { updater, predefinedReportsUpdater };
        }
        protected override IEnumerable<Type> GetDeclaredExportedTypes() {
            var list = base.GetDeclaredExportedTypes().ToList();
            list.AddRange(new[] { typeof(PermissionPolicyUser), typeof(PermissionPolicyRole) });
            return list;
        }
    }
#region DEMO_REMOVE
#if DEBUG
    public class CheckMemoryController : WindowController {
        DevExpress.ExpressApp.Actions.SimpleAction startTrackMemoryAction;
        DevExpress.ExpressApp.Actions.SimpleAction endTrackMemoryAction;
        DevExpress.ExpressApp.Actions.SimpleAction showMemoryAction;
        DevExpress.ExpressApp.Actions.ParametrizedAction maxMemoryAction;
        DevExpress.ExpressApp.Actions.ParametrizedAction usedKBAction;
        private long initialUsedMemory;
        private long maxUsedMemory;
        private long usedKB = 1024;
        public CheckMemoryController() {
            startTrackMemoryAction = new DevExpress.ExpressApp.Actions.SimpleAction(this, "StartTrackMemory", PredefinedCategory.Tools);
            startTrackMemoryAction.Caption = "StartTrackMemory";
            startTrackMemoryAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(action_Execute);

            maxMemoryAction = new DevExpress.ExpressApp.Actions.ParametrizedAction(this, "MaxMemory", PredefinedCategory.Tools, typeof(int));
            maxMemoryAction.Caption = "MaxMemory";
            maxMemoryAction.Execute += new DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventHandler(maxMemoryAction_Execute);

            usedKBAction = new DevExpress.ExpressApp.Actions.ParametrizedAction(this, "UsedKB", PredefinedCategory.Tools, typeof(int));
            usedKBAction.Caption = "UsedKB";
            usedKBAction.Execute += UsedKBAction_Execute;

            endTrackMemoryAction = new DevExpress.ExpressApp.Actions.SimpleAction(this, "EndTrackMemory", PredefinedCategory.Tools);
            endTrackMemoryAction.Caption = "EndTrackMemory";
            endTrackMemoryAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(endTrackMemoryAction_Execute);

            showMemoryAction = new DevExpress.ExpressApp.Actions.SimpleAction(this, "showMemoryAction", PredefinedCategory.Tools);
            showMemoryAction.Caption = "showMemoryAction";
            showMemoryAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(actionShowMemory_Execute);
        }

        private void UsedKBAction_Execute(object sender, DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventArgs e) {
            if(e.ParameterCurrentValue != null) {
                usedKB = (int)e.ParameterCurrentValue;
            }
        }

        void maxMemoryAction_Execute(object sender, DevExpress.ExpressApp.Actions.ParametrizedActionExecuteEventArgs e) {
            maxUsedMemory = 0;
            if(e.ParameterCurrentValue != null) {
                maxUsedMemory = (int)e.ParameterCurrentValue;
            }
        }

        void endTrackMemoryAction_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            DevExpress.Data.Helpers.LohPooled.PoolBase.FlushPools();
            GC.GetTotalMemory(true);
            long usedMemory = GC.GetTotalMemory(true);
            long memoryGrow = (usedMemory - initialUsedMemory) / (1024 * usedKB);
            if(memoryGrow > maxUsedMemory) {
                throw new Exception(memoryGrow.ToString());
            }
            else {
                throw new Exception(maxUsedMemory.ToString());
            }
        }

        private void action_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            GC.GetTotalMemory(true);
            initialUsedMemory = GC.GetTotalMemory(true);
        }

        private void actionShowMemory_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
            GC.Collect();
            GC.GetTotalMemory(true);
            initialUsedMemory = GC.GetTotalMemory(true);
            throw new Exception(initialUsedMemory.ToString());
        }
    }

    public class XtraReportWithSubReport : XtraReportOrdinary {
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        public XtraReportWithSubReport()
            : base() {
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();

            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.PageHeader.HeightF = 89.99998F;
            this.PageHeader.Name = "PageHeader";
            this.xrSubreport1.Id = 0;
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ReportSource = new ReportV2Demo.Module.XtraReportSubReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(630F, 43.54165F);
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { this.PageHeader});
            this.Name = "XtraReportWithSub";
            this.Version = AssemblyInfo.VersionShort;
            this.DisplayName = "Report with sub report";

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }

    }

    public class XtraReportSubReport : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;

        public XtraReportSubReport() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2});
            this.collectionDataSource1.Name = "collectionDataSource1";
            this.collectionDataSource1.ObjectTypeName = "ReportV2Demo.Module.BusinessObjects.Company";
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Name")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(268.125F, 23F);
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "City")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(371.875F, 10.00001F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(268.125F, 23F);
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] { this.Detail });
            this.ComponentStorage.Add(this.collectionDataSource1);
            this.DataSource = this.collectionDataSource1;
            this.Version = AssemblyInfo.VersionShort;
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

    }
#endif
#endregion
}
