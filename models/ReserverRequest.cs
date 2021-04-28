using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.models
{
    [Serializable]
    public class ReserverRequest
    {

        public int IdClient { get; set; }
        public String NomClient { get; set; }
        public String PrenomClient { get; set; }
        public String InfosPayement { get; set; }

        public int IdReservation { get; set; }
        public int PrixReservation { get; set; }
        public int IdChambre { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Boolean Isfree { get; set; }

        public int Prix { get; set; }
        public int NombreDeLiet { get; set; }
        public bool EstLibre { get; set; }
        public int IdHotel { get; set; }
        public int NombrePersonne { get; set; }

        public ReserverRequest() { }

        public ReserverRequest(int idClient, string nomClient, string prenomClient, string infosPayement, int idReservation, int prixReservation, int idChambre, DateTime dateDebut,
        DateTime dateFin, Boolean isfree, int prix, int nombreDeLiet, bool estLibre, int idHotel, int nombrePersonne)
        {
            IdClient = idClient;
            NomClient = nomClient;
            PrenomClient = prenomClient;
            InfosPayement = infosPayement;

            IdReservation = idReservation;
            PrixReservation = prixReservation;
            IdChambre = idChambre;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Isfree = isfree;

            Prix = prix;
            NombreDeLiet = nombreDeLiet;
            EstLibre = estLibre;
            IdHotel = idHotel;
            NombrePersonne = nombrePersonne;
        }

    }
}