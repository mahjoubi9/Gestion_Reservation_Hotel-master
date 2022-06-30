using Gestion_Hotel.Model;
using Gestion_Hotel.UC;
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
    public partial class ReservationForm : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        public int numRoom { get; set; }
        public static List<Reservation> MyList { get; set; }

        public ReservationForm()
        {
            InitializeComponent();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            using (cnx)
            {
                cnx.Open();

                //------------ Insertion du client -------------------------------
                string qry = "insert into public.\"client\" (\"nomCli\", \"prenomCli\", \"telCli\", \"emailCli\") Values ('" + txtNom.Text + "', '" + txtPrenom.Text + "', '" + txtTel.Text + "', '" + txtEmail.Text + "') ";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                cmd.ExecuteNonQuery();


                int idCli = 0;
                //---------------- Selection de l'id du client inséré ---------------------
                using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                {
                    if (!c.State.Equals(ConnectionState.Open))
                        c.Open();
                    string qry1 = "select \"idCli\" from public.\"client\" where \"nomCli\"='" + txtNom.Text + "' and  \"telCli\"='" + txtTel.Text + "' and  \"emailCli\"='" + txtEmail.Text + "' ";
                    NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                    var reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        idCli = reader1.GetInt32(0);

                    }
                    c.Close();
                }

                //--------------- Selection de l'id de la chambre qu'on veut réserver ---------------
                string qry2 = "select \"idChambre\" from public.\"chambre\" where  \"numChambre\"='" + numRoom + "' ";
                NpgsqlCommand cmd2 = new NpgsqlCommand(qry2, cnx);
                var reader = cmd2.ExecuteReader();


                int idRoom = 0;

                while (reader.Read())
                {
                    idRoom = reader.GetInt32(0);
                }
                reader.Close();
                
                //------------ Selection des réservations ----------
                string qry3 = "select \"dateDebutRes\",  \"idClient\", \"idChambre\", \"liberer\" from public.\"reservation\" ";
                NpgsqlCommand cmd3 = new NpgsqlCommand(qry3, cnx);
                var reader3 = cmd3.ExecuteReader();

                var listeRes = new List<Reservation>();

                while (reader3.Read())
                {
                    listeRes.Add(new Reservation(reader3.GetDateTime(0),  reader3.GetInt32(1), reader3.GetInt32(2), reader3.GetBoolean(3)));
                }
                reader3.Close();
                MyList = listeRes;

                Boolean isReserved = false;
                
                //----------- Boucle sur toutes les réservations -----------
                foreach (Reservation item in listeRes)
                {
                    //MessageBox.Show(item.dateDebutRes.ToString() + " - " + item.dateFinRes.ToString() + " - " + item.idChambre.ToString());
                    if(idRoom == item.idChambre)
                    {
                        
                        if (item.liberer == false)
                        {
                                //MessageBox.Show("Merci de chosir une autre date ! Cette chambre est réservée. de " + item.dateDebutRes.ToString() + " à " + item.dateFinRes.ToString());
                                MessageBox.Show("Merci de choisir une autre date ! Cette chambre est réservée." );
                            isReserved = true;
                            break;
                        }
                        else
                        {
                            isReserved = false;
                        }
                    }
                    else
                    {
                        isReserved = false;
                    }

                }

                if (!isReserved)
                {
                    //MessageBox.Show("La chambre n'est pas encore réservé");
                    //---------------insertion d'une réservation ---------------------------
                    using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                    {
                        if (!c.State.Equals(ConnectionState.Open))
                            c.Open();

                        // string qry4 = "insert into public.\"reservation\" (\"dateDebutRes\", \"dateFinRes\", \"idClient\", \"idChambre\", \"liberer\") Values ('" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' , '" + dateTimePicker2.Value.Date.ToString("yyyy-MM-dd") + "' ,  '" + idCli + "', '" + idRoom + "', '"+ false +"')";

                        string qry4 = "insert into public.\"reservation\" (\"dateDebutRes\",  \"idClient\", \"idChambre\", \"liberer\") Values ('" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' ,  '" + idCli + "', '" + idRoom + "', '" + false + "')";

                        NpgsqlCommand cmd4 = new NpgsqlCommand(qry4, c);

                        cmd4.ExecuteNonQuery();
                        c.Close();
                    }
                }

                
                cnx.Close();
                
                this.Hide();
            }
           
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
