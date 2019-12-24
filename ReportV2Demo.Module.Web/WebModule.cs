using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.ReportsV2.Web;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Updating;
using DevExpress.XtraReports.UI;

namespace ReportV2Demo.Module.Web {
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class ReportV2DemoAspNetModule : ModuleBase {
        public ReportV2DemoAspNetModule() {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }

    #region DEMO_REMOVE
    #if DEBUG
    public class ExportVisibleActionController : ObjectViewController<ListView, IReportDataV2> {
        public ExportVisibleActionController() {
            IContainer components = new System.ComponentModel.Container();
            SimpleAction showExportActions = new DevExpress.ExpressApp.Actions.SimpleAction(components);
            showExportActions.Caption = "Show export actions";
            showExportActions.Category = "View";
            showExportActions.Id = "showExportAction";
            showExportActions.Execute += new SimpleActionExecuteEventHandler(this.showExportActions_Execute);

            RegisterActions(components);
        }
        private void showExportActions_Execute(object sender, SimpleActionExecuteEventArgs e) {
            Frame.GetController<WebReportsController>().SetFormatSpecificExportActionsVisible(true);
        }
    }
    public class HTMLViewerActionController : ObjectViewController<ListView, IReportDataV2> {
        public HTMLViewerActionController() {
            SimpleAction action = new DevExpress.ExpressApp.Actions.SimpleAction();
            action.Caption = "Set HTML5 viewer";
            action.Category = "View";
            action.Id = "enableHTML5viewer";
            action.Execute += action_Execute;

            RegisterActions(new ActionBase[] {action});
        }

        private void action_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ReportsAspNetModuleV2 module = (ReportsAspNetModuleV2)Frame.Application.Modules.FindModule(typeof(ReportsAspNetModuleV2));
            if(module != null) {
                module.ReportViewerType = ReportViewerTypes.HTML5;
            }
        }
    }
    public class WebReportServiceController_TestController : WebReportServiceController {
        protected override DevExpress.ExpressApp.SystemModule.DialogController CreatePreviewReportDialogController() {
            ExportReportToTXT_TestController result = Application.CreateController<ExportReportToTXT_TestController>();
            return result;
        }
        protected override DevExpress.ExpressApp.SystemModule.DialogController CreateReportDesignerDialogController() {
            ExportReportToTXT_TestController result = Application.CreateController<ExportReportToTXT_TestController>();
            result.AcceptAction.Active["Designer"] = false;
            return result;
        }

    }
    public class CustomizeReportDesginerController : ViewController<DetailView> {
        public CustomizeReportDesginerController() {
            TargetViewId = ReportsAspNetModuleV2.ReportDesignDetailViewWebName;
        }
        protected override void OnActivated() {
            base.OnActivated();
            ReportDesignerDetailItem designerDetailItem = View.GetItems<ReportDesignerDetailItem>()[0];
            designerDetailItem.ControlCreated += designerDetailItem_ControlCreated;
        }
        private void designerDetailItem_ControlCreated(object sender, EventArgs e) {
            ReportDesignerDetailItem designerDetailItem = sender as ReportDesignerDetailItem;
            designerDetailItem.ReportDesigner.ClientSideEvents.CustomizeMenuActions = @"function(s,e) {
                for (index = 0; index < e.Actions.length; ++index) {
                    if(e.Actions[index].text.indexOf('Preview') == 0) {
                        window.previewReportAction = e.Actions[index];
                    }
                    if(e.Actions[index].text === 'Save') {
                        window.saveReportAction = e.Actions[index];
                    }
                    if(e.Actions[index].text === 'Exit') {
                        window.exitReportAction = e.Actions[index];
                    }
                }
                window.designerTypesCount =  DevExpress.Reporting.Designer.Data.Parameter.typeValues.length;
            }";
        }
    }
    public class CustomizeHTML5ViewerController : ViewController<DetailView> {
        public CustomizeHTML5ViewerController() {
            TargetViewId = ReportsAspNetModuleV2.ReportViewDetailViewWebName;
        }
        protected override void OnActivated() {
            base.OnActivated();
            var items = View.GetItems<ReportWebViewerDetailItem>();
            if(items.Count > 0) {
                ReportWebViewerDetailItem detailItem = items[0];
                detailItem.ControlCreated += detailItem_ControlCreated;
            }
        }
        private void detailItem_ControlCreated(object sender, EventArgs e) {
            ReportWebViewerDetailItem item = sender as ReportWebViewerDetailItem;
            item.ReportViewer.ClientSideEvents.CustomizeMenuActions = @"function(s,e) {
                xaf.Utils.GetMainWindow().reportViewer = s;
                for (index = 0; index < e.Actions.length; ++index) {
                    if(e.Actions[index].text.indexOf('Export') == 0) {{
                        xaf.Utils.GetMainWindow().exportReportAction = e.Actions[index];
                    }}
                }
            }";
        }
    }
    public class ExportReportToTXT_TestController : PreviewReportDialogController {
        private XtraReport shownReport = null;

        public ExportReportToTXT_TestController()
            : base() {
            ParametrizedAction exportToTxt = new ParametrizedAction(this, "ExportToTxt", DialogActionContainerName, typeof(string));
            exportToTxt.Execute += exportToTxt_Execute;
        }

        private void exportToTxt_Execute(object sender, ParametrizedActionExecuteEventArgs e) {
            //diagnostic info for:
            //ReportV2Demo_Web_ContacttWithSubMappedToViewData (Elapsed:00:00:31.1559236) Application:ReportV2Demo_Web MachineName:VICTIMTARGET IP:172.22.2.17
            //Caught the 'System.IO.FileNotFoundException' exception. Exeption text: 'Could not find file 'c:\Projects\13.2\Xaf_FT_Demos_ReportsV2\Scripts\ContactReportWithSubreportMappedToViewDataSource.txt'.', stack trace: ' at System.IO.__Error.WinIOError(Int32 errorCode, String maybeFullPath)
            // at System.IO.FileStream.Init(String path, FileMode mode, FileAccess access, Int32 rights, Boolean useRights, FileShare share, Int32 bufferSize, FileOptions options, SECURITY_ATTRIBUTES secAttrs, String msgPath, Boolean bFromProxy, Boolean useLongPath, Boolean checkHost)
            // at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access)
            // at DevExpress.EasyTest.Framework.Commands.CompareFilesCommand.FileCompare(String file1, String file2)
            DevExpress.Persistent.Base.Tracing.Tracer.LogText("Saving report '" + shownReport.ToString() + "' to file '" + (string)e.ParameterCurrentValue + "'");
            DevExpress.Persistent.Base.Tracing.Tracer.LogText("Environment.CurrentDirectory: '" + Environment.CurrentDirectory);
            shownReport.ExportToText((string)e.ParameterCurrentValue);
        }

        protected override void OnActivated() {
            UnsubscribeToEvents();
            SubscribeToEvents();
            base.OnActivated();
        }
        protected override void OnDeactivated() {
            UnsubscribeToEvents();
            shownReport = null;
            base.OnDeactivated();
        }

        private void SubscribeToEvents() {
            ReportsModuleV2 reportsModule = ReportsModuleV2.FindReportsModule(Application.Modules);
            reportsModule.ReportsDataSourceHelper.CustomSetupReportDataSource += ReportsDataSourceHelper_CustomSetupReportDataSource;
        }
        private void UnsubscribeToEvents() {
            ReportsModuleV2 reportsModule = ReportsModuleV2.FindReportsModule(Application.Modules);
            reportsModule.ReportsDataSourceHelper.CustomSetupReportDataSource -= ReportsDataSourceHelper_CustomSetupReportDataSource;
        }
        void ReportsDataSourceHelper_CustomSetupReportDataSource(object sender, CustomSetupReportDataSourceEventArgs e) {
            shownReport = e.Report;
        }
    }
    public class DisablePopupController : ObjectViewController<ListView, IReportDataV2> {
        public DisablePopupController() {
            IContainer components = new System.ComponentModel.Container();
            SimpleAction disablePopup = new DevExpress.ExpressApp.Actions.SimpleAction(components);
            disablePopup.Caption = "Disable Popup";
            disablePopup.Category = "View";
            disablePopup.Id = "disablePopupAction";
            disablePopup.Execute += disablePopup_Execute;

            RegisterActions(components);
        }
        void disablePopup_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ReportsAspNetModuleV2 module = (ReportsAspNetModuleV2)Frame.Application.Modules.FindModule(typeof(ReportsAspNetModuleV2));
            if(module != null) {
                module.DesignAndPreviewDisplayMode = DesignAndPreviewDisplayModes.DetailView;
            }
        }
    }
    public class DisplayModeController : ViewController {
        public DisplayModeController() {
            TargetObjectType = typeof(IReportDataV2);
            SimpleAction action = new SimpleAction(this, "ChangeMode", DevExpress.Persistent.Base.PredefinedCategory.View);
            action.Execute += Action_Execute;
            RegisterActions(new ActionBase[] { action });
        }

        private void Action_Execute(object sender, SimpleActionExecuteEventArgs e) {
            ReportsAspNetModuleV2 module = Application.Modules.FindModule<ReportsAspNetModuleV2>();
            module.ShowReportDesignerActionTarget = module.ShowReportDesignerActionTarget == ActionTarget.CurrentTab ? ActionTarget.NewTab : ActionTarget.CurrentTab;
            View.Refresh();
        }
    }
#endif
    #endregion
}
