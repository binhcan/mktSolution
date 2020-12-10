using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.ViewModel.SCM.Product.Manage
{
    public class SCM_ProductCreateRequest
    {
        public int IdOrder { set; get; }
        public string ModelName { set; get; }
        public string Jobname { set; get; }
        public int Qty { set; get; }
        public DateTime DateProduct { set; get; }
        public int CreateBy { set; get; }
    }
}
