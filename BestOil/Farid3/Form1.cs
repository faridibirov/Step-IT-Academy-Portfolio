namespace Farid3
{
    public partial class Form1 : Form
    {


        double[] gasprice = { 1.0, 2.0, 2.3, 0.8 };

        double qhot, qham, qfries, qcola = 0;

        double cafetprice = 0;

        double gastprice = 0;

        int timer = 0;

        double cashier;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxoil_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int i = 0; i < 4; i++)
            {
                if (comboBoxoil.SelectedIndex == i)
                {
                    textbfuelprice.Text = $"{gasprice[i]}";
                    qunatityoil.Text = "0";
                    sumoil.Text = "0";

                }
            }


        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioqunatity.Checked)
            {
                qunatityoil.Enabled = true;
                sumoil.Text = "0";
                sumoil.Enabled = false;
                totaloillabel.Text = "0";
                liazn.Text = "AZN";
                groupBox2.Text = "К оплате";
            }

            if (radioSumm.Checked)
            {
                sumoil.Enabled = true;
                qunatityoil.Text = "0";
                qunatityoil.Enabled = false;
                totaloillabel.Text = "0";
                liazn.Text = "Литров";
                groupBox2.Text = "К выдаче";

            }
        }

        private void Radio_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (radioqunatity.Checked)
                {
                    if (qunatityoil.Text == "")
                    {
                        totaloillabel.Text = "0";
                    }

                    else
                    {
                        totaloillabel.Text = $"{Math.Round((Double.Parse(qunatityoil.Text) * Double.Parse(textbfuelprice.Text)),2)  }";
                        liazn.Text = "AZN";
                        gastprice = Double.Parse(totaloillabel.Text);
                    }
                }


                if (radioSumm.Checked)
                {
                    if (sumoil.Text == "")
                    {
                        totaloillabel.Text = "0";
                    }

                    else
                    {
                        totaloillabel.Text = $"{Math.Round((Double.Parse(sumoil.Text) / Double.Parse(textbfuelprice.Text)), 2) }";
                        liazn.Text="Литров";
                        gastprice = Double.Parse(sumoil.Text);
                    }
                }
            }

            catch (FormatException)
            {
                sumoil.Text = "0";
                qunatityoil.Text = "0";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxoil.SelectedIndex = 0;
            textbfuelprice.Text = $"{gasprice[0]}";


        }

        private void hotdogcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdogcheckbox.Checked)
            {
                hotdogtext.Enabled = true;
            }

            else
            {
                hotdogtext.Enabled = false;
                cafetprice -= (double.Parse(hotprice.Text) * qhot);
                qhot = 0;
                hotdogtext.Text = "0";
                cafetotal.Text = Math.Round(cafetprice, 2).ToString();
            }
        }

        private void hamburgercbox_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgercbox.Checked)
            {
                hamburgertext.Enabled = true;
            }

            else
            {
                hamburgertext.Enabled = false;
                cafetprice -= (double.Parse(hamprice.Text) * qham);
                qham = 0;
                hamburgertext.Text = "0";
                cafetotal.Text = Math.Round(cafetprice, 2).ToString();
            }

        }



        private void friescbox_CheckedChanged(object sender, EventArgs e)
        {
            if (friescbox.Checked)
            {
                friestext.Enabled = true;
            }

            else
            {
                friestext.Enabled = false;
                cafetprice -= (double.Parse(friesprice.Text) * qfries);
                qfries = 0;
                friestext.Text = "0";
                cafetotal.Text = Math.Round(cafetprice, 2).ToString();
            }
        }



        private void colacbox_CheckedChanged(object sender, EventArgs e)
        {
            if (colacbox.Checked)
            {
                colatext.Enabled = true;
            }

            else
            {
                colatext.Enabled = false;
                cafetprice -= (double.Parse(colaprice.Text) * qcola);
                qcola = 0;
                colatext.Text = "0";
                cafetotal.Text = Math.Round(cafetprice, 2).ToString();
            }
        }



        private void hotdogtext_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (hotdogtext.Text != "")
                {
                    if (double.Parse(hotdogtext.Text) != qhot)
                    {
                        cafetprice -= (double.Parse(hotprice.Text) * qhot);
                        qhot = double.Parse(hotdogtext.Text);
                        cafetprice += (double.Parse(hotprice.Text) * qhot);
                        cafetotal.Text = Math.Round(cafetprice, 2).ToString();
                    }

                }


            }
            catch (FormatException)
            {
                hotdogtext.Text = "0";
              
            }
        }

       

        private void hamburgertext_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (hamburgertext.Text != "")
                {
                    if (double.Parse(hamburgertext.Text) != qham)
                    {
                        cafetprice -= (double.Parse(hamprice.Text) * qham);
                        qham = double.Parse(hamburgertext.Text);
                        cafetprice += (double.Parse(hamprice.Text) * qham);
                        cafetotal.Text = Math.Round(cafetprice, 2).ToString();
                    }

                }

            }
            catch (FormatException)
            {
                hamburgertext.Text="0";
            }
        }

     

        private void friestext_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (friestext.Text != "")
                {
                    if (double.Parse(friestext.Text) != qfries)
                    {
                        cafetprice -= (double.Parse(friesprice.Text) * qfries);
                        qfries = double.Parse(friestext.Text);
                        cafetprice += (double.Parse(friesprice.Text) * qfries);
                        cafetotal.Text = Math.Round(cafetprice, 2).ToString();
                    }

                }

            }
            catch (FormatException)
            {
                friestext.Text="0";
            }
        }

       

        private void colatext_TextChanged(object sender, EventArgs e)
        {
            try
            {


                if (colatext.Text != "")
                {
                    if (double.Parse(colatext.Text) != qcola)
                    {
                        cafetprice -= (double.Parse(colaprice.Text) * qcola);
                        qcola = double.Parse(colatext.Text);
                        cafetprice += (double.Parse(colaprice.Text) * qcola);
                        cafetotal.Text = Math.Round(cafetprice, 2).ToString();
                    }

                }

            }
            catch (FormatException)
            {
                colatext.Text="0";
            }
        }

        private void overallbutton_Click(object sender, EventArgs e)
        {

            overalltext.Text = $"{Math.Round((gastprice + cafetprice), 2)} AZN";
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;

            if (timer==5)
            {
                var result = MessageBox.Show("Завершить продажу для этого покупателя?", "Завершение покупки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cashier += cafetprice + gastprice;
                    totaloillabel.Text = "0";
                    cafetotal.Text = "0";
                    overalltext.Text = "0";
                    qunatityoil.Text = "0";
                    sumoil.Text = "0";
                    hotdogcheckbox.Checked = false;
                    hamburgercbox.Checked = false;
                    friescbox.Checked = false;
                    colacbox.Checked = false;
                    timer = 0;
                    timer1.Stop();
                }

                else
                    timer = 0;

            }

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общая сумма за {DateTime.Today.ToShortDateString()} равняется {cashier} AZN", "Закрытие кассы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}