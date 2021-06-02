using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Graduation.Core
{
    internal class LocalizationManager : ILocalizationManager
    {
        private bool _isInitialized = false;
        private TaskSynchronizer _lockObject = new TaskSynchronizer();
        private Dictionary<int, Dictionary<string, LocalizedResource>> _resources;

        private readonly EducationContext _context;

        public LocalizationManager(EducationContext context)
        {
            this._context = context;
        }

        public async Task<LocalizedResource> GetValueAsync(int languageId, string key, string defaultValue, CancellationToken cancellationToken)
        {
            await this.Init(cancellationToken);

            if (!this._resources.ContainsKey(languageId))
            {
                return new LocalizedResource
                {
                    Key = key,
                    Value = !string.IsNullOrEmpty(defaultValue) ? defaultValue : key
                };
            }

            if (!this._resources[languageId].ContainsKey(key))
            {
                return new LocalizedResource
                {
                    Key = key,
                    Value = !string.IsNullOrEmpty(defaultValue) ? defaultValue : key
                };
            }

            return this._resources[languageId][key];
        }

        private async Task Init(CancellationToken cancellationToken)
        {
            if (!this._isInitialized)
            {
                await this._lockObject.LockAsync(async () =>
                {
                    if (!this._isInitialized)
                    {
                        this._resources = (await this._context.LocalizedResources.ToListAsync(cancellationToken))
                            .GroupBy(x => x.LanguageId)
                            .ToDictionary(x => x.Key, x => x.ToDictionary(l => l.Key, l => l));

                        this._isInitialized = true;
                    }
                }, cancellationToken);
            }
        }
    }
}