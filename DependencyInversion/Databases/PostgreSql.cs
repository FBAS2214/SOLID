namespace DependencyInversion.Databases;

class PostgreSql
{
    public void Read() => Console.WriteLine("Read with PostgreSql");
    public void Modifer() => Console.WriteLine("Modifer with PostgreSql");
    public void Remove() => Console.WriteLine("Remove with PostgreSql");
    public void Create() => Console.WriteLine("Create with PostgreSql");
}
