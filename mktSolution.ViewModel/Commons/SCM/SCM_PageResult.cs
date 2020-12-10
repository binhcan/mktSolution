using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.ViewModel.Commons.SCM
{
    public class SCM_PageResult<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
