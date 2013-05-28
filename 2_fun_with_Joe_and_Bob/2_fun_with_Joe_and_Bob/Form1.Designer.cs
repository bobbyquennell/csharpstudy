namespace _2_fun_with_Joe_and_Bob
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
            this.JoesCashlabel = new System.Windows.Forms.Label();
            this.BobsCashlabel = new System.Windows.Forms.Label();
            this.BanksCashlabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoesCashlabel
            // 
            this.JoesCashlabel.AutoSize = true;
            this.JoesCashlabel.Location = new System.Drawing.Point(57, 9);
            this.JoesCashlabel.Name = "JoesCashlabel";
            this.JoesCashlabel.Size = new System.Drawing.Size(53, 13);
            this.JoesCashlabel.TabIndex = 0;
            this.JoesCashlabel.Text = "Joe has $";
            // 
            // BobsCashlabel
            // 
            this.BobsCashlabel.AutoSize = true;
            this.BobsCashlabel.Location = new System.Drawing.Point(57, 36);
            this.BobsCashlabel.Name = "BobsCashlabel";
            this.BobsCashlabel.Size = new System.Drawing.Size(55, 13);
            this.BobsCashlabel.TabIndex = 1;
            this.BobsCashlabel.Text = "Bob has $";
            // 
            // BanksCashlabel
            // 
            this.BanksCashlabel.AutoSize = true;
            this.BanksCashlabel.Location = new System.Drawing.Point(57, 64);
            this.BanksCashlabel.Name = "BanksCashlabel";
            this.BanksCashlabel.Size = new System.Drawing.Size(82, 13);
            this.BanksCashlabel.TabIndex = 2;
            this.BanksCashlabel.Text = "The bank has $";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(52, 168);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(87, 58);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(171, 168);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(80, 58);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BanksCashlabel);
            this.Controls.Add(this.BobsCashlabel);
            this.Controls.Add(this.JoesCashlabel);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoesCashlabel;
        private System.Windows.Forms.Label BobsCashlabel;
        private System.Windows.Forms.Label BanksCashlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

