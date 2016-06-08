using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _ctx;

        public ProductRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Product> All
        {
            get
            {
                return _ctx.Products.ToList();
            }
        }

        public List<Product> AllWithComments
        {
            get
            {
                return _ctx.Products.ToList();
            }
        }

    }
}
