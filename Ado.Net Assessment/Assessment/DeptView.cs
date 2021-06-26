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
    public partial class DeptView : Form
    {
        DepartmentLogic ob;
        public DeptView()
        {
            InitializeComponent();
            ob = new DepartmentLogic();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeptView_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ob.getDeptAllData();
        }
    }
}
