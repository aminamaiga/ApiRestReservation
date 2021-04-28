using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.models
{
    [Serializable]
    public class Adresse
    {
        public int IdAdresse { get; set; }
        public int Rue { get; set; }
        public String Pays { get; set; }
        public int Numero { get; set; }
        public int Gps { get; set; }

        public String Ville { get; set; }
        public int IdHotel { get; set; }

        public Adresse() { }

        public Adresse(int idAdresse, int rue, string pays, int numero, string ville, int idHotel, int gps)
        {
            IdAdresse = idAdresse;
            Rue = rue;
            Pays = pays;
            Numero = numero;
            this.Gps = gps;
            Ville = ville;
            this.IdHotel = idHotel;
        }
    }
}
