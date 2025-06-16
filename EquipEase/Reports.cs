using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipEase
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            // Set the font for the listBoxReports to "Courier New" so .PadRight works properly
            listBoxReports.Font = new Font("Courier New", 8);

            // Generates and displays various reports in the list box.
            // Generate and display the unique customers report
            SQL.GenerateUniqueCustomersReport(listBoxReports);
            SQL.AddSeparator(listBoxReports);

            // Generate and display the average rental duration report
            SQL.GenerateAverageDurationReport(listBoxReports);
            SQL.AddSeparator(listBoxReports);

            // Generate and display the most popular equipment types report
            SQL.GeneratePopularEquipTypesReport(listBoxReports);
            SQL.AddSeparator(listBoxReports);

            // Generate and display the total number of rentals per month report
            SQL.GenerateTotaRentalsNumReport(listBoxReports);
            SQL.AddSeparator(listBoxReports);

            // Generate and display the income per equipment type report
            SQL.GenerateIncomePerEquipTypeReport(listBoxReports);

        }

        /// <summary>
        /// Event handler for the button1 click event.
        
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            
            
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
        /// Event handler to exit the application.
        /// </summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
