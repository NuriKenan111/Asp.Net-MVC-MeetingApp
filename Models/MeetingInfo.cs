namespace MeetingApp.Models;

public class MeetingInfo{
    public int Id { get; set; }
    public string? Location { get; set; }
    public DateTime? Date { get; set; }
    public int NumberOfPeople { get; set; }

    public MeetingInfo(int id, string? location, DateTime? date, int numberOfPeople)
    {
        Id = id;
        Location = location;
        Date = date;
        NumberOfPeople = numberOfPeople;
    }

}