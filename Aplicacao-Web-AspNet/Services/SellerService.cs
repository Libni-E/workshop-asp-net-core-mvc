using Aplicacao_Web_AspNet.Models;
using Aplicacao_Web_AspNet.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Aplicacao_Web_AspNet.Services
{
    public class SellerService
    {
        private readonly Aplicacao_Web_AspNetContext _context;

        public SellerService(Aplicacao_Web_AspNetContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();

        }
        public void Insert(Seller obj)
        {
            
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();

        }
    }
}
