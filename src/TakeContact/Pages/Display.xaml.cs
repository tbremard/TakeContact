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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Cmd;
using System.Windows.Xps;
using System.Printing;
using Microsoft.Win32;

namespace ViewFormulaire
{
    /// <summary>
    /// Interaction logic for Confirmation.xaml
    /// </summary>
    public partial class ViewList : Page
    {
        private MainWindow main;

        public ViewList(MainWindow _main)
        {
            InitializeComponent();
            this.main = _main;
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            this.main.pageInput.ResetContent();
            this.main.Content = this.main.pageInput;
        }
        List<LineEntry> entries;
        public void LoadContent()
        {
            
            entries = this.main.cmdPool.cmdInput.GetEntries();
            this.gridList.ItemsSource = entries;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel (*.xlsx)|xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.FileName = "TakeContact_Export.xlsx";

            if (saveFileDialog.ShowDialog() == true)
            {
                this.main.cmdPool.cmdInput.Export(saveFileDialog.FileName, entries);
                MessageBox.Show("Fichier sauvegardé !", "TakeContact", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return;

          //  this.main.pv.Test2(this.gridList);
          //  return;
            /*
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                Size S = new Size(pd.PrintableAreaWidth, pd.PrintableAreaHeight);
                GridDocumentPaginator paginator = new GridDocumentPaginator(this.gridList, S);
                pd.PrintDocument(paginator ,"ListOfContacts");
            }*/
        }

    }

}
