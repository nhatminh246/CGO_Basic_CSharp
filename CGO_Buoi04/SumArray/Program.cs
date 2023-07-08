namespace SumArray;
class Program
{
    static void Main(string[] args)
    {
        int []numbers = new int[5];
        int total = 0;
        numbers[0] = 2;
        numbers[1] = 5;
        numbers[2] = 9;
        numbers[3] = 6;
        numbers[4] = 7;
        foreach (int i in numbers){
            total += i;
        }
        Console.WriteLine(total.ToString());
    }
}
