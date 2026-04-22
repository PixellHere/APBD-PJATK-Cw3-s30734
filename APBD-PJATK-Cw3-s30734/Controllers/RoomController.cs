using APBD_PJATK_Cw3_s30734.DTOs;
using APBD_PJATK_Cw3_s30734.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_PJATK_Cw3_s30734.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class RoomsController(IRoomService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllRooms([FromQuery] int? minCapacity,
        [FromQuery] bool? hasProjector, [FromQuery] bool? isActive)
    {
        if (minCapacity == null && hasProjector == null && isActive == null)
            return Ok(service.GetRooms());
        else
            return Ok(service.GetByFiltr(minCapacity, hasProjector, isActive));
    }

    [HttpGet("{id:int}")]
    public IActionResult GetRoom([FromRoute] int id)
    {
        var room = service.GetById(id);
        return room == null ? NotFound() : Ok(room);
    }

    [HttpGet("building/{buildingCode:int}")]
    public IActionResult GetRoomsByBuildingCode(int buildingCode)
    {
        return Ok(service.GetByBuildingCode(buildingCode));
    }

    [HttpPost]
    public IActionResult CreateRoom([FromBody] CreateRoomDTO room)
    {
        return Ok(service.AddRoom(room));
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateRoom([FromRoute] int id, [FromBody] UpdateRoomDTO room)
    {
        var updateRoom = service.UpdateRoom(id, room);
        return updateRoom == null ? NotFound() : Ok(updateRoom);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteRoom([FromRoute] int id)
    {
        var deleteRoom = service.RemoveRoom(id);
        return deleteRoom == null ? NotFound() : Ok(deleteRoom);
    }
}