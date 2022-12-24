using Microsoft.AspNetCore.Mvc;
using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers;
using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueris;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;

namespace UpSchool_CQRS_Projects.Controllers
{
    public class StudentController : Controller
    {
        private readonly CreateStudentCommandHandler _createStudentCommandHandler;
        private readonly GetAllStudentQueryHandler _getAllStudentQueryHandler;
        private readonly RemoveStudentCommandHandler _removeStudentCommandHandler;
        private readonly GetStudentByIDQueryHandler _getStudentByIDQueryHandler;
        private readonly UpdateStudentCommandHandler _updateStudentCommandHandler;

        public StudentController(CreateStudentCommandHandler createStudentCommandHandler, GetAllStudentQueryHandler getAllStudentQueryHandler, RemoveStudentCommandHandler removeStudentCommandHandler, GetStudentByIDQueryHandler getStudentByIDQueryHandler, UpdateStudentCommandHandler updateStudentCommandHandler)
        {
            _createStudentCommandHandler = createStudentCommandHandler;
            _getAllStudentQueryHandler = getAllStudentQueryHandler;
            _removeStudentCommandHandler = removeStudentCommandHandler;
            _getStudentByIDQueryHandler = getStudentByIDQueryHandler;
            _updateStudentCommandHandler = updateStudentCommandHandler;
        }
        public IActionResult Index()
        {
            var values = _getAllStudentQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddStudent(CreateStudentCommands command)
        {
            _createStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteStudent(int id)
        {
            _removeStudentCommandHandler.Handle(new RemoveStudentCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            var values = _getStudentByIDQueryHandler.Handle(new GetStudentByIDQuery(id));
            return View(values);
        }

        public IActionResult UpdateStudent(UpdateStudentCommand command)
        {
            _updateStudentCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
