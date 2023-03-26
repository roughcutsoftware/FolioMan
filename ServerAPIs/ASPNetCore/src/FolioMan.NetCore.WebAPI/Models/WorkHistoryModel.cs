namespace FolioMan.NetCore.WebAPI.Models
{
    public class WorkHistoryModel
    {
        public Guid WorkHistoryGuidKeyId { get; set; } = Guid.NewGuid();
        public string JobTitle { get; set; }
        public EmployerModel Employer { get; set; }
        public WorkToFromModel WorkToFromRange { get; set; }
        public List<WorkHighlightModel> WorkHighlights { get; set; }

        public WorkHistoryModel()
        {
            this.WorkHighlights = new List<WorkHighlightModel>();
        }
    }
}
