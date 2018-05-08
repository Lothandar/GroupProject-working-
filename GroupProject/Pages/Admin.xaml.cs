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
    /// Logique d'interaction pour Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        List<PurchaseItems> PurchasedItems = new List<PurchaseItems>();
        List<OrderedItem> OrderedItems = new List<OrderedItem>();
        public Admin()
        {
            InitializeComponent();
        }

        private void Logout_button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void Executive_Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Exec());
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (OrderedItem order in OrderedItems)
                {
                    if (order.Authorized)
                    {
                        string query = "UPDATE `order` SET Authorized = true WHERE orderNo = '" + order.ID + "'";
                        DatabaseManagement.Update(query);
                    }
                    UserControl_Initialized(sender, e);
                  
                }
                MessageBox.Show("Theses Orders has been authorized successfully ", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
            }
            catch
            { }
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            OrderedItems = new List<OrderedItem>();
            string query = "Select * FROM `order`, `supplier` Where Authorized = false And supplierNo = supplier.supplierID; ";
            List<List<string>> list = DatabaseManagement.SelectQuery(query);

            if(list.Count() != 0)
            {

           
            foreach(List<string> littlelist in list)
            {
                OrderedItems.Add(new OrderedItem {
                    ID = Int64.Parse(littlelist[0]),
                    Price = double.Parse(littlelist[1]),
                    OrderDate = littlelist[4],
                    DeliveryDate = littlelist[5],
                    Supplier = littlelist[7],
                    Authorized = false
                });
            }
            OrderData.ItemsSource = OrderedItems;
            }
        }

        private void OrderData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PurchasedItems = new List<PurchaseItems>();
            try
            {
                Int64 test = OrderedItems[OrderData.SelectedIndex].ID;
                string query = "Select `ItemsOrdered`.* from `ItemsOrdered`, `order` Where `ItemsOrdered`.OrderID = `order`.orderNo and `order`.orderNo ='" + test + "'";
                List<List<string>> list = DatabaseManagement.SelectQuery(query);
                foreach (List<string> littlelist in list)
                {
                    PurchasedItems.Add(new PurchaseItems()
                    {
                        ID = Int64.Parse(littlelist[0]),
                        Quantity = int.Parse(littlelist[2]),
                        //Price = double.Parse(littlelist[3])

                    });
                }
                ItemsData.ItemsSource = PurchasedItems;
            }
            catch
            {

            }
        }
    }
    public class OrderedItem
    {
        public Int64 ID { get; set; }
        public double Price { get; set; }
        public string Supplier { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public bool Authorized { get; set; }
    }
}
