using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCnAPI.Models;

namespace MVCnAPI.Data
{
    public class MVCnAPIContext : DbContext
    {
        public MVCnAPIContext (DbContextOptions<MVCnAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MVCnAPI.Models.Person> Person { get; set; }
    }
}
