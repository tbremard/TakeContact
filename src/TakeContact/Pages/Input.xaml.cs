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
using System.Windows.Forms.Integration;

using Cmd;
using System.Xml;
using System.Windows.Markup;

namespace ViewFormulaire
{
    /// <summary>
    /// Interaction logic for InputForm.xaml
    /// </summary>
    public partial class InputForm : Page
    {
        private MainWindow main;

        public InputForm(MainWindow _main)
        {
            InitializeComponent();
            this.main = _main;
            this.MainTitle.Text = System.Configuration.ConfigurationManager.AppSettings["MainTitle"];
        }


        protected LineEntry GetEntry()
        {
            LineEntry ret = new LineEntry();
            ret.Email = this.txtMail.Text;
            ret.FirstName = this.txtFirstName.Text;
            ret.LastName = this.txtLastName.Text;
            return ret;
        }

        public void ResetContent()
        {
            this.txtFirstName.Text = "";
            this.txtLastName.Text = "";
            this.txtMail.Text = "";
            int i;
            i = this.main.cmdPool.cmdInput.GetNumberEntries();
            this.txtNbEntries.Text = i.ToString();
            if (i <= 1)
            {
                this.txtNbEntries.Text += " personne sauvegardée";
            }
            else
            {
                this.txtNbEntries.Text += " personnes sauvegardées";
            }
            this.RefreshButton();

        }

        private void show()
        {
            /*
            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;
            set.IndentChars = "    ";
            set.NewLineOnAttributes = true;

            StringBuilder sb = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(sb, set);
            XamlWriter.Save(btnValidate.Template, writer);
            MessageBox.Show(sb.ToString());
            */
            
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LineEntry entry = GetEntry();
                this.main.cmdPool.cmdInput.AddNewEntry(entry);
                this.main.Content = this.main.pageConfirm;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDisplayList_Click(object sender, RoutedEventArgs e)
        {
            this.show();
            this.main.pageViewList.LoadContent();
            this.main.Content = this.main.pageViewList;
        }

        private void RefreshButton()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)
                || string.IsNullOrEmpty(txtLastName.Text)
                || string.IsNullOrEmpty(txtMail.Text))
            {
                this.btnValidate.IsEnabled = false;
            }
            else
            {
                this.btnValidate.IsEnabled = true;
            }

        }
        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.RefreshButton();
        }
    }
}
