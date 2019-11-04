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

namespace ViewFormulaire
{
    /// <summary>
    /// Interaction logic for Confirmation.xaml
    /// </summary>
    public partial class Confirmation : Page
    {
        private MainWindow main;
        public Confirmation(MainWindow _main)
        {
            InitializeComponent();
            this.main = _main;
            this.txtConfirm.Text = System.Configuration.ConfigurationManager.AppSettings["ConfirmationContent"];
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            this.main.pageInput.ResetContent();
            this.main.Content = this.main.pageInput;
        }
    }
}
