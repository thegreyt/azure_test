using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportV2Demo.Module.PredefinedEditableReports {
    public class ReportWithSubReportDifferentEnumsLayout {
        public static string ReportLayout = @"
/// <XRTypeInfo>
///   <AssemblyFullName>DevExpress.XtraReports.v19.1, Version=19.1.0.0, Culture=neutral, PublicKeyToken=79868b8147b5eae4</AssemblyFullName>
///   <AssemblyLocation>C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraReports.v19.1\v4.0_19.1.0.0__79868b8147b5eae4\DevExpress.XtraReports.v19.1.dll</AssemblyLocation>
///   <TypeName>DevExpress.XtraReports.UI.XtraReport</TypeName>
///   <Localization>en-US</Localization>
///   <Version>19.1</Version>
///   <References>
///     <Reference Path=""C:\2019.1\XAF\Demos\CS\ReportsV2Demo\ReportV2Demo.Win\bin\Debug\DevExpress.Persistent.Base.v19.1.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.SqlXml\v4.0_4.0.0.0__b77a5c561934e089\System.Data.SqlXml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Security\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Security.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Numerics\v4.0_4.0.0.0__b77a5c561934e089\System.Numerics.dll"" />
///     <Reference Path=""C:\2019.1\XAF\Demos\CS\ReportsV2Demo\ReportV2Demo.Win\bin\Debug\DevExpress.ExpressApp.v19.1.dll"" />
///     <Reference Path=""C:\2019.1\XAF\Demos\CS\ReportsV2Demo\ReportV2Demo.Win\bin\Debug\DevExpress.Utils.v19.1.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Forms\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Forms.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Accessibility\v4.0_4.0.0.0__b03f5f7f11d50a3a\Accessibility.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Deployment\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Deployment.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization.Formatters.Soap\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Serialization.Formatters.Soap.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\PresentationCore\v4.0_4.0.0.0__31bf3856ad364e35\PresentationCore.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\WindowsBase\v4.0_4.0.0.0__31bf3856ad364e35\WindowsBase.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml\v4.0_4.0.0.0__b77a5c561934e089\System.Xaml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationTypes\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationTypes.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Input.Manipulations\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Input.Manipulations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationProvider\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationProvider.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Remoting\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Remoting.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Transactions\v4.0_4.0.0.0__b77a5c561934e089\System.Transactions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.EnterpriseServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.EnterpriseServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.RegularExpressions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_32\System.Data.OracleClient\v4.0_4.0.0.0__b77a5c561934e089\System.Data.OracleClient.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices.Protocols\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.Protocols.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceProcess\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.ServiceProcess.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration.Install\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.Install.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Internals\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Internals.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\SMDiagnostics\v4.0_4.0.0.0__b77a5c561934e089\SMDiagnostics.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Services\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.Services.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Utilities.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Utilities.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Framework\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Framework.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Tasks.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Tasks.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationClient\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationClient.dll"" />
///     <Reference Path=""C:\2019.1\XAF\Demos\CS\ReportsV2Demo\ReportV2Demo.Win\bin\Debug\DevExpress.Images.v19.1.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.dll"" />
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
///   </References>
///   <Resources>
///     <Resource Name=""XtraReportSerialization.Report1"">
/// zsrvvgEAAACRAAAAbFN5c3RlbS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTQuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVzb3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAAAAAAAAAAAAFBBRFBBRFC0AAAA</Resource>
///   </Resources>
/// </XRTypeInfo>
namespace XtraReportSerialization {
    
    public class Report1 : DevExpress.XtraReports.UI.XtraReport {
            private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
            private DevExpress.XtraReports.UI.XRSubreport subreport1;
            private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
            private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
            private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
            private DevExpress.XtraReports.UI.XRTable table1;
            private DevExpress.XtraReports.UI.XRTableRow tableRow1;
            private DevExpress.XtraReports.UI.XRTableCell tableCell1;
            private DevExpress.XtraReports.UI.XRTableCell tableCell2;
            private DevExpress.XtraReports.UI.XRTableCell tableCell3;
            private DevExpress.XtraReports.UI.XRTableCell tableCell4;
            private DevExpress.XtraReports.UI.DetailBand Detail;
            private DevExpress.XtraReports.UI.XRTable table2;
            private DevExpress.XtraReports.UI.XRTableRow tableRow2;
            private DevExpress.XtraReports.UI.XRTableCell tableCell8;
            private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
            private DevExpress.XtraReports.UI.XRControlStyle Title;
            private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
            private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
            private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
            private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
            private System.Resources.ResourceManager _resources;
            private string _resourceString;
            public Report1() {
                this._resourceString = DevExpress.XtraReports.Serialization.XRResourceManager.GetResourceFor(""XtraReportSerialization.Report1"");
                this.InitializeComponent();
            }
            private System.Resources.ResourceManager resources {
                get {
                    if(_resources == null) {
                        this._resources = new DevExpress.XtraReports.Serialization.XRResourceManager(this._resourceString);
                    }
                    return this._resources;
                }
            }
            private void InitializeComponent() {
                this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
                this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
                this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
                this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
                this.Detail = new DevExpress.XtraReports.UI.DetailBand();
                this.subreport1 = new DevExpress.XtraReports.UI.XRSubreport();
                this.table1 = new DevExpress.XtraReports.UI.XRTable();
                this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
                this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
                this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
                this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
                this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
                this.table2 = new DevExpress.XtraReports.UI.XRTable();
                this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
                this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
                this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
                this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
                this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
                this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
                this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
                this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
                ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
                // 
                // TopMargin
                // 
                this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.subreport1});
                this.TopMargin.HeightF = 350F;
                this.TopMargin.Name = ""TopMargin"";
                // 
                // BottomMargin
                // 
                this.BottomMargin.Name = ""BottomMargin"";
                // 
                // ReportHeader
                // 
                this.ReportHeader.HeightF = 60F;
                this.ReportHeader.Name = ""ReportHeader"";
                // 
                // GroupHeader1
                // 
                this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.table1});
                this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
                this.GroupHeader1.HeightF = 28F;
                this.GroupHeader1.Name = ""GroupHeader1"";
                // 
                // Detail
                // 
                this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.table2});
                this.Detail.HeightF = 25F;
                this.Detail.Name = ""Detail"";
                // 
                // subreport1
                // 
                this.subreport1.LocationFloat = new DevExpress.Utils.PointFloat(5.999994F, 25.99999F);
                this.subreport1.Name = ""subreport1"";
			    this.subreport1.ReportSourceUrl = ""SubReportKEY"";
                this.subreport1.SizeF = new System.Drawing.SizeF(633.9999F, 310.5F);
                // 
                // table1
                // 
                this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
                this.table1.Name = ""table1"";
                this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
                        this.tableRow1});
                this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
                // 
                // tableRow1
                // 
                this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                        this.tableCell1,
                        this.tableCell2,
                        this.tableCell3,
                        this.tableCell4});
                this.tableRow1.Name = ""tableRow1"";
                this.tableRow1.Weight = 1D;
                // 
                // tableCell1
                // 
                this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
                this.tableCell1.Name = ""tableCell1"";
                this.tableCell1.StyleName = ""DetailCaption1"";
                this.tableCell1.StylePriority.UseBorders = false;
                this.tableCell1.Text = ""First Name"";
                this.tableCell1.Weight = 0.21784785344050481D;
                // 
                // tableCell2
                // 
                this.tableCell2.Name = ""tableCell2"";
                this.tableCell2.StyleName = ""DetailCaption1"";
                this.tableCell2.Text = ""Last Name"";
                this.tableCell2.Weight = 0.21407353327824519D;
                // 
                // tableCell3
                // 
                this.tableCell3.Name = ""tableCell3"";
                this.tableCell3.StyleName = ""DetailCaption1"";
                this.tableCell3.Text = ""Middle Name"";
                this.tableCell3.Weight = 0.2518829815204327D;
                // 
                // tableCell4
                // 
                this.tableCell4.Name = ""tableCell4"";
                this.tableCell4.StyleName = ""DetailCaption1"";
                this.tableCell4.Text = ""Title Of Courtesy"";
                this.tableCell4.Weight = 0.31619558481069709D;
                // 
                // table2
                // 
                this.table2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
                this.table2.Name = ""table2"";
                this.table2.OddStyleName = ""DetailData3_Odd"";
                this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
                        this.tableRow2});
                this.table2.SizeF = new System.Drawing.SizeF(205.5271F, 25F);
                // 
                // tableRow2
                // 
                this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                        this.tableCell8});
                this.tableRow2.Name = ""tableRow2"";
                this.tableRow2.Weight = 11.5D;
                // 
                // tableCell8
                // 
                this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[TitleOfCourtesy]"")});
                this.tableCell8.Name = ""tableCell8"";
                this.tableCell8.StyleName = ""DetailData1"";
                this.tableCell8.Weight = 0.31619563176081733D;
                // 
                // collectionDataSource1
                // 
                this.collectionDataSource1.Name = ""collectionDataSource1"";
                this.collectionDataSource1.ObjectTypeName = ""ReportV2Demo.Module.BusinessObjects.Contact"";
                this.collectionDataSource1.TopReturnedRecords = 0;
                // 
                // Title
                // 
                this.Title.BackColor = System.Drawing.Color.Transparent;
                this.Title.BorderColor = System.Drawing.Color.Black;
                this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
                this.Title.BorderWidth = 1F;
                this.Title.Font = new System.Drawing.Font(""Arial"", 14.25F);
                this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
                this.Title.Name = ""Title"";
                // 
                // DetailCaption1
                // 
                this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
                this.DetailCaption1.BorderColor = System.Drawing.Color.White;
                this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
                this.DetailCaption1.BorderWidth = 2F;
                this.DetailCaption1.Font = new System.Drawing.Font(""Arial"", 8.25F, System.Drawing.FontStyle.Bold);
                this.DetailCaption1.ForeColor = System.Drawing.Color.White;
                this.DetailCaption1.Name = ""DetailCaption1"";
                this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
                this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                // 
                // DetailData1
                // 
                this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
                this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
                this.DetailData1.BorderWidth = 2F;
                this.DetailData1.Font = new System.Drawing.Font(""Arial"", 8.25F);
                this.DetailData1.ForeColor = System.Drawing.Color.Black;
                this.DetailData1.Name = ""DetailData1"";
                this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
                this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                // 
                // DetailData3_Odd
                // 
                this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
                this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
                this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
                this.DetailData3_Odd.BorderWidth = 1F;
                this.DetailData3_Odd.Font = new System.Drawing.Font(""Arial"", 8.25F);
                this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
                this.DetailData3_Odd.Name = ""DetailData3_Odd"";
                this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
                this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                // 
                // PageInfo
                // 
                this.PageInfo.Font = new System.Drawing.Font(""Arial"", 8.25F, System.Drawing.FontStyle.Bold);
                this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
                this.PageInfo.Name = ""PageInfo"";
                this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
                // 
                // Report1
                // 
                this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                        this.TopMargin,
                        this.BottomMargin,
                        this.ReportHeader,
                        this.GroupHeader1,
                        this.Detail});
                this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
                        this.collectionDataSource1});
                this.DataSource = this.collectionDataSource1;
                this.DisplayName = ""ReportWithSubReportDifferentEnums"";
                this.Extensions.Add(""DataSerializationExtension"", ""XtraReport"");
                this.Extensions.Add(""DataEditorExtension"", ""XtraReport"");
                this.Extensions.Add(""ParameterEditorExtension"", ""XtraReport"");
                this.Font = new System.Drawing.Font(""Arial"", 9.75F);
                this.Margins = new System.Drawing.Printing.Margins(100, 100, 350, 100);
                this.Name = ""Report1"";
                this.PageHeight = 1100;
                this.PageWidth = 850;
                this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
                        this.Title,
                        this.DetailCaption1,
                        this.DetailData1,
                        this.DetailData3_Odd,
                        this.PageInfo});
                this.Version = ""19.1"";
                ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            }
        }
    }
";
    }
}
