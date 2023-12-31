namespace GISClient.Data.Model
{
    public class TopologyLinkDTO    
    {
        public Guid? Id { get; set; }
        public String? Predicate { get; set; }
        public Status? Status { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public String? CommonBorder { get; set; }
    }
}