using MediatR;
using System.Collections.Generic;
using UpSchool_CQRS_Projects.CQRS.Results.UniversityResults;

namespace UpSchool_CQRS_Projects.CQRS.Queries.UniversityQueris
{
    public class GetAllUniversityQuery:IRequest<List<GetAllUniversityQueryResult>>
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
        public string FacultyCount { get; set; }
    }
}
