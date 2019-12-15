using BLL.Services;
using BLL.Views;
using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFs
{
    public class ItemListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ItemService _itemService;
        private readonly CategoryService _categoryService;

        public ObservableCollection<ItemViewModel> Items { get; set; }
        public ObservableCollection<CategoryDTO> Categories { get; set; }

        private ItemViewModel _selectedItem;
        private CategoryDTO _selectedCategory;

        public ItemViewModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                try
                {
                    _selectedItem = value;
                    _selectedCategory = _categoryService.GetByName(_selectedItem.Category);
                    OnPropertyChanged("SelectedItem");
                }
                catch { }
            }
        }

        public CategoryDTO SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        public ItemListViewModel(ItemService itemService, CategoryService categoryService)
        {
            _itemService = itemService;
            _categoryService = categoryService;
            Update();
        }

        public string Name
        {
            get { return _selectedItem.Name; }
            set
            {
                _selectedItem.Category = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _selectedItem.Description; }
            set
            {
                _selectedItem.Description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Category
        {
            get { return _selectedItem.Category; }
            set
            {
                _selectedItem.Category = value;
                OnPropertyChanged("Category");
            }
        }

        public string Price
        {
            get { return _selectedItem.Price.ToString(); }
            set
            {
                _selectedItem.Price = Convert.ToInt32(value);
                OnPropertyChanged("Price");
            }
        }

        public string InStock
        {
            get { return _selectedItem.InStock; }
            set
            {
                _selectedItem.InStock = value;
                OnPropertyChanged("InStock");
            }
        }

        public CategoryDTO CategoryDescription
        {
            get { return _categoryService.GetByName(_selectedItem.Category); }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged("CategoryDescription");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Update()
        {
            Items = new ObservableCollection<ItemViewModel>(_itemService.GetViewModels());
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.GetAll());
        }
    }
}
