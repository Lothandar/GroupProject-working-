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
    /// Logique d'interaction pour PuchaseAssistant.xaml
    /// </summary>
    public partial class PuchaseAssistant : UserControl
    {
        List<PurchaseItems> OrderingItem = new List<PurchaseItems>();
        public PuchaseAssistant()
        {
            InitializeComponent();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Index());
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            //Create the Order
            var itemsSource = ItemsData.ItemsSource;
            foreach (var item in itemsSource)
            {
                item.ToString();
            }
            DateTime dateTime = DateTime.UtcNow.Date;
            string date = dateTime.ToString("dd/MM/yyyy");
            string values = "3";
            string query = "INSERT INTO table_name (orderDate, deliveryDate, paid, supplierNo, EmployeeNo) VALUES(" + values + "); ";
            DatabaseManagement.Add(query);
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            CheapOrFast.Items.Add("Search for");
            CheapOrFast.Items.Add("Cheapest");
            CheapOrFast.Items.Add("Fastest");
            CheapOrFast.SelectedItem = "Search for";


            ItemsListBox.Items.Add("Pick an Item");

            List<List<string>> list = DatabaseManagement.SelectQuery("Select title from garden WHERE StockLevel < ReorderLevel");
            if (list.Count() == 0)
            {
                ItemsListBox.Items.Add("No Item in the database need to be Refilled");
            }
            else
            {
                foreach (List<string> items in list)
                {
                    foreach (string item in items)
                    {
                        ItemsListBox.Items.Add(item);
                    }
                }
                //SupplierListBox.Items.Add(list.Count());
            }
            ItemsListBox.SelectedItem = "Pick an Item";

            ItemsData.ItemsSource = OrderingItem;
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            if (CheapOrFast.SelectedItem.ToString() != "Pick an Item" && ItemsListBox.SelectedItem.ToString() != "Search for")
            {
                string query = string.Empty;
                if (ItemsData.HasItems)  //has to change the check has it's not going through then
                {
                    query = "Select supplierprice.* from supplierprice, garden, supplier where supplierprice.itemid = garden.itemId and garden.itemId = (Select garden.itemId from garden where garden.title = '" + label.Content.ToString() + "' and supplierprice.supplierID = supplier.supplierID and supplier.supplierID = (select supplier.supplierID from supplier where supplier.suppliername = '" + ItemsListBox.SelectedItem.ToString() + "'";
                }
                else
                {
                    //just to change a comment
                    //get delivery time and supplier name
                    if (CheapOrFast.SelectedItem.ToString() == "Cheapest")
                    {
                        query = "SELECT MIN(currentPrice) as Cheapest, supplierprice.itemId, garden.title, supplierprice.supplierID, supplierName, deliveryDays FROM supplierprice, garden, supplier where supplierprice.itemId = garden.itemId and garden.title =  '" + ItemsListBox.SelectedItem.ToString() + "' and supplierprice.supplierID = supplier.supplierID group by currentPrice, SupplierID, itemid ASC limit 1;";
                    }
                    else
                    {
                        query = "SELECT MIN(deliveryDays) as shortest, itemid, SupplierID, currentPrice FROM supplierprice GROUP By currentPrice, SupplierID, itemid ASC LIMIT 1";
                    }

                    List<List<String>> list = DatabaseManagement.SelectQuery(query);
                    List<string> littlelist = new List<string>();
                    try
                    {
                        littlelist = list[0];
                    }
                    catch
                    {

                    }
                    label.Content = littlelist[4];

                    ItemsListBox.Items.Clear();

                    ItemsListBox.Items.Add("Pick an Item");

                    List<List<string>> Itemlist = DatabaseManagement.SelectQuery("Select title from garden, supplier, supplierprice WHERE supplierName = '" + label.Content + "' and  StockLevel < ReorderLevel and supplier.supplierID = supplierprice.supplierID and supplierprice.itemId = garden.itemId;");
                    if (list.Count() == 0)
                    {
                        ItemsListBox.Items.Add("No Item in the database need to be Refilled");
                    }
                    else
                    {
                        foreach (List<string> items in Itemlist)
                        {
                            foreach (string item in items)
                            {
                                ItemsListBox.Items.Add(item);
                            }
                        }

                        OrderingItem.Add(new PurchaseItems()
                        {
                            ID = Int64.Parse(littlelist[1]),
                            Name = littlelist[2],
                            Price = double.Parse(littlelist[0]),
                            Quantity = 1,
                            DeliveryTime = int.Parse(littlelist[5]),
                            TotalPrice = double.Parse(littlelist[0]) * 1
                        });
                        ItemsData.ItemsSource = OrderingItem;

                    }

                    DatabaseManagement.SelectQuery(query);
                }

            }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ItemsData.ItemsSource = null;
            label.Content = "Current Supplier";

            ItemsListBox.Items.Add("Pick an Item");

            ItemsListBox.Items.Clear();

            List<List<string>> list = DatabaseManagement.SelectQuery("Select title from garden WHERE StockLevel < ReorderLevel");
            if (list.Count() == 0)
            {
                ItemsListBox.Items.Add("No Item in the database need to be Refilled");
            }
            else
            {
                foreach (List<string> items in list)
                {
                    foreach (string item in items)
                    {
                        ItemsListBox.Items.Add(item);
                    }
                }
                //SupplierListBox.Items.Add(list.Count());
            }
            ItemsListBox.SelectedItem = "Pick an Item";
        }
    }
    public class PurchaseItems
    {
        public Int64 ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int DeliveryTime { get; set; }
        public double TotalPrice { get; set; }
    }
}
