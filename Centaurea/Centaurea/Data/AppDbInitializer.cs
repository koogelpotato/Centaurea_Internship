using Centaurea.Models;

namespace Centaurea.Data
{
    public class AppDbInitializer
    {
        public static async void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if(!context.Concerts.Any())
                {
                    context.Concerts.AddRange(new List<Concert>
                    {
                        new Concert()
                        {

                        }
                    });
                }
            }
        }
    }
}
