using APBD_PJATK_Cw3_s30734.DTOs;
using APBD_PJATK_Cw3_s30734.Models;

namespace APBD_PJATK_Cw3_s30734.Services;

public interface IReservationsService
{
    IEnumerable<ReservationDTO> GetAll();
    ReservationDTO? GetById(int id);
    IEnumerable<ReservationDTO> GetByFilter(DateTime? date, ReservationStatus? status, int? roomId);
    ReservationDTO? AddReservation(CreateReservationDTO reservation);
    ReservationDTO? UpdateReservation(int id, UpdateReservationDTO reservation);
    string? RemoveReservation(int id);
    bool ValidateNewReservation(CreateReservationDTO reservation);
    bool IsRoomInUse(int id, DateTime date, DateTime startTime, DateTime endTime);
}