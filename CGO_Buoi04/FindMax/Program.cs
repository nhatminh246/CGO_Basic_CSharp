namespace FindMax;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int size;
        do{
            Console.WriteLine("Nhap size cua danh sach:");
            size = Int32.Parse(Console.ReadLine());
            if(size > 20){
                Console.WriteLine("Khong duoc nhap qua 20 ");
            }
        }while (size >20);
        for(int i = 0; i < size; i++){
            Console.WriteLine("Nhap phan tu vi tri "+i+" trong danh sach");
            list.Add(Int32.Parse(Console.ReadLine()));
        }
        int max = list.Max();
        int index = list.IndexOf(max);
        Console.WriteLine("vi tri cua so lon nhat la "+index+" va co gia tri la "+ max);
    }
}
