using NovoTeste.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoTeste.Services
{
    public class SellerService
    {
        private readonly NovoTesteContext _context;

        public SellerService(NovoTesteContext context)
        {
            _context = context;
        }
       public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
