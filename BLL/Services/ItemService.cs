using AutoMapper;
using BLL.Views;
using DAL.Concrete;
using DTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ItemService
    {
        private readonly ItemDal _itemDal;
        private readonly IMapper _mapper;

        public ItemService(ItemDal itemDal, IMapper mapper)
        {
            _itemDal = itemDal;
            _mapper = mapper;
        }

        public IEnumerable<ItemViewModel> GetViewModels()
        {
            IEnumerable<ItemDTO> itemDTOs = this.GetAll();
            var itemsView = itemDTOs.ToList().ConvertAll(x => _mapper.Map<ItemDTO, ItemViewModel>(x));
            return itemsView;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            List<ItemDTO> itemDTOs = new List<ItemDTO>();

            CategoryDal categoryDal = new CategoryDal();
            foreach (var item in _itemDal.GetAll())
            {
                ItemDTO itemDTO = _mapper.Map<Item, ItemDTO>(item);
                itemDTO.category = categoryDal.GetById(item.CategoryId);
                itemDTOs.Add(itemDTO);
            }
            return itemDTOs;
        }

        public ItemDTO GetById(int id)
        {
            Item item = _itemDal.GetById(id);
            ItemDTO itemDTO = _mapper.Map<Item, ItemDTO>(item);
            return itemDTO;
        }

        public IEnumerable<ItemDTO> GetByCategory(string categName)
        {
            CategoryDal categDal = new CategoryDal();
            Category categ = categDal.GetByName(categName);

            List<ItemDTO> itemsDTO = new List<ItemDTO>();
            foreach (var item in _itemDal.GetByFieldName("categoryid", categ.Id.ToString()))
            { 
                ItemDTO itemDTO = _mapper.Map<Item, ItemDTO>(item);
                itemsDTO.Add(itemDTO);
            }
            return itemsDTO;
        }

        public bool Create(ItemViewModel model)
        {
            try
            {
                CategoryDal categoryDal = new CategoryDal();

                Item item = _mapper.Map<ItemViewModel, Item>(model);
                item.CategoryId = categoryDal.GetByFieldName("name", model.Category).First().Id;
                _itemDal.Insert(item);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Create(ItemDTO model)
        {
            try
            {
                Item item = _mapper.Map<ItemDTO, Item>(model);
                _itemDal.Insert(item);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update(ItemViewModel model)
        {
            try
            {
                CategoryDal categoryDal = new CategoryDal();

                Item item = _mapper.Map<ItemViewModel, Item>(model);
                item.CategoryId = categoryDal.GetByFieldName("name", model.Category).First().Id;
                _itemDal.UpdateByEntity(item);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _itemDal.Delete(_itemDal.GetById(id));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}