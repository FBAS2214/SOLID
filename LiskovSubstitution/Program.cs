namespace LiskovSubstitution;


class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

}

class Square : Rectangle
{
    public Square(double side)
        : base(side, side) { }


    public override double Width
    {
        get => base.Width;
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }


    public override double Height
    {
        get => base.Height;
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}



class Calculate
{
    public static double Area(Rectangle r) => r.Width * r.Height;
}


class Program
{
    static void Main()
    {
        Rectangle r = new(10, 5);
        // r.Height = 7;


        Square s = new(10);
        s.Height = 15;

        // Console.WriteLine(Calculate.Area(r));
        // Console.WriteLine(Calculate.Area(s));
    }
}