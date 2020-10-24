using eShopSolution.Application.Dtos;

namespace eShopSolution.Application.Catalog.Products
{
    public class GetPublicProductPagingRequest:PagingRequestBase
    {
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}