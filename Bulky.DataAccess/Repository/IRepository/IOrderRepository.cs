using RaythosAerospace.Models;
using RaythosAerospace.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaythosAerospace.DataAccess.Repository.IRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        void Update(Order obj);

        
        void UpdateStripePaymentID(int id, string sessionId, String paymentId);

        void UpdateStatus(int id, string orderStatus, String? paymentStatus = SD.PaymentStatusApproved);
    }
}
