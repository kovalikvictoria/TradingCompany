using BLL.Services;
using BLL.Views;
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

namespace WPFs
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        private readonly ItemService _itemService;
        private readonly CategoryService _categService;
        ItemListViewModel _viewModel;

        public AddItemWindow(ItemListViewModel viewModel, ItemService itemService, CategoryService categoryService)
        {
            _viewModel = viewModel;

            _itemService = itemService;
            _categService = categoryService;
            DataContext = _viewModel;

            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (name_textbox.Text.Length == 0 
                || desc_textbox.Text.Length == 0
                || price_textbox.Text.Length == 0
                || inStock_textbox.Text.Length == 0
                || category_combobox.SelectedItem.ToString().Length == 0)
            {
                MessageBox.Show("Fields can not be empty.");
            }
            else
            {
                ItemViewModel item = new ItemViewModel();
                item.Name = name_textbox.Text;
                item.Description = desc_textbox.Text;
                item.Price = Convert.ToInt32(price_textbox.Text);
                item.InStock = inStock_textbox.Text;
                item.Category = category_combobox.Text.ToString();
                
                try
                {
                    _itemService.Create(item);
                    MessageBox.Show("Successfully created.");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
