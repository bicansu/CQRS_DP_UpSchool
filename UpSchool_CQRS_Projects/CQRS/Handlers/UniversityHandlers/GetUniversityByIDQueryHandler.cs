using MediatR;
using System.Threading;
using System.Threading.Tasks;
using UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueris;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler:IRequestHandler<GetUniversityByIDQuery,GetUniversityByIDQueryResult>
    {
        private readonly Context _contex;

        public GetUniversityByIDQueryHandler(Context contex)
        {
            _contex = contex;
        }

        public async Task<GetUniversityByIDQueryResult> Handle(GetUniversityByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _contex.Universities.FindAsync(request.id);
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,
                City=values.City,
                Name = values.Name,
                Population = values.Population

            };
         

        }
    }
}
