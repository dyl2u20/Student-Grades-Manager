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
    public partial class insertRecordForm : Form
    {
        mainForm myParent;
        string dbLocation = "";
        public insertRecordForm(string dbLoc, mainForm parentDetails)
        {
            InitializeComponent();
            myParent = parentDetails;
            dbLocation = dbLoc;
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes current form
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Closes current form
            this.Close();

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            //Set Database
            OleDbConnection studentsDB = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
            //Open Database
            studentsDB.Open();
            //Set query
            OleDbCommand insertRecord = new OleDbCommand("INSERT into studentDB([First Name], Surname, Subject, Marks, Grades) VALUES('" + firstNameText.Text + "','" + surnameText.Text + "','" + subjectText.Text + "'," + Convert.ToInt32(marksText.Text) + ",'" + gradesText.Text + "');", studentsDB);
            //Set query and get results
            int results = insertRecord.ExecuteNonQuery();

            if (results > 0)
            {
                //All of record gets inserted
                MessageBox.Show("Record inserted sucessfully", "Insert Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Display failed
                MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Close database connection
            studentsDB.Close();
            //Dispose of the database 
            studentsDB.Dispose();
            //Refresh parent forms datagrid
            myParent.refreshDB();
            //Close this form
            this.Close();
        }

        private void insertRecordForm_Load(object sender, EventArgs e)
        {
            //Error handling 
            try
            {
                int counter = 0;
                //Opening the connection
                OleDbConnection studentsDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;data source =" + dbLocation);
                //Opening the database

                //Open database 
                studentsDB.Open();
                //Now that database is open set 
                //connection open to true 

                //Make sql
                OleDbCommand readAllRecords = new OleDbCommand("SELECT * FROM studentDB;", studentsDB);
                //Ask sql
                OleDbDataReader readDB = readAllRecords.ExecuteReader();
                //Format table
                while (readDB.Read())
                {
                    //Adding the text from the database
                    //into the columns
                    gradeSystemDataGrid.Rows.Add(Convert.ToInt32(readDB[0]), readDB[1].ToString(), readDB[2].ToString(),readDB[3].ToString(), Convert.ToInt32(readDB[4]), readDB[5].ToString());
                    counter++;
                }
                gradeSystemDataGrid.Sort(gradeSystemDataGrid.Columns[5], ListSortDirection.Descending);
                //Close database connection
                studentsDB.Close();
                //Dispose database connection
                studentsDB.Dispose();
            }
            catch (Exception ex)
            {
                //Informs end user of the excepted
                //error that occured during the 
                //running of the application 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
