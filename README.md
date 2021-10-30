# WinUI GridControl - Export GridControl Data in Code

This example exports [GridControl](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.GridControl) data to a CSV file.

Follow the steps below to export [GridControl](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.GridControl) data in code-behind:

1. Reference the `DevExpress.WinUI.Grid.Printing` and `DevExpress.WinUI.Printing` namespaces.
1. Create a [GridControlPrinter](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.Printing.GridControlPrinter) instance that contains the [GridControl](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.GridControl) you want to export. Pass the created [GridControlPrinter](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.Printing.GridControlPrinter) instance to the [PrintableLink](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Printing.PrintableLink)'s [constructor](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Printing.PrintableLink.-ctor.overloads) as a parameter to create a [PrintableLink](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Printing.PrintableLink) instance. The **PrintableLink(( class creates a link between a [GridControl](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.GridControl) and an exported document.
1. Call a [CreateDocument*](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Printing.LinkBase.CreateDocument.overloads) method to create a new document. Then, call an [ExportTo*](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase._methods) method according to a file format you need.

## Available Formats
You can export [GridControl](https://docs.devexpress.com/WinUI/DevExpress.WinUI.Grid.GridControl) data to the following formats:

| Format | Methods |
|-|-|
| Csv | [ExportToCsv](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToCsv.overloads) |
| Docx | [ExportToDocx](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToDocx.overloads) |
| Html | [ExportToHtml](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToHtml.overloads) |
| Image | [ExportToImage](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToImage.overloads) |
| Mail | [ExportToMail](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToMail.overloads) |
| Mht | [ExportToMht](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToMht.overloads) |
| Pdf | [ExportToPdf](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToPdf.overloads) |
| Rtf | [ExportToRtf](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToRtf.overloads) |
| Text | [ExportToText](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToText.overloads) |
| Xls | [ExportToXls](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToXls.overloads) |
| Xlsx | [ExportToXlsx](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToXlsx.overloads) |
| Xps | [ExportToXps](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PrintingSystemBase.ExportToXps.overloads) |

<!-- default file list -->
## Files to Look At

- [GridPage.xaml](./CS/ExportGridControl/ExportGridControl/Views/GridPage.xaml) (VB: [GridPage.xaml](./VB/ExportGridControl/ExportGridControl/Views/GridPage.xaml))
- [GridPage.xaml.cs](./CS/ExportGridControl/PrintGridControl/Views/GridPage.xaml.cs) (VB: [GridPage.xaml.vb](./CS/ExportGridControl/PrintGridControl/Views/GridPage.xaml.vb))
<!-- default file list end -->

## Documentation

- [Export GridControl Data in Code](https://docs.devexpress.com/WinUI/403345/controls/data-grid/print-export#export-data-in-code)
- [Print and Export GridControl Data](https://docs.devexpress.com/WinUI/403345/controls/data-grid/print-export)
