using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public enum EItem
    {
        ID,
        NAME,
        DESCRIPTION,
        CATEGORYID,
        PRICE,
        INSTOCK
    }

    public class Item : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string InStock { get; set; }

        public Item(string name, string desc, int categId,
            decimal price, string inStock)
        {
            Name = name;
            Description = desc;
            CategoryId = categId;
            Price = price;
            InStock = inStock;
        }
    }
}
