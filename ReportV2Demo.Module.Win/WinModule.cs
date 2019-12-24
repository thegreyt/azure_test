using System;
using System.Collections.Generic;
using System.ComponentModel;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;

namespace ReportV2Demo.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class ReportV2DemoWindowsFormsModule : ModuleBase
    {
        public ReportV2DemoWindowsFormsModule()
        {
            InitializeComponent();
        }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            return ModuleUpdater.EmptyModuleUpdaters;
        }
    }
}
