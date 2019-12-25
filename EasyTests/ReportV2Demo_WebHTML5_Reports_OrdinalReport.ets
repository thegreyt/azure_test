#Application ReportV2Demo_Web
#Application ReportV2Demo_NewStyleWeb

*Action Navigation(Reports.Reports)

*Action Set HTML5 viewer

*ProcessRecord
 Display Name = Ordinal Report

*DeleteFile c:\ReportsV2_Predefined_OrdinalReport_Web.txt

*ExecuteScript
 0 = window.top.exportReportAction.clickAction({itemData:{format:'txt'}});

*Sleep 4000

*FillForm
 File name: = c:\ReportsV2_Predefined_OrdinalReport_Web.txt

*Action Save

*Sleep 3500

*CompareFiles
 Actual = c:\ReportsV2_Predefined_OrdinalReport_Web.txt
 Expected = .\Files\ReportsV2_Predefined_OrdinalReport_Web.txt
 
*Action Close

*Action Disable Popup
 
*ProcessRecord
 Display Name = Ordinal Report

*DeleteFile c:\ReportsV2_Predefined_OrdinalReport_Web.txt

*ExecuteScript
 0 = window.top.exportReportAction.clickAction({itemData:{format:'txt'}});

*Sleep 4000

*FillForm
 File name: = c:\ReportsV2_Predefined_OrdinalReport_Web.txt

*Action Save

*Sleep 3500

*CompareFiles
 Actual = c:\ReportsV2_Predefined_OrdinalReport_Web.txt
 Expected = .\Files\ReportsV2_Predefined_OrdinalReport_Web.txt