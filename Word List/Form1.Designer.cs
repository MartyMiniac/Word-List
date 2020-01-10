namespace Word_List
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
            this.addWordButton = new System.Windows.Forms.Button();
            this.addWordTB = new System.Windows.Forms.TextBox();
            this.searchWordTB = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.wordList = new System.Windows.Forms.ListView();
            this.addMeaningTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(535, 339);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(112, 54);
            this.addWordButton.TabIndex = 0;
            this.addWordButton.Text = "Add Word";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // addWordTB
            // 
            this.addWordTB.Location = new System.Drawing.Point(152, 331);
            this.addWordTB.Name = "addWordTB";
            this.addWordTB.Size = new System.Drawing.Size(377, 22);
            this.addWordTB.TabIndex = 1;
            this.addWordTB.TextChanged += new System.EventHandler(this.addWordTB_TextChanged);
            // 
            // searchWordTB
            // 
            this.searchWordTB.Location = new System.Drawing.Point(31, 18);
            this.searchWordTB.Name = "searchWordTB";
            this.searchWordTB.Size = new System.Drawing.Size(303, 22);
            this.searchWordTB.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(340, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 39);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wordList
            // 
            this.wordList.Location = new System.Drawing.Point(31, 55);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(772, 270);
            this.wordList.TabIndex = 4;
            this.wordList.UseCompatibleStateImageBehavior = false;
            this.wordList.View = System.Windows.Forms.View.List;
            this.wordList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // addMeaningTB
            // 
            this.addMeaningTB.Location = new System.Drawing.Point(152, 359);
            this.addMeaningTB.Multiline = true;
            this.addMeaningTB.Name = "addMeaningTB";
            this.addMeaningTB.Size = new System.Drawing.Size(377, 57);
            this.addMeaningTB.TabIndex = 5;
            this.addMeaningTB.TextChanged += new System.EventHandler(this.addMeaningTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meaning of";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // wordDisplay
            // 
            this.wordDisplay.AutoSize = true;
            this.wordDisplay.Location = new System.Drawing.Point(28, 376);
            this.wordDisplay.Name = "wordDisplay";
            this.wordDisplay.Size = new System.Drawing.Size(23, 17);
            this.wordDisplay.TabIndex = 8;
            this.wordDisplay.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 428);
            this.Controls.Add(this.wordDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMeaningTB);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchWordTB);
            this.Controls.Add(this.addWordTB);
            this.Controls.Add(this.addWordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.TextBox addWordTB;
        private System.Windows.Forms.TextBox searchWordTB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView wordList;
        private System.Windows.Forms.TextBox addMeaningTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordDisplay;
    }
}

