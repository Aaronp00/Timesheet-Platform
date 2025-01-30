using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Security;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;


namespace TimeSheet
{
    public partial class MainForm : Form
    {

        private Form3 form3Inst;
        private Form2 form2Inst;

        public MainForm()
        {

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            //shows the false of both selections when progam starts 
            NewEmBox.Visible = false;
            OldEmBox.Visible = false;


          // creating a instance the Form2
            form2Inst = new Form2(this);
            form2Inst.Hide();

            // creating a instance the Form3 while referencing the form2 
            form3Inst = new Form3(form2Inst);
            form3Inst.Hide();

            ModifyDataGridView();

            //reseting the shift timer back to zero 
            ResetShiftTimers();

        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to TimeSheet Platform", "Alert", MessageBoxButtons.OK, MessageBoxIcon.None);

            OldShiftBox.Visible = false;

            //reseting the shift timer back to zero 
            ResetShiftTimers();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
   


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////// NEW EMPLOYEE 
        /// </summary>



        private void NewSubmitButton_Click(object sender, EventArgs e)
        {

            string UserInputNewFName = NewFName.Text;
            string UserInputNewLName = NewLName.Text;
            string UserInputNewSelectDep = NewSelectDep.Text;

            DateTime startTime = NewTimeIn.Value;
            DateTime endTime = NewTimeOut.Value;


            // Calculatinhg  time difference
            TimeSpan timeDifference;
            if (endTime >= startTime)
            {
                timeDifference = endTime - startTime;
            }
            else
            {
                // Handle cases where endTime is past midnight
                timeDifference = (endTime.AddDays(1)) - startTime;
            }


            // error handler if  time case is null
            if (string.IsNullOrWhiteSpace(UserInputNewFName) || string.IsNullOrWhiteSpace(UserInputNewLName) || string.IsNullOrWhiteSpace(UserInputNewSelectDep)
                || startTime == endTime || timeDifference.TotalMinutes <= 0)

            {
                MessageBox.Show("Please fill in all fields and make sure the Time In and Time Out are valid before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further processing if any field is empty
            }
            else
            {
                // adds  all submissions to datagrid 

                AddToRowNew(NewFName.Text, NewLName.Text, NewSelectDep.Text, timeDifference);



                MessageBox.Show($"***TimeSheet Submitted***. Welcome {NewFName.Text} you are now a registered employee!");


                // reseting all data for the next user 
                NewFName.Clear();
                NewLName.Clear();
                NewSelectDep.SelectedItem = null;
                ResetShiftTimers();
            }


        }

        private void NewTimeIn_ValueChanged(object sender, EventArgs e)
        {

        }

        //this this the main funtiion that allows the addition to the dataGrid
        public void AddToRowNew(string Fname, string Lname, string NDepartment, TimeSpan timeDifference)
        {

            // adding a new employee number with every new submittion
            int nextRowNumber = form2Inst.DataGridView1.Rows.Count;
            string RowNum = $"Emp{nextRowNumber}";

            string totalHours = $"{timeDifference.Hours}h {timeDifference.Minutes}m";


            string[] row = { RowNum, Fname, Lname, NDepartment, totalHours };

            form2Inst.DataGridView1.Rows.Add(row);

            ImportOldSelectName();
        }














        /// <summary>
        /// //////////////////////////////////////////////////////////////THE DATAGRID STRUCTURE 
        /// </summary>

        private void ModifyDataGridView()
        {
         

            //forming the column names and structure that will be presented in form 2 

            form2Inst.DataGridView1.ColumnCount = 5; //The amount of columns (the count)

            form2Inst.DataGridView1.Columns[0].Name = "Employee Number ";
            form2Inst.DataGridView1.Columns[1].Name = "FirstName";
            form2Inst.DataGridView1.Columns[2].Name = "Last Name";
            form2Inst.DataGridView1.Columns[3].Name = "Department ";
            form2Inst.DataGridView1.Columns[4].Name = "Overall Hours ";

            //this will give the datagrid equal sizing across all 5 sections
            form2Inst.DataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            form2Inst.DataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            form2Inst.DataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            form2Inst.DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            form2Inst.DataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        






        /// <summary>
        /// //////////////////////////////////////////////////////////////******************* OLD EMPLOYEE
        /// </summary>


        private void ImportOldSelectName()
        {
            // Clears existing items in the combobox
            OldSelectName.Items.Clear();

            // Add names from the DataGrid  
            foreach (DataGridViewRow row in form2Inst.DataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    //  the combining of first and lastt name  , to create the fullname in a string 
                    string fullName = $"{row.Cells[1].Value.ToString()} {row.Cells[2].Value.ToString()}";

                    // adding the  full name to the combobox in existing employee
                    OldSelectName.Items.Add(fullName);



                }

            }

        }


       


        private string selectedFullName;

        private void OldSelectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OldSelectName.SelectedItem == null)
            {
                return;
            }


            string selected = OldSelectName.SelectedItem.ToString();

            DialogResult OldSelectedNameResult = MessageBox.Show($"you selected {selected} , are you sure you want to proceed ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (OldSelectedNameResult == DialogResult.Yes)
            { selectedFullName = selected;
                OldShiftBox.Visible = true;

            }


        }


        private void OldSubmitButton_Click(object sender, EventArgs e)
        {
           
            DateTime OldstartTime = OldTimeIn.Value;
            DateTime OldendTime = OldTimeOut.Value;

            // Calculating  time difference
            TimeSpan OldtimeDifference;



            if (OldendTime >= OldstartTime)
            {
                OldtimeDifference = OldendTime - OldstartTime;
            }
            else
            {
                // Handels the case when the endTimee is past midnight 
                OldtimeDifference = (OldendTime.AddDays(1)) - OldstartTime;
            }


            // manages null values
            if (string.IsNullOrWhiteSpace(OldSelectName.Text)
                || OldstartTime == OldendTime || OldtimeDifference.TotalMinutes <= 0)

            {

                MessageBox.Show("Please fill in all fields and make sure the Time In and Time Out are valid before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // This will Stop further proceeding if any field is empty
            }
            else
            {
                // allows me to add the time data to the row if data is valid 
                AddToRowOld(OldtimeDifference);
                MessageBox.Show($"***Time Sheet Submitted***.    {selectedFullName} you have added {OldtimeDifference.TotalHours}h {OldtimeDifference.Minutes}m to the timesheet Data ");

                OldSelectName.SelectedItem = null;

                //reseting the shift timer back to zero 
                ResetShiftTimers();
            }
        }

        public void AddToRowOld(TimeSpan OldtimeDifference)
        {

            string OldtotalHours = $"{OldtimeDifference.Hours}h {OldtimeDifference.Minutes}m";


            // Findingt the matching row in the DataGridView
            foreach (DataGridViewRow row in form2Inst.DataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string fullName = $"{row.Cells[1].Value.ToString()} {row.Cells[2].Value.ToString()}";

                    if (fullName == selectedFullName)
                    {
                        // converting the existing total hours
                        string existingHoursText = row.Cells[4].Value.ToString();
                        TimeSpan existingHours = ConvertHours(existingHoursText);

                        // Add the new hours to the existing hours
                        TimeSpan newTotalHours = existingHours + OldtimeDifference;

                        // Updating the row with the new total hours
                        row.Cells[4].Value = $"{newTotalHours.Hours}h {newTotalHours.Minutes}m";
                        double totalWorkedHours = newTotalHours.TotalHours;


                        return; // Exiting the loop 
                    }
                }
            }
        }


        private TimeSpan ConvertHours(string hoursText)
        {

            int hours = 0;
            int minutes = 0;

            // checking if input is null 
            if (!string.IsNullOrEmpty(hoursText))
            {
                string[] parts = hoursText.Split(new[] { 'h', 'm' }, StringSplitOptions.RemoveEmptyEntries);

                // assigning hours and minutes separately 

                if (parts.Length > 0 && int.TryParse(parts[0], out int h))
                {
                    hours = h;
                }

                if (parts.Length > 1 && int.TryParse(parts[1], out int m))
                {
                    minutes = m;
                }
            }

            ///returnig a new time object 
            return new TimeSpan(hours, minutes, 0);
        }


        // not needed
        private void OldEmBox_Enter(object sender, EventArgs e)
        {

        }







        //                  This is the access point options from form 1
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////ACCESS POINT OPTIONS AND OTHER METHODS
        /// </summary>


        // bring the form2 forward , allowing the user to change option
        private void FormTwoView_Click(object sender, EventArgs e)

        {

            form2Inst.Show();
            form2Inst.BringToFront();

            
            this.Hide();
            
        }
    




        
            private void NewEmView_Click(object sender, EventArgs e)
            {
            //the change of timesheet selection button in the access point.
             NewEmBox.Visible = true;
             OldEmBox.Visible = false;

            }

        private void OldEmView_Click(object sender, EventArgs e)
        {
            //the change of timesheet selection button in the access point.
            NewEmBox.Visible = false;
            OldEmBox.Visible = true;
        }


        private void ExitTimeSheet_Click(object sender, EventArgs e)
        { 
            NewEmBox.Visible = false;
            OldEmBox.Visible = false;
            
            DialogResult dialogResult = MessageBox.Show("Before you exit , do you want the overtime data sent to your personal email? ", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {  //Hiding the Mainform and Form2
                this.Hide();
                form2Inst.Hide();
                

                //This brings forward the email form
                form3Inst.Show();



            }
            else
            {    MessageBox.Show("GOODBYE","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                form2Inst.Hide();

                Application.Exit();
                

            }
           

        }

      
        //not needed 
        private void NewShiftBox_Enter(object sender, EventArgs e)
        {

        }

        // info box
        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the time in 24-hour format (e.g., 18:45 for 6:45 PM): ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        //The reseting of time data
        private void ResetShiftTimers()
        {
            NewTimeIn.Value = DateTime.Today.AddHours(0);
            NewTimeOut.Value = DateTime.Today.AddHours(0);
            OldTimeIn.Value = DateTime.Today.AddHours(0);
            OldTimeOut.Value = DateTime.Today.AddHours(0);
        }



    }
}
