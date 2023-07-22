namespace IndexOfException;
class Program
{
    static void Main(string[] args)
    {
        try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'n', 'h', 'a', 't', 'm', 'i','n','h' });
                char value = characters[10];
            }
            catch (IndexOutOfRangeException  ex)
            {
                System.Console.WriteLine(ex);
            }

    }
}
