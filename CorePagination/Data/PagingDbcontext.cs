using CorePagination.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CorePagination.Data
{
    public class PagingDbcontext : DbContext
    {
        public PagingDbcontext() : base("LocalSQL")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PagingDbcontext>());
        }

    public DbSet<Information> Informations { get; set; }
    }
}
