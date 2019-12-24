using System;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace ReportV2Demo.Win {
    static class Program {
        [STAThread]
        static void Main() {
            #region DEMO_REMOVE
#if DXCORE3
            System.Runtime.Loader.AssemblyLoadContext.Default.Resolving += (context, assemblyName) => {
                string p = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), assemblyName.Name + ".dll");
                if(System.IO.File.Exists(p)) {
                    return context.LoadFromAssemblyPath(p);
                }
                return null;
            };
            MainBody();
        }

        [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        private static void MainBody() {
#endif
            #endregion
            PasswordCryptographer.EnableRfc2898 = true;
            PasswordCryptographer.SupportLegacySha512 = false;

#if DEBUG
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if !NETCOREAPP && !NETSTANDARD
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
#endif
            Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath;
            Tracing.Initialize();
            ReportV2DemoWindowsFormsApplication winApplication = new ReportV2DemoWindowsFormsApplication();
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
            if(connectionStringSettings != null) {
                winApplication.ConnectionString = connectionStringSettings.ConnectionString;
            }
            else if(string.IsNullOrEmpty(winApplication.ConnectionString) && winApplication.Connection == null) {
                connectionStringSettings = ConfigurationManager.ConnectionStrings["SqlExpressConnectionString"];
                if(connectionStringSettings != null) {
                    winApplication.ConnectionString = DbEngineDetector.PatchConnectionString(connectionStringSettings.ConnectionString);
                }
#region DEMO_REMOVE
                winApplication.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString;
#endregion
            }
            if(System.Diagnostics.Debugger.IsAttached && winApplication.CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                winApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
            try {
                winApplication.Setup();
                winApplication.Start();
            }
            catch(Exception e) {
                winApplication.HandleException(e);
            }
        }
    }
}
