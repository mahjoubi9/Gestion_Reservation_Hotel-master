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
namespace Gestion_Hotel.UC
{
    public partial class ucHotelOne : UserControl
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "GestionHotel");
        private NpgsqlConnection cnxx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        //---- numéro de la chambre --------
        public int NumHotel { get; set; }
        public string NomHotel { get; set; }
        public ucHotelOne()
        {
            InitializeComponent();
            cnxx = new NpgsqlConnection(cc);
            // ucHotel_Load();
        }

        private void nomHotel_Click(object sender, EventArgs e)
        {


        }
        private void ucHotel_Load(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucHotelOne_Load(object sender, EventArgs e)
        {
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

                }
                nomHotel.Text = NomHotel.ToString();
                numHotel.Text = NumHotel.ToString();
               //
               //MessageBox.Show("ucHotelOne " + NomHotel.ToString());

                cnx.Close();
            }
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(numHotel.ToString()) ;
            cnxx.Open();
                sql = @"DELETE FROM hotel WHERE idhotel= (" + numHotel.ToString() + ");";
                cmd = new NpgsqlCommand(sql, cnxx);
                cmd.ExecuteReader();
                MessageBox.Show("hotel suppririmé avec succées");
                //this.form1.SelectionServeurs();
                cnxx.Close();
           
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("View");
            Form1 form = new Form1();
            
            //form.ShowDialog();
            NumHotel = Convert.ToInt32(this.numHotel.Text);
            form.idHotelSelected = NumHotel;
            //MessageBox.Show(numChambre);
            // ReservationForm resForm = new ReservationForm();
            // resForm.numRoom = Convert.ToInt32(numChambre);
            form.Show();


        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addChambreForm form = new addChambreForm();
            form.idHotelSelected = Int32.Parse(numHotel.Text);
            form.Show();

        }

        private void modifieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifieHotelForm form = new modifieHotelForm(nomHotel.Text);
            form.nomhotelselected = nomHotel.Text;
            form.idhotelSelected = Int32.Parse(numHotel.Text);
            form.Show();
        }
    }
}
