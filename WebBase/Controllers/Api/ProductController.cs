using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BLL.DTO;
using BLL.Services;
using Domain;
using Microsoft.AspNet.Identity;

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

       

        // PUT: api/Product/5
        public HttpResponseMessage Put(Product product)
        {
            //var ser = service;
            //  _repo.UdpateService(service);/*
            if (_service.AddOrUpdate(product))
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotModified);
            }
        }


        // DELETE: api/Product/5
        public HttpResponseMessage Delete(int id)
        {
            if (_service.Delete(id))
            {
                return Request.CreateResponse(HttpStatusCode.OK, id);
            }
            return Request.CreateResponse(HttpStatusCode.NotModified);
        }
    }
}
