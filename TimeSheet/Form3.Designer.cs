namespace TimeSheet
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBoxEmailAlert = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEmailInput = new System.Windows.Forms.TextBox();
            this.SubmitEmailButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBoxEmailAlert.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxEmailAlert
            // 
            this.GroupBoxEmailAlert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupBoxEmailAlert.Controls.Add(this.label1);
            this.GroupBoxEmailAlert.Controls.Add(this.TextBoxEmailInput);
            this.GroupBoxEmailAlert.Controls.Add(this.SubmitEmailButton);
            this.GroupBoxEmailAlert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBoxEmailAlert.Font = new System.Drawing.Font("Adobe Hebrew", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxEmailAlert.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxEmailAlert.Name = "GroupBoxEmailAlert";
            this.GroupBoxEmailAlert.Size = new System.Drawing.Size(518, 338);
            this.GroupBoxEmailAlert.TabIndex = 0;
            this.GroupBoxEmailAlert.TabStop = false;
            this.GroupBoxEmailAlert.Text = "Email Alert ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Adobe Hebrew", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your personal email address ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxEmailInput
            // 
            this.TextBoxEmailInput.Location = new System.Drawing.Point(85, 135);
            this.TextBoxEmailInput.Name = "TextBoxEmailInput";
            this.TextBoxEmailInput.Size = new System.Drawing.Size(338, 32);
            this.TextBoxEmailInput.TabIndex = 1;
            // 
            // SubmitEmailButton
            // 
            this.SubmitEmailButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SubmitEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitEmailButton.Font = new System.Drawing.Font("Adobe Hebrew", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitEmailButton.Location = new System.Drawing.Point(80, 223);
            this.SubmitEmailButton.Name = "SubmitEmailButton";
            this.SubmitEmailButton.Size = new System.Drawing.Size(343, 56);
            this.SubmitEmailButton.TabIndex = 0;
            this.SubmitEmailButton.Text = "Submit Email ";
            this.SubmitEmailButton.UseCompatibleTextRendering = true;
            this.SubmitEmailButton.UseVisualStyleBackColor = false;
            this.SubmitEmailButton.Click += new System.EventHandler(this.SubmitEmailButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 368);
            this.Controls.Add(this.GroupBoxEmailAlert);
            this.Name = "Form3";
            this.Text = "Email data";
            this.GroupBoxEmailAlert.ResumeLayout(false);
            this.GroupBoxEmailAlert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxEmailAlert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxEmailInput;
        private System.Windows.Forms.Button SubmitEmailButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}