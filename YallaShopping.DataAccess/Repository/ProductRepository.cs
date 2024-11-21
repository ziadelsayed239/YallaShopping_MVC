using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YallaShopping.DataAccess.Data;
using YallaShopping.DataAccess.Repository.IRepository;
using YallaShopping.Models;

namespace YallaShopping.DataAccess.Repository
{
    public class ProductRepository: Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
            _db.Products.Include(p => p.Category).Include(p => p.CategoryId);
        }

        public void Update(Product product)
        {
            var existingEntity = _db.Products.Local.FirstOrDefault(p => p.Id == product.Id);
            if (existingEntity != null)
            {
                _db.Entry(existingEntity).State = EntityState.Detached;
            }
            _db.Products.Update(product);
        }

    }
}
