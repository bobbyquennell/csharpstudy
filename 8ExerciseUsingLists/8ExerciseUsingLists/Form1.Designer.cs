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
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(292, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 268);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(12, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 268);
            this.listBox2.TabIndex = 1;
            // 
            // Button_MoveToDeck2
            // 
            this.Button_MoveToDeck2.Location = new System.Drawing.Point(173, 101);
            this.Button_MoveToDeck2.Name = "Button_MoveToDeck2";
            this.Button_MoveToDeck2.Size = new System.Drawing.Size(75, 23);
            this.Button_MoveToDeck2.TabIndex = 2;
            this.Button_MoveToDeck2.Text = ">>";
            this.Button_MoveToDeck2.UseVisualStyleBackColor = true;
            // 
            // Button_MoveToDeck1
            // 
            this.Button_MoveToDeck1.Location = new System.Drawing.Point(173, 155);
            this.Button_MoveToDeck1.Name = "Button_MoveToDeck1";
            this.Button_MoveToDeck1.Size = new System.Drawing.Size(75, 23);
            this.Button_MoveToDeck1.TabIndex = 3;
            this.Button_MoveToDeck1.Text = "<<";
            this.Button_MoveToDeck1.UseVisualStyleBackColor = true;
            // 
            // button_ResetDeck1
            // 
            this.button_ResetDeck1.Location = new System.Drawing.Point(57, 369);
            this.button_ResetDeck1.Name = "button_ResetDeck1";
            this.button_ResetDeck1.Size = new System.Drawing.Size(103, 23);
            this.button_ResetDeck1.TabIndex = 4;
            this.button_ResetDeck1.Text = "Reset Deck #1";
            this.button_ResetDeck1.UseVisualStyleBackColor = true;
            // 
            // button_ShuffleDeck1
            // 
            this.button_ShuffleDeck1.Location = new System.Drawing.Point(57, 412);
            this.button_ShuffleDeck1.Name = "button_ShuffleDeck1";
            this.button_ShuffleDeck1.Size = new System.Drawing.Size(103, 23);
            this.button_ShuffleDeck1.TabIndex = 5;
            this.button_ShuffleDeck1.Text = "Shuffle Deck #1";
            this.button_ShuffleDeck1.UseVisualStyleBackColor = true;
            // 
            // button_ResetDeck2
            // 
            this.button_ResetDeck2.Location = new System.Drawing.Point(250, 369);
            this.button_ResetDeck2.Name = "button_ResetDeck2";
            this.button_ResetDeck2.Size = new System.Drawing.Size(107, 23);
            this.button_ResetDeck2.TabIndex = 6;
            this.button_ResetDeck2.Text = "Reset Deck #2";
            this.button_ResetDeck2.UseVisualStyleBackColor = true;
            // 
            // button_ShuffleDeck2
            // 
            this.button_ShuffleDeck2.Location = new System.Drawing.Point(250, 412);
            this.button_ShuffleDeck2.Name = "button_ShuffleDeck2";
            this.button_ShuffleDeck2.Size = new System.Drawing.Size(107, 23);
            this.button_ShuffleDeck2.TabIndex = 7;
            this.button_ShuffleDeck2.Text = "Shuffle Deck #2";
            this.button_ShuffleDeck2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 459);
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

