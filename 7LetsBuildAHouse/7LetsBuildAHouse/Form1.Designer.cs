namespace _7LetsBuildAHouse
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gohere = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.ComboBox();
            this.GoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 128);
            this.textBox1.TabIndex = 0;
            // 
            // Gohere
            // 
            this.Gohere.Location = new System.Drawing.Point(29, 181);
            this.Gohere.Name = "Gohere";
            this.Gohere.Size = new System.Drawing.Size(75, 23);
            this.Gohere.TabIndex = 1;
            this.Gohere.Text = "Go Here:";
            this.Gohere.UseVisualStyleBackColor = true;
            this.Gohere.Click += new System.EventHandler(this.Gohere_Click);
            // 
            // Exits
            // 
            this.Exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exits.FormattingEnabled = true;
            this.Exits.Location = new System.Drawing.Point(146, 182);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(121, 21);
            this.Exits.TabIndex = 2;
            // 
            // GoThroughTheDoor
            // 
            this.GoThroughTheDoor.Location = new System.Drawing.Point(29, 225);
            this.GoThroughTheDoor.Name = "GoThroughTheDoor";
            this.GoThroughTheDoor.Size = new System.Drawing.Size(238, 23);
            this.GoThroughTheDoor.TabIndex = 3;
            this.GoThroughTheDoor.Text = "Go through the door";
            this.GoThroughTheDoor.UseVisualStyleBackColor = true;
            this.GoThroughTheDoor.Visible = false;
            this.GoThroughTheDoor.Click += new System.EventHandler(this.GoThroughTheDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.GoThroughTheDoor);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.Gohere);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gohere;
        private System.Windows.Forms.ComboBox Exits;
        private System.Windows.Forms.Button GoThroughTheDoor;
    }
}

