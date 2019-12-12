using AutoMapper;
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
                .RegisterType<IAuthenticationService, AuthenticationService>()
                .RegisterType<IUserService, UserService>()
                .RegisterType<IRoleService, RoleService>()
                .RegisterType<IProductService, ProductService>()
                .RegisterType<IOrderService, OrderService>()
                .RegisterType<ISupplierService, SupplierService>()
                .RegisterType<ISuppToProdService, SuppToProdService>()
                .RegisterInstance<IMapper>(ObjectsMapper.CreateMapper());
            //, InstanceLifetime.Singleton
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}