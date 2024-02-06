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
    public class ShoppingCardRepository : Repository<ShoppingCard>, IShoppingCardRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCardRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(ShoppingCard obj)
        {
            _db.ShoppingCards.Update(obj);
        }
    }
}
