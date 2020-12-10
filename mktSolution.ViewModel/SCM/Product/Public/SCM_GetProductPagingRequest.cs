using mktSolution.ViewModel.Commons.SCM;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.ViewModel.SCM.Product.Public
{
    public class SCM_GetProductPagingRequest : PagingRequestBase
    {
        public int? ProductId { set; get; }
    }
}
