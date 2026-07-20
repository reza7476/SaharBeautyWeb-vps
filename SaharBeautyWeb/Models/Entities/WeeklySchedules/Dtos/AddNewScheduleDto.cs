namespace SaharBeautyWeb.Models.Entities.WeeklySchedules.Dtos;

public class AddNewScheduleDto
{
    public bool IsActive { get; set; }
    public DayWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

}
