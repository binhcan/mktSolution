using mktSolution.Application.SCM.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Product.Dtos.Public
{
    public class SCM_GetProductPagingRequest : PagingRequestBase
    {
        public int? ProductId { set; get; }
    }
}
