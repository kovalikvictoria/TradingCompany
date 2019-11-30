//using Unity;
//using Unity.Resolution;
//using BLL.Services.Interfaces;
//using BLL.Services.ImplementedServices;
//using DAL;
//using AutoMapper;

//namespace BLL
//{
//    public static class DependencyInjectorBLL
//    {
//        private readonly static IUnityContainer _unityContainer = GetUnity();

//        private static IUnityContainer GetUnity()
//        {
//            var container = new UnityContainer();
//            container.RegisterDALTypes();
//            container.RegisterBLLTypes();

//            return container;
//        }

//        public static void RegisterBLLTypes(this IUnityContainer container)
//        {
//            container
//                .RegisterType<IAuthenticationService, AuthenticationService>()
//                .RegisterType<IUserService, UserService>()
//                .RegisterType<ICategoryService, CategoryService>()
//                .RegisterInstance<IMapper>(MapperConfig.CreateMapper(), InstanceLifetime.Singleton); ;
//        }

//        public static T Resolve<T>(params ParameterOverride[] overrides)
//        {
//            return _unityContainer.Resolve<T>(overrides);
//        }
//    }
//}