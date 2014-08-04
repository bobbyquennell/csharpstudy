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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // labelFileDate
            // 
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Location = new System.Drawing.Point(12, 115);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(49, 13);
            this.labelFileDate.TabIndex = 7;
            this.labelFileDate.Text = "File Date";
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
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(98, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

