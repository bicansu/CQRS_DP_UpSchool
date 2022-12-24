using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandlers
{
    public class CreateUniversityCommandHandler:IRequestHandler<CreateUniversityCommand>
    {
        private readonly Context _context;

        public CreateUniversityCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateUniversityCommand request, CancellationToken cancellationToken)
        {
            _context.Universities.Add(new DAL.Entities.University
            {
                City = request.City,
                Name = request.Name,
                Population = request.Population,
                FacultyCount = request.FacultyCount
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }

}
