using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ReviewDal : ADalCrud<Review> // ADalRead<User>
    {
        public ReviewDal() : base()
        {
        }

        // class ADalRead
        protected override string GetTableName()
        {
            return "[REVIEW]";
        }

        protected override Review CreateInstance(ICollection<string> args)
        {
            List<string> parameters = args.ToList<string>();
            Review review = new Review(
                Convert.ToInt32(parameters[Convert.ToInt32(EReview.USERID)]),
                Convert.ToInt32(parameters[Convert.ToInt32(EReview.ITEMID)]),
                parameters[Convert.ToInt32(EReview.TEXT)],
                Convert.ToDateTime(parameters[Convert.ToInt32(EReview.DATETIME)]));
            review.Id = Convert.ToInt32(parameters[Convert.ToInt32(EReview.ID)]);
            return review;
        }

        // class ADalCrud
        protected override IDictionary<string, string> GetValues(Review review)
        {
            // TODO Use Enum
            IDictionary<string, string> result = new Dictionary<string, string>();
            result.Add(EReview.ID.ToString().ToLower(), review.Id.ToString());
            result.Add(EReview.USERID.ToString().ToLower(), review.UserId.ToString());
            result.Add(EReview.ITEMID.ToString().ToLower(), review.ItemId.ToString());
            result.Add(EReview.TEXT.ToString().ToLower(), review.Text);
            result.Add(EReview.DATETIME.ToString().ToLower(), review.DateTime.ToString());

            return result;
        }

        public void PrintReview(Review review)
        {
            Console.WriteLine(
                "\nID: " + review.Id.ToString() +
                "\nUSER_ID: " + review.UserId.ToString() +
                "\nITEM_ID: " + review.ItemId.ToString() +
                "\nTEXT OF REVIEW: " + review.Text +
                "\nDATETIME: " + review.DateTime.ToString() + "\n");
        }

        public void PrintListOfReviews(IList<Review> reviews)
        {
            foreach (Review review in reviews)
            {
                PrintReview(review);
            }
        }
    }
}
