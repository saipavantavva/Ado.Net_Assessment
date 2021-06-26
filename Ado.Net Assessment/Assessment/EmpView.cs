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
    public partial class EmpView : Form
    {
        EmployeeLogic ob;
        public EmpView()
        {
            InitializeComponent();
            ob = new EmployeeLogic();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ob.getAllData();
        }
    }
}
