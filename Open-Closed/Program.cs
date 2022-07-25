namespace OpenClosed;


abstract class Developer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Position { get; set; }
    public double Salary { get; set; }


    public Developer(int id, string? name, string? position, double salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }


    public abstract double CalculateBonus();
}



class Junior : Developer
{
    public Junior(int id, string? name, double salary)
        : base(id, name, nameof(Junior), salary) { }

    public override double CalculateBonus() => Salary * 0.1;
}


class Middle : Developer
{
    public Middle(int id, string? name, double salary)
        : base(id, name, nameof(Middle), salary) { }

    public override double CalculateBonus() => Salary * 0.2;
}


class Senior : Developer
{
    public Senior(int id, string? name, double salary)
        : base(id, name, nameof(Senior), salary) { }

    public override double CalculateBonus() => Salary * 0.3;
}



class Program
{
    static void Main()
    {
        List<Developer> list = new()
        {
            new Junior(1, "Ceyhun", 1000),
            new Junior(2, "Ferman", 1100),
            new Middle(3, "Nihad", 1500),
            new Senior(4, "Elgun", 2000)
        };

        list.ForEach(d => Console.WriteLine(d.CalculateBonus()));
    }
}