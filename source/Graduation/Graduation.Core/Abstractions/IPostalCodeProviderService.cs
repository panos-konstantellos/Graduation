using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Graduation.Core
{
    public interface IPostalCodeProviderService
    {
        Task<IEnumerable<PostalCode>> GetPostalCodesAsync(CancellationToken cancellationToken);

        Task<PostalCode> GetPostalCodeAsync(string code, CancellationToken cancellationToken);
    }
}