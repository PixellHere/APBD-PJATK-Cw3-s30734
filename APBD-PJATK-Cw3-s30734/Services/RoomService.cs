using APBD_PJATK_Cw3_s30734.Data;
using APBD_PJATK_Cw3_s30734.DTOs;
using APBD_PJATK_Cw3_s30734.Models;

namespace APBD_PJATK_Cw3_s30734.Services;

public class RoomService : IRoomService
{
    public IEnumerable<RoomDTO> GetRooms()
    {
        return new List<RoomDTO>(TrainingCenterData.Rooms.Select(room => new RoomDTO
        {
            Id = room.Id,
            Name = room.Name,
            BuildingCode = room.BuildingCode,
            Floor =  room.Floor,
            Capacity = room.Capacity,
            HasProjector =  room.HasProjector,
            IsActive = room.IsActive,
        }));
    }

    public RoomDTO? GetById(int id)
    {
        return TrainingCenterData.Rooms
            .Where(room => room.Id == id)
            .Select(room => new RoomDTO
            {
                Id = room.Id,
                Name = room.Name,
                BuildingCode = room.BuildingCode,
                Floor = room.Floor,
                Capacity = room.Capacity,
                HasProjector = room.HasProjector,
                IsActive = room.IsActive
            })
            .FirstOrDefault();
    }

    public IEnumerable<RoomDTO> GetByBuildingCode(int buildingCode)
    {
        return TrainingCenterData.Rooms
            .Where(room => room.BuildingCode == buildingCode)
            .Select(room => new RoomDTO
            {
                Id = room.Id,
                Name = room.Name,
                BuildingCode = room.BuildingCode,
                Floor = room.Floor,
                Capacity = room.Capacity,
                HasProjector = room.HasProjector,
                IsActive = room.IsActive
            });
    }

    public IEnumerable<RoomDTO> GetByFiltr(int? minCapacity, bool? hasProjector, bool? isActive)
    {
        return TrainingCenterData.Rooms
            .Where(room => (room.Capacity >= (minCapacity ?? 0)) 
                           && (room.HasProjector == (hasProjector ?? room.HasProjector)) 
                           && (room.IsActive == (isActive  ?? room.IsActive)))
            .Select(room => new RoomDTO
            {
                Id = room.Id,
                Name = room.Name,
                BuildingCode = room.BuildingCode,
                Floor = room.Floor,
                Capacity = room.Capacity,
                HasProjector = room.HasProjector,
                IsActive = room.IsActive
            });
    }

    public RoomDTO AddRoom(CreateRoomDTO room)
    {
        var newRoom = new Room
        {
            Id = TrainingCenterData.Rooms.OrderByDescending(r => r.Id).First().Id + 1,
            Name = room.Name,
            BuildingCode = room.BuildingCode,
            Floor = room.Floor,
            Capacity = room.Capacity,
            HasProjector = room.HasProjector,
            IsActive = room.IsActive
        };
        
        TrainingCenterData.Rooms.Add(newRoom);

        return new RoomDTO
        {
            Id = newRoom.Id,
            Name = newRoom.Name,
            BuildingCode = newRoom.BuildingCode,
            Floor = newRoom.Floor,
            Capacity = newRoom.Capacity,
            HasProjector = newRoom.HasProjector,
            IsActive = newRoom.IsActive
        };
    }

    public RoomDTO? UpdateRoom(int id, UpdateRoomDTO room)
    {
        var updatedRoom = TrainingCenterData.Rooms.FirstOrDefault(r => r.Id == id);
        
        if (updatedRoom == null)
            return null;
        
        updatedRoom.Name = room.Name;
        updatedRoom.BuildingCode = room.BuildingCode;
        updatedRoom.Floor = room.Floor;
        updatedRoom.Capacity = room.Capacity;
        updatedRoom.HasProjector = room.HasProjector;
        updatedRoom.IsActive = room.IsActive;

        return new RoomDTO
        {
            Id = updatedRoom.Id,
            Name = updatedRoom.Name,
            BuildingCode = updatedRoom.BuildingCode,
            Floor = updatedRoom.Floor,
            Capacity = updatedRoom.Capacity,
            HasProjector = updatedRoom.HasProjector,
            IsActive = updatedRoom.IsActive
        };
    }

    public bool? RemoveRoom(int id)
    {
        var deleteRoom = TrainingCenterData.Rooms.FirstOrDefault(r => r.Id == id);
        
        if (deleteRoom == null)
            return null;
        
        TrainingCenterData.Rooms.Remove(deleteRoom);
        
        return true;
    }
    
    public bool IsRoomInUse(int id)
    {
        return TrainingCenterData.Reservations.Any(r => (r.RoomId == id) && (r.Date >= DateOnly.FromDateTime(DateTime.Now)));
    }
}