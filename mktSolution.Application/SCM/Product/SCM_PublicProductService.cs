using Microsoft.EntityFrameworkCore;
using mktSolution.Data.EF;
using mktSolution.Data.Entities;
using mktSolution.ViewModel.Commons.SCM;
using mktSolution.ViewModel.SCM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mktSolution.Application.SCM.Product
{
    public class SCM_PublicProductService: I_SCM_PublicProductService
    {
        private readonly MktDbContext _context;
        public SCM_PublicProductService(MktDbContext context)
        {
            _context = context;
        }

        public async Task<List<SCM_ProductViewModel>> GetAll()
        {
            var query = from p in _context.SCM_Products
                        select p;
            var data = await query.Select(x => new SCM_ProductViewModel()
            {
                Jobname = x.Jobname,
                ModelName = x.ModelName,
                Qty = x.Qty,
                DateProduct = x.DateProduct
            }).ToListAsync();

            return data;
        }

        public Task<SCM_PageResult<SCM_ProductViewModel>> GetAllByProductId(SCM_GetPublicProductPagingRequest request)
        {
           
            throw new NotImplementedException();
        }
    }
}
