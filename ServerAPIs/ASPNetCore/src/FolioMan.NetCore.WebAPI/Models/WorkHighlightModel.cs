namespace FolioMan.NetCore.WebAPI.Models
{
    public class WorkHighlightModel
    {
        public Guid WorkHighlightGuidKeyId { get; set; } = Guid.NewGuid();
        public string Highlight { get; set; }
        public WorkHighlightModel() { }
    }
}
