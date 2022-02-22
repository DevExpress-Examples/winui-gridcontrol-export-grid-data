Imports Microsoft.UI.Xaml
Imports Microsoft.UI.Xaml.Controls
Imports Microsoft.UI.Xaml.Controls.Primitives

' To learn more about WinUI, the WinUI project structure,
' and more about our project templates, see: http://aka.ms/winui-project-info.
Namespace ExportGridControl

    ''' <summary>
    ''' An empty window that can be used on its own or navigated to within a Frame.
    ''' </summary>
    Public NotInheritable Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim frame As Frame = TryCast(Content, Frame)
            frame.Navigate(GetType(GridPage))
        End Sub
    End Class
End Namespace
