using mktSolution.Application.SCM.Dtos;
using mktSolution.Application.SCM.Product.Dtos;
using mktSolution.Application.SCM.Product.Dtos.Manage;
using mktSolution.Data.EF;
using mktSolution.Data.Entities;
using mktSolution.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mktSolution.Application.SCM.Product
{
    public class SCM_ManageProductService : I_SCM_ManageProductService
    {
        private readonly MktDbContext _context;
        public SCM_ManageProductService(MktDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(SCM_ProductCreateRequest request)
        {
            var product = new SCM_Product()
            {
                ModelName = request.ModelName,
                Jobname = request.Jobname,
                Qty = request.Qty,
                DateProduct = request.DateProduct,
                CreateBy = request.CreateBy

            };
            _context.SCM_Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productID)
        {
            var product = await _context.SCM_Products.FindAsync(productID);
            if (product == null) throw new MktException($"Cannot find a product {productID}");
            _context.SCM_Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<List<SCM_ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<SCM_PageResult<SCM_ProductViewModel>> GetAllPaging(SCM_GetProductPagingRequest request)
        {
            ////1. Select join
            //var query = "";
            ////2. filter
            //if (!string.IsNullOrEmpty(request.KeyWord))
            //    query = query.Where(x=>x.)
            throw new NotImplementedException();
        }

        public async Task<int> Update(SCM_ProductUpdateRequest request)
        {
            var product = await _context.SCM_Products.FindAsync(request.IdProduct);
            if (product == null) throw new MktException($"cannot find product with id: {request.IdProduct}");
            product.Jobname = request.Jobname;
            product.ModelName = request.ModelName;
            product.Status = request.Status;
            product.DateProduct = request.DateProduct;
            product.UpdateDate = DateTime.Now;

            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateQty(int productID, int newQty)
        {
            var product = await _context.SCM_Products.FindAsync(productID);
            if (product == null) throw new MktException($"cannot find product with id: {productID}");

            product.Qty = newQty;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
