using APIReservationHotel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.modatabase
{
    public class MockReservation
    {
        public static List<Reservation> ListeReservations { get; set; }

        public static List<Reservation> GetListeReservations()
        {
            ListeReservations = new List<Reservation>();
            ListeReservations.Add(new Reservation(1, 1, 70, 1, new DateTime(), new DateTime(), true));
            ListeReservations.Add(new Reservation(1, 1, 70, 1, new DateTime(), new DateTime(), true));
            return ListeReservations;
        }

    }
}