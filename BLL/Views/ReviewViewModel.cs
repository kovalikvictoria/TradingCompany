using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Views
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Item { get; set; }
        public string Text { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
