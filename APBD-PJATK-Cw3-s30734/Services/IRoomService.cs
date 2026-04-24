using APBD_PJATK_Cw3_s30734.DTOs;

namespace APBD_PJATK_Cw3_s30734.Services;

public interface IRoomService
{
    IEnumerable<RoomDTO> GetRooms();
    RoomDTO? GetById(int id);
    IEnumerable<RoomDTO> GetByBuildingCode(int buildingCode);
    IEnumerable<RoomDTO> GetByFiltr(int? minCapacity, bool? hasProjector, bool? isActive);
    RoomDTO AddRoom(CreateRoomDTO room);
    RoomDTO? UpdateRoom(int id, UpdateRoomDTO room);
    bool? RemoveRoom(int id);
    bool IsRoomInUse(int id);
}