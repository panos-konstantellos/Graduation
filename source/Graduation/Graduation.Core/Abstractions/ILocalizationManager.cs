using System.Threading;
using System.Threading.Tasks;

namespace Graduation.Core
{
    public interface ILocalizationManager
    {
        Task<LocalizedResource> GetValueAsync(int languageId, string key, string defaultValue, CancellationToken cancellationToken);
    }
}