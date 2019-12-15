using AutoMapper;
using BLL.Views;
using DTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ObjectsMapper
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();

                cfg.CreateMap<Review, ReviewDTO>();
                cfg.CreateMap<ReviewDTO, ReviewViewModel>()
                    .ForMember(x => x.User,
                               m => m.MapFrom(y => y.user.Login));
                cfg.CreateMap<ReviewDTO, ReviewViewModel>()
                    .ForMember(x => x.Item,
                               m => m.MapFrom(y => y.item.Name));
                cfg.CreateMap<ReviewViewModel, Review>();

                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<ItemDTO, ItemViewModel>()
                    .ForMember(x => x.Category,
                               m => m.MapFrom(y => y.category.Name));
                cfg.CreateMap<ItemDTO, Item>();
                cfg.CreateMap<ItemViewModel, Item>();

                cfg.CreateMap<Category, CategoryDTO>();

                cfg.CreateMap<UserRegistrationModel, User>();
                cfg.CreateMap<UserRegistrationModel, UserDTO>();
            }).CreateMapper();
        }
    }
}
