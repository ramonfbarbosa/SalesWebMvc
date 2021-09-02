using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webmvc.Models
{
    public class webmvcContext : DbContext
    {
        public webmvcContext (DbContextOptions<webmvcContext> options)
            : base(options)
        {
        }

        public DbSet<webmvc.Models.Department> Department { get; set; }
    }
}
