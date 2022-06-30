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
    public partial class Form1 : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel");
        public int idHotelSelected;
        public Form1()
        {
            InitializeComponent();
        }

        private void ucHotel1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //------------------ Remplissage de la liste des chambres ------------------
            using (cnx)
            {
                cnx.Open();
                /*     sql = @"select * from commande where num_tab=" + idTable + ";";
                     cmd = new NpgsqlCommand(sql, cnx);
                     dt = new DataTable();
                     dt.Load(cmd.ExecuteReader());
                     cnx.Close();
                     if (dt.Rows.Count > 0)
                     {
                         foreach (DataRow row in dt.Rows)
                         {

                             if (row["date_comm"].ToString() != date.Value.Day + "-" + date.Value.Month + "-" + date.Value.Year)
                             {
                                 a = 1;
                             }
                             else
                             {
                                 a = 0;
                                 break;
                             }
                         }
                     }*/
                //MessageBox.Show(idHotelSelected.ToString());
                //   string qry = @"select * from chambre where idhotel=" + idHotelSelected + ";"; 
                string qry = "select \"idChambre\", \"numChambre\", \"prixChambre\", \"idHotel\" from public.\"chambre\" ";
               // string qry = "select \"idChambre\", \"numChambre\", \"prixChambre\"   from public.\"chambre\" where \"idhotel\"= @idHotelSelected";

                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                var reader = cmd.ExecuteReader();

                var listChambres = new List<Chambre>();


                while (reader.Read())
                {
                    if (reader.GetInt32(3)==idHotelSelected)
                    {
                        listChambres.Add(new Chambre(reader.GetInt32(1), reader.GetDouble(2)));
                       // MessageBox.Show(reader.GetDouble(2).ToString());
                    }
                    
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
                   // MessageBox.Show(item.NumChambre.ToString());
                }

                cnx.Close();

                //------------ sélection du nom de l'hotel qui a l'id = 1 -------------
                using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
                {
                    if (!c.State.Equals(ConnectionState.Open))
                        c.Open();

                    cnx.Open();

                    string qry1 = "select \"idhotel\", \"nomhotel\", \"adrhotel\", \"categorie\", \"tel\" from public.\"hotel\" where \"idhotel\" = " + idHotelSelected;
                    NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                    var reader1 = cmd1.ExecuteReader();

                    while (reader1.Read())
                    {
                        // MessageBox.Show(reader.GetString(1));
                        lblNomHotel.Text =reader1.GetString(1);
                        adresslbl.Text =reader1.GetString(2);
                        categorielbl.Text =reader1.GetString(3);
                        tellbl.Text =reader1.GetString(4);
                    }


                    c.Close();

                }
            }
        }

        private void addHotelbtn_Click(object sender, EventArgs e)
        {

        }

        private void ajouteChambrelbtn_Click(object sender, EventArgs e)
        {
            addChambreForm form = new addChambreForm();
            form.idHotelSelected = idHotelSelected;
            form.Show();
        }

        private void modifiebtn_Click(object sender, EventArgs e)
        {
            modifieHotelForm form = new modifieHotelForm(lblNomHotel.Text, adresslbl.Text, categorielbl.Text, tellbl.Text);
            form.nomhotelselected = lblNomHotel.Text;
            form.idhotelSelected = idHotelSelected;
            form.Show();
        }
    }
}
