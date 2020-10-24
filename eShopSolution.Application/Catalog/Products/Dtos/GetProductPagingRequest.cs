using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
   public class GetProductPagingRequest:PagingRequestBase
    {
        public string  keyWord { get; set; }

        public List<int> CategoryId { get; set; }
    }
}
