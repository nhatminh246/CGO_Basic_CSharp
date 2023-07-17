namespace StopWatch;
public class Watch
{
    private DateTime startTime { get; set; }
    private DateTime endTime { get; set; }

    public Watch(DateTime startTime, DateTime endTime)
    {
        this.startTime = startTime;
        this.endTime = endTime;
    }
    public Watch(){
        startTime = DateTime.Now;
    }
    public void Start() 
    {
        startTime = DateTime.Now;
    }
    public void End() {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime(){
        return (endTime - startTime).TotalMilliseconds;
    }
}
