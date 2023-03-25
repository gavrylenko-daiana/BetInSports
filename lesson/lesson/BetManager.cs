namespace lesson;

public class BetManager
{
    public List<Event> Events { get; set; } = new List<Event>();
    private List<Bet> Bets { get; set; } = new List<Bet>();

    public void AddEvent(Event sportEvent)
    {
        Events.Add(sportEvent);
    }

    public void RemoveEvent(int index)
    {
        if (index >= 0 && index < Events.Count)
        {
            Events.RemoveAt(index);
        }
    }

    public void DisplayEvents()
    {
        for (int i = 0; i < Events.Count; i++)
        {
            Console.WriteLine($"Событие {i + 1}: {Events[i].GetInfo()}\n");
        }
    }

    public void AddBet(Bet bet)
    {
        Bets.Add(bet);
    }

    public void DisplayBets()
    {
        for (int i = 0; i < Bets.Count; i++)
        {
            Console.WriteLine($"Ставка {i + 1}: {Bets[i].GetInfo()}\nВыигрыши: {Bets[i].CalculateWinnings()}\n");
        }
    }
}