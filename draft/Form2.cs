using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JSONandSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string connectionString = "server=localhost;User Id=root;password=;Database=softwareengineera2";

        MySqlConnection connection = new MySqlConnection(connectionString);
        private void btn_sql_Click(object sender, EventArgs e)
        {
            connection.Open();
            string insertion = "INSERT INTO `subject` values (\"null\"" + "," + "\"" + tb_year.Text + "\"" + "," + "\"" + tb_course.Text + "\"" + "," + "\"" + tb_venue.Text + "\"" + "," + "\"" +tb_weekdays.Text+ "\"" + "," + "\"" + tb_starttime.Text+"\"" + "," + "\"" + tb_size.Text + "\""+");";
            MySqlCommand insertcommand = new MySqlCommand(insertion, connection);
            if(tb_year.Text!=""&&tb_course.Text != "" && tb_course.Text != "" && tb_venue.Text != "" && tb_weekdays.Text != "" && tb_starttime.Text != "" && tb_size.Text != "")
            {

                try
            {
                insertcommand.ExecuteNonQuery();
                MessageBox.Show(tb_course.Text+" for" +tb_year.Text+" students "+" is added.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                DisplaySqlErrors(ex);
            }
            insertcommand.Dispose();
            }
            else
            {
                MessageBox.Show("Please enter the course information.");
            }
            connection.Close();
        }
        static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
