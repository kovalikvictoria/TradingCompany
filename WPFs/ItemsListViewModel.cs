using BLL.Services;
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
    public class ItemsListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly CategoryService _categoryService;

        public ObservableCollection<CategoryDTO> Categories { get; set; }

        private CategoryDTO _selectedCategory;

        public CategoryDTO SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;

                OnPropertyChanged("SelectedUser");
            }
        }

        public ItemsListViewModel(CategoryService categoryService)
        {
            _categoryService = categoryService;
            Update();
        }

        public string CategoryName
        {
            get { return _selectedCategory.Name; }
            set
            {
                _selectedCategory.Name = value;
                OnPropertyChanged("CategoryName");
            }
        }
        public string CategoryDescription
        {
            get { return _selectedCategory.Description; }
            set
            {
                _selectedCategory.Description = value;
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
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.GetAll());
        }
    }
}