using APBD_PJATK_Cw3_s30734.Models;

namespace APBD_PJATK_Cw3_s30734.DTOs;

public class CreateReservationDTO
{
    public int RoomId { get; set; }
    public string OrganizerName { get; set; } = string.Empty;
    public string Topic { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public ReservationStatus Status { get; set; }
}