using mktSolution.Data.Entities;
using mktSolution.ViewModel.Commons.SCM;
using mktSolution.ViewModel.SCM.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mktSolution.Application.SCM.Product
{
    public interface I_SCM_PublicProductService
    {
        Task<SCM_PageResult<SCM_ProductViewModel>> GetAllByProductId(SCM_GetPublicProductPagingRequest request);
        Task<List<SCM_ProductViewModel>> GetAll();
    }
}
