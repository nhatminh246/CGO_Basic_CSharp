namespace CharCount;
class Program
{

    static int CharCount(string str, char c){
        int index = 0;
        for(int i = 0; i < str.Length; i++){
            if(str[i] == c){
                index++;
            }
        }
        return index;
    }
    static void Main(string[] args)
    {
        string s = "Day la 1 vi du de dem so luong ky tu theo yeu cau cua nguoi dung";
        Console.WriteLine(s);
        Console.WriteLine("Nhap ky tu ban muon dem tu chuoi o tren !");
        char c = Console.ReadLine()[0];
        Console.WriteLine("So luonng ky tu \"{0}\" co trong chuoi o tren la {1}", c,CharCount(s, c));

    }
}
