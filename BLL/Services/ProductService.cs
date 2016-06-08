﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;

namespace BLL.Services
{
    public class ProductService
    {
        private IProductRepository _repo;
        private Factories.ProductFactory _factory;
        public ProductService()
        {
            this._repo = new ProductRepository(new ApplicationDbContext());
            this._factory = new Factories.ProductFactory();
        }
        public List<ProductDTO> getAllProducts()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }
        public List<ProductDTO> Find(int id)
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).Where(x => x.ProductId.Equals(id)).ToList();

        }

        public List<ProductDTO> FindByName(string name)
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).Where(x => x.Name.Equals(name)).ToList();

        }
    }
}