using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers
{
    public class UpdateStudentCommandHandler
    {
        private readonly Context _context;

        public UpdateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateStudentCommand command)
        {
            var values = _context.Students.Find(command.StudentID);
            values.City = command.City;
            values.Name = command.Name;
            values.Surname=command.Surname;
            values.Age= command.Age;
            _context.SaveChanges();

        }
    }
}
