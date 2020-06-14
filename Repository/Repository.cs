using Core;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    //Here why <T> == BaseEntity ?
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> entity;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }

        public IEnumerable<T> GetAllProduct()
        {
            return entity.AsEnumerable();
        }

        public T GetProductById(int Id)
        {
            return entity.FirstOrDefault(x => x.Id == Id);
        }
    }
}
