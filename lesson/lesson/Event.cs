namespace lesson;

public class Event
{
    private string Name { get; set; }
    private DateTime Date { get; set; }
    public List<double> Odds { get; set; } = new List<double>();

    public Event(string Name, DateTime Date, List<double> Odds)
    {
        this.Name = Name;
        this.Date = Date;
        this.Odds = Odds;
    }

    public string GetInfo()
    {
        return $"Title: {Name}\nDate: {Date}\nThe odds: {string.Join(", ", Odds)}";
    }
}