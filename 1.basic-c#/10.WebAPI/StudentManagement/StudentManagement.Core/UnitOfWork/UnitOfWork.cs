using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StudentManagement.API.Data;

namespace StudentManagement.API.UnitOfWork
{
    public class UnitOfWorka : IUnitOfWork
    {
        public ApplicationDbContext DbContext { get; set; }
        public UnitOfWorka(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            DbContext = dbContextFactory.CreateDbContext();
        }

        public int Commit()
        {
            return DbContext.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return DbContext.Database.BeginTransaction();
        }
    }
}