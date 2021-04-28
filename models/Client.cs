using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.models
{
    [Serializable]
    public class Client
    {
        public int IdClient { get; set; }
        public String NomClient { get; set; }
        public String PrenomClient { get; set; }
        public String InfosPayement { get; set; }

        public Client() { }

        public Client(int idClient, string nomClient, string prenomClient, string infosPayement)
        {
            IdClient = idClient;
            NomClient = nomClient;
            PrenomClient = prenomClient;
            InfosPayement = infosPayement;
        }
    }
}