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
        private string student_id;
        public void setStudent(string thisstudent_id)
        {
            this.student_id = thisstudent_id;
        }
        public string getStudent()
        {
            return student_id;
        }
        //Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time-subject.start_time) as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id and testjson.time BETWEEN "19:00:00" AND "01:00:00";
        private void btn_addJSONbin_Click(object sender, EventArgs e)
        {
            /*
            if (cb_studentyear.SelectedItem.ToString() == "1")
            {
            }
            else if (cb_hour.SelectedItem.ToString() == "2")
            {
            }
            else if (level_picker.SelectedItem.ToString() == "Hard")
            {
            }
            player = tb_name.Text + " (" + level_picker.SelectedItem.ToString() + ")";
            playerS = player;
            Hide();
            */
            if (cb_hour.SelectedItem.ToString() != string.Empty)
            {
                connection.Open();
                string venuecheck = "select * from`subject` where " + "\"" + cb_courseid.SelectedItem.ToString() + "\"" + "=id;";
                MySqlCommand mySql = new MySqlCommand(venuecheck, connection);
                MySqlDataReader sqlreader = mySql.ExecuteReader();
                if (sqlreader.HasRows == true)
                {
                    WebResponse myResp;
                    WebRequest myReq;
                    myReq = WebRequest.Create("https://api.jsonbin.io/v3/b");
                    myReq.Method = "POST";
                    myReq.ContentType = "application/json";

                    myReq.Headers.Add("X-Master-Key", APIkey);

                    myReq.Headers.Add("X-Bin-Name", cb_courseid.SelectedItem.ToString() + "|" + getStudent().ToString() + "|" + dateTime.ToString("yyyyMMdd"+cb_hour.SelectedItem.ToString()+"mmss"));
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
                        //MessageBox.Show("Add Success");
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
                MessageBox.Show("Please enter your lesson location!");
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
            //MessageBox.Show("Finished");
            backUp();
        }
        private void btn_toSQL_Click(object sender, EventArgs e)
        {
            connection.Open();
            string attendformat = tb_result.Text.Replace("\r\n", "_");
            string att = attendformat.Substring(0, attendformat.Length - 1);
            string[] attendrecord = att.Split('_');
            string SQL = "";
            string sqlhead = "insert into testjson (student,weekday,time,Venue) values";
            string valueshead = "(" + "\"";
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
                    SQL = sqlhead + valueshead + attenddata[1] + valuesmidend + "weekday(\"" + attenddata[2] + "\")+1" + valuesmidstart + attenddata[2] + valuesmid + attenddata[0] + valuesend + sqltail;
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
                    Console.WriteLine("Insert Success");
                    //MessageBox.Show("Insert Success");
                }
                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                    MessageBox.Show("Insert Fail");
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
            string sql = "Select count(student_id) as total from studentinfo where year= 1;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader datareader = cmd.ExecuteReader();
            var Excelapp = new Excel.Application();
            Excelapp.Visible = true;
            Workbook workBook = Excelapp.Workbooks.Add();
            Worksheet worksheet = Excelapp.ActiveSheet;
            if (datareader.HasRows == true)
            {
                worksheet.Name = "subject";
                var datarow = 2;
                while (datareader.Read())
                {
                    worksheet.Cells[datarow, 1] = datareader["total"];
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
            }
            datareader.Close();
            cmd.Dispose();
            Excel.Worksheet worksheet1 = workBook.Worksheets.Add();
            worksheet1.Name = "Year1 Students";
            string year1student = "Select student_id,Student_Name from `studentinfo` where year= 1;";
            MySqlCommand y1cmd = new MySqlCommand(year1student, connection);
            MySqlDataReader dataReader = y1cmd.ExecuteReader();
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
                //do sth here for year 1 sheet
                worksheet1.Columns.AutoFit();
                worksheet1.Rows.AutoFit();
            }
            dataReader.Close();
            y1cmd.Dispose();
            Excel.Worksheet worksheet2 = workBook.Worksheets.Add();
            worksheet2.Name = "Year2 Students";
            //string year2student = "Select student_id,Student_Name from `studentinfo` where year= 2;";

            string year2student = "Select studentinfo.student_id,studentinfo.Student_Name,time(testjson.time) as time,subject.start_time, time(testjson.time)-subject.start_time as timer From studentinfo, testjson,subject where testjson.student= studentinfo.student_id and testjson.CourseId= subject.id;";
            MySqlCommand y2cmd = new MySqlCommand(year2student, connection);
            MySqlDataReader data = y2cmd.ExecuteReader();
            int y2sn = 0;
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
                    }
                }
                //do sth here  year 2 sheet

                worksheet2.Columns.AutoFit();
                worksheet2.Rows.AutoFit();
            }
            worksheet2.Cells[y2sn + 5, 1] = "Total student number";
            worksheet2.Cells[y2sn + 5, 2] = y2sn;
            y2sn = 0;
            worksheet2.Columns.AutoFit();
            worksheet2.Rows.AutoFit();
            data.Close();
            y2cmd.Dispose();
            //string coursesql = "SELECT subject.course_name from subject,testjson,studentinfo where subject.venue=" + "\"" + "MUC508" + "\"" + " and subject.Weekdays=" + "weekday( " + dateTime.ToString("yyyyMMddHHmmss") + ")+1 and time(time(" + dateTime.ToString("yyyyMMddHHmmss") + ") - subject.start_time) <= time(1) and (studentinfo.student_id=testjson.student) and subject.SchoolYear=studentinfo.Year;";
            //MySqlCommand mySqlCommand = new MySqlCommand(coursesql, connection);
            // string _name = (string)mySqlCommand.ExecuteScalar();
            //mySqlCommand.Dispose();

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