using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel.Model
{
    class Chambre
    {
        public int NumChambre { get; set; }
        public double prixChambre { get; set; }

        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");


        public Chambre()
        {

        }

        public Chambre(int num, double prix)
        {
            this.NumChambre = num;
            this.prixChambre = prix;
        }
    
    }
}
