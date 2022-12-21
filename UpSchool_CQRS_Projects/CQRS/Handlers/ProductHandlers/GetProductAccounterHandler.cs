using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccounterQueryHandler
    {
        private readonly Context _productContext;

        public GetProductAccounterQueryHandler(Context productContext)
        {
            _productContext = productContext;
        }

        public List<GetProductAccounterQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductAccounterQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Stock = x.Stock,
                Brand = x.Brand,
                SalePrice = x.SalePrice,
                PurchasePrice = x.PurchasePrice
            }).AsNoTracking().ToList();

            return values;
        }

    }
}
