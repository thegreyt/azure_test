#Application ReportV2Demo_Win

*Action Navigation(Reports.Reports)

*ProcessRecord
 Display Name = Ordinal Report

*Sleep 4000

*Action Main Menu.&File.Export Document....Text File
*Sleep 500
*Action OK
*Sleep 500
*FillForm
 File name: = c:\ReportV2Demo_Win_PredefinedReports_OrdinalReport.txt
*Sleep 500
*Action Save
*Sleep 500
*Action No

*CompareFiles
 Actual = c:\ReportV2Demo_Win_PredefinedReports_OrdinalReport.txt
 Expected = .\Files\ReportsV2_Predefined_OrdinalReport_Web.txt

*Action Exit

*ProcessRecord
 Display Name = Report with sub report

*Sleep 4000

*Action Main Menu.&File.Export Document....Text File
*Sleep 500
*Action OK
*Sleep 500
*FillForm
 File name: = c:\ReportV2Demo_Win_PredefinedReports_SubReport.txt
*Sleep 500
*Action Save
*Sleep 500
*Action No

*CompareFiles
 Actual = c:\ReportV2Demo_Win_PredefinedReports_SubReport.txt
 Expected = .\Files\ReportsV2_Predefined_SubReport_Web.txt

*Action Exit

*ProcessRecord
 Display Name = Report with ViewDataSource

*Sleep 4000

*Action Main Menu.&File.Export Document....Text File
*Sleep 500
*Action OK
*Sleep 500
*FillForm
 File name: = c:\ReportV2Demo_Win_PredefinedReports_View.txt
*Sleep 500
*Action Save
*Sleep 500
*Action No

*CompareFiles
 Actual = c:\ReportV2Demo_Win_PredefinedReports_View.txt
 Expected = .\Files\ReportsV2_Predefined_View_Web.txt

*Action Exit