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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Data123___CopyDataSet9.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this._Data123___CopyDataSet9.Employee);
            // TODO: This line of code loads data into the '_Data123___CopyDataSet8.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this._Data123___CopyDataSet8.Employee);

        }
    }
}
