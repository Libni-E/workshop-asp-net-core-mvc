using Aplicacao_Web_AspNet.Models;
using Aplicacao_Web_AspNet.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Aplicacao_Web_AspNet.Services.Exceptions;
using System.Threading.Tasks;

namespace Aplicacao_Web_AspNet.Services
{
    public class SellerService
    {
        private readonly Aplicacao_Web_AspNetContext _context;

        public SellerService(Aplicacao_Web_AspNetContext context)
        {
            _context = context;
        }
        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();

        }
        public async Task InsertAsync(Seller obj)
        {
            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async  Task<Seller> FindByIdAsync(int id)
        {
             return  await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if(!hasAny)
            {
                throw new NotFoundException("Is not found");
            }
            try
            {
                 _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
