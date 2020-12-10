using mktSolution.ViewModel.Commons.SCM;
using mktSolution.ViewModel.SCM.Product;
using mktSolution.ViewModel.SCM.Product.Manage;
using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Application.SCM.Product
{
    public interface I_SCM_PublicProductService
    {
        SCM_PageResult<SCM_ProductViewModel> GetAllByProductId(SCM_GetProductPagingRequest request);
    }
}
