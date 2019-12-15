using BLL.Services;
using BLL.Views;
using Elasticsearch.Net;
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
using System.Windows.Shapes;
using TradingCompany.BLL;

namespace WPFs
{
    /// <summary>
    /// Interaction logic for ItemsMenu.xaml
    /// </summary>
    public partial class ItemsMenu : Window
    {
        ItemListViewModel _viewModel;
        private readonly ItemService _itemService;
        public ItemsMenu(ItemListViewModel viewModel, ItemService itemService)
        {
            _viewModel = viewModel;
            _itemService = itemService;
            DataContext = _viewModel;

            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ItemsDataGrid.ItemsSource);
            view.Filter = ItemsFilter;
        }

        private bool ItemsFilter(object obj)
        {
            if (String.IsNullOrEmpty(search_textbox.Text))
                return true;
            else
                return ((obj as ItemViewModel).Category.IndexOf(search_textbox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void ItemsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            category_combobox.Text = _viewModel.SelectedItem.Category;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsDataGrid.SelectedItems.Count > 0)
            {
                ItemViewModel item = new ItemViewModel();
                var dialog = MessageBox.Show("Are you sure?", "Update", MessageBoxButton.YesNo);

                if (dialog == MessageBoxResult.Yes)
                {
                    item = _viewModel.SelectedItem;
                    item.Name = name_textbox.Text;
                    item.Description = desc_textbox.Text;
                    item.Price = Convert.ToInt32(price_textbox.Text);
                    item.InStock = inStock_textbox.Text;
                    item.Category = _viewModel.SelectedCategory.Name;
                    _itemService.Update(item);
                }
                ItemsDataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Choose item");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsDataGrid.SelectedItems.Count > 0)
            {
                var item = _viewModel.SelectedItem;
                var dialog = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);

                if (dialog == MessageBoxResult.Yes)
                {
                    _itemService.Delete(item.Id);
                }
                try
                {
                    _viewModel.Items.Remove(item);
                    ItemsDataGrid.Items.Refresh();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Choose item");
            }
        }


        private void search_textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(ItemsDataGrid.ItemsSource).Refresh();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var window = DependencyInjectorBLL.Resolve<AddItemWindow>();
            window.Show();
        }

      
    }
}
