using CorePagination.Data;
using CorePagination.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePagination.Services
{
    public class PagingService
    {
        public readonly PagingDbcontext _Context;
        public PagingService(PagingDbcontext context)
        {
            _Context = context;
        }

        public List<InformationViewmodel> DoPaging()
        {
            var test = new List<InformationViewmodel>();
            return test;
        }
    }
}
