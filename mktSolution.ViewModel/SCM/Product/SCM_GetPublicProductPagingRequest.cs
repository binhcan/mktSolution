using mktSolution.ViewModel.Commons.SCM;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.ViewModel.SCM.Product
{
    public class SCM_GetPublicProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { set; get; }
        public List<int> OrderIds { set; get; }
    }
}
