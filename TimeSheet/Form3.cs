using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet
{
  
  public partial class Form3 : Form
    {
        private Form2 form2Inst;

        public Form3(Form2 form2Instance)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            // creating an instance of form 2 , to allow direct access  
            form2Inst = form2Instance;

        }

        private void SubmitEmailButton_Click(object sender, EventArgs e)
        {


            // Input of email to ensure fields are not empty
           if (string.IsNullOrWhiteSpace(TextBoxEmailInput.Text))
            {
                MessageBox.Show("Please fill in the email fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            try
            {    //string builder allowing me to structure the email
                StringBuilder emailBody = new StringBuilder();

                emailBody.AppendLine("TimeSheet Data:");

                //the scaNNING of each row 
                foreach (DataGridViewRow row in form2Inst.DataGridView1.Rows)
                {
                    if (!row.IsNewRow) //ignore the new row 
                    {
                        
                       
                       for (int Data = 0; Data < row.Cells.Count; Data++)
                            
                                if (row.Cells[Data].Value != null)

                                {    //outputting each row from the data grid 
                                    emailBody.Append($"{row.Cells[Data].Value}  ");
                                }
                            
                            emailBody.AppendLine(); // allows me to Move to the next row of data
                              
                    }
                }



                // Create email message
                MailMessage mm = new MailMessage();
                mm.From = new MailAddress("Your_gmail_email"); // my own  email
                mm.To.Add(new MailAddress(TextBoxEmailInput.Text)); // the input email
                mm.Subject = "TimeSheet Data - OVERTIME NOTIFICATION"; 
                mm.Body = emailBody.ToString(); // The email body


                // Configure the SMTP client
                SmtpClient sc = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Gmail's SMTP port for TLS
                    Credentials = new System.Net.NetworkCredential("You_gmail_email", "app_password_from_gmail"), // the the email followed by  app password 
                    EnableSsl = true // Enable secure connection
                };

                // Send the email
                sc.Send(mm);
                MessageBox.Show("***Email sent successfully!***  Thankyou for using the platform", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
