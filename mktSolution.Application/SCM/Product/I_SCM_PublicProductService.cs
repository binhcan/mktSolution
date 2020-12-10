using mktSolution.Application.SCM.Dtos;
using mktSolution.Application.SCM.Product.Dtos;
using mktSolution.Application.SCM.Product.Dtos.Public;
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
