using eAppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.WebAPI
{
    public static  class Helper
    {

        public static async Task CrateUserAsync(WebApplication app)
        {
            using (var scoped = app.Services.CreateScope())
            {
                var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
           
                // Eğer hiç kullanıcı yoksa, bir admin oluştur
                if (!userManager.Users.Any())
                {
                   await userManager.CreateAsync(new AppUser
                    {
                        FirstName = "Furkan",
                        LastName = "Aydemir",
                        Email = "admin@admin.com",
                        UserName = "admin",
                    }, "1");

                }

            }
        }
    }
}
