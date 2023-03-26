namespace FolioMan.NetCore.WebAPI.Models;

public class CandidateModel
{
    public Guid CandidateGuidKeyId { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string? Email { get; set; } = string.Empty;
    public string City { get; set; }
    public string State { get; set; }
    public CandidateModel() { }
}