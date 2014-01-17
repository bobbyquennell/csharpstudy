namespace _7LetsBuildAHouseAndHideAndFind
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
            this.ExitsComboBox = new System.Windows.Forms.ComboBox();
            this.GoThroughTheDoorButton = new System.Windows.Forms.Button();
            this.check_button = new System.Windows.Forms.Button();
            this.Hide_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 149);
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
            this.Gohere.Visible = false;
            this.Gohere.Click += new System.EventHandler(this.Gohere_Click);
            // 
            // ExitsComboBox
            // 
            this.ExitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExitsComboBox.FormattingEnabled = true;
            this.ExitsComboBox.Location = new System.Drawing.Point(146, 182);
            this.ExitsComboBox.Name = "ExitsComboBox";
            this.ExitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ExitsComboBox.TabIndex = 2;
            this.ExitsComboBox.Visible = false;
            // 
            // GoThroughTheDoorButton
            // 
            this.GoThroughTheDoorButton.Location = new System.Drawing.Point(29, 225);
            this.GoThroughTheDoorButton.Name = "GoThroughTheDoorButton";
            this.GoThroughTheDoorButton.Size = new System.Drawing.Size(238, 23);
            this.GoThroughTheDoorButton.TabIndex = 3;
            this.GoThroughTheDoorButton.Text = "Go through the door";
            this.GoThroughTheDoorButton.UseVisualStyleBackColor = true;
            this.GoThroughTheDoorButton.Visible = false;
            this.GoThroughTheDoorButton.Click += new System.EventHandler(this.GoThroughTheDoorButton_Click);
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(29, 255);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(238, 23);
            this.check_button.TabIndex = 4;
            this.check_button.Text = "check";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Visible = false;
            // 
            // Hide_button
            // 
            this.Hide_button.Location = new System.Drawing.Point(29, 285);
            this.Hide_button.Name = "Hide_button";
            this.Hide_button.Size = new System.Drawing.Size(238, 23);
            this.Hide_button.TabIndex = 5;
            this.Hide_button.Text = "Hide";
            this.Hide_button.UseVisualStyleBackColor = true;
            this.Hide_button.Click += new System.EventHandler(this.Hide_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 344);
            this.Controls.Add(this.Hide_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.GoThroughTheDoorButton);
            this.Controls.Add(this.ExitsComboBox);
            this.Controls.Add(this.Gohere);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gohere;
        private System.Windows.Forms.ComboBox ExitsComboBox;
        private System.Windows.Forms.Button GoThroughTheDoorButton;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button Hide_button;
    }
}

