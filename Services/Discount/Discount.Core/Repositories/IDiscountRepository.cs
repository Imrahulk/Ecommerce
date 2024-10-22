using Discount.Core.Entities;

namespace Discount.Core.Repositories
{
    public interface IDiscountRepository
    {
        Task<Coupon> GetDiscount(string productName);
        Task<bool> CreateDiscount(string productName);
        Task<bool> UpdateDiscount(string productName);
        Task<bool> DeleteDiscount(string productName);
    }
}
