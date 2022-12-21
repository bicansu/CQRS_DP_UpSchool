using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.DAL.Entities;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _productContext;

        public CreateProductCommandHandler(Context productContext)
        {
            _productContext = productContext;
        }

        public void Handle (CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceofDate = command.ProduceofDate,
                EndofDate = command.EndofDate,
                Status = command.Status

            });

            _productContext.SaveChanges();
        }
    }
}
