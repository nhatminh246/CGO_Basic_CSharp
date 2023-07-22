namespace InterfaceIcomparable;
class Program
{
    static void Main(string[] args)
    {
      ComperableCircle[] Circle = new ComperableCircle[3];
      Circle[0] = new ComperableCircle(3.6);
      Circle[1] = new ComperableCircle();
      Circle[2] = new ComperableCircle(3.5, "indigo", false);

      Console.WriteLine("Pre-sorted:");
      foreach (ComperableCircle circle in Circle)
      {
        Console.WriteLine(circle);
      }

      Array.Sort(Circle);

      Console.WriteLine("After-sorted:");
      foreach (ComperableCircle circle in Circle)
      {
        Console.WriteLine(circle);
      }
    }
}
