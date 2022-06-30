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
    public partial class addHotelsForm : Form
    {
        //NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "GestionHotel");
        private NpgsqlConnection cnx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public addHotelsForm()
        {
            InitializeComponent();
            cnx = new NpgsqlConnection(cc);
        }

        private void addHotelsForm_Load(object sender, EventArgs e)
        {
         
        }

        private void ajouteHotelbtn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            //l'ajout de la commande
            sql = @"INSERT INTO hotel (nomhotel,adrhotel,categorie) VALUES ('" + nomHotelslbl.Text + "','" + adressBox.Text + "','" + categorieHotelcomboBox.Text + "');";
           // sql = @"INSERT INTO hotel('nomHotel','adrHotel') VALUES ('" + nomHotelslbl.Text + "','" +adrHotelcomboBox.Text + "');";
            cmd = new NpgsqlCommand(sql, cnx);
            cmd.ExecuteReader();
            MessageBox.Show("Ajouté Hotel avec success");
            this.Hide();
        }
    }
}
