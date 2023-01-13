namespace Endavadex.Api.Controllers.Dtos
{
    public class AssignmentDto
    {
        public string Role { get; set; }
        public string Duties { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
