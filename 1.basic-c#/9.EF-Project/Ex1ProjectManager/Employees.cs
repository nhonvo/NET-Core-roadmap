public class Employees
{
    public int EmployeeId { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
}
