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
    public partial class DeptInsert : Form
    {
        DepartmentLogic ob;
        public DeptInsert()
        {
            InitializeComponent();
            ob = new DepartmentLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Deptid = Convert.ToInt32(Deptidtxt.Text);
            d.Deptname = Deptnametxt.Text.ToString();
            d.Deptlocation = Deptloctxt.Text.ToString();
            d.Managerid = Convert.ToInt32(Manaderidtxt.Text);
            string msg = ob.addsp(d);
            MessageBox.Show(msg);

            Deptidtxt.Text = "";
            Deptnametxt.Text = "";
            Deptloctxt.Text = "";
            Manaderidtxt.Text = "";
            
        }
    }
}
