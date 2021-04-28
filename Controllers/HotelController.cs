using APIReservationHotel.modatabase;
using APIReservationHotel.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;

namespace APIReservationHotel.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ILogger<HotelController> _logger;

        public List<Chambre> ListeChambre;
        public List<Categorie> ListeCategorie;
        public List<Hotel> ListeHotel = new List<Hotel>();
        public List<Hotel> ReturnListeHotel = new List<Hotel>();
        public List<Reservation> ListeReservations = new List<Reservation>();
        List<Client> ListeClients = new List<Client>();

        public Boolean isChambre = false;

        public HotelController(ILogger<HotelController> logger)
        {
            _logger = logger;
            ListeClients = ClientMock.GetClientsLists();
             ListeHotel = HotelMock.GetHotels();
            ListeChambre = MockChambre.GetListChambre();
            ListeCategorie = MockeCategorie.GetListCategories();
            ListeReservations = MockReservation.GetListeReservations();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("weatherforecast")]
        public String Get()
        {
            return "bonjour";
        }

        public Hotel[] GetHotels()
        {
            return HotelMock.GetHotels().ToArray();
        }


        public List<Reservation> GetReservations()
        {
            return MockReservation.GetListeReservations();
        }


        public List<Adresse> GetAdresses()
        {
            return MockAdresse.GetListAdresse();
        }


        public List<Client> GetClients()
        {
            return ClientMock.GetClientsLists();
        }


        public List<Categorie> GetCategories()
        {
            return MockeCategorie.GetListCategories();
        }


        public List<Chambre> GetChambres()
        {
            return MockChambre.GetListChambre();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("search")]
        public Response<Hotel> SearchHotel([FromUri] String ville, [FromUri] String nomHotel,
            [FromUri] int categorie,
            [FromUri] DateTime dateArrivee, [FromUri] DateTime dateDepart,
            [FromUri] int prixMin, [FromUri] int prixMax, [FromUri] int nombrePersonne)
        {
            Response<Hotel> response = new Response<Hotel>();
         
            IEnumerable<Hotel> allHotels = from Hotel hotel in ListeHotel
                                           select hotel;

            if (!String.IsNullOrEmpty(ville))
            {
                allHotels = allHotels.Where(p => p.Ville.ToLower().Equals(ville.ToLower()));
            }
            if (nomHotel != null)
            {
                allHotels = allHotels.Where(p => p.nomHotel.ToLower().Equals(nomHotel.ToLower()));
            }

           if (categorie >= 1)
               {
                allHotels = allHotels.Where(p => p.idCategorie == categorie);
               }
          if (nombrePersonne >= 1)
               {
                   allHotels = allHotels.Where(p => p.nombreLit <= nombrePersonne);
               }

            foreach (Hotel q in allHotels)
            {
                ReturnListeHotel.Add(new Hotel(q.IdHotel, q.nomHotel, q.nombreChambre, q.nombreLit, q.lieuDit, q.idCategorie,
                 q.Rue, q.Pays, q.Numero, q.Latitude, q.Longitude, q.Ville));
            }

            if (prixMin >= 1 && prixMax >= 2)
            {
                ReturnListeHotel = new List<Hotel>();
                var hc = from Hotel hotel in allHotels
                         join chambre in ListeChambre
                            on hotel.IdHotel
                            equals chambre.IdHotel
                         where chambre.Prix >= prixMin && chambre.Prix <= prixMax
                         select
                             new
                             {
                                 hotel,
                                 chambre
                             };

                foreach (var q in hc)
                {
                    Hotel h = new Hotel(q.hotel.IdHotel, q.hotel.nomHotel, q.hotel.nombreChambre, q.hotel.nombreLit, q.hotel.lieuDit, q.hotel.idCategorie,
                  q.hotel.Rue, q.hotel.Pays, q.hotel.Numero, q.hotel.Latitude, q.hotel.Longitude, q.hotel.Ville);

                    if (q.chambre != null)
                    {
                        h.SetChambres(q.chambre);
                    }
                    ReturnListeHotel.Add(h);
                }
            }
            if (dateDepart >= DateTime.Now && dateArrivee >= DateTime.Now)
            {
                ReturnListeHotel = new List<Hotel>();
                var hc = from Hotel hotel in allHotels
                         join chambre in ListeChambre
                            on hotel.IdHotel
                            equals chambre.IdHotel
                         join reservation in ListeReservations
                         on chambre.IdChambre
                         equals reservation.IdChambre
                         select
                             new
                             {
                                 hotel,
                                 chambre
                             };

                foreach (var q in hc)
                {
                    Hotel h = new Hotel(q.hotel.IdHotel, q.hotel.nomHotel, q.hotel.nombreChambre, q.hotel.nombreLit, q.hotel.lieuDit, q.hotel.idCategorie,
                  q.hotel.Rue, q.hotel.Pays, q.hotel.Numero, q.hotel.Latitude, q.hotel.Longitude, q.hotel.Ville);

                    if (q.chambre != null)
                    {
                        h.SetChambres(q.chambre);
                    }
                    ReturnListeHotel.Add(h);
                }
            }
            
            response.Responses = ReturnListeHotel.ToArray();
            response.Message = "Reponse true. Resultat trouvé " + ReturnListeHotel.Count;
            return response;
        }


        [HttpPost("reserver")]
        public ReserverRequest DoReservat([FromForm] ReserverRequest reserverRequest)
        {
            int idReservation = ListeReservations.Count;
            int idClient = ListeClients.Count;
            int prix = reserverRequest.PrixReservation * reserverRequest.NombrePersonne;
            Reservation reservation = new Reservation(idReservation, idClient,
                prix, reserverRequest.IdChambre, reserverRequest.DateDebut, reserverRequest.DateFin,
                reserverRequest.Isfree
                );
            Client client = new Client(idClient, reserverRequest.NomClient, reserverRequest.PrenomClient, reserverRequest.InfosPayement);
           
            ListeReservations.Add(reservation);
            ListeClients.Add(client);

            reserverRequest.PrixReservation = prix;
            return reserverRequest;
        }
    }
}