using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Commands.UniversityCommands;
using UpSchool_CQRS_Projects.DAL.Context;
using UpSchool_CQRS_Projects.Migrations;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandlers
{
    public class RemoveUniversityCommandHandler : IRequestHandler<RemoveUniversityCommand>
    {
        private readonly Context _context;

        public RemoveUniversityCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveUniversityCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Universities.Find(request.id);
            _context.Universities.Remove(values);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
    }

