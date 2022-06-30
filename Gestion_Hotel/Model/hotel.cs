using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Gestion_Hotel.Model
{
    public class hotel
    {
        public int idHotel { get; set; }
        public string nomHotel { get; set; }
        public string adrHotel { get; set; }
        public string categorie { get; set; }

        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");

        public hotel(int idHotel, string nomHotel, string adrHotel)
        {
            this.idHotel = idHotel;
            this.nomHotel = nomHotel;
            this.adrHotel = adrHotel;
        }

        public hotel()
        {
        }
    }
}
