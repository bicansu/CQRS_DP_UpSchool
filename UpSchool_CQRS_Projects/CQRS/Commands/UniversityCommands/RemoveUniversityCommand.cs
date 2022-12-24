using MediatR;

namespace UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class RemoveUniversityCommand: IRequest
    {
        public RemoveUniversityCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
