using APBD_PJATK_Cw3_s30734.Data;
using APBD_PJATK_Cw3_s30734.DTOs;

namespace APBD_PJATK_Cw3_s30734.Services;

public class ReservationsService : IReservationsService
{
    public IEnumerable<ReservationDTO> GetAll()
    {
        return TrainingCenterData.Reservations
            .Select(reservation => new ReservationDTO
            {
                Id = reservation.Id,
                RoomId = reservation.RoomId,
                OrganizerName = reservation.OrganizerName,
                Topic = reservation.Topic,
                Date = reservation.Date,
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime,
                Status = reservation.Status

            });
    }

    public ReservationDTO GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ReservationDTO> GetByFilter(DateTime? date, string? status, int? roomId)
    {
        throw new NotImplementedException();
    }

    public ReservationDTO AddReservation(CreateReservationDTO reservation)
    {
        throw new NotImplementedException();
    }

    public ReservationDTO? UpdateReservation(int id, UpdateReservationDTO reservation)
    {
        throw new NotImplementedException();
    }

    public string? RemoveReservation(int id)
    {
        throw new NotImplementedException();
    }
}