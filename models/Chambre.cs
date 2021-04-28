using System;

namespace APIReservationHotel.models
{
    [Serializable]
    public class Chambre
    {
        public int IdChambre { get; set; }
        public int Prix { get; set; }
        public int NombreDeLiet { get; set; }
        public bool EstLibre { get; set; }
        public int IdHotel { get; set; }

        public Chambre() { }
        public Chambre(int idChambre, int prix, int nombreDeLiet, bool estLibre, int idHotel)
        {
            IdChambre = idChambre;
            Prix = prix;
            NombreDeLiet = nombreDeLiet;
            EstLibre = estLibre;
            IdHotel = idHotel;
        }
    }
}