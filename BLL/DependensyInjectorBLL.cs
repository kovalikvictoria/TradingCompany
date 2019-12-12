using AutoMapper;
using BLL;
using BLL.Services;
using TradingCompany.DAL;
using Unity;
using Unity.Resolution;

namespace TradingCompany.BLL
{
    public static class DependencyInjectorBLL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();

        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();
            container.RegisterBLLTypes();

            return container;
        }

        public static void RegisterBLLTypes(this IUnityContainer container)
        {
            container
                .RegisterType<UserService>()
                .RegisterType<CategoryService>()
                .RegisterType<ItemService>()
                .RegisterType<ReviewService>()
                .RegisterInstance<IMapper>(ObjectsMapper.CreateMapper());
            //, InstanceLifetime.Singleton
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}