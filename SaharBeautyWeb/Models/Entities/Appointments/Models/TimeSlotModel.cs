namespace SaharBeautyWeb.Models.Entities.Appointments.Models;

public class TimeSlotModel
{
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }
    public bool IsActive { get; set; }
}
