using System.Reflection;

namespace Presentation_Layer.Extensions
{
    public static class AutoMapperExtension
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
