Imports DevExpress.WinUI.Grid.Printing
Imports DevExpress.WinUI.Printing
Imports Microsoft.UI.Xaml
Imports Microsoft.UI.Xaml.Controls

Namespace ExportGridControl

    Public NotInheritable Partial Class GridPage
        Inherits Page

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public ReadOnly Property ViewModel As ViewModel = New ViewModel()

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim documentSource = New PrintableLink(New GridControlPrinter(Me.gridcontrol))
            documentSource.CreateDocument()
            documentSource.PrintingSystem.ExportToCsv("C:\Users\Public\Documents\Report.csv")
        End Sub
    End Class
End Namespace
