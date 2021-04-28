using APIReservationHotel.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.modatabase
{ 
 public class HotelMock
{
    static List<Hotel> ListeHotel { get; set; }

    public static List<Hotel> GetHotels()
    {
        ListeHotel = new List<Hotel>();
        Hotel h = new Hotel(1, "Hotel Panama", 100, 90, "Panama", 1, 06, "Brasil", 2837, 24.183, -15.555, "Sao Pollo" );
        ListeHotel.Add(h);
        ListeHotel.Add(new Hotel(2, "Hotel Lamantin", 200, 200, "Lamantin", 1, 3665, "France", 217, 14.183, -5.555, "Montpellier"));
        ListeHotel.Add(new Hotel(3, "Hotel Teroubi", 300, 290, "Teroubi", 1, 923, "France", 137, 2.183, -19.274, "Nice"));
        ListeHotel.Add(new Hotel(4, "Hotel Wakola", 400, 390, "Wakola", 2, 553, "Italie", 737, 11.183, -17.245, "Rome"));
            ListeHotel.Add(new Hotel(5, "Hotel Plaza", 500, 490, "Plaza", 3, 6422, "Espagne", 037, 11.183, -18.8464, "Madrid")) ;
        ListeHotel.Add(new Hotel(6, "Hotel Golden", 600, 590, "Golden", 4, 2543, "Espagne", 2837, 24.183, -15.555, "Madrid"));
        ListeHotel.Add(new Hotel(7, "Hotel Pullman", 700, 690, "Pullman", 5, 0484, "France", 2837, 24.183, -15.555, "Montpellier"));
        ListeHotel.Add(new Hotel(8, "Hotel Mercure", 800, 790, "Mercure", 6, 6384, "France", 237, 24.3746, -15.7354, "Montpellier"));
        return ListeHotel;
    }
}
}