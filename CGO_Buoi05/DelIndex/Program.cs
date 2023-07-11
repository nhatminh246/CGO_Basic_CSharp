namespace DelIndex;
class Program
{

    static void DelIndex(int[] arr, int index){
        for (int i = index; i < arr.Length-1; i++){
            arr[i] = arr[i+1];
        }
        arr[arr.Length-1] = default(int);
    }
    static bool Check(int[] array, int value, ref int index){
        for (int i = 0; i < array.Length;i++){
            if (array[i] == value){
                index = i;
                return true;
            }
                
        }
        return false;
    }
    static void Main(string[] args)
    {
        int index = -1, value;
        bool flag = false;
        int[] arr = { 1, 2,5,7,3,36};  
        Console.Write("Mang hien tai co gia tri la: ");
        Console.WriteLine(string.Join(",", arr));  
        Console.WriteLine("Nhap gia tri can xoa");
        value = Int32.Parse(Console.ReadLine());
        flag = Check(arr, value, ref index);
        if(flag){
            if(index != - 1) Console.WriteLine("Gia tri ban muon xoa co trong mang va nam o vi tri {0}",index);
            DelIndex(arr,index);
            Console.Write("Mang sau khi xoa co gia tri la: ");
            Console.WriteLine(string.Join(",", arr.Take(arr.Length -1)));
        }else{
            Console.WriteLine("Phan tu can xoa khong co trong mang");
        }
       
    }
}
