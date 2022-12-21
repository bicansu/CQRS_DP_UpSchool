using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;
using UpSchool_CQRS_Projects.CQRS.Results.ProductResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductHumanResourceByIDQueryHandler
    {
        private readonly Context _productContext;

        public GetProductHumanResourceByIDQueryHandler(Context productContext)
        {
            _productContext = productContext;
        }

        public GetProductHumanResourceByIDQueryResult Handle(GetProductHumanResourceByIDQuery query)
        {
            var values = _productContext.Products.Find(query.id);
            return new GetProductHumanResourceByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice

            };
        }
        
    }
}
