using Core;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProduct()
        {
          return  _repository.GetAllProduct();
        }

        public Product GetProductById(int Id)
        {
            return _repository.GetProductById(Id);
        }
    }
}
