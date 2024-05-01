namespace ex2ProductManagement.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Base
    {
        private readonly AppDbContext _dbContext;
        public T GetData()
        {

            var obj = _dbContext.Set<T>().FirstOrDefault();
            return obj;
        }

        public T UpdateData(int id)
        {
            var obj = _dbContext.Set<T>().FirstOrDefault(x=>x.Id == id);
            return obj;
        }
    }
}