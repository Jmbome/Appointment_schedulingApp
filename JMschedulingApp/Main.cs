using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMschedulingApp
{
    public partial class Main : Form
    {
        public static MySqlConnection con { get; set; }


        public Main()
        {
            InitializeComponent();

            LoadCustomerGrid();


        }

        // UPDATEBUTTON CLICK EVENT LISTENER
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerdataGrid.CurrentRow == null || !CustomerdataGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("No selection was made");
                } 
                else
                {
                    //Populate textboxes with datagrid values
                    IdtextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    NametextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[4].Value.ToString();
                    AddresstextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[5].Value.ToString();
                    PhonetextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[6].Value.ToString();
                    CitytextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[7].Value.ToString();
                    CountrytextBox.Text = CustomerdataGrid.SelectedRows[0].Cells[8].Value.ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Load CustomerdataGrid Method
        private void LoadCustomerGrid()
        {
            try
            {
                var selectString =                                                                                                      
                   "SELECT customerId, address.addressId, city.cityId, country.countryId, customer.customerName, address.address, address.phone, city.city, country.country" + " " +
                    "FROM customer, address, city, country" + "  " +
                   " WHERE customer.addressId = address.addressId AND address.cityId = city.cityId AND city.countryId = country.countryId" + " " +
                   "ORDER BY customerId";


                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                con = new MySqlConnection(constr);
                var dataAdapter = new MySqlDataAdapter(selectString, con);
                var commandBuilder = new MySqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                CustomerdataGrid.ReadOnly = true;
                CustomerdataGrid.DataSource = ds.Tables[0]; //POPULATE DATA TABLE

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //SEARCH DATAGRID METHOD
        //public void SearchData(string search)
        //{
        //    string query = "SELECT* FROM customer where customerName like '%" + search + "%'";
        //    string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        //    con = new MySqlConnection(constr);
        //    var dataAdapter = new MySqlDataAdapter(query, con);
        //    var commandBuilder = new MySqlCommandBuilder(dataAdapter);
        //    var ds = new DataSet();
        //    dataAdapter.Fill(ds);
        //    CustomerdataGrid.ReadOnly = true;
        //    CustomerdataGrid.DataSource = ds.Tables[0];
            
        //}


        //SAVEBUTTON CLICK EVENT LISTENER
        private void SaveButton_Click(object sender, EventArgs e)

        {
            try
            {
                //Create and open connection
                //for table update

                string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                con = new MySqlConnection(constr);
                con.Open();

                var selectedRow = CustomerdataGrid.CurrentRow.Cells[0].Value.ToString();

                if (!(CustomerdataGrid.SelectedRows.Count == 0))
                {
                    if (selectedRow.Contains(IdtextBox.Text))
                    {
                        // UPDATES AND SAVE SELECTED CUSTOMER ROW

                        var nameString = "UPDATE customer SET customerName = @CUSTOMERNAME where customerId = @CUSTOMERID";
                        var addressString = "UPDATE address SET address = @ADDRESS, PHONE = @PHONE WHERE addressId = @ADDRESSID";
                        var cityString = "UPDATE city SET city = @CITY where cityId = @CITYID";
                        var countrydString = "UPDATE country SET country = @COUNTRY where countryId = @COUNTRYID";
                        MySqlCommand Namecmd = new MySqlCommand(nameString, con);
                        MySqlCommand Addresscmd = new MySqlCommand(addressString, con);
                        MySqlCommand Citycmd = new MySqlCommand(cityString, con);
                        MySqlCommand Countrycmd = new MySqlCommand(countrydString, con);

                        Namecmd.Parameters.AddWithValue("@CUSTOMERNAME", NametextBox.Text);
                        Namecmd.Parameters.AddWithValue("@CUSTOMERID", IdtextBox.Text);
                        Namecmd.ExecuteNonQuery();



                        Addresscmd.Parameters.AddWithValue("@ADDRESS", AddresstextBox.Text);
                        Addresscmd.Parameters.AddWithValue("@PHONE", PhonetextBox.Text);
                        Addresscmd.Parameters.AddWithValue("@ADDRESSID", CustomerdataGrid.SelectedRows[0].Cells[1].Value.ToString());
                        Addresscmd.ExecuteNonQuery();


                        Citycmd.Parameters.AddWithValue("@CITY", CitytextBox.Text);
                        Citycmd.Parameters.AddWithValue("@CITYID", CustomerdataGrid.SelectedRows[0].Cells[2].Value.ToString());
                        Citycmd.ExecuteNonQuery();


                        Countrycmd.Parameters.AddWithValue("@COUNTRY", CountrytextBox.Text);
                        Countrycmd.Parameters.AddWithValue("@COUNTRYID", CustomerdataGrid.SelectedRows[0].Cells[3].Value.ToString());
                        Countrycmd.ExecuteNonQuery();

                    }
                }
                else 
                {
                    //INSERTS NEW DATA VALUE INTO CUSTOMER TABLE

                    var customerString = "INSERT INTO customer VALUES(NULL, @CUSTOMERNAME, @ADDRESSID, 1, NOW(), 'test', NOW(), 'test')";
                    var addressString = "INSERT INTO address VALUES(NULL, @ADDRESS, 'xxx', @CITYID, 111123, @PHONE, NOW(), 'test', NOW(), 'test')";
                    var cityString = "INSERT INTO city VALUES(NULL, @CITY, @COUNTRYID, NOW(), 'test', NOW(), 'test')";
                    var countrydString = "INSERT INTO country VALUES(NULL, @COUNTRY, NOW(), 'test', NOW(), 'test')";

                    MySqlCommand customercmd = new MySqlCommand(customerString, con);
                    MySqlCommand Addresscmd = new MySqlCommand(addressString, con);
                    MySqlCommand Citycmd = new MySqlCommand(cityString, con);
                    MySqlCommand Countrycmd = new MySqlCommand(countrydString, con);

                  
                    Countrycmd.Parameters.AddWithValue("@COUNTRY", CountrytextBox.Text);
                    Countrycmd.ExecuteNonQuery();
                    int countryID = (int)Countrycmd.LastInsertedId;

                    Citycmd.Parameters.AddWithValue("@CITY", CitytextBox.Text);
                    Citycmd.Parameters.AddWithValue("@COUNTRYID", countryID);
                    Citycmd.ExecuteNonQuery();
                    int cityID = (int)Citycmd.LastInsertedId;

                    Addresscmd.Parameters.AddWithValue("@ADDRESS", AddresstextBox.Text);
                    Addresscmd.Parameters.AddWithValue("@PHONE", PhonetextBox.Text);
                    Addresscmd.Parameters.AddWithValue("@CITYID", cityID);
                    Addresscmd.ExecuteNonQuery();
                    int addressID = (int)Addresscmd.LastInsertedId;

                    customercmd.Parameters.AddWithValue("@CUSTOMERNAME", NametextBox.Text);
                    customercmd.Parameters.AddWithValue("@ADDRESSID", addressID);
                    customercmd.ExecuteNonQuery();
  
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Refresh Customer grid
            LoadCustomerGrid();

            //Clear selection
            CustomerdataGrid.ClearSelection();

            //Clear text box
            IdtextBox.Clear();
            NametextBox.Clear();
            AddresstextBox.Clear();
            PhonetextBox.Clear();
            CitytextBox.Clear();
            CountrytextBox.Clear();
        }

        //Save button activation method
        private void ActivateSaveButton()
        {
            if (!string.IsNullOrWhiteSpace(NametextBox.Text) &&
                !string.IsNullOrWhiteSpace(AddresstextBox.Text) &&
                !string.IsNullOrWhiteSpace(PhonetextBox.Text) &&
                !string.IsNullOrWhiteSpace(CitytextBox.Text) &&
                !string.IsNullOrWhiteSpace(CountrytextBox.Text))
            {
                SaveButton.Enabled = true;
                // Savebutton.BackColor = Color.SlateGray;
            }
            else
            {
                SaveButton.Enabled = false;
            }

        }

        //DELETE BUTTON CLICK EVENT LISTENER 
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //CustomerdataGrid.Rows.RemoveAt(CustomerdataGrid.SelectedRows[0].Index);

            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            con = new MySqlConnection(constr);
            con.Open();
            try
            {
                if (CustomerdataGrid.CurrentRow == null || !CustomerdataGrid.CurrentRow.Selected)
                {
                    MessageBox.Show("No selection was made");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var appointmentString = "DELETE FROM appointment where customerId = @CUSTOMERID";
                        var customerString = "DELETE FROM customer where customerId = @CUSTOMERID";
                        //var addressString = "DELETE FROM address where cityId = @CITYID";
                        //var cityString = "DELETE FROM city where  countryId= @COUNTRYID";
                        //var countrydString = "DELETE FROM country countryId  = @COUNTRYID";

                        MySqlCommand appointmentcmd = new MySqlCommand(appointmentString, con);
                        MySqlCommand customercmd = new MySqlCommand(customerString, con);
                        //MySqlCommand Addresscmd = new MySqlCommand(addressString, con);
                        //MySqlCommand Citycmd = new MySqlCommand(cityString, con);
                        //MySqlCommand Countrycmd = new MySqlCommand(countrydString, con);


                        appointmentcmd.Parameters.AddWithValue("@CUSTOMERID", CustomerdataGrid.SelectedRows[0].Cells[0].Value.ToString());
                        appointmentcmd.ExecuteNonQuery();

                        customercmd.Parameters.AddWithValue("@CUSTOMERID", CustomerdataGrid.SelectedRows[0].Cells[0].Value.ToString());
                        customercmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Refresh Customer grid
            LoadCustomerGrid();

            //Clear grid selection
            CustomerdataGrid.ClearSelection();
            con.Close(); //close coneection
        }



        //FORM LOAD EVENT LISTENER
        private void Main_Load(object sender, EventArgs e)
        {
            //Clear row selection on form load
            CustomerdataGrid.ClearSelection();

            //Disable saveButton when form loads
            SaveButton.Enabled = false;

        }


        //SEARCH BUTTON CLICK EVENT LISTENER
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            try
            {
                //var gridCount = CustomerdataGrid.RowCount;
                if (searchValue != "")
                {
                    
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in CustomerdataGrid.Rows)                    
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue) || row.Cells[4].Value.ToString().ToUpper().Contains(searchValue.ToUpper()) )             
                        {
                            rowIndex = row.Index;  
                            CustomerdataGrid.Rows[rowIndex].Selected = true;
                            CustomerdataGrid.Rows[rowIndex].DefaultCellStyle.SelectionBackColor = Color.Coral;
                        }
                    }

                    if (rowIndex == -1)
                    {
                        MessageBox.Show("Item not found!");
                    }
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



             /***************TEXTBOX EVENT LISTENERS*******************/


        //Name textbox event listener
        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NametextBox.Text))
            {
                SaveButton.Enabled = true;
            }

            ActivateSaveButton();
        }

        // Address textbox event listener
        private void AddresstextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AddresstextBox.Text))
            {
                SaveButton.Enabled = true;
            }

            ActivateSaveButton();
        }

        //Phone textbox event listener
        private void PhonetextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhonetextBox.Text))
            {
                SaveButton.Enabled = true;
            }

            ActivateSaveButton();
        }

        //City textbox event listener
        private void CitytextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CitytextBox.Text))
            {
                SaveButton.Enabled = true;
            }

            ActivateSaveButton();
        }

        //Country textbox event listener
        private void CountrytextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CitytextBox.Text))
            {
                SaveButton.Enabled = true;
            }

            ActivateSaveButton();
        }


        //Appointment button click event listener
        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        //Exit button click event listener
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
