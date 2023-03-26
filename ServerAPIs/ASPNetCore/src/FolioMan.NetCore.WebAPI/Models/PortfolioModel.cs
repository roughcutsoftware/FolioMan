namespace FolioMan.NetCore.WebAPI.Models
{
    public class PortfolioModel
    {
        public Guid PortfolioGuidKeyId { get;set; } = Guid.NewGuid();
        public CandidateModel Candidate { get; set; }
        public string PortfolioName { get;set;} = string.Empty;
        public string PortfolioDescription { get; set; } = string.Empty;

        //
        public List<WorkHistoryModel> WorkHistory { get; set; }

        public PortfolioModel()
        {
            this.WorkHistory = new List<WorkHistoryModel>();
        }


    }
}
