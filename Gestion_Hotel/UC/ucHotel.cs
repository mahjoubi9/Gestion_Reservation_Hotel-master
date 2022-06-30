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
    public partial class ucHotel : UserControl
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");

        public ucHotel()
        {
            InitializeComponent();
        }

        private void ucHotel_Load(object sender, EventArgs e)
        {
            /*//------------------ Remplissage de la liste des chambres ------------------
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
                  //MessageBox.Show(reader.GetDouble(2) .ToString());
                }

                //------------------ Remplisage du panel par ucRoom --------------------
                flowLayoutPanel.Controls.Clear();

                foreach (Chambre item in listChambres)
                {
                    //MessageBox.Show(item.NumChambre.ToString() + " - " + item.prixChambre.ToString());

                    ucRoom ucRoom = new ucRoom();

                    ucRoom.NumRoom = item.NumChambre;


                    flowLayoutPanel.Controls.Add(ucRoom);


                    this.Controls.Add(flowLayoutPanel);

                }

                cnx.Close();

                //------------ sélection du nom de l'hotel qui a l'id = 1 -------------
                using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                {
                    if (!c.State.Equals(ConnectionState.Open))
                        c.Open();

                    cnx.Open();

                    string qry1 = "select \"idHotel\", \"nomHotel\", \"adrHotel\" from public.\"hotel\" where \"idHotel\" = 1";
                    NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                    var reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        // MessageBox.Show(reader.GetString(1));
                        lblNomHotel.Text = "Hotel " + reader1.GetString(1);
                    }


                    c.Close();

                }
            }*/

        }
    }
}
