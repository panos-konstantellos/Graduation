using System.Linq;

namespace Graduation.Web.Controllers
{
    public static class StringExtensionMethods
    {
        public static string NullIfEmpty(this string s)
        {
            return string.IsNullOrEmpty(s) ? null : s;
        }
        public static string NullIfWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s) ? null : s;
        }
        
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