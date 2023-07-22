namespace InterfaceResizeable
{
    public class Shape
    {
        private string color = "green";
        private bool filled = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string GetColor()
        {
            return color;
        }

        public bool IsFilled()
        {
            return filled;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");
        }
    }

    public class Circle : Shape,Resizeable{
        public void Resize(double percent){
            double newRadius = GetRadius() + GetRadius() * percent / 100;
            SetRadius(newRadius);
        }
        private double radius = 1.0;
        public Circle(){

        }
        public Circle(double radius){
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color, filled){
            this.radius = radius;
        }
        public double GetRadius(){
            return radius;
        }
        public void SetRadius(double radius){
            this.radius = radius;
        }
        public double GetArea(){
            return radius * radius * 3.14;
        }
        public double GetPetimeter(){
            return radius * 2 * 3.14;
        }
        public override String ToString()

        {

            return "A Circle with radius = "

                    + GetRadius()

                    + ", which is a subclass of "

                    + base.ToString();

        }

    }
    public class Rectangle : Shape,Resizeable{
        public void Resize(double percent){
            double newHeight = GetHeight() + GetHeight() * percent / 100;
            double newWidth  = GetWidth() + GetWidth() * percent /100;
            SetHeight(newHeight);
            SetWidth(newWidth);
        }
        private double width  = 1, height = 1;
        public Rectangle(){}
        public Rectangle(double width, double height){
            this.width = width;
            this.height = height;
        }
        public Rectangle(double width, double height, string color, bool filled) : base(color,filled){
            this.width = width;
            this.height=height;
        }
        public double GetWidth(){
            return width;
        }
        public void SetWidth(double width){
            this.width = width;
        }
        public double GetHeight(){
            return height;
        }
        public void SetHeight(double height){
            this.height = height;
        }
        public double GetArea(){
            return width * height;
        }
        public double GetPetimeter(){
            return (width + height) * 2 ;
        }
        public override string ToString()
        {
            return "A Rectangle with width "+ GetWidth() + " and length= " + GetHeight() + " ,which is a subclass of " + base.ToString();
        }
    }
    public class Square:Rectangle,Resizeable{
        public void Resize(double percent){
            double newSide = GetSide() + GetSide() * percent / 100;
            SetSide(newSide);
        }
        public Square(){}
        public Square(double side) : base(side , side){

        }
        public Square(double side, string color , bool filled) : base(side, side, color,filled){}
        public double GetSide(){
            return GetHeight();
        }
        public void SetSide(double side){
            SetHeight(side);
            SetWidth(side);
        }
        public override string ToString()
        {
            return "A Square with side= "+ GetSide()+ ", which is a subclass of " + base.ToString();
        }
    }
    public interface Resizeable{
        public void Resize(double percent);
    }
}