using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ViewFormulaire
{
    /// <summary>
    /// Interaction logic for PrintView.xaml
    /// </summary>
    public partial class PrintView : Window
    {
     
        public PrintView()
        {
            InitializeComponent();
        }
        public void Test1()
        {
            GridToPrint gPrint = GridToPrint.Create();
            GridToPrint.SetUIElementOnGrid(this.gridMain, 0, 0, gPrint);

            Button btn2 = new Button();
            btn2.Content = "btn2";
            gPrint.SetContent(btn2);
        }


        public void Test2(DataGrid x)
        {
            Size S = new Size(793, 1122);
            GridDocumentPaginator paginator = new GridDocumentPaginator(x, S);
            GridToPrint gPrint;
            gPrint = paginator.GetGridToPrint(0);
            GridToPrint.SetUIElementOnGrid(this.gridMain, 0, 0, gPrint);
        }
    }
}