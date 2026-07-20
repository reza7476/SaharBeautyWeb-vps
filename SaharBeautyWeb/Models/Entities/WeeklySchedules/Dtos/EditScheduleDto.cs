namespace SaharBeautyWeb.Models.Entities.WeeklySchedules.Dtos;

public class EditScheduleDto
{
    public bool IsActive { get; set; }
    public DayWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int Id { get; set; }
}
