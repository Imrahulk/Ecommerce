using Basket.Application.Responses;
using Basket.Core.Entities;
using MediatR;

namespace Basket.Application.Commands
{
    public class CreateShoppingCartCommand : IRequest<ShoppingCartResponse>
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public CreateShoppingCartCommand(string userName, List<ShoppingCartItem> item)
        {
            UserName = userName;
            Items = item;

        }
    }
}
