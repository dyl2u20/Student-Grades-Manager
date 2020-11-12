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
    public partial class editRecordForm : Form
    {
        string dbLocation = "";
        int id;
        bool infoEntered = false;
        mainForm myParent;
        public editRecordForm(string dbLoc, mainForm parentDetails, int idDetails)
        {
            InitializeComponent();
            dbLocation = dbLoc;
            id = idDetails;
            myParent = parentDetails;
        }

        private void editRecordForm_Load(object sender, EventArgs e)
        {
            //Set database
            OleDbConnection studentsDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
            //Open database
            studentsDB.Open();
            //
            OleDbCommand getID = new OleDbCommand("SELECT * FROM studentDB WHERE [Student ID] =" + id + ";", studentsDB);
            //Send query and get results
            OleDbDataReader readRecords = getID.ExecuteReader();
            //
            while (readRecords.Read())
            {
                //Reading in the selected rows 
                firstNameText.Text = readRecords[1].ToString();
                surnameText.Text = readRecords[2].ToString();
                //Convert car year to int then to string
                subjectText.Text = readRecords[3].ToString();
                marksText.Text = Convert.ToInt32(readRecords[4]).ToString();
                gradesText.Text = readRecords[5].ToString();
                gradeSystemDataGrid.Rows.Add(Convert.ToInt32(readRecords[0]), readRecords[1].ToString(), readRecords[2].ToString(), 
                    readRecords[3].ToString(), Convert.ToInt32(readRecords[4]), readRecords[5].ToString());
            }
            if (firstNameText.Text == "" || surnameText.Text == "" || subjectText.Text == "" || marksText.Text == "" || gradesText.Text == "")
            {
                MessageBox.Show("Error, some records were found to be missing, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            //Close database
            studentsDB.Close();
            //Dispose database
            studentsDB.Dispose();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //Error handling with try and catch 
            try
            {
                //Handling if nothing is entered into all the boxes
                //Need to handle if only one of the boxes 
                //etc isn't error handled for 
                if (firstNameText.Text == "" || surnameText.Text == "" || subjectText.Text == "" || gradesText.Text == "" || marksText.Text == "")
                {
                    infoEntered = false;
                    MessageBox.Show("Error, please insert relevant information into all the boxes provided", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Else then set info entered to true
                    infoEntered = true;
                }
                while (infoEntered == true)
                {
                    OleDbConnection studentsDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                    //Open Database
                    studentsDB.Open();
                    //Set query
                    //Ensure correct spacing is present
                    //as this can affect the sql code
                    OleDbCommand editRecords = new OleDbCommand("Update studentDB SET [First Name] = '" + firstNameText.Text + "', Surname ='" + surnameText.Text + "',Subject ='" +
                        subjectText.Text + "', Marks =" + Convert.ToInt32(marksText.Text) + ", Grades ='" + gradesText.Text + "' WHERE [STUDENT ID] = " + id + ";", studentsDB);
                    //Send query and get results
                    int results = editRecords.ExecuteNonQuery();
                    //Verifying if there are any 
                    //results to return 
                    if (results > 0)
                    {
                        MessageBox.Show("Sucessfully updated record entry", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error, update has failed, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Close database
                    studentsDB.Close();
                    //Dispose database
                    studentsDB.Dispose();
                    //Refresh parent form 
                    myParent.refreshDB();
                    //Close current form
                    this.Close();
                    //Exit point
                    infoEntered = false;
                }
            }
            catch (Exception ex)
            {
                //Displays the error that was excepted
                //during the running of the application 
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Closes current form
            this.Close();
        }
    }
}
