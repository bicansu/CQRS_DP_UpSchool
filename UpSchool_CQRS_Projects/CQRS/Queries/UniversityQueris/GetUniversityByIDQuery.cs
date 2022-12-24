using MediatR;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueris
{
    public class GetUniversityByIDQuery:IRequest<GetUniversityByIDQueryResult>
    {
        public GetUniversityByIDQuery()
        {
            this.id = id;
        }

        public GetUniversityByIDQuery(int id)
        {
            this.id = id;
        }

        public int id {get;set;}
    }
}
