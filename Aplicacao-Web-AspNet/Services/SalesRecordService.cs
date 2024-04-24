using Aplicacao_Web_AspNet.Data;
using Aplicacao_Web_AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao_Web_AspNet.Services
{
    public class SalesRecordService
    {
        private readonly Aplicacao_Web_AspNetContext _context;

        public SalesRecordService(Aplicacao_Web_AspNetContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDataAsync(DateTime? minDate, DateTime? maxDate) 
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
