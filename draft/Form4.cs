using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;


namespace JSONandSQL
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static string connectionString = "server=localhost;User Id=root;password=;Database=softwareengineera2; convert zero datetime=True";
        MySqlConnection connection = new MySqlConnection(connectionString);
        DateTime dateTime = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = "SELECT *,count(*) as ontime FROM `testjson`,`subject` WHERE  time(time(testjson.time) - subject.start_time) <= time(1) and testjson.weekday=subject.Weekdays;";
            MySqlCommand cmd= new MySqlCommand(sql, connection);
           MySqlDataReader datareader = cmd.ExecuteReader();
            var Excelapp = new Excel.Application();
            Excelapp.Visible = true;
            Excel.Workbook workBook = Excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = Excelapp.ActiveSheet;
            worksheet.Name = "test";

            if (datareader.HasRows == true)
            {
                var datarow = 2;
                while (datareader.Read())
                {
                    worksheet.Cells[datarow, 1] = datareader["ontime"];
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
            }
            datareader.Close();
            cmd.Dispose();
            connection.Close();
            connection.Open();
            Excel.Worksheet worksheet1 = workBook.Worksheets.Add();
            worksheet1.Name = "Year1 Students";
            string year1student = "Select student_id,Student_Name from `studentinfo` where year= 1;";
            MySqlCommand y1cmd = new MySqlCommand(year1student, connection);
            MySqlDataReader dataReader= y1cmd.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    worksheet1.Cells[1, i + 1] = dataReader.GetName(i);
                    while (dataReader.Read())
                    {
                        worksheet1.Cells[datarow, 1] = dataReader["student_id"];
                        worksheet1.Cells[datarow, 2] = dataReader["student_Name"];
                        datarow++;
                    }
                }
                worksheet1.Columns.AutoFit();
                worksheet1.Rows.AutoFit();
            }
            dataReader.Close();
            y1cmd.Dispose();
            connection.Close();
            connection.Open();
            Excel.Worksheet worksheet2 = workBook.Worksheets.Add();
            worksheet2.Name = "Year2 Students";
            string year2student = "Select student_id,Student_Name from `studentinfo` where year= 2;";
            MySqlCommand y2cmd = new MySqlCommand(year2student, connection);
            MySqlDataReader data= y2cmd.ExecuteReader();
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    worksheet2.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        worksheet2.Cells[datarow, 1] = data["student_id"];
                        worksheet2.Cells[datarow, 2] = data["student_Name"];
                        datarow++;
                    }
                }
                    worksheet2.Columns.AutoFit();
                    worksheet2.Rows.AutoFit();
            }
            data.Close();
            y2cmd.Dispose();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            connection.Open();
            string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue="+"\""+tb_location.Text+"\""+" and subject.Weekdays="+"weekday( "+ dateTime.ToString("yyyyMMddHHmmss") +")+1 and time(time("+ dateTime.ToString("yyyyMMddHHmmss") + ") - subject.start_time) <= time(1) and (studentinfo.student_id="+"\""+tb_userID.Text+"\""+") and subject.SchoolYear=studentinfo.Year;";
            MySqlCommand mySqlCommand =new MySqlCommand(coursesql,connection);
            string _name = (string)mySqlCommand.ExecuteScalar();
            MessageBox.Show(_name);
            mySqlCommand.Dispose();
            connection.Close();
            */
        }

    }
}
