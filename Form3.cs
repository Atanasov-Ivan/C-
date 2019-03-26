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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Data123___CopyDataSet7.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter1.Fill(this._Data123___CopyDataSet7.Task);
            // TODO: This line of code loads data into the '_Data123___CopyDataSet6.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this._Data123___CopyDataSet6.Task);

        }
    }
}
