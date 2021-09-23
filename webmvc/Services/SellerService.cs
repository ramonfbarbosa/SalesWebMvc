using webmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc.Services
{
    public class SellerService
    {
        private readonly webmvcContext _context;

        public SellerService(webmvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
