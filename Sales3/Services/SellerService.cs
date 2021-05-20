using Sales3.Data;
using Sales3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales3.Services
{
    public class SellerService
    {
        private readonly Sales3Context _context;

        public SellerService(Sales3Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
