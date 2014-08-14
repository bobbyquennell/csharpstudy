namespace _9ExcuseManager
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
            this.lableExcuse = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelLastUsed = new System.Windows.Forms.Label();
            this.textBoxExcuse = new System.Windows.Forms.TextBox();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerLastUsed = new System.Windows.Forms.DateTimePicker();
            this.labelTitleofFileDate = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lableExcuse
            // 
            this.lableExcuse.AutoSize = true;
            this.lableExcuse.Location = new System.Drawing.Point(12, 24);
            this.lableExcuse.Name = "lableExcuse";
            this.lableExcuse.Size = new System.Drawing.Size(42, 13);
            this.lableExcuse.TabIndex = 0;
            this.lableExcuse.Text = "Excuse";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 58);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Results";
            // 
            // labelLastUsed
            // 
            this.labelLastUsed.AutoSize = true;
            this.labelLastUsed.Location = new System.Drawing.Point(12, 85);
            this.labelLastUsed.Name = "labelLastUsed";
            this.labelLastUsed.Size = new System.Drawing.Size(55, 13);
            this.labelLastUsed.TabIndex = 2;
            this.labelLastUsed.Text = "Last Used";
            // 
            // textBoxExcuse
            // 
            this.textBoxExcuse.Location = new System.Drawing.Point(98, 24);
            this.textBoxExcuse.Name = "textBoxExcuse";
            this.textBoxExcuse.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcuse.TabIndex = 3;
            this.textBoxExcuse.TextChanged += new System.EventHandler(this.textBoxExcuse_TextChanged);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(98, 51);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(100, 20);
            this.textBoxResults.TabIndex = 4;
            this.textBoxResults.TextChanged += new System.EventHandler(this.textBoxResults_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePickerLastUsed
            // 
            this.dateTimePickerLastUsed.Location = new System.Drawing.Point(98, 82);
            this.dateTimePickerLastUsed.Name = "dateTimePickerLastUsed";
            this.dateTimePickerLastUsed.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLastUsed.TabIndex = 6;
            this.dateTimePickerLastUsed.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTitleofFileDate
            // 
            this.labelTitleofFileDate.AutoSize = true;
            this.labelTitleofFileDate.Location = new System.Drawing.Point(12, 115);
            this.labelTitleofFileDate.Name = "labelTitleofFileDate";
            this.labelTitleofFileDate.Size = new System.Drawing.Size(49, 13);
            this.labelTitleofFileDate.TabIndex = 7;
            this.labelTitleofFileDate.Text = "File Date";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(54, 188);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 9;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(172, 188);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(266, 187);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Enabled = false;
            this.buttonRandom.Location = new System.Drawing.Point(369, 187);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 12;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelFileDate
            // 
            this.labelFileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFileDate.Location = new System.Drawing.Point(98, 115);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(200, 26);
            this.labelFileDate.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.labelTitleofFileDate);
            this.Controls.Add(this.dateTimePickerLastUsed);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.textBoxExcuse);
            this.Controls.Add(this.labelLastUsed);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.lableExcuse);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableExcuse;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelLastUsed;
        private System.Windows.Forms.TextBox textBoxExcuse;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUsed;
        private System.Windows.Forms.Label labelTitleofFileDate;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

