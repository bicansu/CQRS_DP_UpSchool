using UpSchool_CQRS_Projects.CQRS.Queries.StudentQueris;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler
    {
        private readonly Context _context;

        public GetStudentByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetStudentByIDQueryResult Handle(GetStudentByIDQuery query)
        {
            var values = _context.Students.Find(query.id);
            return new GetStudentByIDQueryResult
            {
                Age = values.Age,
                City = values.City,
                Name = values.Name,
                Surname = values.Surname,
                StudentID = values.StudentID,
            };
        }
    }
}
