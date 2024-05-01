/*using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

*//*var project = new List<Projects>{
    new Projects{StartDate = new  DateTime(2023, 2,4), EndDate = new DateTime(2026, 2,4)},
    new Projects{StartDate = new DateTime(2023, 2,4), EndDate = new DateTime(2026, 2, 4)},
    new Projects{StartDate = new DateTime(2023, 2, 4), EndDate = new DateTime(2026, 2, 4)}
};
var employee = new List<Employees>
{
    new Employees{Email = "a@gmail.com", PhoneNumber = "012345"},
    new Employees{Email = "a@gmail.com", PhoneNumber = "012345"},
    new Employees{Email = "a@gmail.com", PhoneNumber = "012345"}
};*//*
var pe = new List<ProjectEmployee>
{
    new ProjectEmployee{EmployeeId = 6, ProjectId = 4},
    new ProjectEmployee{EmployeeId = 5, ProjectId = 4},
    new ProjectEmployee{EmployeeId = 5, ProjectId = 5},
    new ProjectEmployee{EmployeeId = 4, ProjectId = 6}

};
*//*await context.AddRangeAsync(project);
await context.AddRangeAsync(employee);*//*
await context.AddRangeAsync(pe);
//await context.SaveChangesAsync();

var result1 = context.ProjectEmployees
    .Join(context.Projects, pe => pe.ProjectId, p => p.ProjectId, (pe, p) => new { pe, p })
    .Join(context.Employees, pe_p => pe_p.pe.EmployeeId, e => e.EmployeeId, (pe_p, e) => new
    {
        ProjectId = pe_p.p.ProjectId,
        StartDate = pe_p.p.StartDate,
        EndDate = pe_p.p.EndDate,
        EmployeeId = e.EmployeeId,
        Email = e.Email,
        PhoneNumber = e.PhoneNumber
    });

foreach (var item in result1)
{
    Console.WriteLine(item.ProjectId + "    " + item.PhoneNumber);
}
var result = context.ProjectEmployees
    .Include(pe => pe.Projects)
    .Include(pe => pe.Employees)
    .Select(pe => new
    {
        ProjectId = pe.Projects.ProjectId,
        StartDate = pe.Projects.StartDate,
        EndDate = pe.Projects.EndDate,
        EmployeeId = pe.Employees.EmployeeId,
        Email = pe.Employees.Email,
        PhoneNumber = pe.Employees.PhoneNumber
    });
foreach (var item in result)
{
    Console.WriteLine(item.PhoneNumber);
}
*/
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;

// var summary = BenchmarkRunner.Run<TrackingVsNoTrackingBenchmark>();
var _db = new AppDbContext();

void HandleProjectEmployee(ProjectEmployee projectEmployee, EntityState state)
{
    switch (state)
    {
        case EntityState.Added:
            // Entity is added to the context
            Console.WriteLine("ProjectEmployee is added to the context.");
            break;
        case EntityState.Modified:
            // Entity is modified
            Console.WriteLine("ProjectEmployee is modified.");
            break;
        case EntityState.Deleted:
            // Entity is deleted
            Console.WriteLine("ProjectEmployee is deleted.");
            break;
        case EntityState.Unchanged:
            // Entity is unchanged
            Console.WriteLine("ProjectEmployee is unchanged.");
            break;
        case EntityState.Detached:
            // Entity is detached from the context
            Console.WriteLine("ProjectEmployee is detached from the context.");
            break;
        default:
            throw new ArgumentOutOfRangeException(nameof(state), state, null);
    }
}
// Creating a new ProjectEmployee entity
var projectEmployee = new ProjectEmployee { EmployeeId = 1, ProjectId = 1 };
_db.ProjectEmployees.Add(projectEmployee);
HandleProjectEmployee(projectEmployee, _db.Entry(projectEmployee).State);

// Modifying an existing ProjectEmployee entity
projectEmployee = _db.ProjectEmployees.Find(1);
projectEmployee.Employees.Email = "newemail@example.com";
_db.SaveChanges();
HandleProjectEmployee(projectEmployee, _db.Entry(projectEmployee).State);

// Deleting an existing ProjectEmployee entity
projectEmployee = _db.ProjectEmployees.Find(1);
_db.ProjectEmployees.Remove(projectEmployee);
_db.SaveChanges();
HandleProjectEmployee(projectEmployee, _db.Entry(projectEmployee).State);
