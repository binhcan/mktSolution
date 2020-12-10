﻿using mktSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Product.Dtos.Manage
{
    public class SCM_ProductUpdateRequest
    {
        public int IdProduct { set; get; }
        public int IdOrder { set; get; }
        public string ModelName { set; get; }
        public string Jobname { set; get; }
        public int Qty { set; get; }
        public DateTime DateProduct { set; get; }
        public string Type { set; get; }
        public Status Status { set; get; }
        public int UpdateBy { set; get; }
        public DateTime UpdateDate { set; get; }
    }
}
