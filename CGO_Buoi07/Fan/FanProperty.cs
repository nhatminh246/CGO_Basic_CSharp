namespace Fan
{
    public class FanProperty
    {
        const int SLOW = 1, MEDIUM = 2, FAST = 3;
        private int speed;
        private bool on;
        private string color;
        private double radius;
        public string Color { get => color; set => color = value; }
        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        
        public FanProperty()
        {
            Speed = SLOW;
            On = false;
            Color = "blue";
            Radius = 5;
        }
        public FanProperty(int speed, bool on, string color, double radius)
        {
            this.speed = speed;
            this.on = on;
            this.color = color;
            this.radius = radius;
        }
        public void ToString()
        {
            if(On)
            {
                Console.WriteLine("Speed: {0}", Speed);
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Radius: {0}", Radius);
                Console.WriteLine("fan is on");
            }
            else
            {
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Radius: {0}", Radius);
                Console.WriteLine("fan is off");
            }
        }
    }
}