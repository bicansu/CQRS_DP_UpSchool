using UpSchool_CQRS_Projects.CQRS.Commands.StudentCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers
{
    public class RemoveStudentCommandHandler
    {
        private readonly Context _contex;

        public RemoveStudentCommandHandler(Context contex)
        {
            _contex = contex;
        }

        public void Handle(RemoveStudentCommand command)
        {
            var values = _contex.Students.Find(command.id);
            _contex.Students.Remove(values);
            _contex.SaveChanges();
        }
    }
}
