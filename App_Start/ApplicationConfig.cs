using Kentico.Web.Mvc;

namespace KenticoMVC
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(ApplicationBuilder builder)
        {
            builder.UseDataAnnotationsLocalization();
            builder.UseNotFoundHandler();
        }
    }
}
