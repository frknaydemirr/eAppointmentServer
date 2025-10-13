using Microsoft.Extensions.DependencyInjection;

namespace eAppointmentServer.Application
{
    public static  class DependencyInjection
    {

        //porgram. cs deki yapılandırma için kullanılır!
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DependencyInjection).Assembly);
            services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssemblies(typeof(DependencyInjection).Assembly));
            return services;
        }
    }
}

//Amaç: Uygulamanın her katmanında(örneğin Application, Infrastructure, Persistence vs.)
//dependency injection(bağımlılık enjeksiyonu) yapılandırmalarını merkezi şekilde tanımlamaktır.

//Yani bu sınıf, Application katmanına ait servisleri (örneğin CQRS handler’ları, validator’lar, 
//services, mapping profilleri vb.) 
//dependency container’a eklemek için bir “genişletme metodu” (extension method) sağlar.
