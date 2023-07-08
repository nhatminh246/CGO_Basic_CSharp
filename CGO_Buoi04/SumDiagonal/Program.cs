namespace SumDiagonal;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap kich co mang n x x: ");
        int n = Int32.Parse(Console.ReadLine());
        int[,] arr = new int[n,n];
        for(int i = 0; i < n;i++){
            for(int j = 0;j < n; j++){
                Console.Write("Moi nhap gia tri cho phan tu co vi tri [{0},{1}]: ",i,j);
                arr[i,j] = Int32.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Mang cua ban co cac phan tu nhu sau:");
        for(int i = 0; i < n;i++){
            for(int j = 0;j < n; j++){
                Console.Write("{0} ",arr[i,j]);
            }
            Console.WriteLine();
        }
        int sum = 0;
        for(int i = 0; i < n; i++){
            sum+= arr[i,i] + arr[i, n-i-1];
        }
        if(n%2 == 1){
            sum-=arr[n/2,n/2];
        }
        Console.WriteLine("Tong cac duong cheo cua mang la {0}", sum);
    }
}
