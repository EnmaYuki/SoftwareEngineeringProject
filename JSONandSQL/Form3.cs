using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JSONandSQL
{
    public partial class Form3 : Form
    {
        static string connectionString = "server=localhost;User Id=root;password=;Database=softwareengineera2";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public Form3()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_userID.Text != "" || tb_username.Text != "")
            {
                checkRole();
            }
            else
            {
                MessageBox.Show("Please input your information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkRole()
        {

            connection.Open();
            string checker = "SELECT teacher_id, Greeting FROM `teacherinfo` WHERE teacher_id ="+"\'" + tb_userID.Text + "\'" + "and Greeting =" + "\'" + tb_username.Text + "\'" + ";";
            MySqlCommand cmd = new MySqlCommand(checker,connection);
            
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    string messagecaption = "Hello, " + reader["Greeting"] + " sir";
                    if (reader["teacher_id"].ToString().Contains("_H-"))
                    {
                        DialogResult dialog = MessageBox.Show("Need to add subject? \n Press No for view jsonbin.",messagecaption , MessageBoxButtons.YesNoCancel);

                        if (dialog == DialogResult.Yes)
                        {
                            Form2 addsubject = new Form2();
                            addsubject.Show();
                        }
                        else if (dialog == DialogResult.No)
                        {
                            Form1 jsonandsql = new Form1();
                            jsonandsql.Show();
                        }
                        else if (dialog == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("View jsonbin?", messagecaption, MessageBoxButtons.OKCancel);

                        if (dialog == DialogResult.OK)
                        {
                            Form1 jsonandsql = new Form1();
                            jsonandsql.Show();
                        }
                        else if (dialog == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            else
            {
                reader.Close();
                cmd.Dispose();
                connection.Close();
                student();
            }
            reader.Close();
            cmd.Dispose();
            connection.Close();
        }
        private void student()
        {
            connection.Open();
            string checker = "SELECT student_id, Student_Name FROM `studentinfo` WHERE student_id =" + "\'" + tb_userID.Text + "\'"+ "or Student_Name =" + "\'" + tb_username.Text + "\'" + ";";
            MySqlCommand cmd = new MySqlCommand(checker, connection);
            
            MySqlDataReader studentreader = cmd.ExecuteReader();

            if (studentreader.HasRows == true)
            {
                while (studentreader.Read())
                {
                    DialogResult dialog = MessageBox.Show("Take attendance?", "Hello, " + studentreader["Student_Name"], MessageBoxButtons.OKCancel);

                    if (dialog == DialogResult.OK)
                    {
                        Form1 jsonandsql = new Form1();
                        jsonandsql.Show();
                    }
                    else if (dialog == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            else
            {
                studentreader.Close();
                cmd.Dispose();
                connection.Close();
                MessageBox.Show("Please enter your information correctly!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            studentreader.Close();
            cmd.Dispose();
            connection.Close();
        }

        private void btn_viewer_Click(object sender, EventArgs e)
        {
            if (tb_userID.PasswordChar == '?')
            {
                tb_userID.PasswordChar = '\0';
            }
            else
            {
                tb_userID.PasswordChar = '?';
            }            
        }
    }
}