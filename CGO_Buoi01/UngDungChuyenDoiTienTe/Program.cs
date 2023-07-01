namespace UngDungChuyenDoiTienTe;
class Program
{
    static void Main(string[] args)
    {
        const int VND_USD = 23000;
        Console.WriteLine("***************************************************");
        Console.WriteLine("Ung dung chuyen doi tien te tu don vi USD ---> VND");
        Console.WriteLine("Hay nhap gia tri USD:");
        float Vnd = VND_USD*float.Parse(Console.ReadLine());
        int ok  = (Vnd>0) ? 1 : 0;
        if(ok==1){
            Console.WriteLine("Gia tri VND sau khi chuyen doi tu don vi USD la: "+ Vnd);
        }
        else{
            Console.WriteLine("Khong the chuyen doi vi gia tri tien te trong thuc te khong the la am");
        }
        Console.WriteLine("***************************************************");

    }
}
