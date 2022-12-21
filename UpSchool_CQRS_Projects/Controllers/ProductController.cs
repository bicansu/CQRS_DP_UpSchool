using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_Projects.CQRS.Commands.ProductCommands;
using UpSchool_CQRS_Projects.CQRS.Handlers.ProductHandlers;
using UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductAccounterQueryHandler _getProductAccounterQueryHandler;
        private readonly GetProductStoragerQueryHandler _getProductStoragerQueryHandler;
        private readonly GetProductHumanResourceByIDQueryHandler _getProductHumanResourceByIDQueryHandler;
        private readonly GetProductAccounterByIDQueryHandler _getProductAccounterByIDQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;

        public ProductController(GetProductAccounterQueryHandler getProductAccounterQueryHandler, GetProductStoragerQueryHandler getProductStoragerQueryHandler, GetProductHumanResourceByIDQueryHandler getProductHumanResourceByIDQueryHandler, GetProductAccounterByIDQueryHandler getProductAccounterByIDQueryHandler, CreateProductCommandHandler createProductCommandHandler)
        {
            _getProductAccounterQueryHandler = getProductAccounterQueryHandler;
            _getProductStoragerQueryHandler = getProductStoragerQueryHandler;
            _getProductHumanResourceByIDQueryHandler = getProductHumanResourceByIDQueryHandler;
            _getProductAccounterByIDQueryHandler = getProductAccounterByIDQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductAccounterQueryHandler.Handle();
            return View(values);
        }

        public IActionResult AccounterIndexByID(int id)
        {
            var values = _getProductAccounterByIDQueryHandler.Handle(new GetProductAccounterByIDQuery(id));
            return View(values);
        }
        public IActionResult StoragerIndex()
        {
            var values = _getProductStoragerQueryHandler.Handle();
            return View(values);
        }

        public IActionResult GetHumanResourceIndex(int id)
        {
            var values = _getProductHumanResourceByIDQueryHandler.Handle(new GetProductHumanResourceByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
