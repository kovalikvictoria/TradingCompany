using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public User user { get; set; }
        public Item item { get; set; }
        public string Text { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
