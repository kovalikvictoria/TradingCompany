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
    public class CategoryService
    {
        private readonly CategoryDal _categoryDal;
        private readonly IMapper _mapper;

        public CategoryService(CategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public CategoryDTO GetById(int id)
        {
            Category categ = _categoryDal.GetById(id);
            CategoryDTO categDTO = _mapper.Map<Category, CategoryDTO>(categ);
            return categDTO;
        }

        public IEnumerable<string> GetCategoryNames()
        {
            List<string> categNames = new List<string>();
            var categs = _categoryDal.GetAll();
            foreach (Category categ in categs)
            {
                categNames.Add(categ.Name);
            }
            return categNames;
        }

        public CategoryDTO GetByName(string name)
        {
            Category categ = _categoryDal.GetByName(name);
            CategoryDTO categDTO = _mapper.Map<Category, CategoryDTO>(categ);
            return categDTO;
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            List<CategoryDTO> categoriesDTO = new List<CategoryDTO>();
            foreach (var categ in _categoryDal.GetAll())
            {
                CategoryDTO categoryDTO = _mapper.Map<Category, CategoryDTO>(categ);
                categoriesDTO.Add(categoryDTO);
            }
            return categoriesDTO;
        }
    }
}
