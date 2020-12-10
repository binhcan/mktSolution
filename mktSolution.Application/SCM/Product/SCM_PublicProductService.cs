using mktSolution.Data.EF;
using mktSolution.ViewModel.Commons.SCM;
using mktSolution.ViewModel.SCM.Product;
using mktSolution.ViewModel.SCM.Product.Manage;
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
            throw new NotImplementedException();
        }
    }
}
