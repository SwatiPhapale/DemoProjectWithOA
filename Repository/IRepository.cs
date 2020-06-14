using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAllProduct();

        T GetProductById(int Id);
    }
}
