using APBD_PJATK_Cw3_s30734.DTOs;
using APBD_PJATK_Cw3_s30734.Models;
using APBD_PJATK_Cw3_s30734.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_PJATK_Cw3_s30734.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ReservationsController(IReservationsService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll([FromQuery] DateOnly? date, [FromQuery] ReservationStatus? status,
        [FromQuery] int? roomId)
    {
        if (date != null || status != null || roomId != null)
            return Ok(service.GetByFilter(date, status, roomId));
        
        return Ok(service.GetAll());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById([FromRoute]int id)
    {
        var reservation = service.GetById(id);
        
        return reservation == null ? NotFound() : Ok(reservation);
    }

    [HttpPost]
    public IActionResult AddReservation([FromBody] CreateReservationDTO reservation)
    {
        if (service.IsRoomInUse(null, reservation.RoomId, reservation.Date, reservation.StartTime, reservation.EndTime))
            return Conflict("Room is in use at this time");

        if (!service.ValidateNewReservation(reservation))
            return Conflict("Reservation is not valid");

        var newReservation = service.AddReservation(reservation);
        
        return newReservation != null ? Ok(newReservation) : BadRequest("Room does not exist");
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateReservation([FromRoute]int id, [FromBody] UpdateReservationDTO reservation)
    {
        if (service.IsRoomInUse(id, reservation.RoomId, reservation.Date, reservation.StartTime, reservation.EndTime))
            return Conflict("Room is in use at this time");
        
        if (!service.ValidateExistingReservation(reservation))
            return Conflict("Reservation is not valid");

        var updatedReservation = service.UpdateReservation(id, reservation);
        
        return updatedReservation != null ? Ok(updatedReservation) : BadRequest("Room does not exist");
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteReservation([FromRoute]int id)
    {
        var deletedRoom = service.RemoveReservation(id);
        return deletedRoom != null ? NoContent() : BadRequest("Room does not exist");
    }
}