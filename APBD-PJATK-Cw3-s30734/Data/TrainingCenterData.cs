using APBD_PJATK_Cw3_s30734.Models;

namespace APBD_PJATK_Cw3_s30734.Data;

public class TrainingCenterData
{
    public static List<Room> Rooms = new List<Room>
    {
        new Room { Id = 1,  Name = "Alpha",   BuildingCode = 101, Floor = 1, Capacity = 20,  HasProjector = true,  IsActive = true  },
        new Room { Id = 2,  Name = "Beta",    BuildingCode = 101, Floor = 1, Capacity = 15,  HasProjector = false, IsActive = true  },
        new Room { Id = 3,  Name = "Gamma",   BuildingCode = 101, Floor = 2, Capacity = 30,  HasProjector = true,  IsActive = true  },
        new Room { Id = 4,  Name = "Delta",   BuildingCode = 102, Floor = 1, Capacity = 10,  HasProjector = false, IsActive = true  },
        new Room { Id = 5,  Name = "Epsilon", BuildingCode = 102, Floor = 2, Capacity = 25,  HasProjector = true,  IsActive = true  },
        new Room { Id = 6,  Name = "Zeta",    BuildingCode = 102, Floor = 3, Capacity = 40,  HasProjector = true,  IsActive = true  },
        new Room { Id = 7,  Name = "Eta",     BuildingCode = 103, Floor = 1, Capacity = 12,  HasProjector = false, IsActive = true  },
        new Room { Id = 8,  Name = "Theta",   BuildingCode = 103, Floor = 2, Capacity = 50,  HasProjector = true,  IsActive = true  },
        new Room { Id = 9,  Name = "Iota",    BuildingCode = 103, Floor = 3, Capacity = 18,  HasProjector = false, IsActive = false },
        new Room { Id = 10, Name = "Kappa",   BuildingCode = 104, Floor = 1, Capacity = 22,  HasProjector = true,  IsActive = true  },
        new Room { Id = 11, Name = "Lambda",  BuildingCode = 104, Floor = 2, Capacity = 35,  HasProjector = true,  IsActive = true  },
        new Room { Id = 12, Name = "Mu",      BuildingCode = 104, Floor = 3, Capacity = 8,   HasProjector = false, IsActive = false },
        new Room { Id = 13, Name = "Nu",      BuildingCode = 105, Floor = 1, Capacity = 60,  HasProjector = true,  IsActive = true  },
        new Room { Id = 14, Name = "Xi",      BuildingCode = 105, Floor = 2, Capacity = 14,  HasProjector = false, IsActive = true  },
        new Room { Id = 15, Name = "Omicron", BuildingCode = 105, Floor = 3, Capacity = 45,  HasProjector = true,  IsActive = false },
    };

    public static List<Reservation> Reservations = new List<Reservation>
    {
        new Reservation { Id = 1,  RoomId = 1,  OrganizerName = "Alice Kowalski",   Topic = "Onboarding Session",          Date = new DateTime(2026, 6, 2),  StartTime = new DateTime(2026, 6, 2,  9,  0, 0), EndTime = new DateTime(2026, 6, 2,  11, 0, 0), Status = ReservationStatus.CONFIRMED  },
        new Reservation { Id = 2,  RoomId = 3,  OrganizerName = "Marek Nowak",      Topic = "Quarterly Review",            Date = new DateTime(2026, 6, 3),  StartTime = new DateTime(2026, 6, 3,  10, 0, 0), EndTime = new DateTime(2026, 6, 3,  12, 0, 0), Status = ReservationStatus.PLANNED    },
        new Reservation { Id = 3,  RoomId = 5,  OrganizerName = "Sara Wiśniewska",  Topic = "UX Design Workshop",          Date = new DateTime(2026, 6, 4),  StartTime = new DateTime(2026, 6, 4,  13, 0, 0), EndTime = new DateTime(2026, 6, 4,  16, 0, 0), Status = ReservationStatus.CONFIRMED  },
        new Reservation { Id = 4,  RoomId = 6,  OrganizerName = "Piotr Zając",      Topic = "All-Hands Meeting",           Date = new DateTime(2026, 6, 5),  StartTime = new DateTime(2026, 6, 5,  9,  0, 0), EndTime = new DateTime(2026, 6, 5,  10, 30, 0), Status = ReservationStatus.PLANNED   },
        new Reservation { Id = 5,  RoomId = 2,  OrganizerName = "Julia Mazur",      Topic = "Sprint Planning",             Date = new DateTime(2026, 6, 6),  StartTime = new DateTime(2026, 6, 6,  8,  0, 0), EndTime = new DateTime(2026, 6, 6,  9,  30, 0), Status = ReservationStatus.CONFIRMED  },
        new Reservation { Id = 6,  RoomId = 8,  OrganizerName = "Tomasz Wróbel",    Topic = "Security Training",           Date = new DateTime(2026, 6, 9),  StartTime = new DateTime(2026, 6, 9,  14, 0, 0), EndTime = new DateTime(2026, 6, 9,  17, 0, 0), Status = ReservationStatus.ON_HOLD    },
        new Reservation { Id = 7,  RoomId = 10, OrganizerName = "Katarzyna Dąbek",  Topic = "HR Policy Briefing",          Date = new DateTime(2026, 6, 10), StartTime = new DateTime(2026, 6, 10, 11, 0, 0), EndTime = new DateTime(2026, 6, 10, 12, 0, 0), Status = ReservationStatus.CANCELLED  },
        new Reservation { Id = 8,  RoomId = 11, OrganizerName = "Rafał Kaczmarek",  Topic = "Cloud Architecture Review",   Date = new DateTime(2026, 6, 11), StartTime = new DateTime(2026, 6, 11, 9,  30, 0), EndTime = new DateTime(2026, 6, 11, 11, 30, 0), Status = ReservationStatus.CONFIRMED },
        new Reservation { Id = 9,  RoomId = 4,  OrganizerName = "Monika Lewandska", Topic = "1-on-1 Coaching",             Date = new DateTime(2026, 6, 12), StartTime = new DateTime(2026, 6, 12, 15, 0, 0), EndTime = new DateTime(2026, 6, 12, 16, 0, 0), Status = ReservationStatus.PLANNED    },
        new Reservation { Id = 10, RoomId = 13, OrganizerName = "Damian Kopeć",     Topic = "Product Demo Day",            Date = new DateTime(2026, 6, 13), StartTime = new DateTime(2026, 6, 13, 10, 0, 0), EndTime = new DateTime(2026, 6, 13, 14, 0, 0), Status = ReservationStatus.ON_HOLD    },
    };
}