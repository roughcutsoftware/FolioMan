namespace FolioMan.NetCore.WebAPI.Models
{
    public class WorkToFromModel
    {
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public bool IsCurrent { get; set; } = false;
        public WorkToFromModel() { }
    }
}
