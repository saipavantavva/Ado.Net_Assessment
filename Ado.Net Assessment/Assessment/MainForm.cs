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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptInsert f1 = new DeptInsert(); 
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmpInsert f2 = new EmpInsert();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmpView f3 = new EmpView();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search srh = new Search();
            srh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Joins joins = new Joins();
            joins.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeptView deptView = new DeptView();
            deptView.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
