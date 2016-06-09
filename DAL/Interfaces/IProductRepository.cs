using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> All { get; }
      //  void Add(Product product);
        bool Delete(int product);
        bool AddOrUpdate(Product product);
    }
}
