using System.Globalization;
using System.Threading;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreLocalizationTest
{
    /// <summary>
    /// Responsible for setting the request culture.
    /// </summary>
    public class CultureFilter : IAuthorizationFilter
    {
        private readonly string[] SUPPORTED_CULTURES = new[] { "en", "fr" };


        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Request.Path.HasValue)
            {
                var languageCode = context.HttpContext.Request.Path.Value.Split('/', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
                if (SUPPORTED_CULTURES.Contains(languageCode))
                {
                    try
                    {
                        Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCode);
                    }
                    catch { /* ignore any errors */ }
                }
            }
        }
    }
}
