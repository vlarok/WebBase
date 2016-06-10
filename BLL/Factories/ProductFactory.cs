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
                Title = product.Title,
                Intro = product.Intro,
                Body = product.Body,
                Created = product.Created,
                Hidden = product.Hidden,
                Comments = product.Comments.Select(s => new CommentDTO() { CommentId = s.CommentId,Title=s.Title, Body = s.Body, Author = s.Author, Created = s.Created}).ToList()
            };


        }
    }
}
