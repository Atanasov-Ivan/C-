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
        ConnectToDB b = new ConnectToDB();
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Data123 p = new Data123();
            p.Username = textBox1.Text;
            p.Password = textBox2.Text;
            p.FirstName = textBox3.Text;
            p.LastName = textBox4.Text;
            p.Position = textBox5.Text;
            p.Lastaction = textBox6.Text;
            b.Insert(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data123 p = new Data123();
            p.Username = textBox1.Text;
            p.Password = textBox2.Text;
            p.FirstName = textBox3.Text;
            p.LastName = textBox4.Text;
            p.Position = textBox5.Text;
            p.Lastaction = textBox6.Text;
            b.Update(p);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Data123 p = new Data123();
            //p.Username = textBox1.Text;
            //p.Password = textBox2.Text;
            //p.FirstName = textBox3.Text;
            //p.LastName = textBox4.Text;
            //p.Position = textBox5.Text;
            //p.Lastaction = textBox6.Text;
//            b.Delete(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            this.Hide();
            adm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
