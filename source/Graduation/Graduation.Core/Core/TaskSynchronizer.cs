using System;
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

    public sealed class TaskSynchronizer
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public Task LockAsync(Func<Task> fn, CancellationToken cancellationToken)
        {
            if (cancellationToken == null)
            {
                throw new ArgumentNullException(nameof(cancellationToken));
            }

            return this.DoLockAsync(fn, cancellationToken);
        }
        
        public Task<T> LockAsync<T>(Func<Task<T>> fn, CancellationToken cancellationToken)
        {
            if (cancellationToken == null)
            {
                throw new ArgumentNullException(nameof(cancellationToken));
            }
            
            return DoLockAsync(fn, cancellationToken);
        }

        private async Task DoLockAsync(Func<Task> fn, CancellationToken cancellationToken)
        {
            using (new TaskLockObject(this._semaphore, cancellationToken))
            {
                await fn();
            }
        }

        private async Task<T> DoLockAsync<T>(Func<Task<T>> fn, CancellationToken cancellationToken)
        {
            using (new TaskLockObject(this._semaphore, cancellationToken))
            {
                return await fn();
            }
        }
    }
}