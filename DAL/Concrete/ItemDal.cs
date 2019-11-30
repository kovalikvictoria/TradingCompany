using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ItemDal : ADalCrud<Item> // ADalRead<User>
    {
        public ItemDal() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[ITEM]";
        }

        protected override Item CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Item item = new Item(
                parameters[Convert.ToInt32(EItem.NAME)],
                parameters[Convert.ToInt32(EItem.DESCRIPTION)],
                Convert.ToInt32(parameters[Convert.ToInt32(EItem.CATEGORYID)]),
                Convert.ToDecimal(parameters[Convert.ToInt32(EItem.PRICE)]),
                parameters[Convert.ToInt32(EItem.INSTOCK)]);
            item.Id = Convert.ToInt32(parameters[Convert.ToInt32(EItem.ID)]);
            return item;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Item item)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EItem.ID.ToString().ToLower(), item.Id.ToString());
            result.Add(EItem.NAME.ToString().ToLower(), item.Name);
            result.Add(EItem.DESCRIPTION.ToString().ToLower(), item.Description);
            result.Add(EItem.CATEGORYID.ToString().ToLower(), item.CategoryId.ToString());
            result.Add(EItem.PRICE.ToString().ToLower(), item.Price.ToString());
            result.Add(EItem.INSTOCK.ToString().ToLower(), item.InStock);

            return result;
        }


        public void PrintItem(Item item)
        {
            Console.WriteLine(
                   "\nID: " + item.Id.ToString() +
                   "\nNAME: " + item.Name +
                   "\nDESCRIPTION: " + item.Description +
                   "\nCATEGORY_ID: " + item.CategoryId.ToString() +
                   "\nPRICE: " + item.Price.ToString() +
                   "\nIN_STOCK: " + item.InStock + "\n");
        }

        public void PrintListOfItems(IList<Item> items)
        {
            foreach (Item item in items)
            {
                PrintItem(item);
            }
        }
    }
}
