using Aplicacao_Web_AspNet.Data;
using Aplicacao_Web_AspNet.Models;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao_Web_AspNet.Services
{
    public class DepartmentService
    {
        private readonly Aplicacao_Web_AspNetContext _context;

        public DepartmentService(Aplicacao_Web_AspNetContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
