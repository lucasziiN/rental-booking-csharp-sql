using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EquipEase
{
    class SQL
    {
        // Generates the connection to the database
        public static SqlConnection con = new SqlConnection(@"Data Source=LUCASZIIN\SQLEXPRESS;Database=EquipEaseDB;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader read;

        /// <summary>
        /// This excecutres the query, used mainly for 
        /// insert/delete/update statements etc. where we don't need
        /// to read from what we are doing.
        /// </summary>
        /// <param name="query"></param>
        public static void executeQuery(string query)
        {
            //try catch to catch any unforseen errors gracefully
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
        }

        /// <summary>
        /// Generates an SQL query based on the input
        /// query e.g. "SELECT * FROM staff"
        /// </summary>
        /// <param name="query"></param>
        public static void selectQuery(string query)
        {
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing query: " + ex.Message);
            }
        }

        /// <summary>
        /// Prints out the ID  based on the query givin into a combo box
        /// </summary>
        /// <param name="comboBox">A control to be used to write existing names to</param>
        /// <param name="query">An SQL query to generate from</param>
        public static void editComboBoxItems(System.Windows.Forms.ComboBox comboBox, string query)
        {
            bool clear = true;

            // Gets data from database
            SQL.selectQuery(query);
            // Check that there is something to write
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (comboBox.Text == SQL.read[0].ToString())
                    {
                        clear = false;
                    }
                }
            }

            // Gets data from database
            SQL.selectQuery(query);
            // If nothing in the comboBox then we need to clear it
            if (clear)
            {
                comboBox.Text = "";
                comboBox.Items.Clear();

            }

            // This will print whatever is in the database to the combobox
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    comboBox.Items.Add(SQL.read[0].ToString());
                }
            }
        }

        /// <summary>
        /// Checks if the equipment is available.
        /// </summary>
        /// <param name="equipmentType">The type of equipment</param>
        /// <param name="branchName">The branch name</param>
        /// <returns>True if the equipment is available, false otherwise</returns>
        public static bool IsEquipmentAvailable(string equipmentType, string branchName)
        {

            string query = "select count(*) from Equipment " +
                "where available = 1 and TypeName = @typeName and BranchName = @branchName";

            try
            {
                // Close the connection if it's open
                con.Close();
                cmd.Connection = con;
                // Open the connection
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@typeName", equipmentType);
                cmd.Parameters.AddWithValue("@branchName", branchName);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue
                MessageBox.Show("Error checking availability of item: " + ex.Message);
                return false;
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }

        /// <summary>
        /// Gets the rate per hour for a specific equipment type.
        /// </summary>
        /// <param name="equipmentType">The type of equipment</param>
        /// <returns>The rate per hour for the equipment type</returns>
        public static decimal GetEquipRate(string equipmentType)
        {

            string query = "select rateperhour from EquipmentType where typename = @typeName";
            
            try
            {
                // Close the connection if it's open
                con.Close();
                cmd.Connection = con;
                // Open the connection
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@typeName", equipmentType);
                

                // Convert received value to a decimal and return it
                return (decimal)cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                // Show an error message if there is an issue
                MessageBox.Show("Error checking price of item: " + ex.Message);
                return 0;
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }


        /// <summary>
        /// Rents equipment by updating the database.
        /// </summary>
        /// <param name="equipId">The equipment ID.</param>
        /// <param name="equipmentType">The type of equipment.</param>
        /// <param name="branchName">The branch name.</param>
        /// <param name="fName">The first name of the customer.</param>
        /// <param name="lName">The last name of the customer.</param>
        /// <param name="phoneNum">The phone number of the customer.</param>
        /// <param name="customerEmail">The email of the customer.</param>
        /// <param name="startHire">The start time of the hire.</param>
        /// <param name="newestEquip">Whether to rent the newest equipment.</param>
        
        public static void RentEquip(int equipId, string equipmentType, string branchName, 
            string fName, string lName, string phoneNum, string customerEmail, 
            string startHire, bool newestEquip)
        {
            string query = "";
            
            // If wants to pick newest equipment, give its equipment Id otherwise just close and open the connection
            if (newestEquip)
            {
                query = "SELECT EquipmentID FROM Equipment WHERE available = 1 AND " +
                    "purchaseDate = (SELECT MAX(purchaseDate) FROM Equipment WHERE available = 1 AND TypeName = @typeName AND BranchName = @branchName) AND " +
                    "TypeName = @typeName AND BranchName = @branchName;";

                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@typeName", equipmentType);
                cmd.Parameters.AddWithValue("@branchName", branchName);

                // Convert the received value to integer
                equipId = (int)cmd.ExecuteScalar();
            }
            else
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
            }
            
            // Query to update availability of equipment
            string query1 = "UPDATE Equipment SET available = 0 WHERE EquipmentID = @equipId;";
           
            // Query to insert the customer's details into the database
            string query2 = "INSERT INTO Customer Values(@customerEmail, @fName, @lName, @phoneNum);";

            // Query to insert the rental details into the database
            string query3 = "INSERT INTO Rental Values(@startHire, @branchName, @customerEmail);";

            //Query to find the rental ID of the rental generated
            string query4 = "select rentalID from rental where startTime = @startHire AND hireFrom = @branchName AND customerEmail = @customerEmail;";
            
            // Update the rentEquipment table with the values for this rental
            string query5 = "INSERT INTO rentEquipment Values(@equipId,@rentalId,null,null);";
            
            try
            {
                // Check if equipId is a valid number, if yes execute the queries defined above.
                if (equipId != -1)
                {
                    // set availability to 0 if the given date is now or before
                    /*if (DateTime.TryParse(startHire, out startHireConverted))
                    {
                        DateTime currentTime = DateTime.Now;

                        if (startHireConverted <= currentTime)
                        {
                            cmd.CommandText = query1;
                            cmd.Parameters.Clear(); // Clear any previous parameters
                            cmd.Parameters.AddWithValue("@equipID", equipId);
                            cmd.ExecuteNonQuery();
                        }
                        
                    }*/


                    // always set availability to 0
                    cmd.CommandText = query1;
                    cmd.Parameters.Clear(); // Clear any previous parameters
                    cmd.Parameters.AddWithValue("@equipID", equipId);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query2;
                    cmd.Parameters.Clear(); // Clear any previous parameters
                    cmd.Parameters.AddWithValue("@customerEmail", customerEmail);
                    cmd.Parameters.AddWithValue("@fName", fName);
                    cmd.Parameters.AddWithValue("@lName", lName);
                    cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query3;
                    cmd.Parameters.Clear(); // Clear any previous parameters
                    cmd.Parameters.AddWithValue("@startHire", startHire);
                    cmd.Parameters.AddWithValue("@branchName", branchName);
                    cmd.Parameters.AddWithValue("@customerEmail", customerEmail);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query4;
                    cmd.Parameters.Clear(); // Clear any previous parameters
                    cmd.Parameters.AddWithValue("@startHire", startHire);
                    cmd.Parameters.AddWithValue("@branchName", branchName);
                    cmd.Parameters.AddWithValue("@customerEmail", customerEmail);
                    cmd.ExecuteNonQuery();
                    int rentalId = (int)cmd.ExecuteScalar();

                    cmd.CommandText = query5;
                    cmd.Parameters.Clear(); // Clear any previous parameters
                    cmd.Parameters.AddWithValue("@equipId", equipId);
                    cmd.Parameters.AddWithValue("@rentalId", rentalId);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Display an error message if necessary
                    MessageBox.Show("Equipment not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Updating Equipment Status: " + ex.Message);
                
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Returns equipment by updating the database.
        /// </summary>
        /// <param name="rentalId">The rental ID.</param>
        /// <param name="equipId">The equipment ID.</param>
        /// <param name="branchName">The branch name.</param>
        /// <param name="endHire">The end time of the hire.</param>
        public static void ReturnEquip(string rentalId, string equipId, string branchName, string endHire)
        {

            // Query to update the rentEquipment table with the return's details
            string query = "update rentEquipment set returnTime = @endHire, returnTo = @branchName where rrentalID = @rentalId and rEquipmentID = @equipId";
            
            // Query to update the availability of the equipment to 1
            string query1 = "UPDATE Equipment SET available = 1 WHERE EquipmentID = @equipId;";
            
            // Query to update the location of the equipment in the Equipment Table
            string query2 = "UPDATE Equipment SET BranchName = @branchName WHERE EquipmentID = @equipId;";

            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@endHire", endHire);
                cmd.Parameters.AddWithValue("@branchName", branchName);
                cmd.Parameters.AddWithValue("@rentalID", rentalId);
                cmd.Parameters.AddWithValue("@equipId", equipId);
                cmd.ExecuteNonQuery();

                cmd.CommandText = query1;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@equipID", equipId);
                cmd.ExecuteNonQuery();

                cmd.CommandText = query2;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@branchName", branchName);
                cmd.Parameters.AddWithValue("@equipID", equipId);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {   
                // Throw an exception if an error occurs
                throw new Exception("Error Updating Equipment Status: " + ex.Message);

            }
            finally
            {
                // Close the connection if still open
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        /// <summary>
        /// Gets the purchase date of the equipment.
        /// </summary>
        /// <param name="equipId">The equipment ID.</param>
        /// <returns>The purchase date of the equipment.</returns>
        public static DateTime GetPurchaseDate(string equipId)
        {
            // Query to get the purchaseDate from the equipment table in the database
            string query = "select purchasedate from equipment where equipmentID = @equipId";

            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                cmd.Parameters.AddWithValue("@equipId", equipId);
                DateTime purchaseDate = (DateTime)cmd.ExecuteScalar();

                return purchaseDate;
            }
            catch (Exception ex)
            {
                // Throw an exception if an error occurs
                throw new Exception("Error Updating Equipment Status: " + ex.Message);

            }
            finally
            {
                // Close the connection if still open
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Finds the branch name from the equipment ID.
        /// </summary>
        /// <param name="equipId">The equipment ID.</param>
        /// <returns>The branch name associated with the equipment ID.</returns>
        public static string FindBranchFromEquipId(int equipId)
        {
            // Query to find where an equipment is located by using its Id
            string query = "select branchName from equipment where equipmentid = " + equipId;

            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.Parameters.Clear(); // Clear any previous parameters
                string branchName = (string)cmd.ExecuteScalar();
                return branchName;
            }
            catch (Exception ex)
            {
                // Throw an exception if an error occurs
                throw new Exception("Error Updating Equipment Status: " + ex.Message);

            }
            finally
            {
                // Close the connection if still open
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// Generates a report of the number of unique customers who rented equipment in each branch in 2023.
        /// </summary>
        /// <param name="listBox">The ListBox to display the report in.</param>
        public static void GenerateUniqueCustomersReport(ListBox listBox)
        {
            string query = "SELECT hireFrom, COUNT(DISTINCT CustomerEmail) AS UniqueCustomers FROM Rental " +
                "WHERE YEAR(StartTime) = 2023 GROUP BY hireFrom;";
            
            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write
            if (SQL.read.HasRows)
            {
                listBox.Items.Add("The number of unique customers who rented equipment in each branch in 2023");
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                listBox.Items.Add("Branch name:".PadRight(50) + "Number of Unique Customers: ");
                while (SQL.read.Read())
                {
                    listBox.Items.Add(SQL.read[0].ToString().PadRight(50) + SQL.read[1].ToString().PadLeft(5));
                    
                }
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                
            }

        }

        /// <summary>
        /// Generates a report of the average rental duration per equipment type in 2023.
        /// </summary>
        /// <param name="listBox">The ListBox to display the report in.</param>
        public static void GenerateAverageDurationReport(ListBox listBox)
        {
            string query = "select typeName, AVG(DATEDIFF(minute, startTime, returnTime)) AS AvgDuration " +
                "from rentequipment join Rental on Rental.rentalID = rentEquipment.rRentalID " +
                "join Equipment on Equipment.equipmentId = rentEquipment.requipmentID " +
                "WHERE YEAR(startTime) = 2023 GROUP BY typeName;";

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write
            if (SQL.read.HasRows)
            {
                listBox.Items.Add("Average rental duration per equipment type in 2023 in hours");
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                listBox.Items.Add("Equipment Type:".PadRight(50) + "Average hours rented: ");
                while (SQL.read.Read())
                {
                    
                    listBox.Items.Add(SQL.read[0].ToString().PadRight(50) + 
                        (Convert.ToInt32(SQL.read[1])/60).ToString()); // Convert value received from minutes to hours

                }
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                
            }
        }

        /// <summary>
        /// Generates a report of the most popular equipment type rented in each branch in 2023.
        /// </summary>
        /// <param name="listBox">The ListBox to display the report in.</param>
        public static void GeneratePopularEquipTypesReport(ListBox listBox)
        {

            /*

            1. Define a Common Table Expression called RankedEquipment
            2. Pull data from rentEquipment, Rental, and Equipment tables
            3. For each branch and equipment type, we count how many times it was rented
            4. Rank obtained counts within each branch using DENSE_RANK()
            5. We select only the most rented equipment types for each branch
            6. Sort results by branch name

            */

            string query = "WITH RankedEquipment AS (SELECT hireFrom, TypeName, COUNT(*) AS RentalCount, " +
                "DENSE_RANK() OVER(PARTITION BY hireFrom ORDER BY COUNT(*) DESC) AS Rank FROM rentEquipment " +
                "JOIN Rental ON Rental.rentalID = rentEquipment.rRentalID " +
                "JOIN Equipment ON Equipment.equipmentId = rentEquipment.requipmentID " +
                "WHERE YEAR(Rental.startTime) = 2023 " +
                "GROUP BY hireFrom, TypeName) " +
                "SELECT hireFrom, TypeName, RentalCount FROM RankedEquipment WHERE Rank = 1 ORDER BY hireFrom;";

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write
            if (SQL.read.HasRows)
            {
                listBox.Items.Add("Most popular equipment type rented in each branch in 2023");
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                listBox.Items.Add("Equipment Type:".PadRight(50) + "Number of rentals: ");
                while (SQL.read.Read())
                {
                    listBox.Items.Add(SQL.read[0].ToString().PadRight(50) + SQL.read[1].ToString().PadRight(30)
                        + SQL.read[2].ToString());

                }
                listBox.Items.Add(string.Empty); // Add an empty line for spacing

            }
        }

        /// <summary>
        /// Generates a report of the total number of rentals per month in 2023.
        /// </summary>
        /// <param name="listBox">The ListBox to display the report in.</param>
        public static void GenerateTotaRentalsNumReport(ListBox listBox)
        {
            string query = "SELECT MONTH(StartTime) AS Month, COUNT(*) AS RentalCount FROM Rental " +
                "WHERE YEAR(StartTime) = 2023 GROUP BY MONTH(StartTime);";

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write
            if (SQL.read.HasRows)
            {
                listBox.Items.Add("The total number of rentals per month in 2023");
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                listBox.Items.Add("Month Number 1-12:".PadRight(50) + "Number of rentals: ");
                
                while (SQL.read.Read())
                {
                    listBox.Items.Add(SQL.read[0].ToString().PadRight(50) + SQL.read[1].ToString().PadRight(30));

                }
                listBox.Items.Add(string.Empty); // Add an empty line for spacing

            }
        }

        /// <summary>
        /// Generates a report of the total income generated by each equipment type in 2023.
        /// </summary>
        /// <param name="listBox">The ListBox to display the report in.</param>
        public static void GenerateIncomePerEquipTypeReport(ListBox listBox)
        {
            string query = "SELECT Equipment.typeName, SUM(DATEDIFF(hour, startTime, returnTime) * ratePerHour) " +
                "AS TotalIncome FROM rentEquipment JOIN Rental ON Rental.rentalID = rentEquipment.rRentalID " +
                "JOIN Equipment ON Equipment.equipmentId = rentEquipment.requipmentID " +
                "JOIN EquipmentType ON EquipmentType.typeName = Equipment.typeName " +
                "WHERE YEAR(Rental.startTime) = 2023 GROUP BY Equipment.typeName;";

            //gets data from database
            SQL.selectQuery(query);
            //Check that there is something to write
            if (SQL.read.HasRows)
            {
                listBox.Items.Add("Total income generated by each equipment type in 2023");
                listBox.Items.Add(string.Empty); // Add an empty line for spacing
                
                while (SQL.read.Read())
                {
                    listBox.Items.Add(SQL.read[0].ToString().PadRight(50) + SQL.read[1].ToString().PadRight(30));

                }
                listBox.Items.Add(string.Empty); // Add an empty line for spacing

            }

        }

        /// <summary>
        /// Adds a separator line in the ListBox for better readability.
        /// </summary>
        /// <param name="listBox">The ListBox to add the separator to.</param>
        public static void AddSeparator(ListBox listBox)
        {
            listBox.Items.Add(string.Empty);
            listBox.Items.Add(new string('-', 60));
            listBox.Items.Add(string.Empty);
        }
    }
}

