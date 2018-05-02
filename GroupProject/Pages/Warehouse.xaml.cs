using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroupProject.Pages
{
    /// <summary>
    /// Logique d'interaction pour Warehouse.xaml
    /// </summary>
    public partial class Warehouse : UserControl
    {
        List<orderedItem> orderItems = new List<orderedItem>();
        public Warehouse()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            string query = "Select order.* , supplier.supplierName FROM `order`, `supplier` Where DeliveryDate = '" + DateTime.Today.ToString("yyyy-MM-dd") + "' And supplierNo = supplier.supplierID; ";
            List<List<string>> list = DatabaseManagement.SelectQuery(query);
            foreach (List<string> littlelist in list)
            {
                orderItems.Add(new orderedItem()
                {
                    ID = Int64.Parse(littlelist[0])
                });
            }
        }
    }
    public class orderedItem
    {
        public Int64 ID { get; set; }
        public double Price { get; set; }
        public string ExpectedDelivery { get; set; }
        public string DeliveryDate { get; set; }
        public string SupplierName { get; set; }

}
}
