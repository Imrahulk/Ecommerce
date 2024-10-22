using Discount.Core.Entities;
using Discount.Core.Repositories;

namespace Discount.Infrastructure.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        public DiscountRepository()
        {
            
        }
        public Task<bool> CreateDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<Coupon> GetDiscount(string productName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDiscount(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
