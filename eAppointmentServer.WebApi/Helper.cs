using eAppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.WebApi
{
    public static class Helper
    {


        //user oluşturmak için yazdığımız async metot:
        public static async Task CreateUserAsync(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                if (!userManager.Users.Any())
                {
                 await   userManager.CreateAsync(new()
                    {
                        FirstName = "Furkan",
                        LastName = "Aydemir",
                        Email = "furkanaydemir12@hotmail.com",
                        UserName = "admin",
                    }, "1");
                }
            }
        }
    }
}
