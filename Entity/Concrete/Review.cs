using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public enum EReview
    {
        ID = 0,
        USERID,
        ITEMID,
        TEXT,
        DATETIME
    }

    public class Review : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public Review(int userId, int itemId, string text, DateTime dateTime)
        {
            UserId = userId;
            ItemId = itemId;
            Text = text;
            DateTime = dateTime;
        }
    }
}
