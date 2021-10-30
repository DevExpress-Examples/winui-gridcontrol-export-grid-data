using DevExpress.WinUI.Grid.Printing;
using DevExpress.WinUI.Printing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ExportGridControl {

    public sealed partial class GridPage : Page {

        public GridPage() {
            InitializeComponent();
        }

        public ViewModel ViewModel { get; } = new ViewModel();

        void Button_Click(object sender, RoutedEventArgs e) {
            var documentSource = new PrintableLink(new GridControlPrinter(gridcontrol));
            documentSource.CreateDocument();
            documentSource.PrintingSystem.ExportToCsv(@"C:\Users\Public\Documents\Report.csv");
        }
    }
}
