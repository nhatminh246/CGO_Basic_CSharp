namespace FindMin;
class Program
{

    static int MinValue(int[] array){
        int min = array[0];
        for(int i = 1; i < array.Length; i++){
            if(array[i]< min){
                min = array[i];
            }
        }
        return min;
    }
    static void Main(string[] args)
    {
        int[]arr = {3,7,8,25,88,34,2,-235,2,62};
        Console.WriteLine("Day so chung ta dang co la: {0} ",string.Join(" ,",arr));
        Console.WriteLine("Gia tri be nhat trong day la: {0}", MinValue(arr));
    }
}
