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
    public partial class EmpInsert : Form
    {
        EmployeeLogic ob;
        public EmpInsert()
        {
            InitializeComponent();
            ob = new EmployeeLogic();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            emp.Empid = Convert.ToInt32(Empidtxt.Text);
            emp.Empname = Empnametxt.Text.ToString();


            /* Date Part */
            string date1 = Dobtxt.Text.ToString();
            emp.Dob = date1;

            emp.Phonenum =long.Parse(Phonetxt.Text);
            emp.Email = Emailtxt.Text.ToString();
            emp.Salary = float.Parse(Salarytxt.Text);
            emp.Deptid = Convert.ToInt32(Deptidtxt.Text);

            
            string msg = ob.addsp(emp);
            MessageBox.Show(msg);

            Empidtxt.Text = "";
            Empnametxt.Text = "";
            Dobtxt.Text = "";
            Phonetxt.Text = "";
            Emailtxt.Text = "";
            Salarytxt.Text = "";
            Deptidtxt.Text = "";

        }
    }
}
