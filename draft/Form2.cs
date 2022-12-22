using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace JSONandSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string connectionString = "server=localhost;User Id=root;password=;Database=softwareengineera2; convert zero datetime=True";
        MySqlConnection connection = new MySqlConnection(connectionString);
        private string collectionID = "638073a80e6a79321e555207";
        private string APIkey = "$2b$10$l5EyYl0U3FvpMQULZaPjX.uPNB86iNFrnKVtTLDMLVu3DuDweIxHi";
        private string student_id;
        private string student_year;
        DateTime dateTime = DateTime.Now;
        public void setStudentid(string thisstudent_id)
        {
            this.student_id = thisstudent_id;
        }
        public string getStudentid()
        {
            return student_id;
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
        public void setYear(string thisyear)
        {
            this.student_year = thisyear;
        }
        public string getYear() { return student_year; }
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
        private void Form2_Load(object sender, EventArgs e)
        {
            connection.Open();
            string studentyear = "Select Year from studentinfo where student_id=" + "\"" + getStudentid() + "\"" + ";";
            MySqlCommand command=new MySqlCommand(studentyear, connection);
            string studentYear=command.ExecuteScalar().ToString();
            setYear(studentYear);
            command.Dispose();
            if (getYear() == "1")
            {
                cb_courseid.Items.Remove("1");
                cb_courseid.Items.Remove("2");
                cb_courseid.Items.Remove("6");
            }else
            {
                cb_courseid.Items.Remove("3");
                cb_courseid.Items.Remove("5");
            }
            string studentname = "Select Student_Name from studentinfo where student_id=" + "\"" + getStudentid() + "\"" + ";";
            MySqlCommand namecommand = new MySqlCommand(studentname, connection);
            string studentName = (string)namecommand.ExecuteScalar();
            namecommand.Dispose();
            this.Text="Hello, " + studentName;
            connection.Close();
        }
        private void btn_addJSONbin_Click(object sender, EventArgs e)
        {
            if (cb_courseid.SelectedItem.ToString() != string.Empty)
            {
                connection.Open();
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

                    myReq.Headers.Add("X-Bin-Name", getStudentid() + "|" + cb_courseid.SelectedItem.ToString() + "|" +dateTime.ToString("yyyyMMddHHmmss"));
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
                    MessageBox.Show("Please enter your lesson location correctly!");
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
            
            for (int i = 0; i < attendrecord.Length; i++)
            {
                string[] attenddata = attendrecord[i].Split('|');
                string SQL = "insert into testjson (student,time,CourseId) values" + "(" + "\"" + attenddata[0] + "\"" + "," + "\"" + attenddata[2] + "\"" + "," + "\"" + attenddata[1] + "\"" + "); ";
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
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 login = new Form3();
            login.Show();
        }
    }
}
