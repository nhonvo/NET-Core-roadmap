using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;

[MemoryDiagnoser]
public class TrackingVsNoTrackingBenchmark
{
    private readonly AppDbContext _db = new AppDbContext();

    [Benchmark]
    public void Tracking()
    {
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        var result = _db.ProjectEmployees.Include(pe => pe.Projects).Include(pe => pe.Employees).ToList();
        foreach (var projectEmployee in result)
        {
            projectEmployee.Projects.StartDate = DateTime.Now;
            projectEmployee.Projects.EndDate = DateTime.Now.AddDays(30);
        }
        _db.SaveChanges();


    }

    [Benchmark]
    public void NoTracking()
    {
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var result = _db.ProjectEmployees.Include(pe => pe.Projects).Include(pe => pe.Employees).ToList();
        foreach (var projectEmployee in result)
        {
            projectEmployee.Projects.StartDate = DateTime.Now;
            projectEmployee.Projects.EndDate = DateTime.Now.AddDays(30);
        }
        _db.SaveChanges();

    }
   /* [Benchmark]
    public async Task TrackingAsync()
    {
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        var result = await _db.ProjectEmployees.Include(pe => pe.Projects).Include(pe => pe.Employees).ToListAsync();
        foreach (var projectEmployee in result)
        {
            projectEmployee.Projects.StartDate = DateTime.Now;
            projectEmployee.Projects.EndDate = DateTime.Now.AddDays(30);
        }

        await _db.SaveChangesAsync();
    }

    [Benchmark]
    public async Task NoTrackingAsync()
    {
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var result = await _db.ProjectEmployees.Include(pe => pe.Projects).Include(pe => pe.Employees).ToListAsync();
        foreach (var projectEmployee in result)
        {
            projectEmployee.Projects.StartDate = DateTime.Now;
            projectEmployee.Projects.EndDate = DateTime.Now.AddDays(30);
        }

        await _db.SaveChangesAsync();
    }*/

}
