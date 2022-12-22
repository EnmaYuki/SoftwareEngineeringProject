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
                            if ( cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString()=="1") )
                            {
                                D = "08";
                            }
                            else if (cb_courseid.SelectedItem.ToString() == "2" &&( cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                            {
                                D = "18";
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
                        if (cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "1"))
                        {
                            D = "09";
                        }
                        else if (cb_courseid.SelectedItem.ToString() == "2" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                        {
                            D = "19";
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
                        if (cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "1"))
                        {
                            D = "10";
                        }
                        else if (cb_courseid.SelectedItem.ToString() == "2" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                        {
                            D = "20";
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
                        if (cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "1"))
                        {
                            D = "11";
                        }
                        else if (cb_courseid.SelectedItem.ToString() == "2" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                        {
                            D = "21";
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
                        if (cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "1"))
                        {
                            D = "12";
                        }
                        else if (cb_courseid.SelectedItem.ToString() == "2" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                        {
                            D = "22";
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
                        if (cb_courseid.SelectedItem.ToString() == "3" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "1"))
                        {
                            D = "13";
                        }
                        else if (cb_courseid.SelectedItem.ToString() == "2" && (cb_studentyear.SelectedItem.ToString() == "All" || cb_studentyear.SelectedItem.ToString() == "2"))
                        {
                            D = "23";
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

            int y2sn = 0;
            int validcount = 0;
            int invalidcount = 0;




            //
            //ionic total sheet
            //
            Excel.Worksheet worksheet1 = workBook.Worksheets.Add();
            worksheet1.Name = "ionic total sheet";
            Worksheet currentWorksheet = worksheet1 as Worksheet;
            int courseid = 2;
            string ionic71 = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 2";
            MySqlCommand i71cmd = new MySqlCommand(ionic71, connection);
            MySqlDataReader data = i71cmd.ExecuteReader();
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


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            int row = 1;
            int rowsize = studentlist.Capacity;
            Double[,] matrix = new double[Datelist.Capacity, studentlist.Capacity];
            foreach (var student in studentlist)
            {
                row++;
                var col = 3;
                foreach (var date in Datelist)
                {

                    ionic71 = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')and courseId = " + courseid;

                    i71cmd = new MySqlCommand(ionic71, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix[row - 1, col - 2] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelist.Capacity; i++)
                {

                    if (matrix[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[row - 2, i] < 1 && matrix[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab - 2;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelist.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelist.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelist.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlist.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlist.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlist.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelist.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlist.Capacity; student++)
                {


                    if (matrix[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[student, lesson] < 1 && matrix[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlist.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlist.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlist.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlist.Capacity, 3 + lesson] = ab;
            }
            Microsoft.Office.Interop.Excel.Range chartRange;
            Microsoft.Office.Interop.Excel.ChartObjects xlCharts =
                (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            Microsoft.Office.Interop.Excel.ChartObject myChart =
                (Excel.ChartObject)xlCharts.Add(0, 150, 300, 250);
            Microsoft.Office.Interop.Excel.Chart chartPage = myChart.Chart;
            object misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b10", "h13");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            //currentWorksheet.get_Range("b10", "h13").EntireColumn.Hidden = true;
            //currentWorksheet.get_Range("i1", "l9").EntireRow.Hidden = true;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;


            //
            //Unity total sheet
            //

            Excel.Worksheet worksheet7 = workBook.Worksheets.Add();
            worksheet7.Name = "Unity total sheet";
            currentWorksheet = worksheet7 as Worksheet;

            ionic71 = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 2";
            i71cmd = new MySqlCommand(ionic71, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            studentlist = new List<string>();
            Datelist = new List<string>();
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


            }
            courseid = 1;
            ionic71 = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = " + courseid + " ORDER BY date(Date)";
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


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            row = 1;
            rowsize = studentlist.Capacity;
            matrix = new double[Datelist.Capacity, studentlist.Capacity];
            foreach (var student in studentlist)
            {
                row++;
                var col = 3;
                foreach (var date in Datelist)
                {

                    ionic71 = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')and courseId = " + courseid;

                    i71cmd = new MySqlCommand(ionic71, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix[row - 1, col - 2] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelist.Capacity; i++)
                {

                    if (matrix[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[row - 2, i] < 1 && matrix[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab - 2;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelist.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelist.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelist.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlist.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlist.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlist.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelist.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlist.Capacity; student++)
                {


                    if (matrix[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[student, lesson] < 1 && matrix[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlist.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlist.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlist.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlist.Capacity, 3 + lesson] = ab;
            }
            xlCharts =
               (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            myChart =
                (Excel.ChartObject)xlCharts.Add(0, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b10", "h13");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            //currentWorksheet.get_Range("b10", "h13").EntireColumn.Hidden = true;
            //currentWorksheet.get_Range("i1", "l9").EntireRow.Hidden = true;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;

            //
            //SQL total sheet
            //

            Excel.Worksheet worksheet10 = workBook.Worksheets.Add();
            worksheet10.Name = "SQL total sheet";
            currentWorksheet = worksheet10 as Worksheet;

            ionic71 = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 2";
            i71cmd = new MySqlCommand(ionic71, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            studentlist = new List<string>();
            Datelist = new List<string>();
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


            }
            courseid = 6;
            ionic71 = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = " + courseid + " ORDER BY date(Date)";
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


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            row = 1;
            rowsize = studentlist.Capacity;
            matrix = new double[Datelist.Capacity, studentlist.Capacity];
            foreach (var student in studentlist)
            {
                row++;
                var col = 3;
                foreach (var date in Datelist)
                {

                    ionic71 = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "') and courseId = " + courseid + ";";

                    i71cmd = new MySqlCommand(ionic71, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix[row - 1, col - 2] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelist.Capacity; i++)
                {

                    if (matrix[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[row - 2, i] < 1 && matrix[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab - 2;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelist.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelist.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelist.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlist.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlist.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlist.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelist.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlist.Capacity; student++)
                {


                    if (matrix[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix[student, lesson] < 1 && matrix[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlist.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlist.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlist.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlist.Capacity, 3 + lesson] = ab;
            }
            xlCharts =
               (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            myChart =
                (Excel.ChartObject)xlCharts.Add(0, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b10", "h13");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            //currentWorksheet.get_Range("b10", "h13").EntireColumn.Hidden = true;
            //currentWorksheet.get_Range("i1", "l9").EntireRow.Hidden = true;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;



            //
            //java total worksheet
            //


            Excel.Worksheet worksheet8 = workBook.Worksheets.Add();
            worksheet8.Name = "java total sheet";
            currentWorksheet = worksheet8 as Worksheet;
            string javasql = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 1";
            i71cmd = new MySqlCommand(javasql, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            List<string> studentlistj = new List<string>();
            List<string> Datelistj = new List<string>();
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        studentlistj.Add(data["student_id"].ToString());
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        datarow++;
                        y2sn++;
                    }
                }


            }
            courseid = 5;
            javasql = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = 5 ORDER BY date(Date)";
            i71cmd = new MySqlCommand(javasql, connection);
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
                        Datelistj.Add(data["Date"].ToString());
                        datarow++;
                        y2sn++;
                    }
                }


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            row = 1;
            rowsize = studentlist.Capacity;


            Double[,] matrix2 = new double[Datelistj.Capacity, studentlistj.Capacity + 2];
            foreach (var student in studentlistj)
            {
                row++;
                var col = 3;
                foreach (var date in Datelistj)
                {

                    javasql = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')and courseId = " + courseid;

                    i71cmd = new MySqlCommand(javasql, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix2[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix2[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix2[row - 2, col - 3] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelistj.Capacity - 2; i++)
                {
                    if (matrix2[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix2[row - 2, i] < 1 && matrix2[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix2[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelistj.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelistj.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelistj.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlistj.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlistj.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlistj.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelistj.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlistj.Capacity; student++)
                {


                    if (matrix2[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix2[student, lesson] < 1 && matrix[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix2[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlistj.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlistj.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlistj.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlistj.Capacity, 3 + lesson] = ab;
            }

            xlCharts = (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            myChart = (Excel.ChartObject)xlCharts.Add(0, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b6", "h9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;

            //
            //C# total worksheet
            //


            Excel.Worksheet worksheet12 = workBook.Worksheets.Add();
            worksheet12.Name = "C# total sheet";
            currentWorksheet = worksheet12 as Worksheet;
            javasql = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 1";
            i71cmd = new MySqlCommand(javasql, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            studentlistj = new List<string>();
            Datelistj = new List<string>();
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        studentlistj.Add(data["student_id"].ToString());
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        datarow++;
                        y2sn++;
                    }
                }


            }
            courseid = 3;
            javasql = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = 3 ORDER BY date(Date)";
            i71cmd = new MySqlCommand(javasql, connection);
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
                        Datelistj.Add(data["Date"].ToString());
                        datarow++;
                        y2sn++;
                    }
                }


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            row = 1;
            rowsize = studentlist.Capacity;

            matrix2 = new double[Datelistj.Capacity, studentlistj.Capacity + 2];
            foreach (var student in studentlistj)
            {
                row++;
                var col = 3;
                foreach (var date in Datelistj)
                {

                    javasql = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')and courseId = " + courseid;

                    i71cmd = new MySqlCommand(javasql, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix2[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix2[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix2[row - 2, col - 3] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelistj.Capacity - 2; i++)
                {
                    if (matrix2[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix2[row - 2, i] < 1 && matrix2[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix2[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelistj.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelistj.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelistj.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlistj.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlistj.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlistj.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelistj.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlistj.Capacity; student++)
                {


                    if (matrix2[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix2[student, lesson] < 1 && matrix[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix2[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlistj.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlistj.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlistj.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlistj.Capacity, 3 + lesson] = ab;
            }

            xlCharts = (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            myChart = (Excel.ChartObject)xlCharts.Add(0, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 150, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b6", "h9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;

            //
            //python total worksheet
            //


            Excel.Worksheet worksheet9 = workBook.Worksheets.Add();
            worksheet9.Name = "python total sheet";
            currentWorksheet = worksheet9 as Worksheet;
            string pythonsql = "SELECT student_id, Student_Name FROM `studentinfo` WHERE Year = 1 or Year =2 ORDER By student_id";
            i71cmd = new MySqlCommand(pythonsql, connection);
            data = i71cmd.ExecuteReader();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            List<string> studentlistp = new List<string>();
            List<string> Datelistp = new List<string>();
            if (data.HasRows == true)
            {
                var datarow = 2;
                for (int i = 0; i < data.FieldCount; i++)
                {
                    currentWorksheet.Cells[1, i + 1] = data.GetName(i);
                    while (data.Read())
                    {
                        currentWorksheet.Cells[datarow, 1] = data["student_id"];
                        studentlistp.Add(data["student_id"].ToString());
                        currentWorksheet.Cells[datarow, 2] = data["student_Name"];
                        datarow++;
                        y2sn++;
                    }
                }


            }
            courseid = 4;
            pythonsql = "SELECT date(Date) as Date FROM `lessons` WHERE courseId = 4 ORDER BY date(Date)";
            i71cmd = new MySqlCommand(pythonsql, connection);
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
                        Datelistp.Add(data["Date"].ToString());
                        datarow++;
                        y2sn++;
                    }
                }


            }
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            row = 1;
            rowsize = studentlist.Capacity;

            Double[,] matrix3 = new double[Datelistp.Capacity + 4, studentlistp.Capacity + 4];
            foreach (var student in studentlistp)
            {
                row++;
                var col = 3;
                foreach (var date in Datelistp)
                {

                    javasql = "SELECT testjson.student, testjson.time, testjson.CourseId,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.student='" + student + "'and date(testjson.time) = date('" + date + "')and courseId = " + courseid;
                    i71cmd = new MySqlCommand(javasql, connection);
                    data.Close();
                    data = i71cmd.ExecuteReader();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            currentWorksheet.Cells[row, col] = data["time"].ToString();
                            int cdc = Int32.Parse(data["timer"].ToString());
                            if (cdc < 0)
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbGreen;
                                matrix3[row - 2, col - 3] = 1;
                            }
                            else
                            {
                                currentWorksheet.Cells[row, col].Interior.Color = Excel.XlRgbColor.rgbRed;
                                matrix3[row - 2, col - 3] = 0.0001;
                            }
                        }

                    }
                    else
                    {
                        currentWorksheet.Cells[row, col] = "absent";
                        matrix3[row - 2, col - 3] = 0;
                    }

                    col++;
                }
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int i = 0; i < Datelistp.Capacity - 2; i++)
                {
                    if (matrix3[row - 2, i] == 1)
                    {
                        pr++;
                    }
                    else if (matrix3[row - 2, i] < 1 && matrix3[row - 2, i] > 0)
                    {
                        la++;
                    }
                    else if (matrix3[row - 2, i] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[row, col] = currentWorksheet.Cells[row, 2];
                currentWorksheet.Cells[row, col + 1] = pr;
                currentWorksheet.Cells[row, col + 2] = la;
                currentWorksheet.Cells[row, col + 3] = ab;

            }
            row = 1;
            currentWorksheet.Cells[1, Datelistp.Capacity + 2] = "Presented";
            currentWorksheet.Cells[1, Datelistp.Capacity + 3] = "Late";
            currentWorksheet.Cells[1, Datelistp.Capacity + 4] = "Absent";
            currentWorksheet.Cells[studentlistp.Capacity + 3, 2] = "Presented";
            currentWorksheet.Cells[studentlistp.Capacity + 4, 2] = "Late";
            currentWorksheet.Cells[studentlistp.Capacity + 5, 2] = "Absent";

            for (int lesson = 0; lesson < Datelistp.Capacity - 2; lesson++)
            {
                int pr = 0;
                int la = 0;
                int ab = 0;
                for (int student = 0; student < studentlistp.Capacity - 4; student++)
                {


                    if (matrix3[student, lesson] == 1)
                    {
                        pr++;
                    }
                    else if (matrix3[student, lesson] < 1 && matrix3[student, lesson] > 0)
                    {
                        la++;
                    }
                    else if (matrix3[student, lesson] == 0)
                    {
                        ab++;
                    }
                }
                currentWorksheet.Cells[2 + studentlistp.Capacity, 3 + lesson] = "lesson " + (lesson + 1);
                currentWorksheet.Cells[3 + studentlistp.Capacity, 3 + lesson] = pr;
                currentWorksheet.Cells[4 + studentlistp.Capacity, 3 + lesson] = la;
                currentWorksheet.Cells[5 + studentlistp.Capacity, 3 + lesson] = ab;
            }

            xlCharts = (Excel.ChartObjects)currentWorksheet.ChartObjects(Type.Missing);
            myChart = (Excel.ChartObject)xlCharts.Add(0, 200, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;


            chartRange = currentWorksheet.get_Range("i1", "l9");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            myChart = (Excel.ChartObject)xlCharts.Add(350, 200, 300, 250);
            chartPage = myChart.Chart;
            misValue = System.Reflection.Missing.Value;
            chartRange = currentWorksheet.get_Range("b18", "h21");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;



            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            data.Close();
            i71cmd.Dispose();
            y2sn = 0;
            validcount = 0;
            invalidcount = 0;
            //currentWorksheet.get_Range("b10", "h13").EntireColumn.Hidden = true;
            //currentWorksheet.get_Range("i1", "l9").EntireRow.Hidden = true;
            currentWorksheet.Columns.AutoFit();
            currentWorksheet.Rows.AutoFit();
            currentWorksheet = null;

            connection.Close();
            workBook.SaveAs(Environment.CurrentDirectory + @"\courseReport.xlsx");
            Marshal.ReleaseComObject(Excelapp.Workbooks);
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 login = new Form3();
            login.Show();
        }
    }
}