namespace APBD_PJATK_Cw3_s30734.DTOs;

public class RoomDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int BuildingCode { get; set; }
    public int Floor { get; set; }
    public int Capacity { get; set; }
    public bool HasProjector  { get; set; }
    public bool IsActive { get; set; }
}