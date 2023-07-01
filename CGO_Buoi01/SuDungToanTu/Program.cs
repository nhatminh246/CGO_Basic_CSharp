namespace SuDungToanTu;
class Program
{
    static void Main(string[] args)
    {   
        float ChieuRong, ChieuDai;
        bool notok = true;
        while(notok){
        Console.WriteLine("Chieu rong cua hinh chu nhat la: ");
        ChieuRong = float.Parse(Console.ReadLine());
        Console.WriteLine("Chieu dai cua hinh chu nhat la: ");
        ChieuDai = float.Parse(Console.ReadLine());
        if(ChieuDai<=0 || ChieuRong <= 0){
            Console.WriteLine("Gia tri khong hop le, hay nhap lai!!!");
        }else{
            notok = false;
        }
        Console.WriteLine("Dien tich hinh chu nhat la: "+(ChieuRong*ChieuDai));
        }
    }

}
