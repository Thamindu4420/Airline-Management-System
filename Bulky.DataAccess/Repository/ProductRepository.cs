using RaythosAerospace.DataAccess.Repository.IRepository;
using RaythosAerospace.DataAcess.Data;
using RaythosAerospace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RaythosAerospace.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Price = obj.Price;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.BalanceQty = obj.BalanceQty;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }

        void IProductRepository.UpdateProductQtyBalance(int Id, int balanceQty)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == Id);
            if (objFromDb != null)
            {
                objFromDb.BalanceQty = balanceQty;
            }
        }
    }
}
