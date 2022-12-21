using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UpSchool_CQRS_Projects.CQRS.Results.StudentResults;
using UpSchool_CQRS_Projects.DAL.Context;

namespace UpSchool_CQRS_Projects.CQRS.Handlers.StudentHandlers
{
    public class GetAllStudentQueryHandler
    {
        private readonly Context _context;

        public GetAllStudentQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllStudentQueryResult> Handle()
        {
            var values = _context.Students.Select(x => new GetAllStudentQueryResult
            {
                City = x.City,
                Department = x.Department,
                Name = x.Name,
                StudentID = x.StudentID,
                Surname = x.Surname
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
