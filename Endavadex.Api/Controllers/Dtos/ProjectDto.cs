namespace Endavadex.Api.Controllers.Dtos
{
    public class ProjectDto
    {
        public string Client { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
