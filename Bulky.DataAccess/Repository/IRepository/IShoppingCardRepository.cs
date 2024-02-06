using RaythosAerospace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaythosAerospace.DataAccess.Repository.IRepository
{
    public interface IShoppingCardRepository : IRepository<ShoppingCard>
    {
        void Update(ShoppingCard obj);
    }
}
