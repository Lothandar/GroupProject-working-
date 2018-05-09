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
        List<ItemsOrdered> orderedItems = new List<ItemsOrdered>();
        public Warehouse()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            string query = "Select `order`.* , supplier.supplierName FROM `order`, `supplier` Where Authorized and (delivered is null or not delivered) and DeliveryDate <= '" + DateTime.Today.ToString("yyyy-MM-dd")+"' And supplierNo = supplier.supplierID;";
            List<List<string>> list = DatabaseManagement.SelectQuery(query);
            foreach (List<string> littlelist in list)
            {
                orderItems.Add(new orderedItem()
                {
                    ID = Int64.Parse(littlelist[0]),
                    Price = double.Parse(littlelist[1]),
                    ExpectedDelivery = littlelist[5],
                    SupplierName = littlelist[8]
                     
                });
            }
            Orders.ItemsSource = orderItems;
        }

        private void Orders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                orderedItems = new List<ItemsOrdered>();
                string query = "Select `ItemsOrdered`.* from `ItemsOrdered`, `order` Where `ItemsOrdered`.OrderID = `order`.orderNo and `order`.orderNo ='" + orderItems[Orders.SelectedIndex].ID + "'";
                List<List<string>> list = DatabaseManagement.SelectQuery(query);
                foreach (List<string> littlelist in list)
                {
                    orderedItems.Add(new ItemsOrdered()
                    {
                        ItemID = Int64.Parse(littlelist[0]),
                        OrderID = Int64.Parse(littlelist[1]),
                        Quantity = int.Parse(littlelist[2])

                    });
                }
                OrdersItems.ItemsSource = orderedItems;
                Submit_Button.IsEnabled = true;
            }
            catch
            {

            }   
         }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            OrdersItems.ItemsSource = null;
            Submit_Button.IsEnabled = false;
            
            orderedItems = new List<ItemsOrdered>();
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (ItemsOrdered item in orderedItems)
            {
                string Query = "INSERT INTO `delivery` (orderID, itemID, deliveredDate, Damaged, missing) VALUES('"+item.OrderID+"','"+item.ItemID+"','"+DateTime.Today.ToString("yyyy-MM-dd")+"','"+ item.Dammaged +"','"+item.Missing+"'); ";
                DatabaseManagement.Add(Query);
                Query = "Update `garden` set StockLever = 'StockLever + " + (item.Quantity - item.Dammaged -item.Missing)+"' where itemId ='"+item.ItemID+"'";
                DatabaseManagement.Update(Query);
            }
            string query = "Update `order` set delivered = 1 where orderNo =" + orderItems[Orders.SelectedIndex].ID;
            DatabaseManagement.Update(query);
            Cancel_Button_Click(sender, e);
        }
    }
    public class orderedItem
    {
        public string SupplierName { get; set; }
        public Int64 ID { get; set; }
        public double Price { get; set; }
        public string ExpectedDelivery { get; set; }
    }
    public class ItemsOrdered
    {
        public Int64 ItemID{ get; set; }
        public Int64 OrderID { get; set; }
        public int Quantity { get; set; }
        public int Dammaged { get; set; }
        public int Missing { get; set; }
    }   
}