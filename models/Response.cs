using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIReservationHotel.models
{ 

    [Serializable]
public class Response<T>
{
    public String Message { get; set; }
    public T[] Responses { get; set; }

}
}
