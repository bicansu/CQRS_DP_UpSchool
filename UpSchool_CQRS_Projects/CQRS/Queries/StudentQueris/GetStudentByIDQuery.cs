namespace UpSchool_CQRS_Projects.CQRS.Queries.StudentQueris
{
    public class GetStudentByIDQuery
    {
        public GetStudentByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
