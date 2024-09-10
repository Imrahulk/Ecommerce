using Catalog.Application.Responses;
using MediatR;
using System.Reflection.Metadata;

namespace Catalog.Application.Queries
{
    public class GetProductByBrandQuery : IRequest<IList<ProductResponse>>
    {
        public string BrandName { get; set; }
        public GetProductByBrandQuery(string brandName)
        {
            BrandName = brandName;
        }
    }
}
