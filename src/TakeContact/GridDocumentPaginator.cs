using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Printing;
using System.Windows.Xps;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Collections.ObjectModel;
using Cmd;

namespace ViewFormulaire
{

    //http://www.codeproject.com/Articles/138233/Custom-Data-Grid-Document-Paginator
    class GridDocumentPaginator : DocumentPaginator
    {
        protected Size size;
        protected DataGrid _grid;
        public GridDocumentPaginator(DataGrid grid, Size s)
        {
            this._grid = grid;
            this.size = s;
        }

        public override IDocumentPaginatorSource Source { get { return null; } }
        protected DataGrid GetContent(int PageNumber)
        {
            DataGrid ret = new DataGrid();
            foreach (DataGridColumn x in this._grid.Columns)
            {
                DataGridTextColumn col;
                col = new DataGridTextColumn();
                DataGridTextColumn colSrc;
                colSrc = x as DataGridTextColumn;
                col.Width = colSrc.Width;
                col.Header = colSrc.Header;
                col.Binding = colSrc.Binding;
                ret.Columns.Add(col);
            }

            ret.CanUserAddRows = false;
            ret.CanUserDeleteRows = false;
            ret.CanUserReorderColumns = false;
            ret.CanUserResizeColumns = false;
            ret.CanUserResizeRows = false;
            ret.CanUserSortColumns = false;
            ret.AutoGenerateColumns = false;

            ObservableCollection<LineEntry> collec;
            collec = new ObservableCollection<LineEntry>();
            int iStart, iStop;
            int nbItemsPerPage = 50;

            iStart = PageNumber * nbItemsPerPage;
            iStop = iStart + nbItemsPerPage - 1;
            if (iStop > this._grid.Items.Count)
            {
                iStop = this._grid.Items.Count;
            }
            for (int i = iStart; i < iStop; i++)
            {
                collec.Add(this._grid.Items[i] as LineEntry);
            }

            ret.ItemsSource = collec;
            ret.HeadersVisibility = this._grid.HeadersVisibility;
            ret.UpdateLayout();
            return ret;
        }

        public GridToPrint GetGridToPrint(int PageNumber)
        {
            GridToPrint gtp;
            gtp = GridToPrint.Create();
            gtp.Width = this.size.Width;
            gtp.Height = this.size.Height;
            DataGrid content = GetContent(PageNumber);
            gtp.SetContent(content);

            // Size the Grid.
            gtp.Measure(new Size(Double.PositiveInfinity,
                                  Double.PositiveInfinity));

            Size sizeGrid = gtp.DesiredSize;
            // Determine point for centering Grid on page.
            Point ptGrid =
                new Point((this.size.Width - sizeGrid.Width) / 2,
                          (this.size.Height - sizeGrid.Height) / 2);
            // Layout pass.
            gtp.Arrange(new Rect(ptGrid, sizeGrid));
            return gtp;
        }

        public override DocumentPage GetPage(int PageNumber)
        {
            GridToPrint gtp;
            gtp = this.GetGridToPrint(PageNumber);
            return new DocumentPage(gtp);
        }

        public override bool IsPageCountValid
        {
            get { return true; }
        }

        public override int PageCount
        {
            get { return 1; }
        }

        public override Size PageSize
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
    }
}
