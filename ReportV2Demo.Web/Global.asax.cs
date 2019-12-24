using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2.Web;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.TestScripts;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Internal;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Security.Resources;
using DevExpress.Web;
using DevExpress.XtraReports.Security;
using ReportV2Demo.Web.Security;

namespace ReportV2Demo.Web {
    public class Global : System.Web.HttpApplication {
        private static bool isSecurityEnabled;
        public Global() {
            InitializeComponent();
            ReportsAspNetModuleV2.EnableValueManagerInHtml5DocumentViewer = true;
        }
        protected void Application_Start(Object sender, EventArgs e)
        {
            AboutInfo.Instance.Copyright = AssemblyInfo.AssemblyCopyright + " All Rights Reserved";
            AccessSettings.ReportingSpecificResources.SetRules(SerializationFormatRule.Allow());
            PasswordCryptographer.EnableRfc2898 = true;
            PasswordCryptographer.SupportLegacySha512 = false;

            ASPxWebControl.CallbackError += new EventHandler(Application_Error);
#if DEBUG
            TestScriptsManager.EasyTestEnabled = true;
#endif
            isSecurityEnabled = false;
            WebApplication.EnableMultipleBrowserTabsSupport = true;
        }
        protected void Session_Start(Object sender, EventArgs e)
        {
            Tracing.Initialize();
            WebApplication.SetInstance(Session, new ReportV2DemoAspNetApplication());
            ScriptPermissionManager.GlobalInstance = new ScriptPermissionManager(ExecutionMode.Unrestricted);
            if(HttpContext.Current.Request.Params.AllKeys.Contains("NewStyle")) {
                WebApplication.Instance.SwitchToNewStyle();
            }
            if(ConfigurationManager.AppSettings["SiteMode"] != null && ConfigurationManager.AppSettings["SiteMode"].ToLower() == "true") {
                InMemoryDataStoreProvider.Register();
                WebApplication.Instance.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
            }
            else {
                ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
                if(connectionStringSettings != null) {
                    WebApplication.Instance.ConnectionString = connectionStringSettings.ConnectionString;
                }
                else if(string.IsNullOrEmpty(WebApplication.Instance.ConnectionString) && WebApplication.Instance.Connection == null) {
                    connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
                    if(connectionStringSettings != null) {
                        WebApplication.Instance.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
                    }
                }
#region DEMO_REMOVE
                WebApplication.Instance.ConnectionString = InMemoryDataStoreProvider.ConnectionString;
#endregion
            }

            if(System.Diagnostics.Debugger.IsAttached && WebApplication.Instance.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                WebApplication.Instance.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }

            InitializeSecurity(WebApplication.Instance);
            WebApplication.Instance.Setup();
            WebApplication.Instance.Start();
        }

        private void InitializeSecurity(WebApplication application) {
            if(HttpContext.Current.Request.Params.AllKeys.Contains("Security") || isSecurityEnabled) {
                isSecurityEnabled = true;
                AuthenticationStandard authentication = new AuthenticationStandardForDebug(typeof(PermissionPolicyUser), typeof(AuthenticationStandardLogonParameters));
                SecurityStrategyComplex security = new SecurityStrategyComplex(typeof(PermissionPolicyUser), typeof(PermissionPolicyRole), authentication);
                application.Security = security;
                application.CreateCustomObjectSpaceProvider += (s, e) => {
                    e.ObjectSpaceProvider = new SecuredObjectSpaceProvider(security, e.ConnectionString, e.Connection, true);
                };
            }
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
        }
        protected void Application_EndRequest(Object sender, EventArgs e)
        {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
        }
        protected void Application_Error(Object sender, EventArgs e)
        {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e)
        {
            WebApplication.LogOff(Session);
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e)
        {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        }
        #endregion
    }
}
