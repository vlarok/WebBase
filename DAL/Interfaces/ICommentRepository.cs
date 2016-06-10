using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface ICommentRepository
    {
        List<Comment> All { get; }
      //  void Add(Product product);
        bool Delete(int product);
        bool AddOrUpdate(Comment product);
    }
}
