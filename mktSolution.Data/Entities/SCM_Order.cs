using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Data.Entities
{
    public class SCM_Order
    {
        public int IdOrder { set; get; }
        public string ModelName { set; get; }
        public int Qty { set; get; }
        public DateTime DueDate { set; get; }
        public string Type { set; get; }

        public Status Status { set; get; }
    }
}
