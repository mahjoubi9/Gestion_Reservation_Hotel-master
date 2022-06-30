using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Gestion_Hotel.Model;

namespace Gestion_Hotel.UC
{
    public partial class ucRoom : UserControl
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        //---- numéro de la chambre --------
        public int NumRoom { get; set; }

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            using (cnx)
            {
                cnx.Open();
                string qry = "select \"idChambre\", \"numChambre\", \"prixChambre\" from public.\"chambre\" ";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                var reader = cmd.ExecuteReader();

                var listChambres = new List<Chambre>();

                while (reader.Read())
                {
                    
                    listChambres.Add(new Chambre(reader.GetInt32(1), reader.GetDouble(2)));
                   
                }
                lblNum.Text = NumRoom.ToString();
              
                cnx.Close();
            }
        }

        public static string numChambre { get; set; }

        private void réserverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numChambre = this.lblNum.Text;
            //MessageBox.Show(numChambre);

            ReservationForm resForm = new ReservationForm();
            resForm.numRoom = Convert.ToInt32(numChambre);
            resForm.Show();

        }

        private void libérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numChambre = this.lblNum.Text;

            using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
            {
                if (!c.State.Equals(ConnectionState.Open))
                    c.Open();

                //------------ Selection des réservations ----------
                string qry3 = "select \"dateDebutRes\",  \"idClient\", \"idChambre\", \"liberer\" from public.\"reservation\" ";
                NpgsqlCommand cmd3 = new NpgsqlCommand(qry3, c);
                var reader3 = cmd3.ExecuteReader();

                var listeRes = new List<Reservation>();

                while (reader3.Read())
                {
                    listeRes.Add(new Reservation(reader3.GetDateTime(0), reader3.GetInt32(1), reader3.GetInt32(2), reader3.GetBoolean(3)));
                }
                reader3.Close();


                //--------------- Selection de l'id de la chambre qu'on veut réserver ---------------
                string qry2 = "select \"idChambre\" from public.\"chambre\" where  \"numChambre\"='" + numChambre + "' ";
                NpgsqlCommand cmd2 = new NpgsqlCommand(qry2, c);
                var reader = cmd2.ExecuteReader();


                int idRoom = 0;

                while (reader.Read())
                {
                    idRoom = reader.GetInt32(0);
                }
                reader.Close();

                c.Close();

                foreach (var item in listeRes)
                {
                    //-------- On vérifie si la chambre est déjà réservée --------------
                    if (idRoom == item.idChambre)
                    {
                        //MessageBox.Show(idRoom.ToString());
                        ConfirmDeleteRes deleteForm = new ConfirmDeleteRes();
                        deleteForm.idRoom = idRoom;
                        deleteForm.Show();
                    }
                }
            }
        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }
    }
}
