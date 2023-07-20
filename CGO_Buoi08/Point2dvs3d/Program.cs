namespace Point2dvs3d;
class Program
{
    static void Main(string[] args)
    {
        Point2d d = new Point2d();
        Console.WriteLine(d.ToString());
        d = new Point2d(3, 5);
        float[] XY = d.GetXY();
        Console.WriteLine(XY[0]);
        Console.WriteLine(XY[1]);
        Console.WriteLine(d.ToString());
        Point3d d3= new Point3d();
        Console.WriteLine(d3.ToString());
        d3 = new Point3d(3, 5, 4);
        Console.WriteLine(d3.ToString());

    }
}
