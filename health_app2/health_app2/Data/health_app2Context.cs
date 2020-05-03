using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using health_app2.Models;

namespace health_app2.Data
{
    public class health_app2Context : DbContext
    {
        public health_app2Context (DbContextOptions<health_app2Context> options)
            : base(options)
        {
        }

        public DbSet<health_app2.Models.Unit> Unit { get; set; }
    }
}
