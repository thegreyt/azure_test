﻿
namespace ReportV2Demo.Module.PredefinedEditableReports {
    public class OrdinalReportResource {
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
/// zsrvvgEAAACRAAAAbFN5c3RlbS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTQuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVzb3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAABAAAAAAAAAFBBRFBBRFBIXnLBAAAAAOcAAAAmJAB0AGgAaQBzAC4AUwBjAHIAaQBwAHQAcwBTAG8AdQByAGMAZQAAAAAAAdUEdXNpbmcgRGV2RXhwcmVzcy5YdHJhUmVwb3J0cy5VSTsNCnVzaW5nIERldkV4cHJlc3MuWHRyYVJlcG9ydHMuUGFyYW1ldGVyczsNCnVzaW5nIFJlcG9ydFYyRGVtby5Nb2R1bGU7DQpwcml2YXRlIHZvaWQgeHRyYVJlcG9ydDFfQmVmb3JlUHJpbnQo
/// b2JqZWN0IHNlbmRlciwgU3lzdGVtLkRyYXdpbmcuUHJpbnRpbmcuUHJpbnRFdmVudEFyZ3MgZSkgew0KWHRyYVJlcG9ydCByZXBvcnQgPSBzZW5kZXIgYXMgWHRyYVJlcG9ydDsNCglQYXJhbWV0ZXIgcGFyYW0gPSAoUGFyYW1ldGVyKXJlcG9ydC5QYXJhbWV0ZXJzW0RldkV4cHJlc3MuRXhwcmVzc0FwcC5SZXBvcnRzVjIuUmVwb3J0RGF0YVNvdXJjZUhlbHBlci5YYWZSZXBvcnRQYXJhbWV0ZXJzT2JqZWN0TmFtZV07DQogICAgICAgaWYocGFyYW0gIT0gbnVsbCkgew0KICAgICAgICAgICBEZW1vUGFyYW1ldGVycyB4YWZQYXJhbWV0ZXIgPSBwYXJhbS5WYWx1ZSBhcyBEZW1vUGFyYW1ldGVyczsNCiAgICAgICAgICAgaWYoeGFmUGFyYW1ldGVyLkNvbnRhY3RQ
/// b3NpdGlvbiAhPSBudWxsKSBsYWJlbDkuVGV4dCArPSB4YWZQYXJhbWV0ZXIuQ29udGFjdFBvc2l0aW9uLlRpdGxlOw0KICAgICAgICB9DQp9</Resource>
///   </Resources>
/// </XRTypeInfo>
namespace XtraReportSerialization {
    
    public class xtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRLine line1;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel label9;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
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
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.line1 = new DevExpress.XtraReports.UI.XRLine();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label9 = new DevExpress.XtraReports.UI.XRLabel();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.label1,
                        this.label2,
                        this.label3,
                        this.label4,
                        this.label5,
                        this.label6,
                        this.label7,
                        this.label8,
                        this.line1});
            this.detailBand1.HeightF = 104F;
            this.detailBand1.Name = ""detailBand1"";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
                        new DevExpress.XtraReports.UI.GroupField(""FullName"", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.pageInfo1,
                        this.pageInfo2});
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = ""pageFooterBand1"";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.label9});
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
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = ""bottomMarginBand1"";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 9F);
            this.label1.Name = ""label1"";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label1.StyleName = ""FieldCaption"";
            this.label1.Text = ""First Name"";
            // 
            // label2
            // 
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 33F);
            this.label2.Name = ""label2"";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label2.StyleName = ""FieldCaption"";
            this.label2.Text = ""Last Name"";
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 57F);
            this.label3.Name = ""label3"";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label3.StyleName = ""FieldCaption"";
            this.label3.Text = ""Position"";
            // 
            // label4
            // 
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(6F, 81F);
            this.label4.Name = ""label4"";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.label4.StyleName = ""FieldCaption"";
            this.label4.Text = ""Email"";
            // 
            // label5
            // 
            this.label5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[FirstName]"")});
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(174F, 9F);
            this.label5.Name = ""label5"";
            this.label5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label5.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label5.StyleName = ""DataField"";
            this.label5.Text = ""label5"";
            // 
            // label6
            // 
            this.label6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[LastName]"")});
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(174F, 33F);
            this.label6.Name = ""label6"";
            this.label6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label6.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label6.StyleName = ""DataField"";
            this.label6.Text = ""label6"";
            // 
            // label7
            // 
            this.label7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[Position.Title]"")});
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(174F, 57F);
            this.label7.Name = ""label7"";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label7.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label7.StyleName = ""DataField"";
            this.label7.Text = ""label7"";
            // 
            // label8
            // 
            this.label8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding(""BeforePrint"", ""Text"", ""[Email]"")});
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(174F, 81F);
            this.label8.Name = ""label8"";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label8.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.label8.StyleName = ""DataField"";
            this.label8.Text = ""label8"";
            // 
            // line1
            // 
            this.line1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 3F);
            this.line1.Name = ""line1"";
            this.line1.SizeF = new System.Drawing.SizeF(638F, 2F);
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.pageInfo1.Name = ""pageInfo1"";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.pageInfo1.StyleName = ""PageInfo"";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
            this.pageInfo2.Name = ""pageInfo2"";
            this.pageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.pageInfo2.StyleName = ""PageInfo"";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = ""Page {0} of {1}"";
            // 
            // label9
            // 
            this.label9.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.label9.Name = ""label9"";
            this.label9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label9.SizeF = new System.Drawing.SizeF(638F, 33F);
            this.label9.StyleName = ""Title"";
            this.label9.Text = ""Ordinal Report"";
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
                        this.pageFooterBand1,
                        this.reportHeaderBand1,
                        this.topMarginBand1,
                        this.bottomMarginBand1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
                        this.collectionDataSource1});
            this.DataSource = this.collectionDataSource1;
            this.DisplayName = ""OrdinalReport"";
            this.Extensions.Add(""DataSerializationExtension"", ""XtraReport"");
            this.Extensions.Add(""DataEditorExtension"", ""XtraReport"");
            this.Extensions.Add(""ParameterEditorExtension"", ""XtraReport"");
            this.Name = ""xtraReport1"";
            this.PageHeight = 1100;
            this.PageWidth = 850;
            this.Scripts.OnBeforePrint = ""xtraReport1_BeforePrint"";
            this.ScriptsSource = resources.GetString(""$this.ScriptsSource"");
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
                        this.Title,
                        this.FieldCaption,
                        this.PageInfo,
                        this.DataField});
            this.Version = ""17.2"";
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
";
    }
}
