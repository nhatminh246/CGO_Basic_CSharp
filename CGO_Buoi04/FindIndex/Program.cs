namespace FindIndex;
class Program
{
    static void Main(string[] args)
    {
        
        string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
        Console.WriteLine("Enter a name’s student:");
        string input_name = Console.ReadLine();
        bool isok = false;
        /*
        for(int i = 0; i < students.Length; i++){
            if(students[i].Equals(input_name)){
                isok = true;
                Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                break;
            }
        }
        if(!isok){
            Console.WriteLine("Not found" + input_name + " in the list.");
        }
        */
        List<string> list = new List<string>(students);
        int index =  list.IndexOf(input_name);
        if(index == -1){
            Console.WriteLine("Not found" + input_name + " in the list.");
        }else{
            Console.WriteLine("Position of the students in the list " + input_name + " is: " + index);
        }


    }
}
