namespace _8ExerciseUsingLists
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Button_MoveToDeck2 = new System.Windows.Forms.Button();
            this.Button_MoveToDeck1 = new System.Windows.Forms.Button();
            this.button_ResetDeck1 = new System.Windows.Forms.Button();
            this.button_ShuffleDeck1 = new System.Windows.Forms.Button();
            this.button_ResetDeck2 = new System.Windows.Forms.Button();
            this.button_ShuffleDeck2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(23, 110);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 400);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(438, 110);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 400);
            this.listBox2.TabIndex = 1;
            // 
            // Button_MoveToDeck2
            // 
            this.Button_MoveToDeck2.Location = new System.Drawing.Point(260, 152);
            this.Button_MoveToDeck2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_MoveToDeck2.Name = "Button_MoveToDeck2";
            this.Button_MoveToDeck2.Size = new System.Drawing.Size(112, 34);
            this.Button_MoveToDeck2.TabIndex = 2;
            this.Button_MoveToDeck2.Text = ">>";
            this.Button_MoveToDeck2.UseVisualStyleBackColor = true;
            this.Button_MoveToDeck2.Click += new System.EventHandler(this.Button_MoveToDeck2_Click);
            // 
            // Button_MoveToDeck1
            // 
            this.Button_MoveToDeck1.Location = new System.Drawing.Point(260, 232);
            this.Button_MoveToDeck1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_MoveToDeck1.Name = "Button_MoveToDeck1";
            this.Button_MoveToDeck1.Size = new System.Drawing.Size(112, 34);
            this.Button_MoveToDeck1.TabIndex = 3;
            this.Button_MoveToDeck1.Text = "<<";
            this.Button_MoveToDeck1.UseVisualStyleBackColor = true;
            this.Button_MoveToDeck1.Click += new System.EventHandler(this.Button_MoveToDeck1_Click);
            // 
            // button_ResetDeck1
            // 
            this.button_ResetDeck1.Location = new System.Drawing.Point(86, 554);
            this.button_ResetDeck1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ResetDeck1.Name = "button_ResetDeck1";
            this.button_ResetDeck1.Size = new System.Drawing.Size(154, 34);
            this.button_ResetDeck1.TabIndex = 4;
            this.button_ResetDeck1.Text = "Reset Deck #1";
            this.button_ResetDeck1.UseVisualStyleBackColor = true;
            this.button_ResetDeck1.Click += new System.EventHandler(this.button_ResetDeck1_Click);
            // 
            // button_ShuffleDeck1
            // 
            this.button_ShuffleDeck1.Location = new System.Drawing.Point(86, 618);
            this.button_ShuffleDeck1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ShuffleDeck1.Name = "button_ShuffleDeck1";
            this.button_ShuffleDeck1.Size = new System.Drawing.Size(154, 34);
            this.button_ShuffleDeck1.TabIndex = 5;
            this.button_ShuffleDeck1.Text = "Shuffle Deck #1";
            this.button_ShuffleDeck1.UseVisualStyleBackColor = true;
            this.button_ShuffleDeck1.Click += new System.EventHandler(this.button_ShuffleDeck1_Click);
            // 
            // button_ResetDeck2
            // 
            this.button_ResetDeck2.Location = new System.Drawing.Point(375, 554);
            this.button_ResetDeck2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ResetDeck2.Name = "button_ResetDeck2";
            this.button_ResetDeck2.Size = new System.Drawing.Size(160, 34);
            this.button_ResetDeck2.TabIndex = 6;
            this.button_ResetDeck2.Text = "Reset Deck #2";
            this.button_ResetDeck2.UseVisualStyleBackColor = true;
            this.button_ResetDeck2.Click += new System.EventHandler(this.button_ResetDeck2_Click);
            // 
            // button_ShuffleDeck2
            // 
            this.button_ShuffleDeck2.Location = new System.Drawing.Point(375, 618);
            this.button_ShuffleDeck2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ShuffleDeck2.Name = "button_ShuffleDeck2";
            this.button_ShuffleDeck2.Size = new System.Drawing.Size(160, 34);
            this.button_ShuffleDeck2.TabIndex = 7;
            this.button_ShuffleDeck2.Text = "Shuffle Deck #2";
            this.button_ShuffleDeck2.UseVisualStyleBackColor = true;
            this.button_ShuffleDeck2.Click += new System.EventHandler(this.button_ShuffleDeck2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deck #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Deck #2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ShuffleDeck2);
            this.Controls.Add(this.button_ResetDeck2);
            this.Controls.Add(this.button_ShuffleDeck1);
            this.Controls.Add(this.button_ResetDeck1);
            this.Controls.Add(this.Button_MoveToDeck1);
            this.Controls.Add(this.Button_MoveToDeck2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Button_MoveToDeck2;
        private System.Windows.Forms.Button Button_MoveToDeck1;
        private System.Windows.Forms.Button button_ResetDeck1;
        private System.Windows.Forms.Button button_ShuffleDeck1;
        private System.Windows.Forms.Button button_ResetDeck2;
        private System.Windows.Forms.Button button_ShuffleDeck2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

