namespace App.Models;

public class Race
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly? EventDate { get; set; }
}
