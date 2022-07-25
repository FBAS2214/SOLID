using DependencyInversion.Databases;

namespace DependencyInversion;


interface IDataBase
{
    void Add();
    void Read();
    void Change();
    void Delete();
}



class MyMsSql : IDataBase
{
    private MsSql _sql = new();

    public void Add() => _sql.Insert();
    public void Change() => _sql.Update();
    public void Delete() => _sql.Delete();
    public void Read() => _sql.Select();
}


class MyPostgreSql : IDataBase
{
    private PostgreSql _sql = new();

    public void Add() => _sql.Create();
    public void Change() => _sql.Modifer();
    public void Delete() => _sql.Remove();
    public void Read() => _sql.Read();
}



class Application
{
    private readonly IDataBase _db;

    public Application(IDataBase dataBase)
    {
        _db = dataBase;
    }

    public void DoSomething()
    {
        _db.Add();
        _db.Read();
        _db.Change();
        _db.Delete();
    }
}



class Program
{
    static void Main()
    {
        Application app = new(new MyPostgreSql());
        app.DoSomething();
    }
}