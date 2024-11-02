using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestApp
{

    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            Date2lbl.Text = DateTime.Now.ToString("dd MMM yy");
            timer1.Start();
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FriesCb.Checked == true)
            {
                FriesTbb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTbb.Enabled = false;
                FriesTbb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTbb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTbb.Enabled = false;
                BurgerTbb.Text = "0";
            }
        }

        private void SaladCb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SaladCb.Checked == true)
            {
                SaladTbb.Enabled = true;
            }
            if (SaladCb.Checked == false)
            {
                SaladTbb.Enabled = false;
                SaladTbb.Text = "0";
            }
        }

        


        

        

        
        

        

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTbb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTbb.Enabled = false;
                SandwichTbb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTbb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTbb.Enabled = false;
                ChickenTbb.Text = "0";
            }
        }

        private void NoodlesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (NoodlesCb.Checked == true)
            {
                NoodlesTbb.Enabled = true;
            }
            if (NoodlesCb.Checked == false)
            {
                NoodlesTbb.Enabled = false;
                NoodlesTbb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTbb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTbb.Enabled = false;
                TeaTbb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTbb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTbb.Enabled = false;
                ColaTbb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTbb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTbb.Enabled = false;
                WaterTbb.Text = "0";
            }
        }

        private void ChocoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocoCb.Checked == true)
            {
                ChocoTbb.Enabled = true;
            }
            if (ChocoCb.Checked == false)
            {
                ChocoTbb.Enabled = false;
                ChocoTbb.Text = "0";
            }
        }

        private void CakesCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CakesCb.Checked == true)
            {
                CakesTbb.Enabled = true;
            }
            if (CakesCb.Checked == false)
            {
                CakesTbb.Enabled = false;
                CakesTbb.Text = "0";
            }
        }

        private void LassiCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LassiCb.Checked == true)
            {
                LassiTbb.Enabled = true;
            }
            if (LassiCb.Checked == false)
            {
                LassiTbb.Enabled = false;
                LassiTbb.Text = "0";
            }
        }

        private void Closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //Declare unit price for different meals and drinks
        double friesup = 50, burgerup = 80, saladup = 100, sandwichup = 75, chickenup = 120;
        double noodlesup = 90, teaup = 15, colaup = 20, waterup = 10, chocolateup = 25;

        //reset button
        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SaladCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            NoodlesCb.Checked = false;
            TeaCb.Checked = false;
            ColaCb.Checked = false;
            WaterCb.Checked = false;
            ChocoCb.Checked = false;
            CakesCb.Checked = false;
            LassiCb.Checked = false;

            Subtotallbl.Text = "Rs" + 0;
            Grdtotallbl.Text = "Rs" + 0;
            taxlbl.Text = "Rs" + 0;
            RecieptTb.Clear();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
    RecieptTb.Text ,
    new Font("Century Gothic", 12, FontStyle.Regular),
    Brushes.Black,
    new Point(130, 130));

        }

        //print reciept
        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        double cakeup = 30, lassiup = 25;

        //Declare variable to hold total price for each drinks and meals
        double friestp, burgertp, saladtp, sandwichtp, chickentp, noodlestp;
        double teatp, colatp, watertp, chocolatetp, caketp, lassitp;
        double Subtotal = 0;
        double tax = 0;
        double GrdTotal = 0;

        //add button
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(FriesTbb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTbb.Text);
            saladtp = saladup * Convert.ToDouble(SaladTbb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTbb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTbb.Text);
            noodlestp = noodlesup * Convert.ToDouble(NoodlesTbb.Text);

            //Let do the same for drinks and desserts
            teatp = teaup * Convert.ToDouble(TeaTbb.Text);
            colatp = colaup * Convert.ToDouble(ColaTbb.Text);
            watertp = waterup * Convert.ToDouble(WaterTbb.Text);
            chocolatetp = chocolateup * Convert.ToDouble(ChocoTbb.Text);
            caketp = cakeup * Convert.ToDouble(CakesTbb.Text);
            lassitp = lassiup * Convert.ToDouble(LassiTbb.Text);

            RecieptTb.Clear();
            Subtotal = 0;
           
            RecieptTb.AppendText(Environment.NewLine);
            RecieptTb.AppendText(Date2lbl.Text+"\t\tFOSS RESTAURANT\t\t" + Datelbl.Text+ Environment.NewLine);
            RecieptTb.AppendText("\t\t\t***************************" + Environment.NewLine);

            if (FriesCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tFries:\t" + friestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (BurgerCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SaladCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tSalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (SandwichCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tSandwich:" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChickenCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (NoodlesCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tNoodles:\t" + noodlestp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + noodlestp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TeaCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ColaCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tCola:\t" + colatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + colatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (WaterCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tWater:\t" + watertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + watertp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (ChocoCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tChocolate:" + chocolatetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CakesCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tCake:\t" + caketp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + caketp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (LassiCb.Checked == true)
            {
                RecieptTb.AppendText("\t\t\tLassi:\t" + lassitp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + lassitp;
                Subtotallbl.Text = "" + Subtotal;
            }
            tax = Subtotal * 0.18;
            GrdTotal = Subtotal+ tax;
            taxlbl.Text ="Rs"+ tax;
            Grdtotallbl.Text = "Rs" + GrdTotal;
            RecieptTb.AppendText("\t\t\t**************************\t" + Environment.NewLine);
            RecieptTb.AppendText("\t\t\tSubtotal:\t" + Subtotal + "Rs" + Environment.NewLine);
            RecieptTb.AppendText("\t\t\tTax:\t" + tax + "Rs" + Environment.NewLine);
            RecieptTb.AppendText("\t\t\tGrandtotal:" + GrdTotal + "Rs" + Environment.NewLine);



        }

        private void RecieptTb_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
