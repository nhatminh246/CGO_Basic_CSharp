namespace ClassAnimal;
public abstract class Animal
{
    protected string Height { get; set; }
    protected string Weight { get; set; }
    public Animal(string height, string weight)
    {
        Height = height;
        Weight = weight;
    }
    public abstract void PrintInfo();
}
class Cat: Animal
{
    private string Name { get; set; }
    public Cat(string weight, string height, string name): base(weight, height)
    {
        Name = name;
    }
    public override void PrintInfo(){
        Console.WriteLine(" Weight: {0}\n Height:{1}\n Name: {2}", Weight, Height, Name);
    }
}

