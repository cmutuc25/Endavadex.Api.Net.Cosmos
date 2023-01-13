namespace Endavadex.Api.Models
{
    public class Vertex
    {
        public Guid? Id { get; set; }
        public string? Label { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "CosmosDb has its partition key set as lowercase pk")]
        public string pk { get; set; } = "pk";
    }
}
