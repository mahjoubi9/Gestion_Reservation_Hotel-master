using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Gestion_Hotel.myForm
{
    public partial class addChambreForm : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        public int idHotelSelected;
        public addChambreForm()
        {
            InitializeComponent();
        }

        private void ajouteChambrelbtn_Click(object sender, EventArgs e)
        {
            cnx.Open();

            //------------ Insertion du client -------------------------------
            string qry = "insert into public.\"chambre\" (\"numChambre\", \"prixChambre\", \"idHotel\", \"category\") Values ('" + Int32.Parse(numChambrebox.Text) + "', '" + Int32.Parse(prixChambrebox.Text) + "', '" + idHotelSelected + "', '" + categoryChambrecomboBox.Text + "') ";
            NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouté Chambre avec success");
            this.Hide();
        }
    }
}
