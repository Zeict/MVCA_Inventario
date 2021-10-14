using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MVCA_Inventario.Repository;
using Unity.Mvc4;

namespace MVCA_Inventario
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IRepository, Repository.Repository>();
            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}