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

        public DbSet<Aplicacao_Web_AspNet.Models.Department> Department { get; set; }
    }
}
