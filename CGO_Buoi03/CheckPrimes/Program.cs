namespace CheckPrimes;
class Program
{   
    static bool check(int n){
        if(n<2) return false;
        else {
            for(int i = 2; i <=Math.Sqrt(n);i++){
                if(n%i == 0) return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(check(number)){
            Console.WriteLine(number + " is a prime");
        }else{
            Console.WriteLine(number + " is not a prime");
        }

    }
}
