using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn1
{
    public partial class SfDataGridForm : Form
    {
        ViewModel viewModel = new ViewModel();
        public SfDataGridForm()
        {
            InitializeComponent();
            sfDataGrid1.AutoGeneratingColumn += SfDataGrid1_AutoGeneratingColumn;
            sfDataGrid1.AutoGenerateColumns = true;
            sfDataGrid1.DataSource = viewModel.Orders;
        }

        private void SfDataGrid1_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if(e.Column.MappingName == "CustomerName")
            {
                e.Column.Width = 170;
            }
        }
    }
}
