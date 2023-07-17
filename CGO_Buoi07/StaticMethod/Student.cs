namespace StaticMethod;
public class Student
{
    private int rollno { get; set; }
    private string name { get; set; }
    private static string college = "BBDIT";
    public Student(int rollno, string name){
        this.rollno = rollno;
        this.name = name;
    }
    public static void Change(){
        college = "CODEGYM";
    }
    public void Display(){
        Console.WriteLine(rollno  + " "+ name + " "+ college);
    }
}
