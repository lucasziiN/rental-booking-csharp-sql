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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open Records Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecords_Click(object sender, EventArgs e)
        {
            Hide();
            RentalRecords rentalRecordsPage = new RentalRecords();
            rentalRecordsPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Open Hiring Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHire_Click(object sender, EventArgs e)
        {
            Hide();
            HireEquipment hireEquipmentPage = new HireEquipment();
            hireEquipmentPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Open Returns Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Hide();
            ReturnEquipment returnEquipmentPage = new ReturnEquipment();
            returnEquipmentPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Open Reports Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            Hide();
            Reports reportsPage = new Reports();
            reportsPage.ShowDialog();
            Close();
        }

        /// <summary>
        /// Open Exit Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
