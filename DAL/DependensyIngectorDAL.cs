using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;
using DAL.Abstract;
using DAL.Concrete;

namespace TradingCompany.DAL
{
    public static class DependencyInjectorDAL
    {
        private readonly static IUnityContainer _unityContainer = GetUnity();
        private static IUnityContainer GetUnity()
        {
            var container = new UnityContainer();
            container.RegisterDALTypes();

            return container;
        }

        public static void RegisterDALTypes(this IUnityContainer container)
        {
            container
                .RegisterType<UserDal>()
                .RegisterType<CategoryDal>()
                .RegisterType<ItemDal>()
                .RegisterType<ReviewDal>();
        }

        public static T Resolve<T>(params ParameterOverride[] overrides)
        {
            return _unityContainer.Resolve<T>(overrides);
        }
    }
}