using System;

namespace APIReservationHotel.models
{
    [Serializable]
    public class Hotel
    {
        public int IdHotel { get; set; }
        public int GetIdHotel()
        {
            return IdHotel;
        }
        public void SetIdHotel(int value)
        {
            IdHotel = value;
        }

        public string nomHotel { get; set; }

        public string GetNomHotel()
        {
            return nomHotel;
        }

        public void SetNomHotel(string value)
        {
            nomHotel = value;
        }

        public int nombreChambre { get; set; }

        public int GetNombreChambre()
        {
            return nombreChambre;
        }

        public void SetNombreChambre(int value)
        {
            nombreChambre = value;
        }

        public int nombreLit { get; set; }

        public int GetNombreLit()
        {
            return nombreLit;
        }

        public void SetNombreLit(int value)
        {
            nombreLit = value;
        }

        public string lieuDit { get; set; }

        public string GetLieuDit()
        {
            return lieuDit;
        }

        public void SetLieuDit(string value)
        {
            lieuDit = value;
        }

        public int idCategorie { get; set; }

        public int GetIdCategorie()
        {
            return idCategorie;
        }

        public void SetIdCategorie(int value)
        {
            idCategorie = value;
        }

        public int Rue { get; set; }
        public String Ville { get; set; }
        public String Pays { get; set; }
        public int Numero { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Chambre Chambres {get; set;}

        public Chambre GetChambres()
        {
            return Chambres;
        }

        public void SetChambres(Chambre chambres)
        {
            this.Chambres = chambres;
        }

        public Hotel()
        {

        }

        public Hotel(int idHotel, string nomHotel, int nombreChambre, int nombreLit, string lieuDit, int idCategorie,
            int rue, String pays, int numero, double latitude, double longitude, String ville)
        {
            this.SetIdHotel(idHotel);
            this.SetNomHotel(nomHotel);
            this.SetNombreChambre(nombreChambre);
            this.SetNombreLit(nombreLit);
            this.SetLieuDit(lieuDit);
            this.SetIdCategorie(idCategorie);
            this.Rue = rue;
            this.Pays = pays;
            this.Numero = numero;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Ville = ville;
        }

        public Hotel(int idHotel, string nomHotel, int nombreChambre, int nombreLit, string lieuDit, int idCategorie,
            int rue, String pays, int numero, double latitude, double longitude, String ville, Chambre chambres)
        {
            this.SetIdHotel(idHotel);
            this.SetNomHotel(nomHotel);
            this.SetNombreChambre(nombreChambre);
            this.SetNombreLit(nombreLit);
            this.SetLieuDit(lieuDit);
            this.SetIdCategorie(idCategorie);
            this.Rue = rue;
            this.Pays = pays;
            this.Numero = numero;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Ville = ville;
            this.Chambres = chambres;
        }


    }
}