namespace ex2ProductManagement.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public T GetData(); 
        public T UpdateData(int id);
    }
}