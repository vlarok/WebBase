using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        /*
        public void Add(Product product)
        {
            _ctx.Products.Add(product);
            _ctx.SaveChanges();
        }
        */
        public bool Delete(int id)
        {
            try
            {
                Product product = (from s in All
                                   where s.ProductId == id
                                   select s).FirstOrDefault();
                _ctx.Products.Remove(product);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AddOrUpdate(Product product)
        {
            try
            {

                _ctx.Products.AddOrUpdate(product);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                return false;
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
