using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Entities
{
    public class SCM_Product
    {
       public int IdProduct { set; get; }
        public int IdOrder { set; get; }
        public string ModelName { set; get; }
        public string Jobname { set; get; }
        public int Qty { set; get; }
        public DateTime DateProduct { set; get; }
        public string Type { set; get; }
        public Status Status { set; get; }
        public int CreateBy { set; get; }
        public DateTime CreateDate { set; get; }
        public int UpdateBy { set; get; }
        public DateTime UpdateDate { set; get; }
        public SCM_Order SCM_Order { set; get; }
    }
}
