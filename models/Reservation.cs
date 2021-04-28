using System;

namespace APIReservationHotel.models
{ 
    [Serializable]
public class Reservation
{
    public int IdReservation { get; set; }
    public int IdClient { get; set; }
    public int PrixReservation { get; set; }
    public int IdChambre { get; set; }
    public DateTime DateDebut { get; set; }
    public DateTime DateFin { get; set; }
    public  Boolean Isfree { get; set; }

        public Reservation() { }

    public Reservation(int idReservation, int idClient, int prixReservation, int idChambre, DateTime dateDebut, 
        DateTime dateFin, Boolean isfree)
    {
        IdReservation = idReservation;
        IdClient = idClient;
        PrixReservation = prixReservation;
        IdChambre = idChambre;
        DateDebut = dateDebut;
        DateFin = dateFin;
        Isfree = isfree;
    }
}
}