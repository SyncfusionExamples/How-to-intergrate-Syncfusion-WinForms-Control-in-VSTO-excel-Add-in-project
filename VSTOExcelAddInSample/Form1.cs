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
    public partial class Form1 : Form
    {
        ViewModel viewModel = new ViewModel();
        public Form1()
        {
            InitializeComponent();
            sfDataGrid1.AutoGenerateColumns = true;
            sfDataGrid1.DataSource = viewModel.Orders;
        }
      
    }
}
