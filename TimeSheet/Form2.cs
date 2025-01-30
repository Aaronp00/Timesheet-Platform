using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSheet
{
    

    public partial class Form2 : Form
    {    
        
        private MainForm mainFormRef;

        //private Form3 Form3Ref;


      
        public Form2(MainForm mainForm)
        {   //Form3 form3

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

           // Form3Ref = form3;

            // referencing the mainform

            this.mainFormRef = mainForm; 
        }

        // ginving the access to the datagrid from out the class
        public DataGridView DataGridView1
        {
            get { return this.dataGridView1; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // bringing the main form to the front 
        private void button1_Click(object sender, EventArgs e)
        {
               mainFormRef.BringToFront();
                mainFormRef.Show();
           

        }

    

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
