using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdTxt.Select();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (Employee em = new Employee())
                {
                    em.registration(AdTxt.Text, SoyadTxt.Text);
                    MessageBox.Show("Record added!");
                }
                AdTxt.Select();
                Form1_Load(this, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (Employee employee = new Employee())
                {
                    List<Employee> emp = employee.get_all_Employees(this);
                    dataGridView1.DataSource = emp;
                }
                AdTxt.Select();
                Form1_Load(this, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
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
                            dataGridView1.DataSource = Empl;
                            AdTxt.Select();
                        }
                    }
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (Employee employee = new Employee())
                {
                    employee.UpdateData(Convert.ToInt32(IDTxt.Text), this);
                }
                AdTxt.Text = "";
                SoyadTxt.Text = null;
                IDTxt.Clear();
                Form1_Load(this, null);
                AdTxt.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int ID1 = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            //int id = (int)dataGridView1.CurrentRow.Cells[0].Value; kısa hali
            string columnName = this.dataGridView1.Columns[e.ColumnIndex].Name;
            if (columnName == "ID")
            {
                IDTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                AdTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                SoyadTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
            }
            AdTxt.Select();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.DeleteData(Convert.ToInt32(IDTxt.Text), this);
            AdTxt.Select();
            Form1_Load(this, null);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string komutsql = "Select * from Employees where EmployeeID =" +"'"+ Convert.ToInt32(IDTxt.Text) + "'";
                List<Employee> Empl = new List<Employee>();

                using (SqlConnection cnn = new SqlConnection("Data Source =.; Initial Catalog = Northwind; Integrated Security = True"))
                {
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
                            dataGridView1.DataSource = Empl;
                        }
                    }
                    cnn.Close();
                }
                AdTxt.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
