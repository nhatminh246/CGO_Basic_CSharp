namespace StopWatch;
class Program
{
    static public Random rand = new Random();
    static void Sort(int[] arr){
        for(int i=0; i <arr.Length-1; i++){
            for(int j = 1; j < arr.Length; j++){
                if(arr[i] >= arr[j]){
                    Swap(arr[i], arr[j]);
                }
            }
        }
    }
    static void Swap(int a, int b){
        int tmp = a;
        a = b;
        b = tmp;
    }
    static void Input(int[] arr){
        for(int i=0; i<arr.Length ; i++){
            arr[i] = rand.Next(0,10000);
        }
    }
    static void Main(string[] args)
    {
        // Program p = new Program();
        int[] a = new int[10000];
        // p.Input(a);
        Input(a);
        Watch stopWatch = new Watch();
        stopWatch.Start();
        Sort(a);
        stopWatch.End();
        Console.WriteLine("Chay chuong trinh mat: " + stopWatch.GetElapsedTime());
        //Chay chuong trinh sap xep 100.000 phan tu lau lam nen e lam 10.000 phan tu thoi nhe :))



    }
}
