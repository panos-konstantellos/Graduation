using System.Threading;
using System.Threading.Tasks;

using Graduation.Core;

namespace Graduation.Web.Models
{
    public struct LocalizedResourceKey
    {
        public string Key;

        public string DefaultValue;

        public LocalizedResourceKey(string key, string defaultValue)
        {
            this.Key = key;
            this.DefaultValue = defaultValue;
        }
    }
    
    public static class FormStepOneLocalizedResourceKeys
    {
        public static readonly LocalizedResourceKey StudentDetails = new(@"Form.StepOne.Title", @"Στοιχεία Φοιτητή");
        
        public static readonly LocalizedResourceKey ContactInfo = new(@"Form.StepOne.ContactInfo", @"Στοιχεία Φοιτητή");
    }
    
    public static class LocalizationManagerExtensions
    {
        public static async Task<LocalizedResource> GetValueAsync(this ILocalizationManager manager, int languageId, LocalizedResourceKey key, CancellationToken cancellationToken)
        {
            return await manager.GetValueAsync(languageId, key.Key, key.DefaultValue, cancellationToken);
        }
    }
}