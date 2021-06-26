using Assessment.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
    public partial class Joins : Form
    {
        public Joins()
        {
            InitializeComponent();
        }

        private void Joins_Load(object sender, EventArgs e)
        {
            EmployeeLogic ob;
            ob = new EmployeeLogic();
            dataGridView1.DataSource = ob.GetData();
        }
    }
}
