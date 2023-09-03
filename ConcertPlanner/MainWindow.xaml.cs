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

namespace ConcertPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringbuilder = new StringBuilder();
            string typeEvent = "";
            string eventNaam = txbNaamEvetn.Text;
            int aantalBezoekers= int.Parse(txbAantalBezoeker.Text);

            if(ComboBoxTypeEvent.SelectedIndex != -1)
            {
                ComboBoxItem itemComboBox = (ComboBoxItem)ComboBoxTypeEvent.SelectedItem;
                typeEvent = itemComboBox.Content.ToString();
                stringbuilder.Append(eventNaam + " - " + typeEvent + " - " + aantalBezoekers);

            }
            ListBoxItem itemsToeveogen = new ListBoxItem();
            itemsToeveogen.Content = stringbuilder.ToString();
            ListboxEvents.Items.Add(itemsToeveogen);
            

        }

        private void BtnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            ListboxEvents.Items.Remove(ListboxEvents.SelectedItem);
            ListboxEvents.SelectedIndex = -1;
            txbAantalBezoeker.Clear();
            txbNaamEvetn.Clear();
            ListboxEvents.SelectedIndex = -1;
             
        }

        private void MenuItemAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItemAlleEventsVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            //for (int i = ListboxEvents.SelectedItems.Count - 1; i > 0; i--)
            //{
            //    ListboxEvents.Items.Remove(ListboxEvents.SelectedItems[i]);
            //}
            ListboxEvents.Items.Clear();
        }

        private void MenuItemStandaardEvent_Click(object sender, RoutedEventArgs e)
        {
            
            ListBoxItem items = new ListBoxItem();
            items.Content = "orkast - “jaarlijks optreden: 250";
            ListboxEvents.Items.Add(items);

        }
    }
}
