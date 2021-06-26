using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assessment.Model
{
    class EmployeeLogic
    {


        private string ConStr = ConfigurationManager.ConnectionStrings["companyDB"].ConnectionString;
        public List<Employee> getAllData()
        {
            List<Employee> li = new List<Employee>();

            string sql = "select * from EMPTABLE";

            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqr = cmd.ExecuteReader();
                while (sqr.Read())
                {
                    Employee ob = new Employee();
                 

                    ob.Empid = Convert.ToInt32(sqr.GetValue(0));
                    ob.Empname = sqr.GetValue(1).ToString();

             
                    DateTime date1 = DateTime.Parse(sqr.GetValue(2).ToString());
                    string dates = date1.ToString("dd/MM/yyyy");
                    ob.Dob = dates;



                    ob.Phonenum = long.Parse(sqr.GetValue(3).ToString());
                    ob.Email = sqr.GetValue(4).ToString();
                    ob.Salary = float.Parse(sqr.GetValue(5).ToString());
                    ob.Deptid = Convert.ToInt32(sqr.GetValue(6));


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


        public string addsp(Employee e)
        {
            string msg = null;
            string sql = "SPINSERTEMPLOYEE";
            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@EMPID", SqlDbType.Int).Value = e.Empid;
                cmd.Parameters.Add("@EMPNAME", SqlDbType.VarChar, 50).Value = e.Empname;
                cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = e.Dob;
                cmd.Parameters.Add("@PHONE", SqlDbType.BigInt).Value = e.Phonenum;
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar,50).Value = e.Email;
                cmd.Parameters.Add("@SALARY", SqlDbType.Float).Value = e.Salary;
                cmd.Parameters.Add("@DEPTID", SqlDbType.Int).Value = e.Deptid;

                cmd.ExecuteNonQuery();

                msg = "Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                msg = "Couldnt Insert the data!!";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }

        public Employee Searching(string i)
        {


            string sql = "select * from EMPTABLE where EMPNAME='" +i+"'";

            SqlConnection conn = new SqlConnection(ConStr);
            Employee ob = new Employee();


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqr = cmd.ExecuteReader();

                if (sqr.HasRows)
                {
                    while (sqr.Read())
                    {

                        ob.Empid = Convert.ToInt32(sqr.GetValue(0));
                        ob.Empname = sqr.GetValue(1).ToString();


                        DateTime date1 = DateTime.Parse(sqr.GetValue(2).ToString());
                        string dates = date1.ToString("dd/MM/yyyy");
                        ob.Dob = dates;

                        ob.Phonenum = long.Parse(sqr.GetValue(3).ToString());
                        ob.Email = sqr.GetValue(4).ToString();
                        ob.Salary = float.Parse(sqr.GetValue(5).ToString());
                        ob.Deptid = Convert.ToInt32(sqr.GetValue(6));
                    }
                }
                else
                {
                    ob = null;
                }


            }
            catch (Exception ex)
            {
              //  MessageBox.Show("ERROR");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return ob;
        }



        public Employee Searchingusngsal(float i)
        {

            Employee ob2 = new Employee();
            string sql = "select * FROM EMPTABLE where SALARY=" + i;
          // string sql = "  select* from EMPTABLE where SALARY like '" + i + "%'";

            SqlConnection conn = new SqlConnection(ConStr);
            try
            {
                conn.Open();
                SqlCommand cmdd = new SqlCommand(sql, conn);
                SqlDataReader sqrr = cmdd.ExecuteReader();

                if (sqrr.HasRows)
                {
                    while (sqrr.Read())
                    {

                        ob2.Empid = Convert.ToInt32(sqrr.GetValue(0));
                        ob2.Empname = sqrr.GetValue(1).ToString();


                        DateTime date1 = DateTime.Parse(sqrr.GetValue(2).ToString());
                        string dates = date1.ToString("dd/MM/yyyy");
                        ob2.Dob = dates;

                        ob2.Phonenum = long.Parse(sqrr.GetValue(3).ToString());
                        ob2.Email = sqrr.GetValue(4).ToString();
                        ob2.Salary = float.Parse(sqrr.GetValue(5).ToString());
                        ob2.Deptid = Convert.ToInt32(sqrr.GetValue(6));
                    }
                }
                else
                {
                    ob2 = null;
                }


            }
            catch (Exception ex)
            {
                //  MessageBox.Show("ERROR");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return ob2;
        }



        public Employee serachempid(int id)
        {


            string sql = "select * from EMPTABLE where EMPID='" + id + "'";

            SqlConnection conn = new SqlConnection(ConStr);
            Employee ob = new Employee();


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqr = cmd.ExecuteReader();

                if (sqr.HasRows)
                {
                    while (sqr.Read())
                    {

                        ob.Empid = Convert.ToInt32(sqr.GetValue(0));
                        ob.Empname = sqr.GetValue(1).ToString();


                        DateTime date1 = DateTime.Parse(sqr.GetValue(2).ToString());
                        string dates = date1.ToString("dd/MM/yyyy");
                        ob.Dob = dates;

                        ob.Phonenum = long.Parse(sqr.GetValue(3).ToString());
                        ob.Email = sqr.GetValue(4).ToString();
                        ob.Salary = float.Parse(sqr.GetValue(5).ToString());
                        ob.Deptid = Convert.ToInt32(sqr.GetValue(6));
                    }
                }
                else
                {
                    ob = null;
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("ERROR");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return ob;
        }

        public string spupdate(Employee e)
        {
            string msg = null;
            string sql = "SPUPDATEEMPLOYEE";
            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = e.Empid;
                cmd.Parameters.Add("@PHONENUM", SqlDbType.BigInt).Value = e.Phonenum;
                cmd.Parameters.Add("@EMAILID", SqlDbType.VarChar, 50).Value = e.Email;

                cmd.ExecuteNonQuery();

                msg = "Data Updated Successfully";
            }
            catch (Exception ex)
            {
                msg = "Couldnt Insert the data!!";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }




        public string spdeleteemp(Employee e)
        {
            string msg = null;
            string sql = "SPDELETEEMPLOYEE";
            SqlConnection conn = new SqlConnection(ConStr);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = e.Empid;

                cmd.ExecuteNonQuery();

                msg = "Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                msg = "Couldnt Delete the data!!";
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }

        public DataTable GetData()
        {
            DataTable table = new DataTable("tablejoin");
            SqlConnection conn = new SqlConnection(ConStr);
            string sql = "SELECT E.EMPID,E.EMPNAME,E.PHONE,E.SALARY,D.DEPTNAME,D.DEPTLOCATION,D.MANAGERID FROM EMPTABLE E INNER JOIN DEPTTABLE D ON E.DEPTID = D.DEPTID ";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to fetch data");
            }
            finally
            {
                conn.Close();
            }
            return table;
        }






     
















    }
}
