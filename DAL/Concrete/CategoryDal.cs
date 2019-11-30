using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class CategoryDal : ADalCrud<Category> // ADalRead<User>
    {
        public CategoryDal() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[CATEGORY]";
        }

        protected override Category CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Category category = new Category(parameters[Convert.ToInt32(ECategory.NAME)],
                parameters[Convert.ToInt32(ECategory.DESCRIPTION)]);
            category.Id = Convert.ToInt32(parameters[Convert.ToInt32(ECategory.ID)]);
            return category;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Category category)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(ECategory.ID.ToString().ToLower(), category.Id.ToString());
            result.Add(ECategory.NAME.ToString().ToLower(), category.Name);
            result.Add(ECategory.DESCRIPTION.ToString().ToLower(), category.Description);

            return result;
        }

        public void PrintCategory(Category category)
        {
            Console.WriteLine(
                "\nID: " + category.Id.ToString() +
                "\nNAME: " + category.Name +
                "\nDESCRIPTION: " + category.Description + "\n");
        }

        public void PrintListOfCategories(IList<Category> categories)
        {
            foreach (Category category in categories)
            {
                PrintCategory(category);
            }
        }
    }
}
