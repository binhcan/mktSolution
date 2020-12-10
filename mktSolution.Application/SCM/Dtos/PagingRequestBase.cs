using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Dtos
{
    public class PagingRequestBase
    {
        public int PageIndex { set; get; }
        public int PageSize { set; get; }
    }
}
