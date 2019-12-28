using CorePagination.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePagination.Services
{
    public class ServiceManager
    {
        private readonly PagingDbcontext _Context;
        public ServiceManager(PagingDbcontext Context)
        {
            _Context = Context;
        }

        public T NewService<T>()
        {
            var serviceType = (T)Activator.CreateInstance(typeof(T), _Context);
            return serviceType;
        }

        public T NewService<T>(params object[] objects)
        {
            var serviceType = (T)Activator.CreateInstance(typeof(T), objects);
            return serviceType;
        }
        public async System.Threading.Tasks.Task<int> SaveAsync()
        {
            return await _Context.SaveChangesAsync();
        }
    }
}
