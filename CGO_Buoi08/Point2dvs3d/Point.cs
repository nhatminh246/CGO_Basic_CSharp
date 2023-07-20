namespace Point2dvs3d;
public class Point2d
{
    private float x = 0f, y = 0f;
    public float Getx(){
        return x;
    }
    public float Gety(){
        return y;
    }
    public void Setx(float x){
        this.x = x;
    }
    public void Sety(float y){
        this.y = y;
    }
    public float[] GetXY(){
        float[] XY = new float[]{ x , y};
        return XY;
    }
    public void SetXY(float x, float y){
        this.x = x;
        this.y = y;
    }
    public Point2d(){}
    public Point2d(float x, float y){
        this.x = x;
        this.y = y;
    }
    public override string ToString(){
        float[] Arr = GetXY();
        return string.Format("---Point2d---\nX value:{0}\nY value:{1}", Arr[0],Arr[1]);
    }
}
public class  Point3d:Point2d{
    private float z = 0f;
    public float Getz(){
        return z;
    }
    public void Setz(float z){
        this.z = z;
    }
    public Point3d(){}
    public Point3d(float x, float y):base(x,y){
    }
    public Point3d(float x, float y, float z):base(x,y){
        this.z = z;
    }
    public void SetXYZ(float x, float y, float z){
        Setx(x);
        Sety(y);
        this.z = z;
    }
    public float[] GetXYZ(){
        float[] XYZ = new float[] {Getx(),Gety(),z};
        return XYZ; 
    }
    public override string ToString()
    {
        return string.Format("---Point3d---\nX value:{0}\nY value:{1}\nZ value:{2}", Getx(), Gety(), Getz());
    }
}
