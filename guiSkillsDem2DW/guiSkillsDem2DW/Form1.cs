using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace guiSkillsDem2DW
{
    public partial class mainForm : Form
    {
        string dbLocation = "";
        int recordCounter = 0;
        bool dbOpened = false;
        bool columnSelected = false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the application
            Environment.Exit(0);
        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //set carsDB Location
                OpenFileDialog getStudentDB = new OpenFileDialog();
                //Every access file with have accdb in its
                //name, this is why a filter is used to
                //ensure this is the only type that can be opened
                getStudentDB.Filter = "Database |* .accdb";

                if (getStudentDB.ShowDialog() == DialogResult.OK)
                {
                    //Setting global var to getDB's file name
                    dbLocation = getStudentDB.FileName;
                    //Now that location is set
                    //set to true 
                    dbOpened = true;
                }
                //Opening the connection
                OleDbConnection studentGradesDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                //Opening the database
                if (dbOpened == true)
                {
                    //Open database 
                    studentGradesDB.Open();
                    //Make sql
                    OleDbCommand readAllRecords = new OleDbCommand("SELECT * FROM studentDB;", studentGradesDB);
                    //Ask sql
                    OleDbDataReader readDB = readAllRecords.ExecuteReader();
                    //Format table
                    while (readDB.Read())
                    {
                        //Adding the text from the database
                        //into the columns
                        gradeSystemDataGrid.Rows.Add(Convert.ToInt32(readDB[0]), readDB[1].ToString(), readDB[2].ToString(), readDB[3].ToString(), Convert.ToInt32(readDB[4]), readDB[5].ToString());
                        recordCounter++;
                    }
                    gradeSystemDataGrid.Sort(gradeSystemDataGrid.Columns[5], ListSortDirection.Descending);
                    //Close database connection
                    studentGradesDB.Close();
                    //Dispose database connection
                    studentGradesDB.Dispose();
                    //Get record count
                    if (gradeSystemDataGrid.SelectedRows.Count > 0)
                    {
                        //Setting the record count text
                        recordCount.Text = (gradeSystemDataGrid.SelectedRows[0].Index + 1).ToString() + " of " + gradeSystemDataGrid.Rows.Count;
                    }
                }
                else
                {
                    //Inform end user they have not
                    //set the database location
                    MessageBox.Show("Error, you have not set the database location, please do so in order to show the database table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error, the database you attempted to open is not compatible with the format of this application, please ensure you have opened a Student's database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSelectedStudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling 
            try
            {
                //While the connection is open run code
                if (dbOpened == true)
                {
                    if(MessageBox.Show("Are you sure you wish to delete the selected record?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        //Gets ID value from first column
                        int id = Convert.ToInt32(gradeSystemDataGrid.CurrentRow.Cells[0].Value);
                        //Set database connection
                        OleDbConnection studentDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                        //Open database
                        studentDB.Open();
                        //Set query
                        OleDbCommand deleteRecord = new OleDbCommand("DELETE * FROM studentDB WHERE [Student ID] =" + id + ";", studentDB);
                        //Send query and get results
                        int result = deleteRecord.ExecuteNonQuery();
                        //Check result
                        if (result > 0)
                        {
                            MessageBox.Show("Record has sucessfully been deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The deletion has failed, please try again.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Close database connection
                        studentDB.Close();
                        //Dispose of connection
                        studentDB.Dispose();
                        //Refresh datagrid
                        refreshDB();
                        //Exit point in our loop
                    }
                    //If connection to database is not open
                    //inform end user
                    else if (dbOpened == false)
                    {
                        MessageBox.Show("Error, please ensure a database has been opened before attempting to delete an entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                //informs end user of excepted error 
                MessageBox.Show(ex.Message);
            }
        }
        public void refreshDB()
        {
            try
            {
                if(dbOpened == true)
                {
                    //Clears datagrids rowsz
                    gradeSystemDataGrid.Rows.Clear();
                    //Set database connecion
                    OleDbConnection studentsDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                    //Open database
                    studentsDB.Open();
                    //Set query
                    OleDbCommand getAll = new OleDbCommand("SELECT * FROM studentDB;", studentsDB);
                    //Send query and get results
                    OleDbDataReader readDB = getAll.ExecuteReader();
                    //Get results
                    while (readDB.Read())
                    {
                        gradeSystemDataGrid.Rows.Add(Convert.ToInt32(readDB[0]), readDB[1].ToString(), readDB[2].ToString(), readDB[3].ToString(), Convert.ToInt32(readDB[4]), readDB[5].ToString());
                    }
                    //Setting record count
                    if (gradeSystemDataGrid.SelectedRows.Count > 0)
                    {
                        //Setting the record count text
                        recordCount.Text = (gradeSystemDataGrid.SelectedRows[0].Index + 1).ToString() + " of " + gradeSystemDataGrid.Rows.Count;
                    }
                    //Close database 
                    studentsDB.Close();
                    //Dispose database
                    studentsDB.Dispose();
                    //Set record count text to counters num
                }
                else
                {
                    MessageBox.Show("Error, please ensure a database is present before attempting to refresh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Calls on refresh database method
            //once menu strip item is clicked
            refreshDB();
        }

        private void ascendingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes datagrid to ascending order on 
            //menu strip click
            gradeSystemDataGrid.Sort(gradeSystemDataGrid.Columns[5], ListSortDirection.Ascending);
        }

        private void descendingOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Changes datagrid to descending order on 
            //menu strip click
            gradeSystemDataGrid.Sort(gradeSystemDataGrid.Columns[5], ListSortDirection.Descending);
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Error handling 
            try
            {
                //While the connection is open 
                if (dbOpened == true)
                {
                    //Opens insert form 
                    insertRecordForm insertDetails = new guiSkillsDem2DW.insertRecordForm(dbLocation, this);
                    insertDetails.ShowDialog();
                    //Exit point in our loop 
                }
                //If connection is not open 
                else if (dbOpened == false)
                {
                    MessageBox.Show("Error, please ensure you have loaded the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //Informs end user of excepted error
                //during the running of the application 
                MessageBox.Show(ex.Message);
            }
        }

        private void editStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling
            try
            {
                //If connection is open the allow for code
                if (columnSelected == true)
                {
                    if (dbOpened == true)
                    {
                        //Storing first row into variable
                        int id = Convert.ToInt32(gradeSystemDataGrid.CurrentRow.Cells[0].Value);
                        //Opening child form and passing arguments 
                        editRecordForm insertCar = new editRecordForm(dbLocation, this, id);
                        //Show dialog to prevent end user
                        //from opening multiple child forms
                        insertCar.ShowDialog();
                    }
                    //Else inform end user connection to
                    //database is not opened 
                    else
                    {
                        //In the case if no database
                        //has been opened 
                        MessageBox.Show("Error, no database has been opened for you to edit any records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, you have not selected any records to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //Display to end user the excepted error
                MessageBox.Show(ex.Message);
            }
        }

        private void gradeSystemDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            columnSelected = true;
        }

        private void gradeSystemDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            columnSelected = true;
        }
        private void searchDB()
        {
            //Error handling
            try
            {
                //Connection must be true in order for code to run
                if (dbOpened == true)
                {
                    int counter = 0;
                    string searchText = searchTextBox.Text;

                    //Creating our list to store the databases
                    //columns' names
                    List<string> myDBList = new List<string>();
                    myDBList.Add("[Student ID]");
                    myDBList.Add("[First Name]");
                    myDBList.Add("Surname");
                    myDBList.Add("Subject");
                    myDBList.Add("Marks");
                    myDBList.Add("Grades");

                    //Clears datagrids rows
                    gradeSystemDataGrid.Rows.Clear();
                    //Using a for loop to loop through 
                    //the database list
                    for (int i = 0; i < myDBList.Count; i++)
                    {
                        OleDbConnection studentsDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                        //Open database
                        studentsDB.Open();
                        //Getting the relevant information
                        //from the database 
                        OleDbCommand getAll = new OleDbCommand("SELECT * FROM studentDB WHERE " + myDBList[i] + " LIKE '%" + searchTextBox.Text + "%';", studentsDB);
                        //Send query and get results
                        OleDbDataReader readDB = getAll.ExecuteReader();
                        //Use while loop while reading in the results
                        //to add them into the database
                        while (readDB.Read())
                        {
                            gradeSystemDataGrid.Rows.Add(Convert.ToInt32(readDB[0]), readDB[1].ToString(), readDB[2].ToString(), readDB[3].ToString(), Convert.ToInt32(readDB[4]), readDB[5].ToString());
                            counter++;
                        }
                        //Close database 
                        studentsDB.Close();
                        //Dispose database
                        studentsDB.Dispose();
                        //Set record count text to counters num
                        if (gradeSystemDataGrid.SelectedRows.Count > 0)
                        {
                            //Setting the record count text
                            recordCount.Text = (gradeSystemDataGrid.SelectedRows[0].Index + 1).ToString() + " of " + gradeSystemDataGrid.Rows.Count;
                        }
                    }
                }
                else
                {
                    //Inform end user they have not connected
                    //the database
                    MessageBox.Show("Error, please ensure you have opened the database before attempting to search for any records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(dbOpened == true)
                {
                    searchDB();
                }
                else
                {
                    MessageBox.Show("Error, please ensure the database is opened before attempting to search for any records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If enter is pressed
                if (e.KeyChar == (char)Keys.Return)
                {
                    //And if dbOpened is equal to true
                    if(dbOpened == true)
                    {
                        //Call on searchDB method
                        searchDB();
                        //Set event handled to true
                        e.Handled = true;
                    }
                    //Else inform end user there was an error
                    else
                    {
                        MessageBox.Show("Error, please ensure the database is opened before attempting to search for any records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database has been opened
                if(dbOpened == true)
                {
                    //Stores the current selected row
                    //into variable
                    int currentRow = gradeSystemDataGrid.SelectedRows[0].Index;

                    //This will ensure the code does not
                    //exceed the amount of records on the database
                    //and prevents breaking from occuring 
                    if (currentRow < gradeSystemDataGrid.RowCount - 1)
                    {
                        //Set to true
                        gradeSystemDataGrid.Rows[currentRow + 1].Cells[0].Selected = true;
                    }
                }
                else
                {
                    //Inform end user using a message box
                    //that not database has been opened
                    MessageBox.Show("Error, please ensure the database has been opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database has been opened
                if (dbOpened == true)
                {
                    //Stores the current selected row
                    //into variable
                    int currentRow = gradeSystemDataGrid.SelectedRows[0].Index;

                    //This will ensure the code does not
                    //exceed the amount of records on the database
                    //and prevents breaking from occuring 
                    if (currentRow > 0)
                    {
                        //Set to true
                        gradeSystemDataGrid.Rows[currentRow - 1].Cells[0].Selected = true;
                    }
                }
                else
                {
                    //Inform end user using a message box
                    //that not database has been opened
                    MessageBox.Show("Error, please ensure the database has been opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstRecordButton_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database is opened
                if(dbOpened == true)
                {
                    //Run code 
                    gradeSystemDataGrid.Rows[0].Selected = true;
                }
                //Else inform end user that they
                //need to have a database opened
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database");
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lastRecordButton_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch 
            try
            {
                //If database has been opened
                if(dbOpened == true)
                {
                    //Run code
                    gradeSystemDataGrid.Rows[gradeSystemDataGrid.Rows.Count - 1].Selected = true;
                }
                //Else inform end user they need to 
                //ensure a database has been opened
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gradeSystemDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                if(dbOpened == true)
                {
                    //This will allow to identify what
                    //row is currently selected on the datagrid
                    //this in turn will be used for our record count
                    if (gradeSystemDataGrid.SelectedRows.Count > 0)
                    {
                        //Setting the record count text
                        recordCount.Text = (gradeSystemDataGrid.SelectedRows[0].Index + 1).ToString() + " of " + gradeSystemDataGrid.Rows.Count;
                    }
                }
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database");
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void gradeSystemDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Error handling using try and catch
            try
            {
                if (dbOpened == true)
                {
                    //This will allow to identify what
                    //row is currently selected on the datagrid
                    //this in turn will be used for our record count
                    if (gradeSystemDataGrid.SelectedRows.Count > 0)
                    {
                        //Setting the record count text
                        recordCount.Text = (gradeSystemDataGrid.SelectedRows[0].Index + 1).ToString() + " of " + gradeSystemDataGrid.Rows.Count;
                    }
                }
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database");
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database is opened
                if (dbOpened == true)
                {
                    //Run code 
                    gradeSystemDataGrid.Rows[0].Selected = true;
                }
                //Else inform end user that they
                //need to have a database opened
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database");
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void previousRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database has been opened
                if (dbOpened == true)
                {
                    //Stores the current selected row
                    //into variable
                    int currentRow = gradeSystemDataGrid.SelectedRows[0].Index;

                    //This will ensure the code does not
                    //exceed the amount of records on the database
                    //and prevents breaking from occuring 
                    if (currentRow > 0)
                    {
                        //Set to true
                        gradeSystemDataGrid.Rows[currentRow - 1].Cells[0].Selected = true;
                    }
                }
                else
                {
                    //Inform end user using a message box
                    //that not database has been opened
                    MessageBox.Show("Error, please ensure the database has been opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch
            try
            {
                //If the database has been opened
                if (dbOpened == true)
                {
                    //Stores the current selected row
                    //into variable
                    int currentRow = gradeSystemDataGrid.SelectedRows[0].Index;

                    //This will ensure the code does not
                    //exceed the amount of records on the database
                    //and prevents breaking from occuring 
                    if (currentRow < gradeSystemDataGrid.RowCount - 1)
                    {
                        //Set to true
                        gradeSystemDataGrid.Rows[currentRow + 1].Cells[0].Selected = true;
                    }
                }
                else
                {
                    //Inform end user using a message box
                    //that not database has been opened
                    MessageBox.Show("Error, please ensure the database has been opened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lastRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Error handling using try and catch 
            try
            {
                //If database has been opened
                if (dbOpened == true)
                {
                    //Run code
                    gradeSystemDataGrid.Rows[gradeSystemDataGrid.Rows.Count - 1].Selected = true;
                }
                //Else inform end user they need to 
                //ensure a database has been opened
                else
                {
                    MessageBox.Show("Error, please ensure you have opened a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Catches and displays excepted error
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
