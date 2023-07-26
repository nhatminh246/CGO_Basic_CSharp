namespace FileCopy;
class Program
{
    static void Main(string[] args)
    {
        try{
            string source = "source.dll";
            string des = "des.dll";
            File.Copy(source, des,true);
            Console.WriteLine("Copy completed");
        }catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
    }
}
