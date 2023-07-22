namespace InterfaceResizeable;
class Program
{
    static Random rnd = new Random();
    static void Main(string[] args)
    {
        List<Circle> arrCircle = new List<Circle>();
        arrCircle.Add(new Circle(6.4));
        arrCircle.Add(new Circle(24));
        arrCircle.Add(new Circle(235));
        foreach(Circle c in arrCircle){
            c.Resize(rnd.Next(0,100));
            Console.WriteLine(c.ToString());
        }
        List<Rectangle> arrRec = new List<Rectangle>();
        arrRec.Add(new Rectangle(6.4 , 25));
        arrRec.Add(new Rectangle(10, 15));
        arrRec.Add(new Rectangle(5, 30));
        foreach(Rectangle r in arrRec){
            r.Resize(rnd.Next(0,100));
            Console.WriteLine(r.ToString());
        }
        List<Square> arrSqu = new List<Square>();
        arrSqu.Add(new Square(5));
        arrSqu.Add(new Square());
        arrSqu.Add(new Square(20));
        foreach(Square s in arrSqu){
            s.Resize(rnd.Next(100));
            Console.WriteLine(s.ToString());
        }
        
        
        
    }
}
