namespace DependencyInversion.Databases;


class MsSql
{
    public void Select() => Console.WriteLine("Select with MsSql");
    public void Update() => Console.WriteLine("Update with MsSql");
    public void Delete() => Console.WriteLine("Delete with MsSql");
    public void Insert() => Console.WriteLine("Insert with MsSql");
}