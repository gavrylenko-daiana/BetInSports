namespace lesson;

public class Bet
{
    private Event SportEvent { get; set; }
    private int Outcome { get; set; }
    private double Amount { get; set; }

    public Bet(Event SportEvent, int Outcome, double Amount)
    {
        this.SportEvent = SportEvent;
        this.Outcome = Outcome;
        this.Amount = Amount;
    }

    public double CalculateWinnings()
    {
        return Math.Round(Amount * SportEvent.Odds[Outcome], 1);
    }

    public string GetInfo()
    {
        string outcomeStr;
        switch (Outcome)
        {
            case 0:
                outcomeStr = "Team A wins";
                break;
            case 1:
                outcomeStr = "Draw";
                break;
            case 2:
                outcomeStr = "Team B wins.";
                break;
            default:
                outcomeStr = "Incorrect result";
                break;
        }

        return $"\nEvent: {SportEvent.GetInfo()}\nResult: {outcomeStr}\nThe amount of the bet: {Amount}";
    }
}