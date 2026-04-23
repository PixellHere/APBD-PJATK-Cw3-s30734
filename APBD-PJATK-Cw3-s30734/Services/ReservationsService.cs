using APBD_PJATK_Cw3_s30734.Data;
using APBD_PJATK_Cw3_s30734.DTOs;
using APBD_PJATK_Cw3_s30734.Models;

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

    public ReservationDTO? GetById(int id)
    {
        return GetAll().FirstOrDefault(r => r.Id == id);
    }

    public IEnumerable<ReservationDTO> GetByFilter(DateTime? date, ReservationStatus? status, int? roomId)
    {
        return GetAll().Where(dto => (dto.Date == (date ?? DateTime.MinValue))
                                     && (dto.Status == (status ?? dto.Status))
                                     && (dto.RoomId == (roomId ?? dto.RoomId)));
    }

    public ReservationDTO AddReservation(CreateReservationDTO reservation)
    {
        var newReservation = new Reservation
        {
            Id = TrainingCenterData.Reservations.Max(r => r.Id) + 1,
            RoomId = reservation.RoomId,
            OrganizerName = reservation.OrganizerName,
            Topic = reservation.Topic,
            Date = reservation.Date,
            StartTime = reservation.StartTime,
            EndTime = reservation.EndTime,
            Status = reservation.Status
        };
        
        TrainingCenterData.Reservations.Add(newReservation);

        return new ReservationDTO
        {
            Id = newReservation.Id,
            RoomId = newReservation.RoomId,
            OrganizerName = newReservation.OrganizerName,
            Topic = newReservation.Topic,
            Date = newReservation.Date,
            StartTime = newReservation.StartTime,
            EndTime = newReservation.EndTime,
            Status = newReservation.Status
        };
    }

    public ReservationDTO? UpdateReservation(int id, UpdateReservationDTO reservation)
    {
        var reservationToUpdate = TrainingCenterData.Reservations.FirstOrDefault(r => r.Id == id);
        
        if(reservationToUpdate == null)
            return null;
        
        reservationToUpdate.RoomId = reservation.RoomId;
        reservationToUpdate.OrganizerName = reservation.OrganizerName;
        reservationToUpdate.Topic = reservation.Topic;
        reservationToUpdate.Date = reservation.Date;
        reservationToUpdate.StartTime = reservation.StartTime;
        reservationToUpdate.EndTime = reservation.EndTime;
        reservationToUpdate.Status = reservation.Status;

        return new ReservationDTO
        {
            Id = reservationToUpdate.Id,
            RoomId = reservationToUpdate.RoomId,
            OrganizerName = reservationToUpdate.OrganizerName,
            Topic = reservationToUpdate.Topic,
            Date = reservationToUpdate.Date,
            StartTime = reservationToUpdate.StartTime,
            EndTime = reservationToUpdate.EndTime,
            Status = reservationToUpdate.Status
        };
    }

    public string? RemoveReservation(int id)
    {
        var reservationToRemove = TrainingCenterData.Reservations.FirstOrDefault(reservation => reservation.Id == id);

        if (reservationToRemove == null)
            return null;

        TrainingCenterData.Reservations.Remove(reservationToRemove);
        
        return "Successfully removed reservation";
    }
    
    //TO DO: Validation methods
}