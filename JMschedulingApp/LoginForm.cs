using JMschedulingApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMschedulingApp
{
    public partial class LoginForm : Form
    {
        public string errorMsg = "The username and password did not match.";
        public LoginForm()
        {
            InitializeComponent();

            if (CultureInfo.CurrentUICulture.LCID == 3084)
            {
                LoginHeaderLabel.Text = "CONNEXION";
                userNamelabel.Text = "Nom d'utilisateur";
                passwordLabel.Text = "Mot de passe";
                LoginButton.Text = "Connexion";
                CancelButton.Text = "Annuler";
                errorMsg = "Le nom d'utilisateur et le mot de passe ne correspondent pas.";
            }
        }

        //login user activity statement lambda
        Action <string> logUserActivity = (logText) =>
       {
            //string path = @"C:\login_file.txt";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //    var textWriter = new StreamWriter(path,true);
            //    textWriter.WriteLine(logText);
            //    textWriter.Close();
            //    MessageBox.Show(textWriter.ToString());
            //}
            //else if (Directory.Exists(path))
            //{
            //    var textWriter = new StreamWriter(path, true);
            //    textWriter.WriteLine(logText);
            //    textWriter.Close();
            //    MessageBox.Show(textWriter.ToString());
            //}

            //Gets current directory information to write the log file to.
            DirectoryInfo info = new DirectoryInfo(".");

           string logPath = info + "\\login_file.txt";// change directory
            if (!File.Exists(logPath))
           {
               var file = File.Create(logPath);
               file.Close();
               TextWriter textWriter = new StreamWriter(logPath);
               textWriter.WriteLine(logText);
               textWriter.Close();
           }
           else if (File.Exists(logPath))
           {
               using (var textWriter = new StreamWriter(logPath, true))
               {
                   textWriter.WriteLine(logText);
               }
           }
       };

        //Login button click event listener 
        private  void LoginButton_Click(object sender, EventArgs e)
        {
            //Login file statements
            string loginSuccess = $"User:{UserNametextBox.Text} successfully " +
                $"logged in at {DateTime.Now}";// success

            string loginFail = $"User:{UserNametextBox.Text} fails to " +
               $"log in at {DateTime.Now}";// failure


            try
            {
               
                if (DbConnection.CheckLogin(UserNametextBox.Text.Trim(), PassWordtextBox.Text.Trim()))
                 {
                   // MessageBox.Show("Connection set");

                    Main mainForm = new Main();
                    this.Hide();
                    mainForm.Show();

                   
                    var idString = $"SELECT userId from user where userName = '{UserNametextBox.Text}'";
                    MySqlCommand cmd = new MySqlCommand(idString, DbConnection.conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    string aptcheck = @"SELECT * FROM appointment 
                                        WHERE userId = @USERID AND
                                         start BETWEEN @START AND @END";

                    var start = DateTime.Now.ToUniversalTime();
                    var end = DateTime.Now.AddMinutes(15).ToUniversalTime();

                    MySqlCommand checkcmd = new MySqlCommand(aptcheck, DbConnection.conn);

                    foreach (DataRow row in dt.Rows)
                    {
                        checkcmd.Parameters.AddWithValue("@USERID", row[0].ToString());
                    }

                    checkcmd.Parameters.AddWithValue("@START", start);
                    checkcmd.Parameters.AddWithValue("@END", end);


                    MySqlDataAdapter checkadp = new MySqlDataAdapter(checkcmd);
                    DataTable checkdt = new DataTable();
                    checkadp.Fill(checkdt);

                    if (checkdt.Rows.Count > 0)
                    {
                        MessageBox.Show("You have an appointment in 15 minutes");
                    }

                    logUserActivity(loginSuccess);

                    /*******Had to make  AppointmentdataGridView "public"
                     * by using "Modifiers" in form designer properties*******/

                    //AppointmentForm dataGridView = new AppointmentForm();

                    //foreach (DataGridViewRow Row in dataGridView.AppointmentdataGridView.Rows)
                    //{
                    //   var dateTimeNow =  DateTime.Now;
                    //   var timedifference = ((DateTime)Row.Cells[4].Value).ToLocalTime() - dateTimeNow;


                    //    foreach (DataRow row in dt.Rows)
                    //    {
                    //        //MessageBox.Show(row[0].ToString());

                    //        if (Row.Cells[2].Value.ToString() == row[0].ToString())
                    //        {
                    //            if (timedifference.Minutes < 15 && timedifference.Hours == 0)
                    //            {
                    //                MessageBox.Show($"You have an appointment in {timedifference.Minutes}");
                    //            }
                    //        }
                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show(errorMsg);
                    UserNametextBox.Clear();
                    PassWordtextBox.Clear();
                    UserNametextBox.Focus();

                    logUserActivity(loginFail);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
