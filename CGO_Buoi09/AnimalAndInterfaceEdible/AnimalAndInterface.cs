namespace AnimalAndInterfaceEdible;
public abstract class Animal
{
    public abstract string MakeSound();
}
public interface Edible{
    public string howtoEat();
}
public class Tiger:Animal{
    public override string MakeSound()
    {
        return "gau gau gau oang oang oang";
    }
}
public class Chicken:Animal,Edible{
    public override string MakeSound(){
        return "buh bub buh lmao lmao";
    }
    public string howtoEat(){
        return "luộc con gà lên mà ăn";
    }
}

public abstract class Fruit:Edible{
    public abstract string howtoEat();
}
public class Orange:Fruit{
    public override string howtoEat(){
        return "dùng dao gọt cam ra rồi ăn";
    }
}
public class Apple:Fruit{
    public override string howtoEat(){
        return "Đưa qua táo vào miệng ăn luôn";
    }
}
