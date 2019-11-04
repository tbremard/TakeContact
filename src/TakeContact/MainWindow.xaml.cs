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

namespace ViewFormulaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public InputForm pageInput;
        public Confirmation pageConfirm;
        public ViewList pageViewList;
        public Page pageList;
        public CmdPool cmdPool;
        public PrintView pv;

        public MainWindow()
        {
            try
            {
                TryInit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Current.Shutdown(0);
            }
        }

        public void  TryInit()
        {
            InitializeComponent();
            this.pageInput = new InputForm(this);
            this.pageConfirm = new Confirmation(this);
            this.pageViewList = new ViewList(this);
            this.cmdPool = new CmdPool(new LocalDbService());
            string[] args = Environment.GetCommandLineArgs();
            const string CLEAR_TOKEN = "-CLEAR";
            const string NOLIST_TOKEN = "-NOLIST";
            foreach (string x in args)
            {
                if (x.ToUpper().Equals(CLEAR_TOKEN))
                {
                    this.cmdPool.cmdInput.ClearDatabase();
                }
                if (x.ToUpper().Equals(NOLIST_TOKEN))
                {
                    this.pageInput.btnDisplayList.Visibility = System.Windows.Visibility.Hidden;
                }
            }
            this.pageInput.ResetContent();
            this.Content = this.pageInput;
        }
    }
}
