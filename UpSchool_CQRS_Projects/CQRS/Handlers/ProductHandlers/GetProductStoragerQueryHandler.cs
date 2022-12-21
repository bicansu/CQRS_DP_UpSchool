using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductStoragerQueryHandler
    {
        private readonly Context _productContext;

        public GetProductStoragerQueryHandler(Context productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductStorageQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new GetProductStorageQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage = x.Storage,
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
