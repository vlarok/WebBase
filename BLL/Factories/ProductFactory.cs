using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class ProductFactory
    {
        public DTO.ProductDTO createBasicDTO(Product product)
        {


            return new DTO.ProductDTO()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Comments = product.Comments.Select(s => new CommentDTO() { CommentId = s.CommentId, CommentText = s.CommentText }).ToList()
            };


        }
    }
}
