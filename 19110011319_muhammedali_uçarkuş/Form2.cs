using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19110011319_muhammedali_uçarkuş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 yeni1 = new Form1();
            yeni1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {

            
            int ilkdeger = 0;
            int sondeger = 0;
            int tuketim = 0;
            double tutar = 0.0;

            DateTime ilk = dateTimePicker1.Value;
            DateTime son = dateTimePicker2.Value;
            System.TimeSpan zaman;
            zaman = son.Subtract(ilk);
            int toplamgun = Convert.ToInt32(zaman.TotalDays);
            listBoxtarih.Items.Add(toplamgun.ToString()+" Gün");






            ilkdeger = Convert.ToInt32(textBox1.Text);
            sondeger = Convert.ToInt32(textBox2.Text);
            tuketim = sondeger - ilkdeger;
            switch(comboBoxTarife.SelectedIndex)
            {
                case 1:
                    tutar=tuketim* 0.3976;
                    break;
                case 2:
                    tutar = tuketim * 0.5991;

                    break;
            }





        // TEK CİFT TARİFE   
               
            string tarife = "";
            if
               (comboBoxTarife.Text == " TEK TERİMLİ")
            {


            }

            else if

                 (comboBoxTarife.Text == "ÇİFT TERİMLİ")
               {

          
                }

            if (checkBoxTek.Checked==true)
                {
                tarife = tarife + "TEK TERİMLİ";
            
            }
            if (checkBoxçift.Checked == true)
            {
                tarife = tarife + "ÇİFT TERİMLİ";

            }
            listBoxAdsoyad.Items.Add(textBoxAdsoyad.Text);
            listBoxTckimlik.Items.Add(textBoxTc.Text);
            listBoxAboneno.Items.Add(textBoxAbone.Text);
            listBoxTarife.Items.Add(comboBoxTarife.Text);
            listBoxilçe.Items.Add(comboBoxilçe.Text);
            listBoxtüketim.Items.Add(tuketim.ToString()+" kwh");
            listBoxToplam.Items.Add(tutar + " TL");

        }

        private void groupBoxBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxTarife.SelectedIndex = 0;
            comboBoxilçe.SelectedIndex = 0;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            listBoxAdsoyad.Items.Clear();
            listBoxTckimlik.Items.Clear();
            listBoxAboneno.Items.Clear();
            listBoxTarife.Items.Clear();
            listBoxilçe.Items.Clear();
            listBoxtüketim.Items.Clear();
            listBoxToplam.Items.Clear();
            listBoxtarih.Items.Clear();

            textBox1.Text = "";
            textBox2.Text="";
            textBoxAdsoyad.Text="";
            textBoxTc.Text = "";
            textBoxAbone.Text = "";
            comboBoxTarife.Text = "";
            comboBoxilçe.Text = "";
            

        }
    }
}
