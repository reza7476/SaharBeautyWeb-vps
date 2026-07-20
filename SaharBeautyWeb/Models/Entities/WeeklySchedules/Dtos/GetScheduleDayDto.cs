namespace SaharBeautyWeb.Models.Entities.WeeklySchedules.Dtos;

public class GetScheduleDayDto
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public bool IsActive { get; set; }
    public string? Description { get; set; }
}
