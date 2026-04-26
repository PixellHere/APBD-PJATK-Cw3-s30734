using System.ComponentModel.DataAnnotations;
using APBD_PJATK_Cw3_s30734.Models;

namespace APBD_PJATK_Cw3_s30734.DTOs;

public class UpdateReservationDTO
{
    public int RoomId { get; set; }
    [Required]
    public string OrganizerName { get; set; } = string.Empty;
    [Required]
    public string Topic { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public ReservationStatus Status { get; set; }
}