namespace Endavadex.Api.Models
{
    public class Vertex
    {
        public object? Id { get; set; }
        public string? Label { get; set; }
        public string PartitionKey { get; set; } = "pk";
    }
}
