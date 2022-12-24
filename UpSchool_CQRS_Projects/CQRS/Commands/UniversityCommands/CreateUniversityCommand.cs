using MediatR;

namespace UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands
{
    public class CreateUniversityCommand:IRequest
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
    }
}
