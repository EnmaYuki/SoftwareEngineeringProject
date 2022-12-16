using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using MySqlX.XDevAPI.Common;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.Common;

namespace JSONandSQL
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = "server=localhost;User Id=root;password=;Database=softwareengineera2; convert zero datetime=True";
        MySqlConnection connection = new MySqlConnection(connectionString);

        private string collectionID = "638073a80e6a79321e555207";
        private string APIkey = "$2b$10$l5EyYl0U3FvpMQULZaPjX.uPNB86iNFrnKVtTLDMLVu3DuDweIxHi";

        DateTime dateTime = DateTime.Now;

        private void btn_addJSONbin_Click(object sender, EventArgs e)
        {

            WebResponse myResp;
            WebRequest myReq;
            myReq = WebRequest.Create("https://api.jsonbin.io/v3/b");
            myReq.Method = "POST";
            myReq.ContentType = "application/json";

            myReq.Headers.Add("X-Master-Key", APIkey);

            myReq.Headers.Add("X-Bin-Name", tb_location.Text + "|" + tb_userID.Text + "|" + dateTime.ToString("yyyyMMddHHmmss") );
            myReq.Headers.Add("X-Collection-Id", collectionID);

            /*
            connection.Open();
            string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue="+"\""+tb_location.Text+"\""+" and subject.Weekdays="+"weekday( "+ dateTime.ToString("yyyyMMddHHmmss") +")+1 and time(time("+ dateTime.ToString("yyyyMMddHHmmss") + ") - subject.start_time) < time(24) and (studentinfo.student_id="+"\""+tb_userID.Text+"\""+") and subject.SchoolYear=studentinfo.Year;";
            MySqlCommand mySqlCommand =new MySqlCommand(coursesql,connection);
            string _name = (string)mySqlCommand.ExecuteScalar();

            mySqlCommand.Dispose();
            connection.Close();
            */
            string postData = "{\"data\":" + "\"\"}"; //Dummy Json
            
            var data = Encoding.ASCII.GetBytes(postData);
            myReq.ContentLength = data.Length;
            using (var stream = myReq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                myResp = myReq.GetResponse();
                MessageBox.Show("Success");
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string a = reader.ReadToEnd();
                        MessageBox.Show(a);
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }
            myReq.Abort();
        }
        private void btn_getJSONbin_Click(object sender, EventArgs e)
        {
            tb_result.Text = "";
            tb_resultData.Text = "";
            tb_resultKey.Text = "";

            WebResponse myResp;
            WebRequest myReq;

            bool getData = true;
            int loopCount = 0;
            string lastRecordID = "";
            while (getData != false)
            {
                if (loopCount == 0)
                {
                    myReq = WebRequest.Create("https://api.jsonbin.io/v3/c/" + collectionID + "/bins");
                }
                else
                {
                    myReq = WebRequest.Create("https://api.jsonbin.io/v3/c/" + collectionID + "/bins/" + lastRecordID);
                }

                myReq.Method = "GET";
                myReq.ContentType = "application/json";
                myReq.Headers.Add("X-Master-Key", APIkey);
                myResp = myReq.GetResponse();
                StreamReader myreader = new StreamReader(myResp.GetResponseStream());
                string myText;
                myText = myreader.ReadToEnd();
                JToken myObject = JValue.Parse(myText);
                int count = 0;
                foreach (JToken arr in myObject)
                {
                    foreach (Object item in arr)
                    {
                        if (item.ToString().Contains("record"))
                        {
                            count += 1;
                            String[] s = item.ToString().Split('"');
                            Console.WriteLine(count + loopCount * 10 + ": " + s[3]);
                            tb_result.Text +="|" + s[3] + Environment.NewLine;// add bin id
                            tb_resultKey.Text += count + loopCount * 10 + ": " + s[3] + Environment.NewLine;
                            lastRecordID = s[3];
                        }

                        if (item.ToString().Contains("name"))
                        {
                            var s = item.ToString().Split('"');
                            Console.WriteLine(count + loopCount * 10 + 1 + ": " + s[5]); // name = charles@hkua.org|202108311730|001|22.121213,114.123456
                            tb_resultData.Text += count + loopCount * 10 + 1 + ": " + s[5] + Environment.NewLine;
                            tb_result.Text +=s[5];
                        }
                    }
                }

                loopCount += 1;
                if (count < 10)
                {
                    getData = false;
                }
                else
                {
                    getData = true;
                }
                myReq.Abort();
            }

            Console.WriteLine("Finished!");
            MessageBox.Show("Finished");
            backup();
        }

        private void btn_toSQL_Click(object sender, EventArgs e)
        {
            connection.Open();
            string backupformat = tb_result.Text.Replace("\r\n", "_");
            string trying = backupformat.Substring(0, backupformat.Length - 1);
            string[] attendrecord = trying.Split('_');
            string SQL = "";
            string sqlhead = "insert into `testjson` values";
            string valueshead = "("+"\"null\"" + "," + "\"";
            string valuesmidend = "\"" + ",";
            string valuesmidstart = "," + "\"";
            string valuesmid = "\"" + "," + "\"";
            string valuesend = "\"" + ")";
            string sqltail = ";";


            for (int i = 0; i < attendrecord.Length; i++)
            {

                string[] attenddata = attendrecord[i].Split('|');
                if (i == 0 && i == attendrecord.Length - 1)
                {
                    SQL = sqlhead + valueshead + attenddata[1]+ valuesmidend+ "weekday(\"" + attenddata[2] + "\")+1" + valuesmidstart+ attenddata[2]+ valuesmid + attenddata[0] + valuesend + sqltail;
                }
                else
                {
                    if (i == 0 && i != attendrecord.Length - 1)
                    {
                        SQL = sqlhead + valueshead + attenddata[1] + valuesmidend + "weekday(\"" + attenddata[2] + "\")+1" + valuesmidstart + attenddata[2] + valuesmid + attenddata[0] + valuesend;
                    }
                    else if (i == attendrecord.Length - 1)
                    {
                        SQL += "," + valueshead + attenddata[1] + valuesmidend + "weekday(\"" + attenddata[2] + "\")+1" + valuesmidstart + attenddata[2] + valuesmid + attenddata[0] + valuesend + sqltail;
                    }
                    else
                    {
                        SQL += "," + valueshead + attenddata[1] + valuesmidend + "weekday(\"" + attenddata[2] + "\")+1" + valuesmidstart + attenddata[2] + valuesmid + attenddata[0] + valuesend;
                    }
                }
                MySqlCommand command = new MySqlCommand(SQL, connection);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Success");
                }
                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                }
                command.Dispose();
                deleteBin(attenddata[3]);
            }
            connection.Close();
        }
        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                Console.WriteLine("Index #" + i + "\n" +
                    "Error: " + exception.Errors[i].ToString() + "\n");
            }
            Console.ReadLine();
        }

        private void deleteBin(string bin_id)
        {
            if(bin_id.Contains("\r\n")) 
            {
                bin_id=bin_id.Replace("\r\n"," ").Trim();
            }
            else if (bin_id.Contains("\r"))
            {
                bin_id = bin_id.Replace("\r", " ").Trim();
            }
            else if (bin_id.Contains("\n"))
            {
                bin_id = bin_id.Replace("\n", " ").Trim();
            }
            else
            {
                bin_id = bin_id.Trim();
            }
                WebResponse myResp;
                WebRequest myReq;
                myReq = WebRequest.Create("https://api.jsonbin.io/v3/b/" +bin_id);
                myReq.Method = "DELETE";
                myReq.ContentType = "application/json";
                myReq.Headers.Add("X-Master-Key", APIkey);

                try
                {
                    myResp = myReq.GetResponse();
                    MessageBox.Show("Delete Success");
                myResp.Close();
                }
                catch (WebException ex)
                {
                    using (var stream = ex.Response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            string a = reader.ReadToEnd();
                            MessageBox.Show(a);
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                }
            myReq.Abort();
        }

        private void backup()
        {
            if (tb_resultData.Text != string.Empty)
            {
            WebResponse myResp;
            WebRequest myReq;
            myReq = WebRequest.Create("https://api.jsonbin.io/v3/b");
            myReq.Method = "POST";
            myReq.ContentType = "application/json";

            myReq.Headers.Add("X-Master-Key", APIkey);

            myReq.Headers.Add("X-Bin-Name", "backUp");
            //myReq.Headers.Add("X-Collection-Id", collectionID);

            /*
            connection.Open();
            string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue="+"\""+tb_location.Text+"\""+" and subject.Weekdays="+"weekday( "+ dateTime.ToString("yyyyMMddHHmmss") +")+1 and time(time("+ dateTime.ToString("yyyyMMddHHmmss") + ") - subject.start_time) < time(24) and (studentinfo.student_id="+"\""+tb_userID.Text+"\""+") and subject.SchoolYear=studentinfo.Year;";
            MySqlCommand mySqlCommand =new MySqlCommand(coursesql,connection);
            string _name = (string)mySqlCommand.ExecuteScalar();

            mySqlCommand.Dispose();
            connection.Close();
            */
            string backupformat=tb_resultData.Text.Replace("\r\n", "_");
            string trying=backupformat.Substring(0, backupformat.Length - 1);
            string[] datarecord= trying.Split('_');
            string postData = "";
            string postDatahead = "{" + "\"";
            string postDatamid = "\"" + ":" + "\"";
            string postDatatail = "\"" + "}";
            string postDatasplit = "\"";


            for(int i = 0; i < datarecord.Length; i++)
            {
                string[] recorddata = datarecord[i].Split(':');
                if (i == 0 && i == datarecord.Length - 1)
                {
                    postData = postDatahead + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatatail;
                }
                else
                {
                    if (i==0 && i != datarecord.Length - 1) 
                    {
                        postData =postDatahead + recorddata[0] + postDatamid + recorddata[1].Trim()+postDatasplit;
                    }
                    else if (i == datarecord.Length - 1)
                    {
                        postData+=","+ postDatasplit+recorddata[0] + postDatamid + recorddata[1].Trim() + postDatatail;
                    }
                    else 
                    {
                        postData += "," + postDatasplit + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatasplit;
                    }
                }
            }
            //string postData = "{" + "\"" + "data" + "\"" + ":" + "\"" + datarecord.Length + "\"}"; //Dummy Json

            var data = Encoding.ASCII.GetBytes(postData);
            myReq.ContentLength = data.Length;
            using (var stream = myReq.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            try
            {
                myResp = myReq.GetResponse();
                MessageBox.Show("Success");
                myResp.Close();
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        string a = reader.ReadToEnd();
                        MessageBox.Show(a);
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }
            myReq.Abort();
            }
            else
            {
                MessageBox.Show("There is no data need to back up!", "Unneccessery back up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_excel_Click(object sender, EventArgs e)
        {
            connection.Open();
            string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue="+"\""+tb_location.Text+"\""+" and subject.Weekdays="+"weekday( "+ dateTime.ToString("yyyyMMddHHmmss") +")+1 and (studentinfo.student_id="+"\""+tb_userID.Text+"\""+") and subject.SchoolYear=studentinfo.Year;";

            //string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue="+"\""+tb_location.Text+"\""+" and subject.Weekdays="+"weekday( "+ dateTime.ToString("yyyyMMddHHmmss") +")+1 and time(time("+ dateTime.ToString("yyyyMMddHHmmss") + ") - subject.start_time) <= time(1) and (studentinfo.student_id="+"\""+tb_userID.Text+"\""+") and subject.SchoolYear=studentinfo.Year;";
            MySqlCommand mySqlCommand =new MySqlCommand(coursesql,connection);
            string _name = (string)mySqlCommand.ExecuteScalar();
            tb_subject.Text = _name;
            mySqlCommand.Dispose();
            connection.Close();
            /* verifiy student 
            connection.Open();
            string data = "SELECT * FROM studentinfo , testjson WHERE ("+"\""+ tb_userID.Text + "\"" + "=studentinfo.student_id);  ";
            MySqlCommand cmd = new MySqlCommand(data, connection);
            MySqlDataReader datareader = cmd.ExecuteReader();
            var Excelapp = new Excel.Application();

            if (datareader.HasRows == true)
            {
                Excelapp.Visible = true;                   
                Excel.Workbook workBook = Excelapp.Workbooks.Add();
                Excel.Worksheet worksheet = Excelapp.ActiveSheet;
                worksheet.Name = "test";
                var datarow = 2;
                while (datareader.Read())
                {
                    worksheet.Cells[datarow, 1] = datareader["Student_Name"];
                    worksheet.Cells[datarow, 2] = datareader["time"];
                }
            }
            datareader.Close();
            cmd.Dispose();
            connection.Close();

            /*
            object Nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "WorkSheet";
            // Write data
            worksheet.Cells[1, 1] = "FileName";
            worksheet.Cells[1, 2] = "FindString";
            worksheet.Cells[1, 3] = "ReplaceString";
            // Show save file dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                app.Quit();
            }
            */
        }
    }
}