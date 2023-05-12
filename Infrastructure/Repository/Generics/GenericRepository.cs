using Domain.Interfaces.Generics;
using Microsoft.Win32.SafeHandles;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Infrastructure.Repository.Generics
{
    public class GenericRepository<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _ContextBase;

        public GenericRepository() 
        {
            _ContextBase = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T entity)
        {
            using var data = new ContextBase(_ContextBase);
            await data.Set<T>().AddAsync(entity);
            await data.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            using var data = new ContextBase(_ContextBase);
            data.Set<T>().Remove(entity);
            await data.SaveChangesAsync();
        }

        public async Task<T> GetEntityById(int Id)
        {
            using var data = new ContextBase(_ContextBase);
            return await data.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> List()
        {
            using var data = new ContextBase(_ContextBase);
            return await data.Set<T>().ToListAsync();
        }

        public async Task Update(T entity)
        {
            using var data = new ContextBase(_ContextBase);
            data.Set<T>().Update(entity);
            await data.SaveChangesAsync();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;

        // Instantiate a SafeHandle instance.
        readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            // Free any other managed objects here.
            if (disposing)
                handle.Dispose();
                
            disposed = true;
        }
        #endregion
    }
}