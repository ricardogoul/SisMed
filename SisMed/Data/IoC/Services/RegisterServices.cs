using SisMed.Application.AppService;
using SisMed.Application.Interfaces;

namespace SisMed.Data.IoC
{
    public class RegisterServices
    {
        public static void Register(IServiceCollection service)
        {
            service.AddScoped<IMedicoAppService, MedicoAppService>();
        }
    }
}
