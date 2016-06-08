using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;

namespace WebBase.Controllers.Api
{
    public class ProductController : ApiController
    {
        private ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }

        // GET: api/Product
        public List<ProductDTO> GetProducts()
        {
            var allProducts = _service.getAllProducts();
            return allProducts;
        }

        // GET: api/Product/5
        public List<ProductDTO> GetProduct(string id)
        {
            List<ProductDTO> product = null;
            int idint;
            bool isNumeric = int.TryParse(id, out idint);
            if (isNumeric)
            {
                product = _service.Find(idint);
            }
            else
            {
                product = _service.FindByName(id);
            }




            return product;

        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
