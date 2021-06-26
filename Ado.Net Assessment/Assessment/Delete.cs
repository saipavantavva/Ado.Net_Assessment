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
    public partial class Delete : Form
    {
        EmployeeLogic ob;
        public Delete()
        {
            InitializeComponent();
            ob = new EmployeeLogic();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            Deltbtn.Visible = false;
        }

        private void Deltbtn_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.Empid = Convert.ToInt32(Empidtxt.Text);

            string msg = ob.spdeleteemp(emp);
            MessageBox.Show(msg);

            dataGridView1.Visible = true;
            dataGridView1.DataSource = ob.getAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Empidtxt.Text);
            Employee c = ob.serachempid(id);
            if (c == null)
                MessageBox.Show("Enter the valid EMPID as this doesnot exist!!!");
            else
            {
                Deltbtn.Visible = true;
            }
        }
    }
}
