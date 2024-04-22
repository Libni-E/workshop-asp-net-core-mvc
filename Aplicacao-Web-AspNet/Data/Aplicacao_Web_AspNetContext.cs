using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicacao_Web_AspNet.Models;

namespace Aplicacao_Web_AspNet.Data
{
    public class Aplicacao_Web_AspNetContext : DbContext
    {
        public Aplicacao_Web_AspNetContext (DbContextOptions<Aplicacao_Web_AspNetContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
