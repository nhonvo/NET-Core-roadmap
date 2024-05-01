namespace DemoConcurrency
{
    interface IRepository
    {
        public string GetData(int id);
        public void UpdateData(int id);
    }

    class Repository : IRepository
    {
        private readonly AppDbContext _db = new AppDbContext();
        public string GetData(int id)
        {
            var customers = _db.Customers.FirstOrDefault();
            return $"{customers.Name} this is our data";
        }

        public void UpdateData(int id)
        {
            var customers = _db.Customers.FirstOrDefault();
            System.Console.WriteLine($"{customers.Name}  is saved");

        }
    }

    class BusineesLogic
    {
        public void DoSomeThing()
        {
            IRepository _repository = new Repository();
            // do some thing
            var data1 = _repository.GetData(1);
            var data2 = _repository.GetData(2);

            System.Console.WriteLine(data1);
            System.Console.WriteLine(data2);

            // caludated
            var sum = data1 + data2;
            _repository.UpdateData(1);
        }
    }

}