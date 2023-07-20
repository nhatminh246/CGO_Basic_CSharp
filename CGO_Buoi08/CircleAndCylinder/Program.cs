namespace CircleAndCylinder;
class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle();
        Console.WriteLine(c.ToString());
        c = new Circle(3,"gray");
        Console.WriteLine(c.ToString());


        Cylinder cyn = new Cylinder();
        Console.WriteLine(cyn.ToString());
        cyn = new Cylinder(3);
        Console.WriteLine(cyn.ToString());
        cyn = new Cylinder(2, 5,"blue");
        Console.WriteLine(cyn.ToString());
    }
}
