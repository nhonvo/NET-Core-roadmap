namespace _1.Scrutor.Services;
public interface IService { }
public class Service1 : IService { }
public class Service2 : IService { }
public class Service : IService { }

public interface IFoo { }
public interface IBar { }
public class Foo : IFoo, IBar { }
