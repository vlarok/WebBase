using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;
using Domain;

namespace WebBase.server.Controllers.Api
{
    public class CommentController : ApiController
    {
        private CommentService _service;

        public CommentController(CommentService service)
        {
            _service = service;
        }



        // PUT: api/Product/5
        public HttpResponseMessage Put(Comment product)
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


       
    }
}
