namespace _4_Mileage_Calculator
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
            this.StartMileagelabel = new System.Windows.Forms.Label();
            this.EndMileagelabel = new System.Windows.Forms.Label();
            this.StartMileagenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EndMileagenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountOwnedlabel = new System.Windows.Forms.Label();
            this.CaculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MileDisplayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartMileagenumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMileagenumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMileagelabel
            // 
            this.StartMileagelabel.AutoSize = true;
            this.StartMileagelabel.Location = new System.Drawing.Point(22, 43);
            this.StartMileagelabel.Name = "StartMileagelabel";
            this.StartMileagelabel.Size = new System.Drawing.Size(83, 13);
            this.StartMileagelabel.TabIndex = 0;
            this.StartMileagelabel.Text = "Starting Mileage";
            // 
            // EndMileagelabel
            // 
            this.EndMileagelabel.AutoSize = true;
            this.EndMileagelabel.Location = new System.Drawing.Point(25, 96);
            this.EndMileagelabel.Name = "EndMileagelabel";
            this.EndMileagelabel.Size = new System.Drawing.Size(80, 13);
            this.EndMileagelabel.TabIndex = 1;
            this.EndMileagelabel.Text = "Ending Mileage";
            // 
            // StartMileagenumericUpDown
            // 
            this.StartMileagenumericUpDown.Location = new System.Drawing.Point(139, 41);
            this.StartMileagenumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StartMileagenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartMileagenumericUpDown.Name = "StartMileagenumericUpDown";
            this.StartMileagenumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.StartMileagenumericUpDown.TabIndex = 2;
            this.StartMileagenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndMileagenumericUpDown
            // 
            this.EndMileagenumericUpDown.Location = new System.Drawing.Point(139, 89);
            this.EndMileagenumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EndMileagenumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndMileagenumericUpDown.Name = "EndMileagenumericUpDown";
            this.EndMileagenumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.EndMileagenumericUpDown.TabIndex = 3;
            this.EndMileagenumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AmountOwnedlabel
            // 
            this.AmountOwnedlabel.AutoSize = true;
            this.AmountOwnedlabel.Location = new System.Drawing.Point(25, 142);
            this.AmountOwnedlabel.Name = "AmountOwnedlabel";
            this.AmountOwnedlabel.Size = new System.Drawing.Size(80, 13);
            this.AmountOwnedlabel.TabIndex = 4;
            this.AmountOwnedlabel.Text = "Amount Owned";
            // 
            // CaculateButton
            // 
            this.CaculateButton.Location = new System.Drawing.Point(25, 189);
            this.CaculateButton.Name = "CaculateButton";
            this.CaculateButton.Size = new System.Drawing.Size(75, 23);
            this.CaculateButton.TabIndex = 5;
            this.CaculateButton.Text = "Caculate";
            this.CaculateButton.UseVisualStyleBackColor = true;
            this.CaculateButton.Click += new System.EventHandler(this.CaculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(135, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // MileDisplayButton
            // 
            this.MileDisplayButton.Location = new System.Drawing.Point(139, 189);
            this.MileDisplayButton.Name = "MileDisplayButton";
            this.MileDisplayButton.Size = new System.Drawing.Size(120, 23);
            this.MileDisplayButton.TabIndex = 7;
            this.MileDisplayButton.Text = "Display Miles";
            this.MileDisplayButton.UseVisualStyleBackColor = true;
            this.MileDisplayButton.Click += new System.EventHandler(this.MileDisplayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.MileDisplayButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CaculateButton);
            this.Controls.Add(this.AmountOwnedlabel);
            this.Controls.Add(this.EndMileagenumericUpDown);
            this.Controls.Add(this.StartMileagenumericUpDown);
            this.Controls.Add(this.EndMileagelabel);
            this.Controls.Add(this.StartMileagelabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Caculator";
            ((System.ComponentModel.ISupportInitialize)(this.StartMileagenumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndMileagenumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartMileagelabel;
        private System.Windows.Forms.Label EndMileagelabel;
        private System.Windows.Forms.NumericUpDown StartMileagenumericUpDown;
        private System.Windows.Forms.NumericUpDown EndMileagenumericUpDown;
        private System.Windows.Forms.Label AmountOwnedlabel;
        private System.Windows.Forms.Button CaculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MileDisplayButton;
    }
}

