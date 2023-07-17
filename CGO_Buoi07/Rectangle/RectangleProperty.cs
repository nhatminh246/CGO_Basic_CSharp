namespace Rectangle;
public class RectangleProperty
{
    private double width, height;
    public double Width{
        get{ return width;}
        set{ width = value; }
    }
    public double Height{
        get{ return height;}
        set{ height = value; }
    }
    public RectangleProperty(){

    }
    public RectangleProperty(double width, double height){
        this.width = width;
        this.height = height;
    }
    public double GetArea(){
        return Width * Height;
    }
    public double GetPerimeter(){
        return ((Width + Height)*2);
    }
    public void Display(){
        Console.WriteLine("Width: "+ Width);
        Console.WriteLine("Height"+ Height);
    }
}
