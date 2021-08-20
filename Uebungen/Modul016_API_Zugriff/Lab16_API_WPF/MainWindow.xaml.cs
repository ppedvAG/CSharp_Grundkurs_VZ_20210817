using Lab16_API_Core;
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

namespace Lab16_API_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TodoItemAPI api = new TodoItemAPI(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        void ItemInfo(TodoItem item)
        {
            if (item == null)
            {
                tbName.Text = "";
                tbId.Text = "";
                cbIsComplete.IsChecked = false;
            }
            else
            {
                tbName.Text = item.Name;
                tbId.Text = item.Id.ToString();
                cbIsComplete.IsChecked = item.IsComplete;
            }
        }

        private void btnSuche_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(tbSuche.Text, out id))
            {
                TodoItem item = api.Get(id);
                ItemInfo(item);

                dgItems.ItemsSource = new List<TodoItem>() { item };
            }
            else
            {
                ItemInfo(null);
                List<TodoItem> items = api.GetAll();
                dgItems.ItemsSource = items;
            }
        }


        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            TodoItem item = new TodoItem();
            item.Name = tbName.Text;
            item.IsComplete = cbIsComplete.IsChecked ?? false;

            Uri itemUri = api.Post(item);

            ItemInfo(api.Get(itemUri.PathAndQuery));

            dgItems.ItemsSource = new List<TodoItem>() { api.Get(itemUri.PathAndQuery) };

            MessageBox.Show($"Neues Item:\n{itemUri.PathAndQuery}");
        }

        private void btnBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(tbId.Text, out id))
            {
                TodoItem item = new TodoItem();
                item.Id = id;
                item.Name = tbName.Text;
                item.IsComplete = cbIsComplete.IsChecked ?? false;

                ItemInfo(api.Put(item));

                dgItems.ItemsSource = new List<TodoItem>() { item };
            }
        }

        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(tbId.Text, out id))
            {
                var code = api.Delete(id);

                ItemInfo(null);
                List<TodoItem> items = api.GetAll();
                dgItems.ItemsSource = items;

                MessageBox.Show($"Code: {code}");
            }
        }
    }
}
