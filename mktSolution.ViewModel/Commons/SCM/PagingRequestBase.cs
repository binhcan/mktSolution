using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.ViewModel.Commons.SCM
{
    public class PagingRequestBase
    {
        public int PageIndex { set; get; }
        public int PageSize { set; get; }
    }
}
