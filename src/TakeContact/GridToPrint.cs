using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;

namespace ViewFormulaire
{
    public class GridToPrint : Grid
    {
        private GridToPrint() { } // default constructor cannot be used

        //https://msdn.microsoft.com/en-us/library/ms752271%28v=vs.100%29.aspx
        public static GridToPrint Create()
        {
            GridToPrint ret = new GridToPrint();
            //            ret.Background = new SolidColorBrush(Colors.PaleVioletRed);
            // Define the Columns
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            colDef1.Width = new GridLength(100);
            colDef2.Width = new GridLength(1, GridUnitType.Star);// GridLength.Auto;
            colDef3.Width = new GridLength(100);

            ret.ColumnDefinitions.Add(colDef1);
            ret.ColumnDefinitions.Add(colDef2);
            ret.ColumnDefinitions.Add(colDef3);

            // Define the Rows
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            rowDef1.Height = new GridLength(100);
            rowDef2.Height = new GridLength(1, GridUnitType.Star);
            rowDef3.Height = new GridLength(100);

            ret.RowDefinitions.Add(rowDef1);
            ret.RowDefinitions.Add(rowDef2);
            ret.RowDefinitions.Add(rowDef3);

            ret.ShowGridLines = false;
            return ret;
        }

        public static void SetUIElementOnGrid(Grid grid, int iRow, int iCol, UIElement x)
        {
            try
            {
                Grid.SetColumn(x, iCol);
                Grid.SetRow(x, iRow);
                grid.Children.Add(x);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }

        public void SetContent(UIElement x)
        {
            int iCol = 1;
            int iRow = 1;

            try
            {
                SetUIElementOnGrid(this, iRow, iCol, x);
            }
            catch
            {
                ;
            }
        }


    }
}
