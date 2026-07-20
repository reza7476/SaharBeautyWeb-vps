namespace SaharBeautyWeb.Models.Entities.WeeklySchedules.Dtos;

public class GetWeeklySchedulesDto
{
    public bool IsActive { get; set; }
    public DayWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int Id { get; set; }
}
public enum DayWeek : byte
{
    None = 0,
    Saturday = 1,
    Sunday = 2,
    Monday = 3,
    Tuesday = 4,
    Wednesday = 5,
    Thursday = 6,
    Friday = 7,
}
