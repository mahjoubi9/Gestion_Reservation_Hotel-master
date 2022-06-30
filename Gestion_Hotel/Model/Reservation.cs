using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel.Model
{
    public class Reservation
    {
        public DateTime dateDebutRes  { get; set; }
        public int idClient { get; set; }
        public int idChambre { get; set; }
        public Boolean liberer { get; set; }

        public Reservation()
        {
                
        }

        public Reservation(DateTime dtDebut, int idClient, int idChambre)
        {
            this.dateDebutRes = dtDebut;
            this.idClient = idClient;
            this.idChambre = idChambre;
            this.liberer = liberer;
        }
        public Reservation(DateTime dtDebut, int idClient, int idChambre, Boolean idliberer)
        {
            this.dateDebutRes = dtDebut;
            this.idClient = idClient;
            this.idChambre = idChambre;
            this.liberer = idliberer;
        }
    }
}
