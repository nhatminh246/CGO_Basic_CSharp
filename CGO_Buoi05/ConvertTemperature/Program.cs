namespace ConvertTemperature;
class Program
{

    static double C_To_F(double c_temp){
        return (9.0 / 5) * c_temp + 32;
    }

    static double F_To_C(double f_temp){
        return (5.0 / 9) * (f_temp - 32);;
    }
    static void Main(string[] args)
    {
        double f_temp, c_temp;
        int choice;
        do{
            Console.WriteLine("******************************************");
            Console.WriteLine("Moi nhap lua chon chuyen doi nhiet do !!!");
            Console.WriteLine("1.Chuyen doi do F sang do C");
            Console.WriteLine("2.Chuyen doi do C sang do F");
            Console.WriteLine("3.Thoat");
            choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Moi nhap do C ma ban muon chuyen sang do F");
                    c_temp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Do C sau khi chuyen doi thanh do F la {0}", C_To_F(c_temp));
                    break;
                case 2:
                    Console.WriteLine("Moi nhap do F ma ban muon chuyen sang do C");
                    f_temp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Do F sau khi chuyen doi thanh do C la {0}", F_To_C(f_temp));
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                break;
            }
        }while (choice != 3);
    }
}
