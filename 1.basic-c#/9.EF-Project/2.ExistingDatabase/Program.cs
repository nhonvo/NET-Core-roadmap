// dotnet ef dbcontext scaffold "Server=CVPNHONVTT\\SQLEXPRESS01;Database=studentManagement;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o Models

using _2.ExistingDatabase.Models;

StudentManagementContext _db = new StudentManagementContext();
var list = _db.Students.ToList();
foreach (var item in list)
{
    System.Console.WriteLine(item.Name);
}