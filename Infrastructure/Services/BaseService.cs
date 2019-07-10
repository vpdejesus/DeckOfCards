using System;
using ApplicationCore.Interfaces;

namespace Infrastructure.Services
{
    public class BaseService : IBaseService
    {
        #region Dispose context

        /// <summary>
        /// Disposes this instance.
        /// </summary>
        void IDisposable.Dispose()
        {
            Dispose(true);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        #endregion
    }
}
