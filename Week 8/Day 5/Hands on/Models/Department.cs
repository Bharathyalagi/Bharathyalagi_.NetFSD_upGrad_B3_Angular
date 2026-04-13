namespace WebApplication8._5.Models;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }

    public List<ContactInfo> Contacts { get; set; }
}