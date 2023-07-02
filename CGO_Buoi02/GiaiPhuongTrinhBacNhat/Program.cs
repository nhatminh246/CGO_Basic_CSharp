namespace GiaiPhuongTrinhBacNhat;
class Program
{
    static void Main(string[] args)
    {
        double a, b, ans;
        Console.WriteLine("Linear Equation Resolver");
        Console.WriteLine("Given a equation as 'ax + b = 0', please enter constants:");
        Console.Write("Enter the value a: " );
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the value b: " );
        b = Convert.ToDouble(Console.ReadLine());
        if(a==0){
            if (b == 0)
            {
                Console.Write("The solution is all x!");
            }
            else
            {
                Console.Write("No solution!");
            }
        }else {
            ans = -b/a;
            ans = (ans==-0)? 0: ans;
            Console.Write("The solution is:  {0}!", ans);
        }
    }
}
