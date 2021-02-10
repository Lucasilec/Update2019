using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesWebMVC.Models;

namespace salesWebMVC.Data
{
    public class salesWebMVCContext : DbContext
    {
        public salesWebMVCContext (DbContextOptions<salesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<salesWebMVC.Models.Departaments> Departaments { get; set; }
    }
}
