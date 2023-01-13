namespace Endavadex.Api.Models
{
    public class Assignment : Edge
    {
        public string Role { get; set; }
        public string Duties { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
