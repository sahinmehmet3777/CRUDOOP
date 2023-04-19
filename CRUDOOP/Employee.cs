using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDOOP
{
    internal class Employee : IDisposable
    {
        public int ID { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }

        public void registration(string Adı, string Soyadı)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True"))
                {
                    string komutsql = "insert into Employees(FirstName, LastName) values('" + Adı + "','" + Soyadı + "')";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(komutsql, cnn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<Employee> get_all_Employees(Form1 form1nesnesi)
        {
            List<Employee> Empl = new List<Employee>();

            using (SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True"))
            {
                string komutsql = "Select * from Employees";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(komutsql, cnn))
                {
                    using (SqlDataReader okuyucu = cmd.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            Employee emp = new Employee();

                            emp.ID = Convert.ToInt32(okuyucu["EmployeeID"]);
                            emp.Adı = okuyucu["FirstName"].ToString();
                            emp.Soyadı = okuyucu["LastName"].ToString();

                            Empl.Add(emp);
                        }
                    }
                }
                cnn.Close();

            }
            return Empl;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void UpdateData(int ID1, Form1 form1nesnesi)
        {
            if (form1nesnesi.IDTxt.Text == "")
            {
                MessageBox.Show("Güncelleme için Personel ID'si seçiniz");
                return;
            }
            
            List<Employee> Empl = new List<Employee>();

            using (SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True"))
            {
                string komutsql = "Update Employees set FirstName=" + "'" + form1nesnesi.AdTxt.Text + "'" + "," + "LastName=" + "'" + form1nesnesi.SoyadTxt.Text + "'" + "where EmployeeID=" + ID1;
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(komutsql, cnn))
                {
                    using (SqlDataReader okuyucu = cmd.ExecuteReader())
                    {
                        while (okuyucu.Read())
                        {
                            Employee emp = new Employee();

                            emp.Adı = okuyucu["FirstName"].ToString();
                            emp.Soyadı = okuyucu["LastName"].ToString();

                            Empl.Add(emp);
                        }
                        //form1nesnesi.dataGridView1.DataSource = Empl; OLMASA DA OLUR
                    }
                }
                cnn.Close();
            }
        }

        public void DeleteData(int ID1, Form1 form1nesnesi)
        {
            if (ID1 != 0)
            {
                if (form1nesnesi.IDTxt.Text == "")
                {
                    MessageBox.Show("Silmek için Personel ID'si seçiniz");
                    return;
                }

                List<Employee> Empl = new List<Employee>();

                using (SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True"))
                {
                    string komutsql = "Delete from Employees where EmployeeID=" + ID1 + 
                        "or EmployeeID = " + "'" + Convert.ToInt32(form1nesnesi.IDTxt.Text) + "'";
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(komutsql, cnn))
                    {
                        using (SqlDataReader okuyucu = cmd.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                Employee emp = new Employee();

                                emp.Adı = okuyucu["FirstName"].ToString();
                                emp.Soyadı = okuyucu["LastName"].ToString();

                                Empl.Add(emp);
                            }
                        }
                    }
                    cnn.Close();

                }
            }
            else
            {
                MessageBox.Show("Silinecek Kaydı Seçiniz!");
            }
        }
    }
}
