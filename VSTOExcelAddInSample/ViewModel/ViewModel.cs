
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Input;

namespace ExcelAddIn1
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI"));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR"));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON"));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT"));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS"));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS"    ));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP"));         
        }
    }

  

}
