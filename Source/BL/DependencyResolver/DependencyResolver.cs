using Microsoft.Extensions.DependencyInjection;

namespace BL.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
      {
         serviceCollection.AddHttpClient();

         return serviceCollection;
      }
   }
}
