using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.Domain.Entities

//başka bir classın bunu implement etmesini engellemek için sealed class kullanılır
// IdentityUser sınıfını Generic olarak kullanıyoruz
//idendity kütüphanesini kullanmamız lazım!
{
    public  sealed  class AppUser: IdentityUser<Guid> 
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => string.Join("", FirstName, LastName);


    }
}


