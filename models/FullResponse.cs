using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.models
{
    [Serializable]
    public class FullResponse
    {
        public int IdHotel { get; set; }
        public String NomHotel { get; set; }

        public String NombreChambre { get; set; }

        public String NombreLit { get; set; }
        public String NomCategorie { get; set; }
        public String Pays { get; set; }
        public String Adresse { get; set; }
        public String NombreEtoile { get; set; }
        public FullResponse()
        {
        }

        public FullResponse(int idHotel, string nomHotel, string nombreChambre, string nombreLit, string nomCategorie, string pays, string adresse, string nombreEtoile)
        {
            IdHotel = idHotel;
            NomHotel = nomHotel;
            NombreChambre = nombreChambre;
            NombreLit = nombreLit;
            NomCategorie = nomCategorie;
            Pays = pays;
            Adresse = adresse;
            NombreEtoile = nombreEtoile;
        }
    }

}