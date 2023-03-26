namespace FolioMan.NetCore.WebAPI.Models;

public class EmployerModel
{
    public Guid EmployerGuidKeyId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public EmployerModel() { }
}