using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Gestion_Hotel.Model;
using Gestion_Hotel.myForm;
using Gestion_Hotel.UC;

namespace Gestion_Hotel
{
    public partial class hotelscs : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");

        public hotelscs()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hotelscs_Load(object sender, EventArgs e)
        {
            //------------------ Remplissage de la liste des hotels ------------------
            using (cnx)
            {
                cnx.Open();
                string qry = "select \"idhotel\", \"nomhotel\", \"adrhotel\" from public.\"hotel\" ";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                var reader = cmd.ExecuteReader();

                var listHotels = new List<hotel>();


                while (reader.Read())
                {

                    listHotels.Add(new hotel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));

                   // MessageBox.Show(reader.GetString(1));
                }

                //------------------ Remplisage du panel par ucRoom --------------------
                flowLayoutPanel1.Controls.Clear();

                foreach (hotel item in listHotels)
                {
                    //MessageBox.Show(item.NumChambre.ToString() + " - " + item.prixChambre.ToString());

                    ucHotelOne ucHotelone = new ucHotelOne();
                    // Button btn = new Button();
                    // btn.Name = "helllo";
                    // btn.Text = "Bonjour";
                    // btn.Visible = true;

                    ucHotelone.NumHotel = item.idHotel;
                    ucHotelone.NomHotel = item.nomHotel;
                   // MessageBox.Show("id " + ucHotelone.NumHotel);

                    flowLayoutPanel1.Controls.Add(ucHotelone);

                    this.Controls.Add(flowLayoutPanel1);

                }
                flowLayoutPanel1.Visible = true;

                this.panel1.Controls.Add(this.flowLayoutPanel1);
                cnx.Close();

                //------------ sélection du nom de l'hotel qui a l'id = 1 -------------
                using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                {
                    if (!c.State.Equals(ConnectionState.Open))
                        c.Open();

                    cnx.Open();

                    string qry1 = "select \"idhotel\", \"nomhotel\", \"adrhotel\" from public.\"hotel\" where \"idhotel\" = 1";
                    NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                    var reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        //MessageBox.Show(reader.GetString(1));
                      //  lblhotelss.Text = "Hotel " + reader1.GetString(1);
                    }


                    c.Close();

                }
            }
        }

        private void addHotelbtn_Click(object sender, EventArgs e)
        {
            addHotelsForm frm = new addHotelsForm();
            frm.Show();
        }

        private void lblhotelss_Click(object sender, EventArgs e)
        {

        }

        private void consommationbtn_Click(object sender, EventArgs e)
        {
            consommationForm form = new consommationForm();
            form.Show();
        }
    }
}
