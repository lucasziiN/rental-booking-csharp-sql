using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EquipEase
{
    public partial class ReturnEquipment : Form
    {
        public ReturnEquipment()
        {
            InitializeComponent();
            // Configure DateTimePicker to make more user-friendly
            dateTimePickerReturn.Format = DateTimePickerFormat.Custom;
            dateTimePickerReturn.CustomFormat = "dd/MM/yyyy h:mm tt";
            dateTimePickerReturn.ShowUpDown = true;

            // Queries to get unavailable equips Ids and the name of each branch
            string unavailableEquipsQuery = "select equipmentID from equipment where available = 0;";
            string branchNameQuery = "SELECT DISTINCT BranchName FROM Equipment";
            
            // Use methods to update combo boxes
            SQL.editComboBoxItems(comboBoxEquipId, unavailableEquipsQuery);
            SQL.editComboBoxItems(comboBoxReturnBranch, branchNameQuery);
            
        }

        // Static variables to hold selected rental ID and equipment ID
        private static string rentalId = "";
        private static string equipId = "";

        /// <summary>
        /// Sets up the columns for the ListView to display rental information.
        /// </summary>
        private void SetupColumns()
        {
            // Clear existing columns safely
            while (listViewDispRentInfo.Columns.Count > 0)
            {
                listViewDispRentInfo.Columns.RemoveAt(0);
            }
            listViewDispRentInfo.View = View.Details;
            listViewDispRentInfo.Columns.Add("Equipment Type", 120);
            listViewDispRentInfo.Columns.Add("Rental ID", 80);
            listViewDispRentInfo.Columns.Add("Equipment ID", 80);
            listViewDispRentInfo.Columns.Add("Start Time", 150);
            listViewDispRentInfo.Columns.Add("Hired From", 150);
            listViewDispRentInfo.Columns.Add("Customer Email", 200);
        }

        /// <summary>
        /// Displays equipment information based on selected equipment ID and customer email.
        /// </summary>
        private void DisplayEquipInfo()
        {
            // Query to get information from the equipment based on the equipment Id and customer's email
            // I use the customers email as well because it seems like some items have not been returned multiple times
            // This makes it difficult to tell which customer is returning it   
            string query = "select typeName,rentalID, rEquipmentID, startTime,hirefrom, customeremail from rentEquipment " +
                "join Rental on Rental.rentalID = rentEquipment.rRentalID " +
                "join Equipment on Equipment.equipmentId = rentEquipment.requipmentID " +
                "where equipmentid = @equipmentId AND customeremail = @customerEmail";


            //clear the listview previous data
            listViewDispRentInfo.Items.Clear();

            try
            {

                // Close the connection if it's open
                SQL.con.Close();
                SQL.cmd.Connection = SQL.con;
                // Open the connection
                SQL.con.Open();
                SQL.cmd.CommandText = query;
                SQL.cmd.Parameters.Clear(); // Clear any previous parameters
                SQL.cmd.Parameters.AddWithValue("@equipmentId", comboBoxEquipId.Text);
                SQL.cmd.Parameters.AddWithValue("@customerEmail", comboBoxEmail.Text);

                SQL.read = SQL.cmd.ExecuteReader();

                // Clear the ListView's previous data
                listViewDispRentInfo.Items.Clear();

                int i = 0;

                // Check that the data has been returned
                if (SQL.read.HasRows)
                {
                    SetupColumns();
                    while (SQL.read.Read())
                    {
                        // Retrieve data from SQL reader
                        string equipmentType = SQL.read[0].ToString();
                        string rentId = SQL.read[1].ToString();
                        string equipId = SQL.read[2].ToString();
                        string startTime = SQL.read[3].ToString();
                        string hireFrom = SQL.read[4].ToString();
                        string customerEmail = SQL.read[5].ToString();

                        // Add data to ListView
                        ListViewItem item = new ListViewItem(equipmentType);
                        item.SubItems.Add(rentId);
                        item.SubItems.Add(equipId);
                        item.SubItems.Add(startTime);
                        item.SubItems.Add(hireFrom);
                        item.SubItems.Add(customerEmail);
                        listViewDispRentInfo.Items.Add(item);
                        i++;
                    }
                    // check if the correct number of rows have been printed
                    Console.WriteLine(i.ToString());


                }
                else //where it doesnt have any successful searches
                {
                    listViewDispRentInfo.Items.Add("No Information to display");
                }
            }
            catch
            {
                // If an error occurs while querying the database
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
            finally
            {
                // Ensure the connection is closed
                if (SQL.con.State == ConnectionState.Open)
                {
                    SQL.con.Close();
                }
            }
        }


        /// <summary>
        /// Event handler for when the equipment ID combo box selection changes.
        /// </summary>
        private void comboBoxEquipId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEmails();
        }

        /// <summary>
        /// Displays customer emails based on the selected equipment ID.
        /// </summary>
        private void DisplayEmails()
        {
            string customerEmailQuery = "select customeremail from rentEquipment " +
               "join Rental on Rental.rentalID = rentEquipment.rRentalID " +
               "join Equipment on Equipment.equipmentId = rentEquipment.requipmentID " +
               "where equipmentid = " + comboBoxEquipId.Text + " AND returnTime is null";

            SQL.editComboBoxItems(comboBoxEmail, customerEmailQuery);
        }

        /// <summary>
        /// Event handler for when the customer email combo box selection changes.
        /// </summary>
        private void comboBoxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEquipInfo();
            // Ensure there are items in the ListView
            if (listViewDispRentInfo.Items.Count > 0)
            {
                // Optionally, select the first item if none is selected
                if (listViewDispRentInfo.SelectedItems.Count == 0)
                {
                    listViewDispRentInfo.Items[0].Selected = true;
                }

                // Ensure an item is selected
                if (listViewDispRentInfo.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listViewDispRentInfo.SelectedItems[0];
                    // Access the "Rental ID" sub-item (second column, index 1)
                    rentalId = selectedItem.SubItems[1].Text;
                    equipId = selectedItem.SubItems[2].Text;
                }
            }
            else
            {
                MessageBox.Show("No items available in the ListView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxReturnBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event handler for the return button click event.
        /// </summary>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            
            string returnBranch, endHire; 
            

            //Check that the text boxes has something typed in it using a method
            bool hasText = checkControls();

            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text. ");
                comboBoxEquipId.Focus();
                return;
            }

            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                returnBranch = comboBoxReturnBranch.Text;
                endHire = dateTimePickerReturn.Value.ToString("yyyy-MM-dd HH:mm:ss");

                
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }

            //(2) Execute the INSERT statement, making sure all quotes and commas are in the correct places.
            //      Practice first on SQL Server Management Studio to make sure it is entering the correct data and in the correct format,
            //      then copy across the statement and where there are string replace the actual text for the variables stored above.
            //Example query: " INSERT INTO Users VALUES ('jkc1', 'John', 'Middle', 'Carter', 'pass1') "
            try
            {
                //SQL.executeQuery("INSERT INTO Customer VALUES ('" + email + "', '" + fname + "', '" + lname + "', '" + phoneNum + "')");
                
                SQL.ReturnEquip(rentalId, equipId, returnBranch, endHire);
                //success message for the user to know it worked
                MessageBox.Show("Return Processed. ID: " + rentalId + " to " + returnBranch + " at " + endHire);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //Go back to the login page since we registered successfully to let the user log in
            Hide();                                 //hides the register form
            StartPage startPage = new StartPage();      //creates the login page as an object
            startPage.ShowDialog();                     //shows the new login page form
            this.Close();                           //closes the register form that was hidden


            
        }

        /// <summary>
        /// Checks if all required controls have data.
        /// </summary>
        /// <returns>True if all controls have data, otherwise false.</returns>
        private bool checkControls()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                // If it's a ComboBox
                if (c is ComboBox comboBox)
                {
                    // If the ComboBox is empty
                    if (string.IsNullOrWhiteSpace(comboBox.Text))
                    {
                        // Set boolean to false because a ComboBox is empty
                        holdsData = false;
                        break; // Optionally break the loop if one empty control is enough to return false
                    }
                }
                // If it's a DateTimePicker
                else if (c is DateTimePicker dateTimePicker)
                {
                    // If the DateTimePicker's value is empty or default
                    if (dateTimePicker.Value == null || dateTimePicker.Value == DateTimePicker.MinimumDateTime)
                    {
                        // Set boolean to false because a DateTimePicker is empty
                        holdsData = false;
                        break; // Optionally break the loop if one empty control is enough to return false
                    }
                }
            }
            // Returns true or false based on if data is in all controls or not
            return holdsData;
        }

        private void goToStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you have seen this plenty of times, I hope it is self explainatory now
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }

        private void hireEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you have seen this plenty of times, I hope it is self explainatory now
            Hide();
            HireEquipment hireEquipmentPage = new HireEquipment();
            hireEquipmentPage.ShowDialog();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToReportsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you have seen this plenty of times, I hope it is self explainatory now
            Hide();
            Reports reportsPage = new Reports();
            reportsPage.ShowDialog();
            Close();
        }

        private void goToRecordsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //you have seen this plenty of times, I hope it is self explainatory now
            Hide();
            RentalRecords rentalRecordsPage = new RentalRecords();
            rentalRecordsPage.ShowDialog();
            Close();
        }
    }
}

