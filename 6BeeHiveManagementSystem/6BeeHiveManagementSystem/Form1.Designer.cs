namespace _6BeeHiveManagementSystem
{
    partial class Form1
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
            this.workerbeeJobcomboBox = new System.Windows.Forms.ComboBox();
            this.workerbeeJobLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.shiftsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.workerbeeAssignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.workShiftsButton = new System.Windows.Forms.Button();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerbeeJobcomboBox
            // 
            this.workerbeeJobcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerbeeJobcomboBox.FormattingEnabled = true;
            this.workerbeeJobcomboBox.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby bee tutoring",
            "Honey manufacturing",
            "Sting patrol"});
            this.workerbeeJobcomboBox.Location = new System.Drawing.Point(12, 56);
            this.workerbeeJobcomboBox.Name = "workerbeeJobcomboBox";
            this.workerbeeJobcomboBox.Size = new System.Drawing.Size(161, 20);
            this.workerbeeJobcomboBox.TabIndex = 0;
            // 
            // workerbeeJobLabel
            // 
            this.workerbeeJobLabel.AutoSize = true;
            this.workerbeeJobLabel.Location = new System.Drawing.Point(10, 41);
            this.workerbeeJobLabel.Name = "workerbeeJobLabel";
            this.workerbeeJobLabel.Size = new System.Drawing.Size(89, 12);
            this.workerbeeJobLabel.TabIndex = 1;
            this.workerbeeJobLabel.Text = "Worker bee job";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(205, 55);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Location = new System.Drawing.Point(203, 40);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(41, 12);
            this.shiftsLabel.TabIndex = 3;
            this.shiftsLabel.Text = "Shifts";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assign this job to a bee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workerbeeAssignmentGroupBox
            // 
            this.workerbeeAssignmentGroupBox.Location = new System.Drawing.Point(4, 12);
            this.workerbeeAssignmentGroupBox.Name = "workerbeeAssignmentGroupBox";
            this.workerbeeAssignmentGroupBox.Size = new System.Drawing.Size(283, 118);
            this.workerbeeAssignmentGroupBox.TabIndex = 5;
            this.workerbeeAssignmentGroupBox.TabStop = false;
            this.workerbeeAssignmentGroupBox.Text = "Worker Bee Assignments";
            // 
            // workShiftsButton
            // 
            this.workShiftsButton.Location = new System.Drawing.Point(331, 41);
            this.workShiftsButton.Name = "workShiftsButton";
            this.workShiftsButton.Size = new System.Drawing.Size(75, 66);
            this.workShiftsButton.TabIndex = 6;
            this.workShiftsButton.Text = "Work the next shift";
            this.workShiftsButton.UseVisualStyleBackColor = true;
            this.workShiftsButton.Click += new System.EventHandler(this.workShiftsButton_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(12, 137);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ReadOnly = true;
            this.ReportTextBox.Size = new System.Drawing.Size(394, 212);
            this.ReportTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 361);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.workShiftsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.workerbeeJobLabel);
            this.Controls.Add(this.workerbeeJobcomboBox);
            this.Controls.Add(this.workerbeeAssignmentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerbeeJobcomboBox;
        private System.Windows.Forms.Label workerbeeJobLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label shiftsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox workerbeeAssignmentGroupBox;
        private System.Windows.Forms.Button workShiftsButton;
        private System.Windows.Forms.TextBox ReportTextBox;
    }
}

