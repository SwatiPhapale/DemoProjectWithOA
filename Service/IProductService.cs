using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
   public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int Id);
    }
}
