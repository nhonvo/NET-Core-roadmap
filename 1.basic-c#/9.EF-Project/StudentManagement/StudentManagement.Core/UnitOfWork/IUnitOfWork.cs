using Microsoft.EntityFrameworkCore.Storage;
using StudentManagement.API.Data;

namespace StudentManagement.API.UnitOfWork
{
    public interface IUnitOfWork
    {
        ApplicationDbContext DbContext { get; set; }
        int Commit();
        Task<int> CommitAsync();
        IDbContextTransaction BeginTransaction();

    }
}