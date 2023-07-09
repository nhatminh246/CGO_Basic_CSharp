namespace FindMax2;
class Program
{
    static void Main(string[] args)
    {
        int max = -999999;
        int maxi = 0, maxj = 0;
        int[,] arr  = new int[3,3];
        Console.WriteLine("Day la chuong trinh tim so lon nhat trong mang 2 chieu co kick co 3x3, moi ban nhap gia tri cho mang!");
        for(int i = 0; i < 3;i++){
            for(int j = 0;j < 3; j++){
                Console.Write("Moi nhap gia tri cho phan tu co vi tri [{0},{1}]: ",i,j);
                arr[i,j] = Int32.Parse(Console.ReadLine());
                if(arr[i,j]>max){
                    maxi = i;
                    maxj = j;
                    max = arr[i,j];
                }
            }
        }
        Console.WriteLine("Phan tu co gia tri lon nhat la {0} va co vi tri la [{1},{2}] ",max,maxi,maxj);
        Console.WriteLine(arr[-1][-1]);
    }
}
