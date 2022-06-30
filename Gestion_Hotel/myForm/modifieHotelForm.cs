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
namespace Gestion_Hotel.myForm
{
    public partial class modifieHotelForm : Form
    {
        //NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "GestionHotel");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public int idhotelSelected;
        public string nomhotelselected;
        public string categoriehotelselected;
        private string nomhotelselected1;

        public modifieHotelForm()
        {
            InitializeComponent();
            cnx = new NpgsqlConnection(cc);
            //MessageBox.Show(nomhotelselected);
            nomHotelsBox.Text = nomhotelselected;
            categorieHotelcomboBox.Text = categoriehotelselected;
        }

        public modifieHotelForm(string nomhotelselected1, string adress, string categorie, string tel)
        {
            InitializeComponent();
            cnx = new NpgsqlConnection(cc);
            this.nomhotelselected = nomhotelselected1;
            adressBox.Text = adress;
            categorieHotelcomboBox.Text = categorie;
            telBox.Text = tel;
            nomHotelsBox.Text = nomhotelselected;

        }
        public modifieHotelForm(string nomhotelselected1)
        {
            InitializeComponent();
            cnx = new NpgsqlConnection(cc);
            this.nomhotelselected = nomhotelselected1;
       
            nomHotelsBox.Text = nomhotelselected;

        }

        private void ajouteHotelbtn_Click(object sender, EventArgs e)
        {

            cnx.Open();
            sql = @"select * from update_hotel(" + idhotelSelected + ",'" + nomHotelsBox.Text + "','" + adressBox.Text + "','" + categorieHotelcomboBox.Text + "','" + telBox.Text + "');";
            cmd = new NpgsqlCommand(sql, cnx);
            cmd.ExecuteReader();
            MessageBox.Show("hotel modifié avec succées");
            cnx.Close();


          /*  cnx.Open();
            //l'ajout de la commande
            sql = @"UPDATE INTO hotel (nomhotel,adrhotel,categorie) VALUES ('" + nomHotelslbl.Text + "','" + adressBox.Text + "','" + categorieHotelcomboBox.Text + "');";
            // sql = @"INSERT INTO hotel('nomHotel','adrHotel') VALUES ('" + nomHotelslbl.Text + "','" +adrHotelcomboBox.Text + "');";
            cmd = new NpgsqlCommand(sql, cnx);
            cmd.ExecuteReader();
            MessageBox.Show("Ajouté Hotel avec success");*/
            this.Hide();
        }
    }
}
