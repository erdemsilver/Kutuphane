using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "library123")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Erdem" && textBox2.Text == "2876")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else 
            {
                textBox2.PasswordChar = '*';
            }

        }
    }
}
