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
    public class ReviewService
    {
        private readonly ReviewDal _reviewDal;
        private readonly IMapper _mapper;

        public ReviewService(ReviewDal reviewDal, IMapper mapper)
        {
            _reviewDal = reviewDal;
            _mapper = mapper;
        }

        public IEnumerable<ReviewDTO> GetByItem(string itemName)
        {
            ItemDal itemDal = new ItemDal();
            Item item = itemDal.GetByName(itemName);

            List<ReviewDTO> reviewsDTO = new List<ReviewDTO>();
            foreach (var review in _reviewDal.GetByFieldName("itemid", item.Id.ToString()))
            {
                ReviewDTO reviewDTO = _mapper.Map<Review, ReviewDTO>(review);
                reviewsDTO.Add(reviewDTO);
            }
            return reviewsDTO;
        }

        public IEnumerable<ReviewDTO> SortByDate(List<ReviewDTO> reviewsDTO)
        {
            return reviewsDTO.OrderBy(obj => obj.DateTime);
        }

        public IEnumerable<ReviewDTO> SortByUser(List<ReviewDTO> reviewsDTO)
        {
            return reviewsDTO.OrderBy(obj => obj.user.Login);
        }

    }
}
