using SaharBeautyWeb.Models.Entities.WeeklySchedules.Dtos;

namespace SaharBeautyWeb.Models.Entities.WeeklySchedules.Models;

public class GetScheduleModel
{
    public bool IsActive { get; set; }
    public DayWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int Id { get; set; }
}
