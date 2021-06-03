using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Graduation.Core
{
    internal class TaskLockObject : IDisposable
    {
        private readonly SemaphoreSlim _semaphore;

        public TaskLockObject(SemaphoreSlim semaphore, CancellationToken cancellationToken)
        {
            this._semaphore = semaphore;

            this._semaphore.WaitAsync(cancellationToken);
        }
        
        public void Dispose()
        {
            this._semaphore.Release();
        }
    }

    public class TaskSynchronizer
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public async Task LockAsync(Func<Task> fn, CancellationToken cancellationToken)
        {
            if (cancellationToken == null)
            {
                throw new ArgumentNullException(nameof(cancellationToken));
            }
            
            using (new TaskLockObject(this._semaphore, cancellationToken))
            {
                await fn();
            }
        }
        
        public async Task<T> LockAsync<T>(Func<Task<T>> fn, CancellationToken cancellationToken)
        {
            if (cancellationToken == null)
            {
                throw new ArgumentNullException(nameof(cancellationToken));
            }
            
            using (new TaskLockObject(this._semaphore, cancellationToken))
            {
                return await fn();
            }
        }
    }
}