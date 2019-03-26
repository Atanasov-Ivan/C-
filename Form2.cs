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
    public partial class Form2 : Form
    {
        ConnectToDB b = new ConnectToDB();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkingCart123 p = new WorkingCart123();
            p.id_WorkingCart = textBox1.Text;
            p.begin = dateTimePicker1.Text;
            p.end = dateTimePicker2.Text;
            p.taskName = comboBox1.Text;
            p.status = comboBox2.Text;
            p.description = textBox4.Text;
            p.username = comboBox3.Text;
            b.InsertWC(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            this.Hide();
            adm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Data123___CopyDataSet5.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter1.Fill(this._Data123___CopyDataSet5.Task);
            // TODO: This line of code loads data into the '_Data123___CopyDataSet3.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this._Data123___CopyDataSet3.Employee);
            // TODO: This line of code loads data into the '_Data123___CopyDataSet1.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this._Data123___CopyDataSet1.Task);
          //  comboBox1.Items.Add("1");
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WorkingCart123 p = new WorkingCart123();
            //p.id_WorkingCart = textBox1.Text;
            //p.begin = dateTimePicker1.Text;
            //p.end = dateTimePicker2.Text;          
            //p.status = comboBox2.Text;
            //p.description = textBox4.Text;
            //p.username = textBox5.Text;
            //b.UpdateWC(p);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
