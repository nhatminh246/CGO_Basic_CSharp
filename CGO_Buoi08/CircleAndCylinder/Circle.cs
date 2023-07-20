namespace CircleAndCylinder;
public class Circle
{
    private double radius = 1.0;
    public double GetRadius(){
        return radius;
    }
    public void SetRadius(double radius){
        this.radius = radius;
    }
    private string color = "red";
    public string GetColor(){
        return color;
    }
    public void SetColor(string color){
        this.color = color;
    }
    public Circle(){}
    public Circle(double radius, string color){
        this.radius = radius;
        this.color = color;
    }
    public virtual double GetArea(){
        return radius  * radius * 3.14;
    }
    public override string ToString(){
        return string.Format("Day la hinh tron co ban kinh la {0} va dien tich la {1} cung voi mau sac la {2}", GetRadius(), GetArea(), GetColor());
    }

}
public class Cylinder:Circle{
    private double height = 1.0;
    public double GetHeight(){
        return height;
    }
    public void SetHeight(double height){
        this.height = height;
    }
    public Cylinder(){

    }
    public Cylinder(double height){
        this.height = height;
    }
    public Cylinder(double height,double radius, string color) : base(radius, color)  {
        this.height = height;
    }
    public override double GetArea(){
        return 2*3.14* GetRadius() * (height + GetRadius());
    }
    public double GetVolume(){
        return 3.14 * GetRadius() * GetRadius() * height;
    }
    public override string ToString()
    {
        return string.Format("day la hinh lang tru co ban kinh la {0} va chieu cao la {1}\ndien tich: {2}\nthe tich: {3}\nmau sac:{4}", GetRadius(), GetHeight(), GetArea(), GetVolume(), GetColor());
    }
}
