using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Numerics;
using System.Security.AccessControl;
using System.Collections;

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
        private DateTime dateTime;
        private string student_id;
        public List<string> studentList = new List<string>();
        public void setcustomdt(string H, string m)
        {
            string Y, M, D="";
                Y = "2022";
                M = "12";
                switch (cb_lesson.SelectedItem.ToString())
                {
                    case "1":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "08";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "14";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "20";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    case "2":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "09";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "15";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "21";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    case "3":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "10";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "16";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "22";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    case "4":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "11";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "17";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "23";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    case "5":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "12";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "18";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "24";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    case "6":
                        {
                            if (((cb_courseid.SelectedItem.ToString() == "2" || cb_courseid.SelectedItem.ToString() == "3") && cb_studentyear.SelectedItem.ToString() == "All")|| (cb_courseid.SelectedItem.ToString() == "2" && cb_studentyear.SelectedItem.ToString()=="2") || (cb_courseid.SelectedItem.ToString() == "3" &&cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "13";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "5" && (cb_studentyear.SelectedItem.ToString() == "All" ||cb_studentyear.SelectedItem.ToString( )=="1")) || cb_courseid.SelectedItem.ToString() == "4" )
                            {
                                D = "19";
                            }
                            else if ((cb_courseid.SelectedItem.ToString() == "1" || cb_courseid.SelectedItem.ToString() == "6") && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "25";
                            }
                            else
                            {
                                MessageBox.Show("Please choose correct couse id for students");
                            break;
                        }
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Please choose couse id and lesson");
                        return;
                    }
                }
                string customize = Y + "-" + M + "-" + D + " " + H + ":" + m + ":00";
                this.dateTime = DateTime.Parse(customize);
        }
        public DateTime getcustomdt()
        {
            return dateTime;
        }
        public void setStudent(string thisstudent_id)
        {
            this.student_id = thisstudent_id;
        }
        public string getStudent()
        {
            return student_id;
        }
        private void btn_getstudent_Click(object sender, EventArgs e)
        {
            if (cb_studentyear.SelectedItem.ToString()=="All")
            {
                studentlist.Items.Clear();
                connection.Open();
                string yearstudent = "Select Student_Name from `studentinfo` order by student_id asc;";
                MySqlCommand sqlCommand = new MySqlCommand(yearstudent,connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        studentlist.Items.Add(reader["Student_Name"]);
                    }
                }
                reader.Close();
                //checkedListBox1.Text=(string)sqlCommand.ExecuteScalar();
                sqlCommand.Dispose();
                connection.Close();
            }
            else if (cb_studentyear.SelectedItem.ToString() == "1")
            {
                studentlist.Items.Clear();
                connection.Open();
                string yearstudent = "Select Student_Name from `studentinfo` where year= " + cb_studentyear.SelectedItem.ToString() + ";";
                MySqlCommand sqlCommand = new MySqlCommand(yearstudent, connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        studentlist.Items.Add(reader["Student_Name"]);
                    }
                }
                reader.Close();
                //checkedListBox1.Text=(string)sqlCommand.ExecuteScalar();
                sqlCommand.Dispose();
                connection.Close();
            }
            else if (cb_studentyear.SelectedItem.ToString() == "2")
            {
                studentlist.Items.Clear();
                connection.Open();
                string yearstudent = "Select Student_Name from `studentinfo` where year= " + cb_studentyear.SelectedItem.ToString() + ";";
                MySqlCommand sqlCommand = new MySqlCommand(yearstudent, connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        studentlist.Items.Add(reader["Student_Name"]);
                    }
                }
                reader.Close();
                //checkedListBox1.Text=(string)sqlCommand.ExecuteScalar();
                sqlCommand.Dispose();
                connection.Close();
            }
            else
            {
                MessageBox.Show("No Student!");
            }
        }
        private void addstudent()
        {
            connection.Open();
            if (studentlist.CheckedItems.Count >= 0)
            {
                for (int i = 0; i < studentlist.CheckedItems.Count; i++)
                {
                    string checker = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Student_Name =" + "\'" + studentlist.CheckedItems[i].ToString() + "\'" + ";";
                    MySqlCommand cmd = new MySqlCommand(checker, connection);

                    MySqlDataReader studentreader = cmd.ExecuteReader();

                    if (studentreader.HasRows == true)
                    {
                        while (studentreader.Read())
                        {
                            setStudent(studentreader["student_id"].ToString());
                            studentList.Add(getStudent());
                        }
                    }
                    studentreader.Close();
                    cmd.Dispose();
                }
            connection.Close();
                for (int si = 0; si<studentList.Count; si++)
                {
                    addJSONbin_Click(studentList[si]);
                }
            }
        }
        //Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time-subject.start_time) as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.time BETWEEN "19:00:00" AND "01:00:00";
        private void btn_addJSONbin_Click(object sender, EventArgs e)
        {
            addstudent();
            MessageBox.Show("Add Success");
        }
        private void addJSONbin_Click(string students)
        {
            if ( cb_courseid.SelectedItem.ToString() != string.Empty && cb_lesson.SelectedItem.ToString() != string.Empty && cb_hour.SelectedItem.ToString() != string.Empty && cb_minute.SelectedItem.ToString() != string.Empty)
            {
                connection.Open();
                setcustomdt(cb_hour.SelectedItem.ToString(), cb_minute.SelectedItem.ToString());
                string coursecheck = "select * from`subject` where " + "\"" + cb_courseid.SelectedItem.ToString() + "\"" + "=id;";
                MySqlCommand mySql = new MySqlCommand(coursecheck, connection);
                MySqlDataReader sqlreader = mySql.ExecuteReader();
                if (sqlreader.HasRows == true)
                {
                    WebResponse myResp;
                    WebRequest myReq;
                    myReq = WebRequest.Create("https://api.jsonbin.io/v3/b");
                    myReq.Method = "POST";
                    myReq.ContentType = "application/json";

                    myReq.Headers.Add("X-Master-Key", APIkey);

                    myReq.Headers.Add("X-Bin-Name", students + "|" + cb_courseid.SelectedItem.ToString() + "|" + getcustomdt().ToString("yyyyMMddHHmmss"));
                    myReq.Headers.Add("X-Collection-Id", collectionID);
                    string postData = "{\"data\":" + "\"\"}"; //Empty Json

                    var data = Encoding.ASCII.GetBytes(postData);
                    myReq.ContentLength = data.Length;
                    using (var stream = myReq.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    try
                    {
                        myResp = myReq.GetResponse();
                        Console.WriteLine("Add Success");
                        myResp.Close();
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show("Add fail");
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
                    sqlreader.Close();
                    mySql.Dispose();
                    connection.Close();
                    MessageBox.Show("Please enter your course correctly!");
                }
                sqlreader.Close();
                mySql.Dispose();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please enter student info!");
            }
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
                            tb_result.Text += "|" + s[3] + Environment.NewLine;// add bin id
                            tb_resultKey.Text += count + loopCount * 10 + ": " + s[3] + Environment.NewLine;
                            lastRecordID = s[3];
                        }

                        if (item.ToString().Contains("name"))
                        {
                            var s = item.ToString().Split('"');
                            Console.WriteLine(count + loopCount * 10 + 1 + ": " + s[5]); // name = charles@hkua.org|202108311730|001|22.121213,114.123456
                            tb_resultData.Text += count + loopCount * 10 + 1 + ": " + s[5] + Environment.NewLine;
                            tb_result.Text += s[5];
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
                myResp.Close();
                myReq.Abort();
            }

            Console.WriteLine("Finished!");
            MessageBox.Show("Finished");
            backUp();
        }
        private void btn_toSQL_Click(object sender, EventArgs e)
        {
            connection.Open();
            string attendformat = tb_result.Text.Replace("\r\n", "_");
            string att = attendformat.Substring(0, attendformat.Length - 1);
            string[] attendrecord = att.Split('_');
            string SQL = "";
            for (int i = 0; i < attendrecord.Length; i++)
            {
                string[] attenddata = attendrecord[i].Split('|');
                if (i == 0 && i != attendrecord.Length - 1)
                {
                    SQL = "insert into testjson (student,time,CourseId) values" + "(" + "\"" + attenddata[0] + "\"" + "," + "\"" + attenddata[2] + "\"" + "," + "\"" + attenddata[1] + "\"" + ")";
                }
                else if (i == attendrecord.Length - 1)
                {
                    SQL = "insert into testjson (student,time,CourseId) values" + "(" + "\"" + attenddata[0] + "\"" + "," + "\"" + attenddata[2] + "\"" + "," + "\"" + attenddata[1] + "\"" + "); ";
                }
                else
                {
                    SQL = "insert into testjson (student,time,CourseId) values" + "(" + "\"" + attenddata[0] + "\"" + "," + "\"" + attenddata[2] + "\"" + "," + "\"" + attenddata[1] + "\"" + "); ";
                }
                MySqlCommand mycommand = new MySqlCommand(SQL, connection);
                try
                {
                    mycommand.ExecuteNonQuery();
                    Console.WriteLine("Insert Success");
                }
                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                    MessageBox.Show("Insert Fail");
                }
                mycommand.Dispose();
                deleteBin(attenddata[3]);
            }
            connection.Close();
            MessageBox.Show("Success insert SQL and delete bin");
            tb_result.Text = "";
            tb_resultKey.Text = "";
            tb_resultData.Text = "";
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
            if (bin_id.Contains("\r\n"))
            {
                bin_id = bin_id.Replace("\r\n", " ").Trim();
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
            myReq = WebRequest.Create("https://api.jsonbin.io/v3/b/" + bin_id);
            myReq.Method = "DELETE";
            myReq.ContentType = "application/json";
            myReq.Headers.Add("X-Master-Key", APIkey);

            try
            {
                myResp = myReq.GetResponse();
                Console.WriteLine("Delete Success");
                //MessageBox.Show("Delete Success");
                myResp.Close();
            }
            catch (WebException ex)
            {
                MessageBox.Show("Delete Fail");
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
        private void backUp()
        {
            if (tb_resultData.Text != String.Empty)
            {
                WebResponse myResp;
                WebRequest myReq;
                myReq = WebRequest.Create("https://api.jsonbin.io/v3/b");
                myReq.Method = "POST";
                myReq.ContentType = "application/json";
                myReq.Headers.Add("X-Master-Key", APIkey);
                myReq.Headers.Add("X-Bin-Name", "backUp");
                string backupformat = tb_resultData.Text.Replace("\r\n", "_");
                string backup = backupformat.Substring(0, backupformat.Length - 1);
                string[] datarecord = backup.Split('_');
                string postData = "";
                string postDatahead = "{" + "\"";
                string postDatamid = "\"" + ":" + "\"";
                string postDatatail = "\"" + "}";
                string postDatasplit = "\"";
                for (int i = 0; i < datarecord.Length; i++)
                {
                    string[] recorddata = datarecord[i].Split(':');
                    if (i == 0 && i == datarecord.Length - 1)
                    {
                        postData = postDatahead + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatatail;
                    }
                    else
                    {
                        if (i == 0 && i != datarecord.Length - 1)
                        {
                            postData = postDatahead + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatasplit;
                        }
                        else if (i == datarecord.Length - 1)
                        {
                            postData += "," + postDatasplit + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatatail;
                        }
                        else
                        {
                            postData += "," + postDatasplit + recorddata[0] + postDatamid + recorddata[1].Trim() + postDatasplit;
                        }
                    }
                }
                var data = Encoding.ASCII.GetBytes(postData);
                myReq.ContentLength = data.Length;
                using (var stream = myReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                try
                {
                    myResp = myReq.GetResponse();
                    Console.WriteLine("Backup Success");
                    //MessageBox.Show("Backup Success");
                    myResp.Close();
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Back up fail");
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
            // string sql = "SELECT *,count(*) as ontime FROM `testjson`,`subject` WHERE  time(time(testjson.time) - subject.start_time) <= time(1) and testjson.weekday=subject.Weekdays;";
            var Excelapp = new Excel.Application();
            Excelapp.Visible = true;
            Workbook workBook = Excelapp.Workbooks.Add();
            Worksheet worksheet1 = Excelapp.ActiveSheet;
            worksheet1.Name = "Ionic lesson1";
            string ionic1 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-18')";
            MySqlCommand i1cmd = new MySqlCommand(ionic1, connection);
            MySqlDataReader data = i1cmd.ExecuteReader();
            int y2sn = 0;
            int validcount = 0;
            int invalidcount = 0;
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    worksheet1.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        worksheet1.Cells[datarow, 1] = data["student_id"];
                        worksheet1.Cells[datarow, 2] = data["student_Name"];
                        worksheet1.Cells[datarow, 3] = data["time"].ToString();
                        worksheet1.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { worksheet1.Cells[datarow, 5] = "OnTime"; }
                        else { worksheet1.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                worksheet1.Columns.AutoFit();
                worksheet1.Rows.AutoFit();
            }
            data.Close();
            i1cmd.Dispose();
            string ionic1i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-18') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00'))";
            MySqlCommand i1icmd = new MySqlCommand(ionic1i, connection);
            MySqlDataReader datai = i1icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    worksheet1.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        worksheet1.Cells[datarow + validcount, 1] = datai["student_id"];
                        worksheet1.Cells[datarow + validcount, 2] = datai["student_Name"];
                        worksheet1.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        worksheet1.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        worksheet1.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                worksheet1.Columns.AutoFit();
                worksheet1.Rows.AutoFit();
            }
            worksheet1.Cells[y2sn + 5, 1] = "Total student number";
            worksheet1.Cells[y2sn + 5, 2] = y2sn;

            worksheet1.Cells[y2sn + 6, 1] = "Valid Register number";
            worksheet1.Cells[y2sn + 6, 2] = validcount;

            worksheet1.Cells[y2sn + 7, 1] = "Invalid Register number";
            worksheet1.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            worksheet1.Columns.AutoFit();
            worksheet1.Rows.AutoFit();
            datai.Close();
            i1icmd.Dispose();

            //lesson2

            Excel.Worksheet worksheet2 = workBook.Worksheets.Add();
            worksheet2.Name = "Ionic lesson2";


            string ionic2 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-19')";
            MySqlCommand i2cmd = new MySqlCommand(ionic2, connection);
            data = i2cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
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
                        worksheet2.Cells[datarow, 3] = data["time"].ToString();
                        worksheet2.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { worksheet2.Cells[datarow, 5] = "OnTime"; }
                        else { worksheet2.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                worksheet2.Columns.AutoFit();
                worksheet2.Rows.AutoFit();
            }
            data.Close();
            i2cmd.Dispose();
            string ionic2i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-19') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00')) order by student_id asc";
            MySqlCommand i2icmd = new MySqlCommand(ionic2i, connection);
            datai = i2icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    worksheet2.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        worksheet2.Cells[datarow + validcount, 1] = datai["student_id"];
                        worksheet2.Cells[datarow + validcount, 2] = datai["student_Name"];
                        worksheet2.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        worksheet2.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        worksheet2.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                worksheet2.Columns.AutoFit();
                worksheet2.Rows.AutoFit();
            }
            worksheet2.Cells[y2sn + 5, 1] = "Total student number";
            worksheet2.Cells[y2sn + 5, 2] = y2sn;

            worksheet2.Cells[y2sn + 6, 1] = "Valid Register number";
            worksheet2.Cells[y2sn + 6, 2] = validcount;

            worksheet2.Cells[y2sn + 7, 1] = "Invalid Register number";
            worksheet2.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            worksheet2.Columns.AutoFit();
            worksheet2.Rows.AutoFit();
            datai.Close();
            i2icmd.Dispose();


            //lesson3

            Excel.Worksheet worksheet3 = workBook.Worksheets.Add();
            worksheet3.Name = "Ionic lesson3";
            Worksheet currentWorksheet = worksheet3 as Worksheet;

            string ionic3 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-20')";
            MySqlCommand i3cmd = new MySqlCommand(ionic3, connection);
            data = i3cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        currentWorksheet.Cells[datarow, 3] = data["time"].ToString();
                        currentWorksheet.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { currentWorksheet.Cells[datarow, 5] = "OnTime"; }
                        else { currentWorksheet.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            data.Close();
            i3cmd.Dispose();
            string ionic3i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-20') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00'))";
            MySqlCommand i3icmd = new MySqlCommand(ionic3i, connection);
            datai = i3icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        currentWorksheet.Cells[datarow + validcount, 1] = datai["student_id"];
                        currentWorksheet.Cells[datarow + validcount, 2] = datai["student_Name"];
                        currentWorksheet.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            currentWorksheet.Cells[y2sn + 5, 1] = "Total student number";
            currentWorksheet.Cells[y2sn + 5, 2] = y2sn;

            currentWorksheet.Cells[y2sn + 6, 1] = "Valid Register number";
            currentWorksheet.Cells[y2sn + 6, 2] = validcount;

            currentWorksheet.Cells[y2sn + 7, 1] = "Invalid Register number";
            currentWorksheet.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;
            datai.Close();
            i3icmd.Dispose();


            //lesson4

            Excel.Worksheet worksheet4 = workBook.Worksheets.Add();
            worksheet4.Name = "Ionic lesson4";
            currentWorksheet = worksheet4 as Worksheet;

            string ionic4 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-21')";
            MySqlCommand i4cmd = new MySqlCommand(ionic4, connection);
            data = i4cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        currentWorksheet.Cells[datarow, 3] = data["time"].ToString();
                        currentWorksheet.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { currentWorksheet.Cells[datarow, 5] = "OnTime"; }
                        else { currentWorksheet.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            data.Close();
            i4cmd.Dispose();
            string ionic4i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-21') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00'))";
            MySqlCommand i4icmd = new MySqlCommand(ionic4i, connection);
            datai = i4icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        currentWorksheet.Cells[datarow + validcount, 1] = datai["student_id"];
                        currentWorksheet.Cells[datarow + validcount, 2] = datai["student_Name"];
                        currentWorksheet.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            currentWorksheet.Cells[y2sn + 5, 1] = "Total student number";
            currentWorksheet.Cells[y2sn + 5, 2] = y2sn;

            currentWorksheet.Cells[y2sn + 6, 1] = "Valid Register number";
            currentWorksheet.Cells[y2sn + 6, 2] = validcount;

            currentWorksheet.Cells[y2sn + 7, 1] = "Invalid Register number";
            currentWorksheet.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;
            datai.Close();
            i4icmd.Dispose();


            //lesson5

            Excel.Worksheet worksheet5 = workBook.Worksheets.Add();
            worksheet5.Name = "Ionic lesson5";
            currentWorksheet = worksheet5 as Worksheet;

            string ionic5 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-22') order by student_id asc";
            MySqlCommand i5cmd = new MySqlCommand(ionic5, connection);
            data = i5cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        currentWorksheet.Cells[datarow, 3] = data["time"].ToString();
                        currentWorksheet.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { currentWorksheet.Cells[datarow, 5] = "OnTime"; }
                        else { currentWorksheet.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            data.Close();
            i5cmd.Dispose();
            string ionic5i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-22') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00')) order by student_id asc";
            MySqlCommand i5icmd = new MySqlCommand(ionic5i, connection);
            datai = i5icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        currentWorksheet.Cells[datarow + validcount, 1] = datai["student_id"];
                        currentWorksheet.Cells[datarow + validcount, 2] = datai["student_Name"];
                        currentWorksheet.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            currentWorksheet.Cells[y2sn + 5, 1] = "Total student number";
            currentWorksheet.Cells[y2sn + 5, 2] = y2sn;

            currentWorksheet.Cells[y2sn + 6, 1] = "Valid Register number";
            currentWorksheet.Cells[y2sn + 6, 2] = validcount;

            currentWorksheet.Cells[y2sn + 7, 1] = "Invalid Register number";
            currentWorksheet.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;
            datai.Close();
            i5icmd.Dispose();



            //lesson6

            Excel.Worksheet worksheet6 = workBook.Worksheets.Add();
            worksheet6.Name = "Ionic lesson6";
            currentWorksheet = worksheet6 as Worksheet;

            string ionic6 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>time('19:30:00')and time(testjson.time)<time('23:30:00') and date(testjson.time) = date('2022-12-23') order by student_id asc;";
            MySqlCommand i6cmd = new MySqlCommand(ionic6, connection);
            data = i6cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        currentWorksheet.Cells[datarow, 3] = data["time"].ToString();
                        currentWorksheet.Cells[datarow, 4] = data["start_time"].ToString();
                        int cdc = Int32.Parse(data["timer"].ToString());
                        if (cdc < 0) { currentWorksheet.Cells[datarow, 5] = "OnTime"; }
                        else { currentWorksheet.Cells[datarow, 5] = "Late"; }
                        datarow++;
                        y2sn++;
                        validcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            data.Close();
            i6cmd.Dispose();
            string ionic6i = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and date(testjson.time) = date('2022-12-23') AND (time(testjson.time)<time('19:30:00')OR time(testjson.time)>time('23:30:00')) order by student_id asc";
            MySqlCommand i6icmd = new MySqlCommand(ionic6i, connection);
            datai = i6icmd.ExecuteReader();

            if (datai.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < datai.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = datai.GetName(i);
                    while (datai.Read())
                    {
                        currentWorksheet.Cells[datarow + validcount, 1] = datai["student_id"];
                        currentWorksheet.Cells[datarow + validcount, 2] = datai["student_Name"];
                        currentWorksheet.Cells[datarow + validcount, 3] = datai["time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 4] = datai["start_time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y2sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            currentWorksheet.Cells[y2sn + 5, 1] = "Total student number";
            currentWorksheet.Cells[y2sn + 5, 2] = y2sn;

            currentWorksheet.Cells[y2sn + 6, 1] = "Valid Register number";
            currentWorksheet.Cells[y2sn + 6, 2] = validcount;

            currentWorksheet.Cells[y2sn + 7, 1] = "Invalid Register number";
            currentWorksheet.Cells[y2sn + 7, 2] = invalidcount;
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;
            datai.Close();
            i6icmd.Dispose();


            //ionic total sheet


            Excel.Worksheet worksheet7 = workBook.Worksheets.Add();
            worksheet7.Name = "ionic total sheet";
            currentWorksheet = worksheet7 as Worksheet;

            string ionic71 = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 2";
            MySqlCommand i71cmd = new MySqlCommand(ionic71, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            List<string> studentlist = new List<string>();
            List<string> Datelist = new List<string>();
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        studentlist.Add(data["student_id"].ToString());
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        datarow++;
                        y2sn++;
                    }
                }
                //do sth here  year 2 sheet
            }
            ionic71 = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = 2 ORDER BY date(Date)";
            i71cmd = new MySqlCommand(ionic71, connection);
            data.Close();
            data = i71cmd.ExecuteReader();
            if (data.HasRows == true)
            {
                var datarow = 3;
                for (int i = 0; i < data.FieldCount; i++)
                {

                    while (data.Read())
                    {
                        currentWorksheet.Cells[1, datarow] = data["Date"];
                        Datelist.Add(data["Date"].ToString());
                        datarow++;
                        y2sn++;
                    }
                }
                //do sth here  year 2 sheet
            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            int row = 1;
            foreach (var student in studentlist)
            {
                row++;
                var col = 3;
                foreach (var date in Datelist)
                {
                    ionic71 = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')";
                   i71cmd = new MySqlCommand(ionic71, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0) { currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen; }
                            else { currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed; }
                        }
                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "null";
                    }
                    col++;
                }
            }
            row = 1;

            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();

            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;


            //try year1
            Excel.Worksheet worksheet8 = workBook.Worksheets.Add();
            worksheet8.Name = "year1 lesson";
            currentWorksheet = worksheet8 as Worksheet;

            string year1 = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and time(testjson.time)>=time('19:30:00')and time(testjson.time)<=time('23:30:00') and date(testjson.time) = date('2022-12-21') and studentinfo.Year=1 order by student_id asc;";
            MySqlCommand year1cmd = new MySqlCommand(year1, connection);
            MySqlDataReader y1data = year1cmd.ExecuteReader();
            var y1sn=0;
            if (y1data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < y1data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = y1data.GetName(i);
                    while (y1data.Read())
                    {
                        currentWorksheet.Cells[datarow + validcount, 1] = y1data["student_id"];
                        currentWorksheet.Cells[datarow + validcount, 2] = y1data["student_Name"];
                        currentWorksheet.Cells[datarow + validcount, 3] = y1data["time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 4] = y1data["start_time"].ToString();
                        currentWorksheet.Cells[datarow + validcount, 5] = "Invalid";
                        datarow++;
                        y1sn++;
                        invalidcount++;
                    }
                }
                //do sth here  year 2 sheet

                currentWorksheet.Columns.AutoFit();
                currentWorksheet.Rows.AutoFit();
            }
            currentWorksheet.Cells[y1sn + 5, 1] = "Total student number";
            currentWorksheet.Cells[y1sn + 5, 2] = y1sn;

            currentWorksheet.Cells[y1sn + 6, 1] = "Valid Register number";
            currentWorksheet.Cells[y1sn + 6, 2] = validcount;

            currentWorksheet.Cells[y1sn + 7, 1] = "Invalid Register number";
            currentWorksheet.Cells[y1sn + 7, 2] = invalidcount;
            y1sn = 0;
            validcount = 0;
            invalidcount = 0;
            y1data.Close();
            year1cmd.Dispose();
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;


            connection.Close();
            workBook.SaveAs(Environment.CurrentDirectory + @"\courseReport.xlsx");
            Marshal.ReleaseComObject(Excelapp.Workbooks);
            //Excelapp.Quit();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 login = new Form3();
            login.Show();
        }
    }
}
/*

//INSERT INTO `rawdata` (`id`, `userID`, `dateStamp`, `scanQR`, `location`) VALUES (NULL, 'hkct001', '20211216140501', '001', NULL);

        private void button2_Click_1(object sender, EventArgs e)
{
    string connectorString = "server=localhost;User Id=root;password=";
    MySqlConnection myConnnect = new MySqlConnection(connectorString);
    myConnnect.Open();
    MySqlCommand myCmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS db1", myConnnect);
    myCmd.ExecuteNonQuery();
    myCmd.Dispose();
    myConnnect.Close();
    connectorString = "server=localhost;User Id=root;password=;Database=db1";
    myConnnect = new MySqlConnection(connectorString);
    myConnnect.Open();
    String create = "CREATE TABLE IF NOT EXISTS `db1`.`attendance` ( `ID` INT NOT NULL AUTO_INCREMENT , `studentID` VARCHAR(255) NOT NULL , `time` VARCHAR(255) NOT NULL , `room` VARCHAR(255) NOT NULL , PRIMARY KEY (`ID`))";
    myCmd = new MySqlCommand(create, myConnnect);
    myCmd.ExecuteNonQuery();
    myCmd.Dispose();
    myConnnect.Close();
    String SQL = "";
    SQL = "SELECT `attendance`.`ID`,`reference`.`name`,`reference`.`groupAB`,`attendance`.`time`,`attendance`.`room` FROM `attendance`,`reference` WHERE `attendance`.`studentID` = `reference`.`studentID` AND `attendance`.`time` LIKE '" + getdate.Value.Date.ToString("yyyyMM") + "%' ORDER BY `attendance`.`ID`";
    myConnnect.Open();
    myCmd = new MySqlCommand(SQL, myConnnect);
    MySqlDataReader data = myCmd.ExecuteReader();
    int read = 0;
    //String result = "";
    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
    if (excel == null) { MessageBox.Show("Excel not found"); return; }
    Workbook workbook1 = excel.Workbooks.Add();
    workbook1.Worksheets.Add();
    Worksheet worksheet1 = workbook1.Worksheets.get_Item(1);
    Worksheet worksheet2 = workbook1.Worksheets.get_Item(2);
    worksheet1.Name = "raw_data";
    worksheet2.Name = "attendance";
    worksheet1.Cells[1, 1] = "ID";
    worksheet1.Cells[1, 2] = "name";
    worksheet1.Cells[1, 3] = "group";
    worksheet1.Cells[1, 4] = "time";
    worksheet1.Cells[1, 5] = "room";
    int i = 2;

    while (data.Read())
    {
        //MessageBox.Show(data["id"] + ". studentID = " + data["studentID"] +" time = " + data["time"]+" room = " + data["room"]);
        //result += data["id"] + ". studentID = " + data["studentID"] + " time = " + data["time"] + " room = " + data["room"] + "\n";
        read++;
        worksheet1.Cells[i, 1] = data["id"];
        worksheet1.Cells[i, 2] = data["name"];
        worksheet1.Cells[i, 3] = data["groupAB"];
        worksheet1.Cells[i, 4] = DateTime.ParseExact(data["time"].ToString(), "yyyyMMddHHmmss", new CultureInfo("fr-FR"));
        worksheet1.Cells[i, 5] = data["room"];
        i++;
    }
    if (read == 0)
    {
        MessageBox.Show("Data not found");
    }
    else
    {
        data.Close();
        myCmd.Dispose();

        SQL = "SELECT `time` FROM `class` WHERE `time` LIKE '" + getdate.Value.Date.ToString("yyyyMM") + "%'";
        myCmd = new MySqlCommand(SQL, myConnnect);
        data = myCmd.ExecuteReader();
        int j = 2;
        List<String> date = new List<string>();
        while (data.Read())
        {
            date.Add(data["time"].ToString());
            worksheet2.Cells[1, j] = DateTime.ParseExact(data["time"].ToString(), "yyyyMMdd", new CultureInfo("fr-FR")).ToString("yyyy/MM/dd");
            j++;
        }
        data.Close();
        myCmd.Dispose();
        SQL = "SELECT `name` FROM `reference`";
        myCmd = new MySqlCommand(SQL, myConnnect);
        data = myCmd.ExecuteReader();
        int k = 2;
        List<String> name = new List<string>();
        while (data.Read())
        {
            worksheet2.Cells[k, 1] = data["name"];
            name.Add(data["name"].ToString());
            k++;
        }
        data.Close();
        myCmd.Dispose();
        int d = 0;
        int n = 0;
        for (; d < date.Count(); d++)
        {
            n = 0;
            for (; n < name.Count(); n++)
            {
                SQL = "SELECT `reference`.`name`,`attendance`.`time`,`attendance`.`room` FROM `attendance`,`reference`,`class` WHERE DAYOFYEAR(`attendance`.`time`) = DAYOFYEAR(`class`.`time`) AND DAYOFYEAR(`class`.`time`) = DAYOFYEAR('" + date[d] + "') AND `attendance`.`room` = `class`.`room` AND `attendance`.`studentID` = `reference`.`studentID` AND `reference`.`name` = '" + name[n] + "'";
                myCmd = new MySqlCommand(SQL, myConnnect);
                data = myCmd.ExecuteReader();
                if (data.Read() == true)
                {
                    worksheet2.Cells[n + 2, d + 2] = "v";
                }
                myCmd.Dispose();
                data.Dispose();
                data.Close();
            }
        }
        worksheet2.Cells[1, d + 2] = "attendance_rate";
        n = 0;
        char R = 'B';
        char R2 = R;
        for (int z = 0; z < d - 1; z++)
        {
            R2++;
        }
        for (; n < name.Count(); n++)
        {
            R = 'B';
            worksheet2.Cells[n + 2, d + 2] = "=(COUNTA(" + R + (n + 2) + ":" + R2 + (n + 2) + ")/COUNTA(" + R + "1:" + R2 + "1))*100";
            R++;
        }

        //MessageBox.Show(result);
        workbook1.SaveAs(Environment.CurrentDirectory + @"\Report_generated_at_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx");
        MessageBox.Show("Excel generated");
    }
    Range range1 = worksheet1.UsedRange;
    Range range2 = worksheet2.UsedRange;

    Marshal.ReleaseComObject(worksheet1);
    Marshal.ReleaseComObject(worksheet2);
    Marshal.ReleaseComObject(range1);
    workbook1.Close(false);
    Marshal.ReleaseComObject(workbook1);
    Marshal.ReleaseComObject(excel.Workbooks);
    excel.Quit();
    Marshal.ReleaseComObject(excel);
    data.Close();
    myCmd.Dispose();
    myConnnect.Close();
    GC.Collect();
    GC.WaitForPendingFinalizers();
}
    }
}
*/