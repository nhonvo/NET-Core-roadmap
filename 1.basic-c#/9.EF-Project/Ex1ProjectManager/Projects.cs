public class Projects
{
    public int ProjectId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }
}
