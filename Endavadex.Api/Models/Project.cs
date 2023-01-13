namespace Endavadex.Api.Models
{
    public class Project : Vertex
    {
        public string Client { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
