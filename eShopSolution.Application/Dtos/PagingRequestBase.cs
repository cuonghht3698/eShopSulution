using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Dtos
{
   public class PagingRequestBase
    {
        public string keyword { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }

    }
}
