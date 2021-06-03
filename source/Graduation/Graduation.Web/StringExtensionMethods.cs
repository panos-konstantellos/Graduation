using System.Linq;

namespace Graduation.Web.Controllers
{
    public static class StringExtensionMethods
    {
        public static string ToCamelCase(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            return text.First().ToString().ToUpper() + text.Substring(1).ToLower();
        }
    }
}