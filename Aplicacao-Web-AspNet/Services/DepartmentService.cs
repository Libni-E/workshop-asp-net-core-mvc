using Aplicacao_Web_AspNet.Data;
using Aplicacao_Web_AspNet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao_Web_AspNet.Services
{
    public class DepartmentService
    {
        private readonly Aplicacao_Web_AspNetContext _context;

        public DepartmentService(Aplicacao_Web_AspNetContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
