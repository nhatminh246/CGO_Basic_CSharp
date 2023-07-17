namespace StaticMethod;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(124, "Nhat Minh");
        Student s2 = new Student(123, "Duc Minh");
        Student s3 = new Student(125, "Hoang Minh");
        s1.Display();
        s2.Display();
        s3.Display();
        Student.Change();
        s1.Display();
        s2.Display();
        s3.Display();
    }
}
