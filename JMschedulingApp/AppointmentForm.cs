using JMschedulingApp.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMschedulingApp
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            loadAppointmentGridView();
            populateConsultantReportGridView();


            LoadMeetingTypes();
            LoadUserIDs();
            LoadCustomerIds();
            FillReportComboboxes();
            
        }

       
        //UserId Method to retrieve user
        //ID from database
        private void LoadUserIDs()
        {
            DbConnection.startConnection();

            var selectUserId = "SELECT userId FROM user";

            MySqlCommand command = new MySqlCommand(selectUserId, DbConnection.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            UserIDcomboBox.DataSource = dataTable;
            UserIDcomboBox.DisplayMember = "userId";
        }


        //CustomerId Method to retrieve customer
        //ID from database
        private void LoadCustomerIds()
        {
            DbConnection.startConnection();

            var selectCustomerId = "SELECT customerId FROM customer";

            MySqlCommand command = new MySqlCommand(selectCustomerId, DbConnection.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            CustomerIDcomboBox.DataSource = dataTable;
            CustomerIDcomboBox.DisplayMember = "customerId";
        }



        //Meeting type Method to set up meeting type
        private void LoadMeetingTypes()
        {
            List<string> meetingTypes = new List<string>
            {
               "Scrum",
               "Stand up",
               "Counselling",
                "Presentation",
                "Press Con",
                "Board Meet"
            };

            //todo add lamda expression for sorting here
            TypeComboBox.DataSource = meetingTypes;
        }

       

        //Method to populate appointment grid table
        private void loadAppointmentGridView()//Establish connection
        {
            var selectString = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment";
            DbConnection.LoadGridTable(selectString, AppointmentdataGridView);//populate AppointmentdataGridView with selected data
            

            for (int i = 0; i < AppointmentdataGridView.Rows.Count; i++)
            {
                //Converts time from UTC to Local time
                AppointmentdataGridView.Rows[i].Cells[4].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentdataGridView.Rows[i].Cells[4].Value, TimeZoneInfo.Local).ToString();
                AppointmentdataGridView.Rows[i].Cells[5].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)AppointmentdataGridView.Rows[i].Cells[5].Value, TimeZoneInfo.Local).ToString();
            }

            //Check if monthly radio button is clicked
            //to display only monyhly appointments or 
            //if weekly radiobutton is checked to 
            //display only weekly appointments
            if (MonthlyradioButton.Checked)
            {
                LoadCurrentMonthApt();
            }
            else if (WeeklyAppointmentsradioButton.Checked)
            {
                LoadCurrentWeekApt();
            }
        }


        private void populateConsultantReportGridView()//Establish connection
        {
            var selectString = "SELECT appointmentId, customerId, userId, type, start, end FROM appointment";
            DbConnection.LoadGridTable(selectString, ConsultantReportGridView);//populate ConsultantReportGridView with selected data

            for (int i = 0; i < ConsultantReportGridView.Rows.Count; i++)
            {
                //Converts time from UTC to Local time
                ConsultantReportGridView.Rows[i].Cells[4].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)ConsultantReportGridView.Rows[i].Cells[4].Value, TimeZoneInfo.Local).ToString();
                ConsultantReportGridView.Rows[i].Cells[5].Value = TimeZoneInfo.ConvertTimeFromUtc((DateTime)ConsultantReportGridView.Rows[i].Cells[5].Value, TimeZoneInfo.Local).ToString();
            }
        }



            //Gets the week of the month
            static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }


        //Current Month Method
        //Displays appointments within
        //the current month
        private void LoadCurrentMonthApt()
        {
            var dt = DateTime.Now.ToLocalTime();

            for (int i = 0; i < AppointmentdataGridView.Rows.Count; i++)
            {
                var appointmentDate = DateTime.Parse(AppointmentdataGridView.Rows[i].Cells[4].Value.ToString()).ToLocalTime();
                if (dt.Month == appointmentDate.Month)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[AppointmentdataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    AppointmentdataGridView.Rows[i].Visible = true;
                    currencyManager1.ResumeBinding();

                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[AppointmentdataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    AppointmentdataGridView.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        //Current Week method
        //Displays appointments within
        //the current week
        private void LoadCurrentWeekApt()
        {
            var dt = DateTime.Now.ToLocalTime();
           

            for (int i = 0; i < AppointmentdataGridView.Rows.Count; i++)
            {
                var gridTime = (DateTime)AppointmentdataGridView.Rows[i].Cells[4].Value;

                if (GetWeekNumberOfMonth(dt) == GetWeekNumberOfMonth(gridTime) && dt.Month == gridTime.Month )   
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[AppointmentdataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    AppointmentdataGridView.Rows[i].Visible = true;
                    currencyManager1.ResumeBinding();


                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[AppointmentdataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    AppointmentdataGridView.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        //refines and update ConsultantReportGridView
        private void LoadConsultantReport()
        {
            for (int i = 0; i < ConsultantReportGridView.Rows.Count; i++)
            {
                var userId = ConsultantReportGridView.Rows[i].Cells[2].Value;

                if (userId.ToString().Equals(ConsultantReportcomboBox.Text.ToString()))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ConsultantReportGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    ConsultantReportGridView.Rows[i].Visible = true;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ConsultantReportGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    ConsultantReportGridView.Rows[i].Visible = false;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        //Update button click event listener
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AppointmentdataGridView.CurrentRow == null || !AppointmentdataGridView.CurrentRow.Selected)
                {
                    MessageBox.Show("No selection was made");
                }
                else
                {
                    //Populate textboxes with datagrid values
                    AppointmentIDtextBox.Text = AppointmentdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    CustomerIDcomboBox.Text = AppointmentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    UserIDcomboBox.Text = AppointmentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    TypeComboBox.Text = AppointmentdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    StartDateTimePicker.Text = AppointmentdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    EndDateTimePicker.Text = AppointmentdataGridView.SelectedRows[0].Cells[5].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Delete button click event listener
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            DbConnection.startConnection();//Establish connection

            try
            {
                if (AppointmentdataGridView.CurrentRow == null || !AppointmentdataGridView.CurrentRow.Selected)
                {
                    MessageBox.Show("No selection was made");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var appointmentString = "DELETE FROM appointment where AppointmentId = @APPOINTMENTID";

                        MySqlCommand appointmentcmd = new MySqlCommand(appointmentString, DbConnection.conn);

                        appointmentcmd.Parameters.AddWithValue("@APPOINTMENTID", AppointmentdataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        appointmentcmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Refresh Customer grid
            loadAppointmentGridView();

            //Clear grid selection
            AppointmentdataGridView.ClearSelection();
            DbConnection.conn.Close(); //close coneection
        }

        // appointment ovelap statement Lambda
        Func <DateTime, DateTime, DateTime, DateTime, bool> isOverlap = (st, e, ast, ae) =>
        {
            //if(st< ast)
            //{
            //    if (e < ast)
            //    {
            //        return false; //st<ast && e < ast
            //    }
            //    else //e >=ast                                //actual if statement expressed below
            //    {
            //        return true; // st < ast && e >= ast
            //    }
            //}
            //else // st > = ast
            //{
            //    if (st > ae)
            //    {
            //        return false; // st >= ast && st > ae
            //    }
            //    else // st <= ae
            //    {
            //        return true; // st >= ast && e < = ae
            //    }

            //}

            //  nested if statement(s)
            return (st < ast) ? (e < ast) ? false : true : (st > ae) ? false : true;
        };


        //Save button click event listener
        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create and open connection
                //for table update

                DbConnection.startConnection();

                /************Handles  Appointment conflicts************/
                foreach (DataGridViewRow Row in AppointmentdataGridView.Rows)
                {
                    var startTime = DateTime.Parse("08:00 AM");
                    var endTime = DateTime.Parse("17:00 PM");
                    var startDate = DateTime.Parse(Row.Cells[4].Value.ToString());
                    var endDate = DateTime.Parse(Row.Cells[5].Value.ToString());
                    var userId = Row.Cells[2].Value.ToString();
                    var startDateTimePicker = DateTime.Parse(StartDateTimePicker.Text);
                    var endDateTimePicker = DateTime.Parse(EndDateTimePicker.Text);


                    if (isOverlap(startDateTimePicker, endDateTimePicker, startDate, endDate) && userId.Equals(UserIDcomboBox.Text.ToString())
                      )
                    {
                        if (!Row.Selected)
                        {
                            MessageBox.Show($"the is a date/time overlap with appointmentId  {Row.Cells[0].Value.ToString()}");
                            return;
                        }

                    }

                    if (startDateTimePicker.TimeOfDay < startTime.TimeOfDay || startDateTimePicker.TimeOfDay > endTime.TimeOfDay ||
                       endDateTimePicker.TimeOfDay > endTime.TimeOfDay || endDateTimePicker.TimeOfDay < startTime.TimeOfDay)
                    {
                        MessageBox.Show("Appointment out of business hour" + "\n" +
                            $"operation hours are from {startTime.ToShortTimeString()} to {endTime.ToShortTimeString()}");
                        return;
                    }

                    if (startDateTimePicker > endDateTimePicker)
                    {
                        MessageBox.Show("Start date/time cannot be greater than end date/time");
                        return;
                    }
                    else if (endDateTimePicker < startDateTimePicker)
                    {
                        MessageBox.Show("end date/time cannot be lesser than end date/time");
                        return;
                    }
                }


                if (!(AppointmentdataGridView.SelectedRows.Count == 0))
                {
                    //var selectedRowFirstINdex = AppointmentdataGridView.SelectedRows[0].Cells[0].ToString();

                    //if (selectedRowFirstINdex.Contains(AppointmentIDtextBox.Text))
                    //{
                        // UPDATES AND SAVE SELECTED ROW

                        var AppointmentString = "UPDATE appointment SET appointmentId = @APPOINTMENTID, customerId = @CUSTOMERID, userId = @USERID," +
                            " type = @TYPE, start = @START, end = @END where appointmentId = @APPOINTMENTID";

                        MySqlCommand cmd = new MySqlCommand(AppointmentString, DbConnection.conn);

                        cmd.Parameters.AddWithValue("@APPOINTMENTID", AppointmentIDtextBox.Text);
                        cmd.Parameters.AddWithValue("@CUSTOMERID", CustomerIDcomboBox.Text);
                        cmd.Parameters.AddWithValue("@USERID", UserIDcomboBox.Text);
                        cmd.Parameters.AddWithValue("@TYPE", TypeComboBox.Text);
                        cmd.Parameters.AddWithValue("@START", DateTimeOffset.Parse(StartDateTimePicker.Text).UtcDateTime);  //Converts time to UTC
                        cmd.Parameters.AddWithValue("@END", DateTimeOffset.Parse(EndDateTimePicker.Text).UtcDateTime);   //Converts time to UTC
                        cmd.ExecuteNonQuery();

                   // }
                }
                else
                {
                   

                    //INSERTS NEW DATA VALUE INTO Appointment TABLE                                                
                    var appointmentString2 = "INSERT INTO appointment VALUES(NULL, @CUSTOMERID, @USERID, 'xxxx'," +
                        " 'xxxx', 'xxxx', 'xxxx', @TYPE, 'xxxx',@START, @END, NOW(), 'xxxx', NOW(), 'xxxx' )";

                    MySqlCommand cmd = new MySqlCommand(appointmentString2, DbConnection.conn);



                    cmd.Parameters.AddWithValue("@CUSTOMERID", CustomerIDcomboBox.Text);
                    cmd.Parameters.AddWithValue("@USERID", UserIDcomboBox.Text);
                    cmd.Parameters.AddWithValue("@TYPE", TypeComboBox.Text);
                    cmd.Parameters.AddWithValue("@START", DateTimeOffset.Parse(StartDateTimePicker.Text).UtcDateTime);  //Converts time to UTC
                    cmd.Parameters.AddWithValue("@END", DateTimeOffset.Parse(EndDateTimePicker.Text).UtcDateTime);   //Converts time to UTC
                    cmd.ExecuteNonQuery();

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Refresh Customer grid
            loadAppointmentGridView();

            //Clear selection
            AppointmentdataGridView.ClearSelection();

            //Clear text/Combo boxes
            AppointmentIDtextBox.Clear();
            CustomerIDcomboBox.SelectedIndex = -1;
            UserIDcomboBox.SelectedIndex = -1;
            TypeComboBox.SelectedIndex = -1;
            TypeReportcomboBox.SelectedIndex = -1;
        }

        private void ActivateSaveButton()
        {
            if (!string.IsNullOrWhiteSpace(CustomerIDcomboBox.Text) && 
                !string.IsNullOrWhiteSpace(UserIDcomboBox.Text) &&
                !string.IsNullOrWhiteSpace(CustomerIDcomboBox.Text) &&
                !string.IsNullOrWhiteSpace(TypeComboBox.Text))
            {
                Savebutton.Enabled = true;
               // Savebutton.BackColor = Color.SlateGray;
            }

            
                //Savebutton.Enabled = false;
                //Savebutton.BackColor = Color.SlateGray;
            
        }

        //Appointment Form load event listener
        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            
            AppointmentdataGridView.ClearSelection();
            ConsultantReportGridView.ClearSelection();
            AllAppointmentsradioButton.Checked = true;

            //Clear comboboxes
            ConsultantReportcomboBox.SelectedIndex = -1;
            CustomerIDcomboBox.SelectedIndex = -1;
            UserIDcomboBox.SelectedIndex = -1;
            TypeComboBox.SelectedIndex = -1;
            TypeReportcomboBox.SelectedIndex = -1;
            CustomerReportcomboBox.SelectedIndex = -1;

             Savebutton.Enabled = false;
            
           
        }


        //All appointments radio button check event listener
        private void AllAppointmentsradioButton_CheckedChanged(object sender, EventArgs e)
        {
            loadAppointmentGridView();
            AppointmentdataGridView.ClearSelection();
        }


        // weekly appointments radio button check event listener
        private void WeeklyAppointmentsradioButton_CheckedChanged(object sender, EventArgs e)
        {

            //Refresh GridView
            loadAppointmentGridView();

            //Clear grid selection
            AppointmentdataGridView.ClearSelection();

            //Load current week appointments
            LoadCurrentWeekApt();

        }

        //Monthly appointments radio button check event listener
        private void MonthlyradioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Refresh GridView
            loadAppointmentGridView();

            //Clear grid selection
            AppointmentdataGridView.ClearSelection();

            //Load current month appointments
            LoadCurrentMonthApt();
        }


        //Populate report comboboxes
        private void FillReportComboboxes()
        {
            DbConnection.startConnection();

            //For TypeReportcombobox
            
            string[] Months = new string[] 
            { 
              "January", "February", "March", "April", "May", "June",
              "July", "August", "September", "October", "November", "December"
            };

            TypeReportcomboBox.DataSource = Months;  // populate appointment TypeReportcombobox

            //For ConsultantReportCombobox
            var selectUserId = "SELECT userId FROM user";

            MySqlCommand command = new MySqlCommand(selectUserId, DbConnection.conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            ConsultantReportcomboBox.DataSource = dataTable;
            ConsultantReportcomboBox.DisplayMember = "userId";

            //For CustomerReportCombobox

            var selectCustomerId = "SELECT customerId FROM customer";

            MySqlCommand cmd = new MySqlCommand(selectCustomerId, DbConnection.conn);
            MySqlDataAdapter mySqlAdpter = new MySqlDataAdapter(cmd);
            DataTable dtTable = new DataTable();
            mySqlAdpter.Fill(dtTable);
            CustomerReportcomboBox.DataSource = dtTable;
            CustomerReportcomboBox.DisplayMember = "customerId";

            DbConnection.closeConnection();

        }

        //TypeReportCombobox change event listener
        private void TypeReportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Resets type report/count labels to default
                TypeReportlabel.ResetText();
                TypeReportCountlabel.ResetText();

                if (TypeReportcomboBox.SelectedIndex < 0)
                {
                    return;
                }

                //  var dataMonth = DateTime.Parse(Row.Cells[4].Value.ToString()).ToUniversalTime();
                var dataMonth = new DateTime(2022, TypeReportcomboBox.SelectedIndex + 1, 12);

                //MessageBox.Show(dataMonth.ToLocalTime().ToString("MMMM"));
                var sqlString = $"select  type, start, count(*)  from appointment where month(start) = '{dataMonth}'  group by type";
                MySqlCommand cmd = new MySqlCommand(sqlString, DbConnection.conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    var dataTimeDate = TimeZoneInfo.ConvertTimeFromUtc((DateTime)row[1], TimeZoneInfo.Local).ToString("MMMM");

                    if (dataTimeDate.Contains(TypeReportcomboBox.Text))
                    {
                        TypeReportlabel.Text = TypeReportlabel.Text + "\t" + row[0].ToString() + "\r\n";
                        TypeReportCountlabel.Text = TypeReportCountlabel.Text + "\t" + row[2].ToString() + "\r\n";
                    }

                }
                return;
                // break;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
           



        //ConsultantReportCombobox change event listener
        private void ConsultantReportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadConsultantReport();//calls load consultant report method

                foreach (DataGridViewRow Row in AppointmentdataGridView.Rows)
                {

                    var userIdString = Row.Cells[2].Value.ToString();

                    if (ConsultantReportcomboBox.Text == userIdString)
                    {

                        var sqlString = $"select userId, count(*) from appointment  where userId = '{userIdString}' ";
                        MySqlCommand cmd = new MySqlCommand(sqlString, DbConnection.conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            UserReportlabel.Text = row[0].ToString();
                            UserReportCountlabel.Text = row[1].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //CustomerReportCombobox change event listener
        private void CustomerReportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                foreach (DataGridViewRow Row in AppointmentdataGridView.Rows)
                {

                    var customerIdString = Row.Cells[1].Value.ToString();

                    if (CustomerReportcomboBox.Text == customerIdString)
                    {

                        var sqlString = $"select customerId, count(*) from appointment  where customerId = '{customerIdString}' ";
                        MySqlCommand cmd = new MySqlCommand(sqlString, DbConnection.conn);
                        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            CustomerReportlabel.Text = row[0].ToString();
                            CustomerReportCountlabel.Text = row[1].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


                                     /*********Combobox input text change event listeners**********/

        //Customer id combobox event listener
        private void CustomerIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerIDcomboBox.Text))

            {

                Savebutton.Enabled = false;

            }
            else

            {
                ActivateSaveButton();
            }
        }

        //user id combobox event listener
        private void UserIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UserIDcomboBox.Text))

            {

                Savebutton.Enabled = false;

            }
            else

            {
                ActivateSaveButton();
            }
        }

        //type combobox event listener
        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TypeComboBox.Text))

            {

                Savebutton.Enabled = false;

            }
            else

            {
                ActivateSaveButton();
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
