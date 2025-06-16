using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EquipEase
{
    public partial class RentalRecords : Form
    {
        public RentalRecords()
        {
            InitializeComponent();

            // Add filter options to the status combo box
            comboBoxStatus.Items.Add("No Filter");
            comboBoxStatus.Items.Add("Ongoing Rentals");
            comboBoxStatus.Items.Add("Upcoming Rentals");
            comboBoxStatus.Items.Add("Past Rentals");
            comboBoxStatus.SelectedIndex = 0;
            
            
        }

        /// <summary>
        /// Event handler for the Search button click event.
        /// Generates and displays rental records based on the selected filter.
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {

            string rentalStatus = "";

            //Check that the combo boxes hold data first
            if (comboBoxStatus.SelectedItem != null)
            {
                //A filter was selected
                rentalStatus = comboBoxStatus.SelectedItem.ToString();
            }

            
            string query = "";

            // Query to get rental information from the database
            query = "select TypeName,startTime,returnTime,hireFrom,returnTo,CustomerEmail from rentEquipment " +
                "join Rental on Rental.RentalID = rentEquipment.rRentalID " +
                "join Equipment on Equipment.EquipmentID = rentEquipment.rEquipmentID ";

            // Append the appropriate filter condition to the query 
            if (rentalStatus == "Upcoming Rentals")
            {
                query = query + "where startTime>CURRENT_TIMESTAMP;";
            }
            else if (rentalStatus == "Ongoing Rentals")
            {
                query = query + "where returnTime is null;";
            }
            else if (rentalStatus == "Past Rentals")
            {
                query = query + "where returnTime<CURRENT_TIMESTAMP;";
            }


            // Execute the query
            SQL.selectQuery(query);

            //clear the listview previous data
            listViewDisplay.Items.Clear();
            int i = 0;
            try
            {
                // Check that data has been returned
                if (SQL.read.HasRows)
                {
                    RestoreColumns();
                    while (SQL.read.Read())
                    {
                        // Retrieve data from SQL reader
                        string equipmentType = SQL.read[0].ToString();
                        string startTime = SQL.read[1].ToString();
                        string returnTime = SQL.read[2].ToString();
                        string hireFrom = SQL.read[3].ToString();
                        string returnTo = SQL.read[4].ToString();
                        string customerEmail = SQL.read[5].ToString();

                        // Add data to ListView
                        ListViewItem item = new ListViewItem(equipmentType);
                        item.SubItems.Add(startTime);
                        item.SubItems.Add(returnTime);
                        item.SubItems.Add(hireFrom);
                        item.SubItems.Add(returnTo);
                        item.SubItems.Add(customerEmail);
                        listViewDisplay.Items.Add(item);
                        i++;
                    }
                    // check if the correct number of rows have been printed
                    Console.WriteLine(i.ToString());
                    RemoveEmptyColumns();
                }
                else //where it doesnt have any successful searches
                {
                    listViewDisplay.Items.Add("No Rentals Found");
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }


        }

        /// <summary>
        /// Removes empty columns from the ListView to enhance display clarity.
        /// </summary>
        private void RemoveEmptyColumns()
        {
            for (int col = listViewDisplay.Columns.Count - 1; col >= 0; col--)
            {
                bool isEmpty = true;

                foreach (ListViewItem item in listViewDisplay.Items)
                {
                    // Check if the column is empty
                    if (!string.IsNullOrEmpty(item.SubItems[col].Text.Trim()))
                    {
                        isEmpty = false;
                        break;
                    }
                }

                // Remove the column if it is empty
                if (isEmpty)
                {
                    listViewDisplay.Columns.RemoveAt(col);
                }
            }
        }

        /// <summary>
        /// Restores the default columns to the ListView.
        /// </summary>
        private void RestoreColumns()
        {
            // Clear existing columns safely
            while (listViewDisplay.Columns.Count > 0)
            {
                listViewDisplay.Columns.RemoveAt(0);
            }
            listViewDisplay.View = View.Details;
            listViewDisplay.Columns.Add("Equipment Type", 120);
            listViewDisplay.Columns.Add("Start Time", 150);
            listViewDisplay.Columns.Add("Return Time", 150);
            listViewDisplay.Columns.Add("Hired From", 150);
            listViewDisplay.Columns.Add("Return To", 150);
            listViewDisplay.Columns.Add("Customer Email", 200);
        }

        /// <summary>
        /// Event handler to navigate to the start page.
        /// </summary>
        private void returnToStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Event handler to navigate to the hire equipment page.
        /// </summary>
        private void hireEquipmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            HireEquipment hireEquipmentPage = new HireEquipment();
            hireEquipmentPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Event handler to navigate to the return equipment page.
        /// </summary>
        private void returnEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ReturnEquipment returnEquipmentPage = new ReturnEquipment();
            returnEquipmentPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Event handler to navigate to the reports page.
        /// </summary>
        private void goToReportsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Reports reportsPage = new Reports();
            reportsPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Event handler to exit the application.
        /// </summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
