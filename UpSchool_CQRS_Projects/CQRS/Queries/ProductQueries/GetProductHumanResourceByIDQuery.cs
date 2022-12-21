namespace UpSchool_CQRS_Projects.CQRS.Queries.ProductQueries
{
    public class GetProductHumanResourceByIDQuery
    {
        public GetProductHumanResourceByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
