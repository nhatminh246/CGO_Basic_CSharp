namespace InsertIndex;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>(){3,7,2,8,5,3,8};
        Console.WriteLine("Cac phan tu trong danh sach hien tai la: ");
        foreach (int i in list) Console.Write(i + " ");
        Console.WriteLine();
        Console.WriteLine("Nhap gia tri so nguyen ban muon chen vao danh sach: ");
        int num = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vi tri ban muon chen vao danh sach:");
        int index = Int32.Parse(Console.ReadLine());
        list.Insert(index,num);
        Console.WriteLine(string.Join(",",list));

    }
}
