using mktSolution.Application.SCM.Dtos;
using mktSolution.Application.SCM.Product.Dtos;
using mktSolution.Application.SCM.Product.Dtos.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mktSolution.Application.SCM.Product
{
    public interface I_SCM_ManageProductService
    {
        Task<int> Create(SCM_ProductCreateRequest request);
        Task<int> Update(SCM_ProductUpdateRequest request);
        Task<bool> UpdateQty(int productID, int newQty);
        Task<int> Delete(int productID);
        Task<List<SCM_ProductViewModel>> GetAll();
        Task<SCM_PageResult<SCM_ProductViewModel>> GetAllPaging(SCM_GetProductPagingRequest request);

    }
}
