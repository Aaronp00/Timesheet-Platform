namespace TimeSheet
{
    partial class MainForm
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
            this.NewEmBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewShiftBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewSubmitButton = new System.Windows.Forms.Button();
            this.NewTimeOut = new System.Windows.Forms.DateTimePicker();
            this.NewTimeIn = new System.Windows.Forms.DateTimePicker();
            this.NewSelectDep = new System.Windows.Forms.ComboBox();
            this.NewLName = new System.Windows.Forms.TextBox();
            this.NewFName = new System.Windows.Forms.TextBox();
            this.OldEmBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OldShiftBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.OldSubmitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OldTimeOut = new System.Windows.Forms.DateTimePicker();
            this.OldTimeIn = new System.Windows.Forms.DateTimePicker();
            this.OldSelectName = new System.Windows.Forms.ComboBox();
            this.NewEmView = new System.Windows.Forms.Button();
            this.OldEmView = new System.Windows.Forms.Button();
            this.AccessPointBox = new System.Windows.Forms.GroupBox();
            this.ExitTimeSheet = new System.Windows.Forms.Button();
            this.FormTwoView = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.NewEmBox.SuspendLayout();
            this.NewShiftBox.SuspendLayout();
            this.OldEmBox.SuspendLayout();
            this.OldShiftBox.SuspendLayout();
            this.AccessPointBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewEmBox
            // 
            this.NewEmBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewEmBox.Controls.Add(this.label3);
            this.NewEmBox.Controls.Add(this.label2);
            this.NewEmBox.Controls.Add(this.label1);
            this.NewEmBox.Controls.Add(this.NewShiftBox);
            this.NewEmBox.Controls.Add(this.NewSelectDep);
            this.NewEmBox.Controls.Add(this.NewLName);
            this.NewEmBox.Controls.Add(this.NewFName);
            this.NewEmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmBox.Location = new System.Drawing.Point(34, 114);
            this.NewEmBox.Name = "NewEmBox";
            this.NewEmBox.Size = new System.Drawing.Size(525, 537);
            this.NewEmBox.TabIndex = 0;
            this.NewEmBox.TabStop = false;
            this.NewEmBox.Text = "New Employee ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Department ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name ";
            // 
            // NewShiftBox
            // 
            this.NewShiftBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NewShiftBox.Controls.Add(this.label9);
            this.NewShiftBox.Controls.Add(this.label8);
            this.NewShiftBox.Controls.Add(this.NewSubmitButton);
            this.NewShiftBox.Controls.Add(this.NewTimeOut);
            this.NewShiftBox.Controls.Add(this.NewTimeIn);
            this.NewShiftBox.Location = new System.Drawing.Point(28, 291);
            this.NewShiftBox.Name = "NewShiftBox";
            this.NewShiftBox.Size = new System.Drawing.Size(453, 217);
            this.NewShiftBox.TabIndex = 1;
            this.NewShiftBox.TabStop = false;
            this.NewShiftBox.Text = "Shift Details";
            this.NewShiftBox.Enter += new System.EventHandler(this.NewShiftBox_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Time Out";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Time In";
            // 
            // NewSubmitButton
            // 
            this.NewSubmitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSubmitButton.Location = new System.Drawing.Point(304, 113);
            this.NewSubmitButton.Name = "NewSubmitButton";
            this.NewSubmitButton.Size = new System.Drawing.Size(119, 70);
            this.NewSubmitButton.TabIndex = 4;
            this.NewSubmitButton.Text = "Submit ";
            this.NewSubmitButton.UseVisualStyleBackColor = false;
            this.NewSubmitButton.Click += new System.EventHandler(this.NewSubmitButton_Click);
            // 
            // NewTimeOut
            // 
            this.NewTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NewTimeOut.Location = new System.Drawing.Point(20, 157);
            this.NewTimeOut.Name = "NewTimeOut";
            this.NewTimeOut.ShowUpDown = true;
            this.NewTimeOut.Size = new System.Drawing.Size(221, 26);
            this.NewTimeOut.TabIndex = 1;
            // 
            // NewTimeIn
            // 
            this.NewTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.NewTimeIn.Location = new System.Drawing.Point(20, 65);
            this.NewTimeIn.Name = "NewTimeIn";
            this.NewTimeIn.ShowUpDown = true;
            this.NewTimeIn.Size = new System.Drawing.Size(221, 26);
            this.NewTimeIn.TabIndex = 3;
            this.NewTimeIn.Value = new System.DateTime(2025, 1, 17, 2, 45, 0, 0);
            this.NewTimeIn.ValueChanged += new System.EventHandler(this.NewTimeIn_ValueChanged);
            // 
            // NewSelectDep
            // 
            this.NewSelectDep.FormattingEnabled = true;
            this.NewSelectDep.Items.AddRange(new object[] {
            "Sales Representative",
            "Operations Manager",
            "Welder/Fabricator",
            "Field Service Technician",
            "Agricultural Engineer"});
            this.NewSelectDep.Location = new System.Drawing.Point(178, 190);
            this.NewSelectDep.Name = "NewSelectDep";
            this.NewSelectDep.Size = new System.Drawing.Size(318, 28);
            this.NewSelectDep.TabIndex = 2;
            this.NewSelectDep.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // NewLName
            // 
            this.NewLName.Location = new System.Drawing.Point(178, 117);
            this.NewLName.Name = "NewLName";
            this.NewLName.Size = new System.Drawing.Size(318, 26);
            this.NewLName.TabIndex = 1;
            // 
            // NewFName
            // 
            this.NewFName.Location = new System.Drawing.Point(178, 46);
            this.NewFName.Name = "NewFName";
            this.NewFName.Size = new System.Drawing.Size(318, 26);
            this.NewFName.TabIndex = 0;
            // 
            // OldEmBox
            // 
            this.OldEmBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldEmBox.Controls.Add(this.label5);
            this.OldEmBox.Controls.Add(this.OldShiftBox);
            this.OldEmBox.Controls.Add(this.OldSelectName);
            this.OldEmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldEmBox.Location = new System.Drawing.Point(577, 114);
            this.OldEmBox.Name = "OldEmBox";
            this.OldEmBox.Size = new System.Drawing.Size(509, 537);
            this.OldEmBox.TabIndex = 1;
            this.OldEmBox.TabStop = false;
            this.OldEmBox.Text = "Existing Employee";
            this.OldEmBox.Enter += new System.EventHandler(this.OldEmBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Name";
            // 
            // OldShiftBox
            // 
            this.OldShiftBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OldShiftBox.Controls.Add(this.label7);
            this.OldShiftBox.Controls.Add(this.OldSubmitButton);
            this.OldShiftBox.Controls.Add(this.label6);
            this.OldShiftBox.Controls.Add(this.OldTimeOut);
            this.OldShiftBox.Controls.Add(this.OldTimeIn);
            this.OldShiftBox.Location = new System.Drawing.Point(33, 291);
            this.OldShiftBox.Name = "OldShiftBox";
            this.OldShiftBox.Size = new System.Drawing.Size(434, 200);
            this.OldShiftBox.TabIndex = 2;
            this.OldShiftBox.TabStop = false;
            this.OldShiftBox.Text = "Shift Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time Out";
            // 
            // OldSubmitButton
            // 
            this.OldSubmitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldSubmitButton.Location = new System.Drawing.Point(289, 103);
            this.OldSubmitButton.Name = "OldSubmitButton";
            this.OldSubmitButton.Size = new System.Drawing.Size(116, 70);
            this.OldSubmitButton.TabIndex = 2;
            this.OldSubmitButton.Text = "Submit ";
            this.OldSubmitButton.UseVisualStyleBackColor = false;
            this.OldSubmitButton.Click += new System.EventHandler(this.OldSubmitButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time In";
            // 
            // OldTimeOut
            // 
            this.OldTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OldTimeOut.Location = new System.Drawing.Point(17, 147);
            this.OldTimeOut.Name = "OldTimeOut";
            this.OldTimeOut.ShowUpDown = true;
            this.OldTimeOut.Size = new System.Drawing.Size(224, 26);
            this.OldTimeOut.TabIndex = 1;
            // 
            // OldTimeIn
            // 
            this.OldTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OldTimeIn.Location = new System.Drawing.Point(17, 49);
            this.OldTimeIn.Name = "OldTimeIn";
            this.OldTimeIn.ShowUpDown = true;
            this.OldTimeIn.Size = new System.Drawing.Size(224, 26);
            this.OldTimeIn.TabIndex = 0;
            // 
            // OldSelectName
            // 
            this.OldSelectName.FormattingEnabled = true;
            this.OldSelectName.Location = new System.Drawing.Point(149, 104);
            this.OldSelectName.Name = "OldSelectName";
            this.OldSelectName.Size = new System.Drawing.Size(318, 28);
            this.OldSelectName.TabIndex = 1;
            this.OldSelectName.SelectedIndexChanged += new System.EventHandler(this.OldSelectName_SelectedIndexChanged);
            // 
            // NewEmView
            // 
            this.NewEmView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewEmView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewEmView.Location = new System.Drawing.Point(59, 36);
            this.NewEmView.Name = "NewEmView";
            this.NewEmView.Size = new System.Drawing.Size(178, 42);
            this.NewEmView.TabIndex = 2;
            this.NewEmView.Text = " New Employee ";
            this.NewEmView.UseVisualStyleBackColor = false;
            this.NewEmView.Click += new System.EventHandler(this.NewEmView_Click);
            // 
            // OldEmView
            // 
            this.OldEmView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OldEmView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OldEmView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OldEmView.Location = new System.Drawing.Point(620, 36);
            this.OldEmView.Name = "OldEmView";
            this.OldEmView.Size = new System.Drawing.Size(197, 42);
            this.OldEmView.TabIndex = 3;
            this.OldEmView.Text = "Existing Employee ";
            this.OldEmView.UseVisualStyleBackColor = false;
            this.OldEmView.Click += new System.EventHandler(this.OldEmView_Click);
            // 
            // AccessPointBox
            // 
            this.AccessPointBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccessPointBox.Controls.Add(this.ExitTimeSheet);
            this.AccessPointBox.Controls.Add(this.FormTwoView);
            this.AccessPointBox.Controls.Add(this.NewEmView);
            this.AccessPointBox.Controls.Add(this.OldEmView);
            this.AccessPointBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AccessPointBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessPointBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccessPointBox.Location = new System.Drawing.Point(34, 12);
            this.AccessPointBox.Name = "AccessPointBox";
            this.AccessPointBox.Size = new System.Drawing.Size(1052, 96);
            this.AccessPointBox.TabIndex = 4;
            this.AccessPointBox.TabStop = false;
            this.AccessPointBox.Text = "Access Point";
            // 
            // ExitTimeSheet
            // 
            this.ExitTimeSheet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitTimeSheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitTimeSheet.Location = new System.Drawing.Point(923, 31);
            this.ExitTimeSheet.Name = "ExitTimeSheet";
            this.ExitTimeSheet.Size = new System.Drawing.Size(106, 53);
            this.ExitTimeSheet.TabIndex = 5;
            this.ExitTimeSheet.Text = "EXIT";
            this.ExitTimeSheet.UseVisualStyleBackColor = false;
            this.ExitTimeSheet.Click += new System.EventHandler(this.ExitTimeSheet_Click);
            // 
            // FormTwoView
            // 
            this.FormTwoView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormTwoView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FormTwoView.Location = new System.Drawing.Point(332, 36);
            this.FormTwoView.Name = "FormTwoView";
            this.FormTwoView.Size = new System.Drawing.Size(178, 42);
            this.FormTwoView.TabIndex = 4;
            this.FormTwoView.Text = "Data TimeSheet";
            this.FormTwoView.UseVisualStyleBackColor = false;
            this.FormTwoView.Click += new System.EventHandler(this.FormTwoView_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfoButton.Image = global::TimeSheet.Properties.Resources.INFO;
            this.InfoButton.Location = new System.Drawing.Point(27, 657);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(74, 78);
            this.InfoButton.TabIndex = 7;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1158, 735);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.AccessPointBox);
            this.Controls.Add(this.OldEmBox);
            this.Controls.Add(this.NewEmBox);
            this.Name = "MainForm";
            this.Text = "TimeSheet Submission";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NewEmBox.ResumeLayout(false);
            this.NewEmBox.PerformLayout();
            this.NewShiftBox.ResumeLayout(false);
            this.NewShiftBox.PerformLayout();
            this.OldEmBox.ResumeLayout(false);
            this.OldEmBox.PerformLayout();
            this.OldShiftBox.ResumeLayout(false);
            this.OldShiftBox.PerformLayout();
            this.AccessPointBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewEmBox;
        private System.Windows.Forms.GroupBox OldEmBox;
        private System.Windows.Forms.ComboBox NewSelectDep;
        private System.Windows.Forms.TextBox NewLName;
        private System.Windows.Forms.TextBox NewFName;
        private System.Windows.Forms.GroupBox NewShiftBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewSubmitButton;
        private System.Windows.Forms.GroupBox OldShiftBox;
        private System.Windows.Forms.Button OldSubmitButton;
        private System.Windows.Forms.DateTimePicker OldTimeOut;
        private System.Windows.Forms.DateTimePicker OldTimeIn;
        private System.Windows.Forms.ComboBox OldSelectName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button NewEmView;
        private System.Windows.Forms.Button OldEmView;
        private System.Windows.Forms.GroupBox AccessPointBox;
        private System.Windows.Forms.Button FormTwoView;
        private System.Windows.Forms.Button ExitTimeSheet;
        private System.Windows.Forms.DateTimePicker NewTimeOut;
        private System.Windows.Forms.DateTimePicker NewTimeIn;
        private System.Windows.Forms.Button InfoButton;
    }
}

