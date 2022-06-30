using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel.Model
{

    public class Client
    {
        public Client()
        {
        }

        public Client(int idCli, string nomCli, string prenomCli, string emailCli, string telCli, double prixconsommation)
        {
            this.idCli = idCli;
            this.nomCli = nomCli;
            this.prenomCli = prenomCli;
            this.emailCli = emailCli;
            this.telCli = telCli;
            this.prixconsommation = prixconsommation;
        }

        public int idCli { get; set; }
        public string nomCli { get; set; }
        public string prenomCli { get; set; }
        public string emailCli { get; set; }
        public string telCli { get; set; }
        public double prixconsommation { get; set; }
    }
    
}
