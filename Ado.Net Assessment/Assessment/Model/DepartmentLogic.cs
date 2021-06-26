using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Assessment.Model
{
    class DepartmentLogic
    {
        private string ConStr = ConfigurationManager.ConnectionStrings["companyDB"].ConnectionString;

        public string addsp(Department d)
        {
            string msg = null;
            string sql = "SPINSERTDEPARTMENT";
            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DEPTID", SqlDbType.Int).Value = d.Deptid;
                cmd.Parameters.Add("@DEPTNAME", SqlDbType.VarChar, 50).Value =d.Deptname;
                cmd.Parameters.Add("@DEPTLOC", SqlDbType.VarChar, 50).Value = d.Deptlocation;
                cmd.Parameters.Add("@MANAGERID", SqlDbType.Int).Value = d.Managerid;

                cmd.ExecuteNonQuery();

                msg = "Data Inserted Successfully";
            }
            catch (Exception)
            {
                msg = "Couldnt Insert the data!!";
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }


        public List<Department> getDeptAllData()
        {
            List<Department> li = new List<Department>();

            string sql = "select * from DEPTTABLE";

            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqr = cmd.ExecuteReader();
                while (sqr.Read())
                {
                    Department ob = new Department();

                    ob.Deptid = Convert.ToInt32(sqr.GetValue(0));
                    ob.Deptname = sqr.GetValue(1).ToString();
                    ob.Deptlocation = sqr.GetValue(2).ToString();
                    ob.Managerid = Convert.ToInt32(sqr.GetValue(3));
                    li.Add(ob);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                conn.Close();
            }


            return li;
        }



    }
}
