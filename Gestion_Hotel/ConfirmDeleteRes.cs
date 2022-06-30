using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Hotel
{
    public partial class ConfirmDeleteRes : Form
    {
        public int idRoom { get; set; }

        public ConfirmDeleteRes()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string gmail = txtGmail.Text;

            int idCli = 0;
            //---------------- Selection de l'id du client inséré ---------------------
            using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
            {
                if (!c.State.Equals(ConnectionState.Open))
                    c.Open();
                string qry1 = "select \"idCli\" from public.\"client\" where \"emailCli\"='"+ txtGmail.Text +"'";
                NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                var reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    
                    idCli = reader1.GetInt32(0);
                    //MessageBox.Show(idCli.ToString());
                    
                }
                if (idCli == 0)
                {
                    MessageBox.Show("Vous n'avez aucune réservation dans cet hotel!");
                }

                //---------- Modification de la table réservation -------------
                using (NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                {
                    if (!cnx.State.Equals(ConnectionState.Open))
                        cnx.Open();
                    //MessageBox.Show(idCli + "--" + idRoom);
                    string rq = "update public.\"reservation\" set \"dateFinRes\"='" + DateTime.UtcNow.ToString("yyyy-MM-dd") + "', \"liberer\"='" + true + "' where \"idClient\" = '" + idCli + "' and  \"idChambre\"='" + idRoom + "' ";
                    NpgsqlCommand cm = new NpgsqlCommand(rq, cnx);
                    cm.ExecuteNonQuery();
                    cnx.Close();
                }
                c.Close();

                this.Hide();
            }
        }
    }
}
