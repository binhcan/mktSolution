using mktSolution.Application.SCM.Dtos;
using mktSolution.Application.SCM.Product.Dtos;
using mktSolution.Application.SCM.Product.Dtos.Public;
using mktSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Product
{
    public class SCM_PublicProductService: I_SCM_PublicProductService
    {
        private readonly MktDbContext _context;
        public SCM_PublicProductService(MktDbContext context)
        {
            _context = context;
        }
        public SCM_PageResult<SCM_ProductViewModel> GetAllByProductId(SCM_GetProductPagingRequest request)
        {
            //var query = from p in _context.SCM_Products
            //            join od in _context.SCM_Orders on p.OrderId equals od.OrderId
            //            select new { p, od };


            throw new NotImplementedException();
        }
    }
}
