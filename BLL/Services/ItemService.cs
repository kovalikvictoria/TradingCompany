using AutoMapper;
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

    }
}
