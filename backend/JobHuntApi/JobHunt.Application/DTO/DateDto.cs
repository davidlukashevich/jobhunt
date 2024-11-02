namespace JobHunt.Application.DTO;

public class DateDto
{
    public int Year { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }

    public DateDto(int year, int day, int month)
    {
        Year = year;
        Day = day;
        Month = month;
    }
}