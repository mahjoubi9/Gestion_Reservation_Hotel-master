using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Gestion_Hotel.Model;
using System.Windows.Forms;

namespace Gestion_Hotel.myForm
{
    public partial class consommationForm : Form
    {
        private String cc = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4};", "localhost", 5433, "postgres", "rasoulalah", "GestionHotel");
        private NpgsqlConnection cnxx;
        private NpgsqlCommand cmd;
        private String sql;
        private DataTable dt;
        public consommationForm()
        {
            InitializeComponent();
            cnxx = new NpgsqlConnection(cc);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void consommationForm_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void PouletCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PouletCb.Checked == true)
            {
                PouletTb.Enabled = true;
            }
            if (PouletCb.Checked == false)
            {
                PouletTb.Enabled = false;
                PouletTb.Text = "0";
            }
        }

        private void MargheritaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MargheritaCb.Checked == true)
            {
                MargheritaTb.Enabled = true;
            }
            if (MargheritaCb.Checked == false)
            {
                MargheritaTb.Enabled = false;
                MargheritaTb.Text = "0";
            }
        }

        private void FruitCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FruitCb.Checked == true)
            {
                FruitTb.Enabled = true;
            }
            if (FruitCb.Checked == false)
            {
                FruitTb.Enabled = false;
                FruitTb.Text = "0";
            }
        }

        private void ThonCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ThonCb.Checked == true)
            {
                ThonTb.Enabled = true;
            }
            if (ThonCb.Checked == false)
            {
                ThonTb.Enabled = false;
                ThonTb.Text = "0";
            }
        }

        private void VégétarienneCb_CheckedChanged(object sender, EventArgs e)
        {
            if (VégétarienneCb.Checked == true)
            {
                VégétarienneTb.Enabled = true;
            }
            if (VégétarienneCb.Checked == false)
            {
                VégétarienneTb.Enabled = false;
                VégétarienneTb.Text = "0";
            }
        }

        private void SchneckCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SchneckCb.Checked == true)
            {
                SchneckTb.Enabled = true;
            }
            if (SchneckCb.Checked == false)
            {
                SchneckTb.Enabled = false;
                SchneckTb.Text = "0";
            }

        }

        private void FruitsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FruitsCb.Checked == true)
            {
                FruitsTb.Enabled = true;
            }
            if (FruitsCb.Checked == false)
            {
                FruitsTb.Enabled = false;
                FruitsTb.Text = "0";
            }
        }

        private void MarocaineCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MarocaineCb.Checked == true)
            {
                MarocaineTb.Enabled = true;
            }
            if (MarocaineCb.Checked == false)
            {
                MarocaineTb.Enabled = false;
                MarocaineTb.Text = "0";
            }
        }

        private void RizCb_CheckedChanged(object sender, EventArgs e)
        {
            if (RizCb.Checked == true)
            {
                RizTb.Enabled = true;
            }
            if (RizCb.Checked == false)
            {
                RizTb.Enabled = false;
                RizTb.Text = "0";
            }
        }

        private void PoulpesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PoulpesCb.Checked == true)
            {
                PoulpesTb.Enabled = true;
            }
            if (PoulpesCb.Checked == false)
            {
                PoulpesTb.Enabled = false;
                PoulpesTb.Text = "0";
            }
        }

        private void NiçoiseCb_CheckedChanged(object sender, EventArgs e)
        {
            if (NiçoiseCb.Checked == true)
            {
                NiçoiseTb.Enabled = true;
            }
            if (NiçoiseCb.Checked == false)
            {
                NiçoiseTb.Enabled = false;
                NiçoiseTb.Text = "0";
            }
        }

        private void CrevettesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CrevettesCb.Checked == true)
            {
                CrevettesTb.Enabled = true;
            }
            if (CrevettesCb.Checked == false)
            {
                CrevettesTb.Enabled = false;
                CrevettesTb.Text = "0";
            }
        }

        private void DindeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (DindeCb.Checked == true)
            {
                DindeTb.Enabled = true;
            }
            if (DindeCb.Checked == false)
            {
                DindeTb.Enabled = false;
                DindeTb.Text = "0";
            }
        }

        private void AtunCb_CheckedChanged(object sender, EventArgs e)
        {
            if (AtunCb.Checked == true)
            {
                AtunTb.Enabled = true;
            }
            if (AtunCb.Checked == false)
            {
                AtunTb.Enabled = false;
                AtunTb.Text = "0";
            }
        }

        private void HeladoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HeladoCb.Checked == true)
            {
                HeladoTb.Enabled = true;
            }
            if (HeladoCb.Checked == false)
            {
                HeladoTb.Enabled = false;
                HeladoTb.Text = "0";
            }
        }

        private void HomardCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HomardCb.Checked == true)
            {
                HomardTb.Enabled = true;
            }
            if (HomardCb.Checked == false)
            {
                HomardTb.Enabled = false;
                HomardTb.Text = "0";
            }
        }

        private void HessCb_CheckedChanged(object sender, EventArgs e)
        {
            if (HessCb.Checked == true)
            {
                HessTb.Enabled = true;
            }
            if (HessCb.Checked == false)
            {
                HessTb.Enabled = false;
                HessTb.Text = "0";
            }
        }

        private void LuxeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LuxeCb.Checked == true)
            {
                LuxeTb.Enabled = true;
            }
            if (LuxeCb.Checked == false)
            {
                LuxeTb.Enabled = false;
                LuxeTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void OrangeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (OrangeCb.Checked == true)
            {
                OrangeTb.Enabled = true;
            }
            if (OrangeCb.Checked == false)
            {
                OrangeTb.Enabled = false;
                OrangeTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void AnanasCb_CheckedChanged(object sender, EventArgs e)
        {
            if (AnanasCb.Checked == true)
            {
                AnanasTb.Enabled = true;
            }
            if (AnanasCb.Checked == false)
            {
                AnanasTb.Enabled = false;
                AnanasTb.Text = "0";
            }
        }

        private void SugarcaneCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SugarcaneCb.Checked == true)
            {
                SugarcaneTb.Enabled = true;
            }
            if (SugarcaneCb.Checked == false)
            {
                SugarcaneTb.Enabled = false;
                SugarcaneTb.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }
        Double Dindeup = 20, Atunup = 20, Heladoup = 25, Homardup = 30, Hessup = 20, Luxeup = 25;
        Double Fruitsup = 40, Marocaineup = 26, Rizup = 30, Crevettesup = 20, Niçoiseup = 25, Poulpesup = 20;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTp.Text + " " + "SubTotal : " + Subtotallbl.Text + " Tax : " + Taxlbl.Text + " Grand Total : " + GrdTotallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));

        }

        private void Closelbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client clientSelected = new Client();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            using (NpgsqlConnection c = new NpgsqlConnection("server=localhost; port=5433;user id=postgres; password=rasoulalah; database=GestionHotel"))
            {
                
                if (!c.State.Equals(ConnectionState.Open))
                    c.Open();
                string qry1 = "select \"idCli\",\"nomCli\",\"prenomCli\",\"emailCli\" ,\"telCli\" ,\"prixconsommation\" from public.\"client\" where \"emailCli\"='" + gmailBox.Text + "' ";
                NpgsqlCommand cmd1 = new NpgsqlCommand(qry1, c);
                var reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    Client client = new Client(reader1.GetInt32(0), reader1.GetString(1), reader1.GetString(2), reader1.GetString(3), reader1.GetString(4), reader1.GetDouble(5));
                    // idCli = reader1.GetInt32(0);
                    clientSelected=client;

                }
                c.Close();
            }

            //MessageBox.Show(GrdTotallbl.Text);
            string valuesWithoutBrackets = GrdTotallbl.Text ;
            string[] values = valuesWithoutBrackets.Split(" ".ToCharArray());

            //values[0] = "6.5976512883340064"
            //values[1] = "53.011505757047068"
            clientSelected.prixconsommation = clientSelected.prixconsommation + Convert.ToDouble(values[1]);

                cnxx.Open();
                sql = @"select * from update_client('" + clientSelected.idCli + "','" + clientSelected.nomCli + "','" + clientSelected.prenomCli + "','" + clientSelected.emailCli + "','" + clientSelected.telCli + "','" + clientSelected.prixconsommation + "');";
                cmd = new NpgsqlCommand(sql, cnxx);
                cmd.ExecuteReader();
                MessageBox.Show("consommation effectue");
               
                cnxx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Poulettp = Pouletup * Convert.ToDouble(PouletTb.Text);
            Margheritatp = Margheritaup * Convert.ToDouble(MargheritaTb.Text);
            Thontp = Thonup * Convert.ToDouble(ThonTb.Text);
            Végétariennetp = Végétarienneup * Convert.ToDouble(VégétarienneTb.Text);
            Fruittp = Fruitup * Convert.ToDouble(FruitTb.Text);
            Schnecktp = Schneckup * Convert.ToDouble(SchneckTb.Text);

            Dindetp = Dindeup * Convert.ToDouble(PouletTb.Text);
            Atuntp = Atunup * Convert.ToDouble(MargheritaTb.Text);
            Heladotp = Heladoup * Convert.ToDouble(ThonTb.Text);
            Homardtp = Homardup * Convert.ToDouble(VégétarienneTb.Text);
            Hesstp = Hessup * Convert.ToDouble(FruitTb.Text);
            Luxetp = Luxeup * Convert.ToDouble(SchneckTb.Text);

            Fruitstp = Fruitsup * Convert.ToDouble(PouletTb.Text);
            Marocainetp = Marocaineup * Convert.ToDouble(MargheritaTb.Text);
            Riztp = Rizup * Convert.ToDouble(ThonTb.Text);
            Crevettestp = Crevettesup * Convert.ToDouble(VégétarienneTb.Text);
            Niçoisetp = Niçoiseup * Convert.ToDouble(FruitTb.Text);
            Poulpestp = Poulpesup * Convert.ToDouble(SchneckTb.Text);

            Orangetp = orangeup * Convert.ToDouble(OrangeTb.Text);
            Watertp = waterup * Convert.ToDouble(WaterTb.Text);
            Colatp = colaup * Convert.ToDouble(ColaTb.Text);
            Ananastp = chocolateup * Convert.ToDouble(AnanasTb.Text);
            Sugarcanetp = pancakesup * Convert.ToDouble(SugarcaneTb.Text);
            Teatp = teaup * Convert.ToDouble(TeaTb.Text);
            ReceiptTp.Clear();
            Subtotal = 0;
            ReceiptTp.AppendText(Environment.NewLine);
            ReceiptTp.AppendText("\tCODEESPACE RESTAURANT " + Environment.NewLine);
            ReceiptTp.AppendText("\t***************************" + Environment.NewLine);
            ReceiptTp.AppendText("\t\t " + Datelbl.Text + Environment.NewLine);

            if (PouletCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Poulet:\t:" + Poulettp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Poulettp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (MargheritaCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Margherita:\t:" + Margheritatp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Margheritatp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (ThonCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Thon:\t:" + Thontp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Thontp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (VégétarienneCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Végétarienne:\t:" + Végétariennetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Végétariennetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (FruitCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Fruit:\t:" + Fruittp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Fruittp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (SchneckCb.Checked == true)
            {
                ReceiptTp.AppendText("\tPizza Schneck:\t:" + Schnecktp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Schnecktp;
                Subtotallbl.Text = " " + Subtotal;
            }


            if (FruitsCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Fruits:\t:" + Fruitstp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Fruitstp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (MarocaineCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Marocaine:\t:" + Marocainetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Marocainetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (RizCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Riz:\t:" + Riztp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Riztp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (CrevettesCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Crevettes:\t:" + Crevettestp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Crevettestp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (NiçoiseCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Niçoise:\t:" + Niçoisetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Niçoisetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (PoulpesCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSalad Poulpes:\t:" + Poulpestp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Poulpestp;
                Subtotallbl.Text = " " + Subtotal;
            }


            if (DindeCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Dinde:\t:" + Dindetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Dindetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (AtunCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Atun:\t:" + Atuntp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Atuntp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (HeladoCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Helado:\t:" + Heladotp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Heladotp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (HomardCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Homard:\t:" + Homardtp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Homardtp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (HessCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Hess:\t:" + Hesstp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Hesstp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (LuxeCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSandwich Luxe:\t:" + Luxetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Luxetp;
                Subtotallbl.Text = " " + Subtotal;
            }





            if (OrangeCb.Checked == true)
            {
                ReceiptTp.AppendText("\tOrange:\t:" + Orangetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Orangetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                ReceiptTp.AppendText("\tWater:\t:" + Watertp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Watertp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                ReceiptTp.AppendText("\tCola:\t:" + Colatp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Colatp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (AnanasCb.Checked == true)
            {
                ReceiptTp.AppendText("\tChocolate:\t:" + Ananastp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Ananastp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (SugarcaneCb.Checked == true)
            {
                ReceiptTp.AppendText("\tSugarcane:\t:" + Sugarcanetp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Sugarcanetp;
                Subtotallbl.Text = " " + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                ReceiptTp.AppendText("\tTea:\t:" + Teatp + " DH" + Environment.NewLine);
                Subtotal = Subtotal + Teatp;
                Subtotallbl.Text = " " + Subtotal;
            }
            tax = Subtotal * 0.16;
            grdTotal = Subtotal + tax;
            Taxlbl.Text = "DH " + tax;
            GrdTotallbl.Text = "DH " + grdTotal;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PouletCb.Checked = false;
            MargheritaCb.Checked = false;
            ThonCb.Checked = false;
            VégétarienneCb.Checked = false;
            FruitCb.Checked = false;
            SchneckCb.Checked = false;

            FruitsCb.Checked = false;
            MarocaineCb.Checked = false;
            RizCb.Checked = false;
            CrevettesCb.Checked = false;
            NiçoiseCb.Checked = false;
            PouletCb.Checked = false;

            DindeCb.Checked = false;
            AtunCb.Checked = false;
            HeladoCb.Checked = false;
            HomardCb.Checked = false;
            HessCb.Checked = false;
            LuxeCb.Checked = false;

            OrangeCb.Checked = false;
            WaterCb.Checked = false;
            ColaCb.Checked = false;
            AnanasCb.Checked = false;
            SugarcaneCb.Checked = false;
            TeaCb.Checked = false;
        }

        Double Pouletup = 10, Margheritaup = 70, Fruitup = 80, Thonup = 20, Schneckup = 100, Végétarienneup = 50;
        Double orangeup = 30, waterup = 10, colaup = 10, chocolateup = 20, pancakesup = 30, teaup = 10;


        Double Poulettp, Margheritatp, Fruittp, Thontp, Schnecktp, Végétariennetp;
        Double Dindetp, Atuntp, Heladotp, Homardtp, Hesstp, Luxetp;
        Double Fruitstp, Marocainetp, Riztp, Crevettestp, Niçoisetp, Poulpestp;
        Double Orangetp, Watertp, Colatp, Ananastp, Sugarcanetp, Teatp;
        Double Subtotal = 0, tax = 0, grdTotal = 0;
    }
}
