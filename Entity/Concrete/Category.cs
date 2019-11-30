using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public enum ECategory
    {
        ID = 0,
        NAME,
        DESCRIPTION
    }

    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(string name, string desc)
        {
            Name = name;
            Description = desc;
        }
    }
}
