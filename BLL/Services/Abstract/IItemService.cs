using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstract
{
    public interface IItemService
    {
        IList<ItemDTO> GetItemsByCategoryId(int categoryId);

        IList<ItemDTO> GetAllItems();

        IList<CategoryDTO> GetAllCategories();
    }
}
