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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="yönetici"&& textBox2.Text=="123")
            { 
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
            MessageBox.Show("Giriş Başarılı");
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
