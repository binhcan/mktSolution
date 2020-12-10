using mktSolution.Application.SCM.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Product.Dtos.Manage
{
    public class SCM_GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { set; get; }
        public List<int> OrderIds { set; get; }
    }
}
