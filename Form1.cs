using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;


namespace phoneBook
{
    public partial class PhoneBook : Form
    {


        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True");
            con.Open();

            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM TablePhoneBook", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvPhoneBook.DataSource = dt;



            //SqlCommand cmd = new SqlCommand("SELECT * FROM TablePhoneBook", con);
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            //sqlDataAdapter.SelectCommand = cmd;

            //DataTable dataTable = new DataTable();

            //sqlDataAdapter.Fill(dataTable);
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = dataTable;
            //dgvPhoneBook.DataSource = bindingSource;
            //sqlDataAdapter.Update(dataTable);
            //con.Close();

            //SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True");
            //con.Open();
            //String query = "select * from TablePhoneBook";
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query,con);
            //var ds=new DataSet();
            //dgvPhoneBook.DataSource = ds.Tables[0];
            //con.Close();
        }

        public PhoneBook()
        {
            InitializeComponent();
            //loadData();
        }




        private void PhoneBook_Load(object sender, EventArgs e)
        {

            loadData();

        }

        private void Apppanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TablePhoneBook ([sID], [firstName], [lastName], [email], [mobile]) VALUES (@sID, @firstName, @lastName, @email, @mobile)", con);
                    cmd.Parameters.AddWithValue("@sID", textID.Text);
                    cmd.Parameters.AddWithValue("@firstName", textFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", textLastName.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@mobile", textMobile.Text);

                    cmd.ExecuteNonQuery();  // Execute the insert command
                    MessageBox.Show("Add success", "Message Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();  // Refresh data or load updated data, if applicable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvPhoneBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is actually selected
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhoneBook.Rows[e.RowIndex];

                // Populate the text boxes with data from the selected row's cells
                textID.Text = row.Cells["sID"].Value.ToString();
                textFirstName.Text = row.Cells["firstName"].Value.ToString();
                textLastName.Text = row.Cells["lastName"].Value.ToString();
                textEmail.Text = row.Cells["email"].Value.ToString();
                textMobile.Text = row.Cells["mobile"].Value.ToString();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textID.Text))
            {
                MessageBox.Show("Please enter a valid ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TablePhoneBook WHERE sID = @sID", con);
                    cmd.Parameters.AddWithValue("@sID", textID.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Delete success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();  // Refresh data or load updated data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            textID.Text = string.Empty;
            textFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textEmail.Text = string.Empty;
            textMobile.Text = string.Empty;


        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True"))
                {
                    con.Open();

                    // Update query with parameters for multiple fields
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE TablePhoneBook SET firstName = @firstName, lastName = @lastName, email = @email,mobile = @mobile WHERE sID = @sID", con);

                    // Add parameters for each field
                    cmd.Parameters.AddWithValue("@sID", textID.Text);

                    cmd.Parameters.AddWithValue("@firstName", textFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastName", textLastName.Text);
                    cmd.Parameters.AddWithValue("@email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@mobile", textMobile.Text);



                    // Execute the query and check if any rows were affected
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();  // Refresh data or load updated data
                    }
                    else
                    {
                        MessageBox.Show("No record found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string searchID = txtSearch.Text.Trim();  // Get the search term

        //    SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True");

        //    // Open the connection
        //    con.Open();

        //    // If no search term, load all data
        //    if (string.IsNullOrWhiteSpace(searchID))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM TablePhoneBook", con);
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sqlDataAdapter.Fill(dt);
        //        dgvPhoneBook.DataSource = dt;  // Bind all data to DataGridView
        //    }
        //    else
        //    {
        //        // If search term exists, search by sID
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM TablePhoneBook WHERE sID = @sID", con);
        //        cmd.Parameters.AddWithValue("@sID", searchID);
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sqlDataAdapter.Fill(dt);
        //        dgvPhoneBook.DataSource = dt;  // Bind filtered data to DataGridView
        //    }

        //    con.Close();  // Close the connection
        //}


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text.Trim());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearch.Text.Trim());  // Real-time search as user types
        }

        private void SearchData(string searchTerm)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd;

                    if (string.IsNullOrWhiteSpace(searchTerm))
                    {
                        // Load all data if search box is empty
                        cmd = new SqlCommand("SELECT * FROM TablePhoneBook", con);
                    }
                    else
                    {
                        // Search across multiple fields with partial matching
                        cmd = new SqlCommand(@"
                    SELECT * FROM TablePhoneBook 
                    WHERE sID LIKE @search 
                    OR firstName LIKE @search 
                    OR lastName LIKE @search 
                    OR email LIKE @search 
                    OR mobile LIKE @search", con);

                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    }

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    // Set the DataSource
                    dgvPhoneBook.DataSource = dt;

                    // Show a message if no results found
                    if (dt.Rows.Count == 0 && !string.IsNullOrWhiteSpace(searchTerm))
                    {
                        MessageBox.Show("No matching records found.", "Search Results",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during search: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }









        int currentIndex = 0; // Variable to store the current row index

        private void ShowData(int index)
        {
            // Check if the index is within bounds
            if (index >= 0 && index < dgvPhoneBook.Rows.Count)
            {
                dgvPhoneBook.ClearSelection();
                dgvPhoneBook.Rows[index].Selected = true;
                dgvPhoneBook.CurrentCell = dgvPhoneBook.Rows[index].Cells[0];
                currentIndex = index;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            ShowData(0); // Show the first row
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                ShowData(currentIndex - 1); // Show the previous row
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < dgvPhoneBook.Rows.Count - 1)
            {
                ShowData(currentIndex + 1); // Show the next row
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            ShowData(dgvPhoneBook.Rows.Count - 2); // Show the last row
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
