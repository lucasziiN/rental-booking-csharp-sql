using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Collections;

namespace EquipEase
{
    public partial class Details : Form
    {
        private HireEquipment mainForm;
        private string equipType = "";
        private string branch = "";

        /// <summary>
        /// Constructor for the Details form.
        /// </summary>
        /// <param name="form">The main HireEquipment form.</param>
        public Details(HireEquipment form)
        {
            InitializeComponent();
            // Configure DateTimePicker to make more user-friendly
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "dd/MM/yyyy h:mm tt";
            dateTimePickerStart.ShowUpDown = true; 

            mainForm = form;

            // Retrieve selected equipment type and branch from the main form
            equipType = SanitizeInput(mainForm.SelectedEquipmentType.ToString());
            branch = SanitizeInput(mainForm.SelectedBranch.ToString());

            // Construct the query string with the sanitized parameters directly embedded
            string query = $"select equipmentId from equipment where typename = '{equipType}' AND available = '1' AND branchName = '{branch}' order by purchaseDate desc";
            // Add to the combo box
            SQL.editComboBoxItems(comboBoxDispEquip, query);
            
        }


        private string SanitizeInput(string input)
        {
            // Replace single quotes with two single quotes to escape them in SQL
            return input.Replace("'", "''");
        }


        /// <summary>
        /// Event handler for the payment button click event.
        /// </summary>
        private void buttonPayment_Click(object sender, EventArgs e)
        {
            string fname, lname, phoneNum, email, startHire;
            int equipId = -1;

            

            //Check that the text boxes has something typed in it using a method
            bool hasText = checkTextBoxes();

            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text. ");
                textBoxFirst.Focus();
                return;
            }

            //(1) GET the data from the textboxes and store into variables created above, good to put in a try catch with error message
            try
            {
                fname = textBoxFirst.Text.Trim();
                lname = textBoxLast.Text.Trim();
                phoneNum = textBoxPhoneNum.Text.Trim();
                email = textBoxEmail.Text.Trim();
                startHire = dateTimePickerStart.Value.ToString("yyyy-MM-dd HH:mm:ss");
                equipId = Convert.ToInt32(comboBoxDispEquip.Text);
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
            
            try
            {
               
                branch = SQL.FindBranchFromEquipId(equipId);
                SQL.RentEquip(equipId, equipType, branch, fname, lname, phoneNum, email, startHire, checkBoxNewEquip.Checked);
                //success message for the user to know it worked
                MessageBox.Show("Booking Made for " + equipType + " from " + branch + " for " + fname + " " + lname);

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
        /// Checks if all required textboxes have data.
        /// </summary>
        /// <returns>True if all textboxes have data, otherwise false.</returns>
        private bool checkTextBoxes()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox)
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
                if (c is ComboBox)
                {
                    holdsData = true;
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }

        /// <summary>
        /// Event handler for when the equipment combo box selection changes.
        /// </summary>
        private void comboBoxDispEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the purchase date of the selected equipment and display it in the textbox
            string purchaseDate = SQL.GetPurchaseDate(comboBoxDispEquip.Text).ToString("yyyy-MM-dd");
            textBoxPurchaseDate.Text = purchaseDate;    

        }

        /// <summary>
        /// Event handler for when the branch select checkbox state changes.
        /// </summary>
        private void checkBoxBranchSelect_CheckedChanged(object sender, EventArgs e)
        {

            // Clear and refresh the combo box based on the checkbox state
            comboBoxDispEquip.Text = "";
            comboBoxDispEquip.Refresh();
            if (checkBoxBranchSelect.Checked)
            {
                // Query to select equipment ID by type name when branch selection is not required
                string query = $"select equipmentId from equipment where typename = '{equipType}' AND available = '1' order by purchaseDate desc";

                SQL.editComboBoxItems(comboBoxDispEquip, query);
            }
            else
            {
                // Query to select equipment ID by type name and branch name
                string query = $"select equipmentId from equipment where typename = '{equipType}' AND available = '1' AND branchName = '{branch}' order by purchaseDate desc";

                // Populate the combo box with the appropriate query
                SQL.editComboBoxItems(comboBoxDispEquip, query);
            }
        }

        private void goToStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigate to the start page
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }

        private void returnEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigate to the rental records page
            Hide();
            RentalRecords rentalRecords = new RentalRecords();
            rentalRecords.ShowDialog();
            Close();
        }

        private void goToRecordsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Navigate to the records page
            Hide();
            RentalRecords rentalRecords = new RentalRecords();
            rentalRecords.ShowDialog();
            Close();
        }
    }
}
