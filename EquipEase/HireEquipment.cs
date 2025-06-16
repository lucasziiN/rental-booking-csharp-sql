using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EquipEase
{
    public partial class HireEquipment : Form
    {
        public HireEquipment()
        {
            InitializeComponent();

            // Initially hide the button to proceed to customer details page
            buttonCustomerDetails.Visible = false;
            string equipmentTypeQuery = "SELECT DISTINCT TypeName FROM Equipment";
            string branchNameQuery = "SELECT DISTINCT BranchName FROM Equipment";
            SQL.editComboBoxItems(comboBoxTypeEquip, equipmentTypeQuery);
            SQL.editComboBoxItems(comboBoxBranch, branchNameQuery);
        }

        // Property to expose the selected value of the ComboBox
        public string SelectedEquipmentType
        {
            get
            {
                return comboBoxTypeEquip.SelectedItem?.ToString() ?? string.Empty;
            }
        }

        // Property to expose the selected value of the ComboBox
        public string SelectedBranch
        {
            get
            {
                return comboBoxBranch.SelectedItem?.ToString() ?? string.Empty;
            }
        }

        /// <summary>
        /// Event handler for the Customer Details button click event.
        /// Navigates to the Details form if the equipment is available.
        /// </summary>
        private void buttonCustomerDetails_Click(object sender, EventArgs e)
        {
            // Navigate to the Details form if the equipment is available
            if (textBoxAvailability.Text == "Available")
            {
                Hide();
                Details detailsPage = new Details(this);
                detailsPage.ShowDialog();
                Close();
            }
        }

        /// <summary>
        /// Event handler for the equipment type combo box selection change event.
        /// Updates the rate and availability when the equipment type is selected.
        /// </summary>
        private void comboBoxTypeEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if both combo boxes have selections
            if (comboBoxBranch.SelectedIndex != -1 && comboBoxTypeEquip.SelectedIndex != -1)
            {
                // Get the selected equipment type and branch name
                string typeEquip = comboBoxTypeEquip.Text;
                string branchName = comboBoxBranch.Text;

                // Display the equipment rate in the text box
                textBoxRate.Text = SQL.GetEquipRate(typeEquip).ToString() ;

                // Check if the equipment is available and update the UI accordingly
                if (SQL.IsEquipmentAvailable(typeEquip, branchName))
                {
                    textBoxAvailability.Text = "Available";
                    buttonCustomerDetails.Visible = true;
                }
                else
                {
                    textBoxAvailability.Text = "Unavailable";
                    buttonCustomerDetails.Visible = false;
                }
            }
            
        }

        /// <summary>
        /// Event handler for the branch combo box selection change event.
        /// Updates the rate and availability when the branch is selected.
        /// </summary>
        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if both combo boxes have selections
            if (comboBoxBranch.SelectedIndex != -1 && comboBoxTypeEquip.SelectedIndex != -1)
            {
                // Get the selected equipment type and branch name
                string typeEquip = comboBoxTypeEquip.Text;
                string branchName = comboBoxBranch.Text;

                // Display the equipment rate in the text box
                textBoxRate.Text = SQL.GetEquipRate(typeEquip).ToString() ;

                // Check if the equipment is available and update the UI accordingly
                if (SQL.IsEquipmentAvailable(typeEquip, branchName))
                {
                    textBoxAvailability.Text = "Available";
                    buttonCustomerDetails.Visible = true;

                }
                else
                {
                    textBoxAvailability.Text = "Unavailable";
                    buttonCustomerDetails.Visible = false;
                }
            }
        }

        /// <summary>
        /// Event handler to navigate to the start page.
        /// </summary>
        private void goToStartPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Event handler to navigate to the rental records page.
        /// </summary>
        private void viewRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            RentalRecords rentalRecords = new RentalRecords();
            rentalRecords.ShowDialog();
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
        /// Event handler to exit the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
