namespace lesson;

public class RandomValue
{
    Random rand = new Random();

    public double GetRandomValue()
    {
        return Convert.ToDouble(Math.Round((rand.Next(100) / 11.0), 1));
    }
}