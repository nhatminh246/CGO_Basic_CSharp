namespace Rectangle;
class Program
{
    static void Main(string[] args)
    {
        RectangleProperty HCN = new RectangleProperty(3,5);
        Console.WriteLine(HCN.GetArea());
        Console.WriteLine(HCN.GetPerimeter());
        HCN.Display();
    }
}
