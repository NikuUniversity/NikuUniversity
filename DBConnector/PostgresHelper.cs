using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DBConnector
{
    public class PostgresHelper : IDisposable, IAsyncDisposable
    {
        // IDisposable implementation
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources here
            }
            // free unmanaged resources here
        }

        // IAsyncDisposable implementation
        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();

            // Dispose of unmanaged resources.
            Dispose(disposing: false);

            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual ValueTask DisposeAsyncCore()
        {
            // override to perform async cleanup of managed resources
            return default;
        }
    }
}
