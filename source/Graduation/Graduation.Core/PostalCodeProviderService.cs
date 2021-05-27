using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Graduation.Core
{
    public sealed class PostalCodeProviderService : IPostalCodeProviderService
    {
        private readonly PostalCodeContext _context;

        public PostalCodeProviderService(PostalCodeContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<PostalCode>> GetPostalCodesAsync(CancellationToken cancellationToken)
        {
            return await this._context.PostalCodes.ToListAsync(cancellationToken);
        }

        public async Task<PostalCode> GetPostalCodeAsync(string code, CancellationToken cancellationToken)
        {
            return await this._context.PostalCodes.FirstOrDefaultAsync(x => x.Code == code, cancellationToken);
        }
    }
}