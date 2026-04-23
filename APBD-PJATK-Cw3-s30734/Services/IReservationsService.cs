using APBD_PJATK_Cw3_s30734.DTOs;

namespace APBD_PJATK_Cw3_s30734.Services;

public interface IReservationsService
{
    IEnumerable<ReservationDTO> GetAll();
    ReservationDTO GetById(int id);
    IEnumerable<ReservationDTO> GetByFilter(DateTime? date, string? status, int? roomId);
    ReservationDTO AddReservation(CreateReservationDTO reservation);
    ReservationDTO? UpdateReservation(int id, UpdateReservationDTO reservation);
    string? RemoveReservation(int id);
}