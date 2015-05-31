namespace BooksClient
{
    partial class AddBook
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.tbIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthors = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(16, 29);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(232, 20);
            this.tbTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(32, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Tytuł";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(13, 63);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(32, 13);
            this.isbn.TabIndex = 3;
            this.isbn.Text = "ISBN";
            // 
            // tbIsbn
            // 
            this.tbIsbn.Location = new System.Drawing.Point(16, 79);
            this.tbIsbn.Name = "tbIsbn";
            this.tbIsbn.Size = new System.Drawing.Size(232, 20);
            this.tbIsbn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wydawca";
            // 
            // tbPublisher
            // 
            this.tbPublisher.Location = new System.Drawing.Point(16, 127);
            this.tbPublisher.Name = "tbPublisher";
            this.tbPublisher.Size = new System.Drawing.Size(232, 20);
            this.tbPublisher.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ilość stron";
            // 
            // tbPages
            // 
            this.tbPages.Location = new System.Drawing.Point(16, 174);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(232, 20);
            this.tbPages.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rok wydania";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(16, 222);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(232, 20);
            this.tbYear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Autorzy (oddzieleni przecinkami)";
            // 
            // tbAuthors
            // 
            this.tbAuthors.Location = new System.Drawing.Point(16, 263);
            this.tbAuthors.Name = "tbAuthors";
            this.tbAuthors.Size = new System.Drawing.Size(232, 20);
            this.tbAuthors.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAuthors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublisher);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.tbIsbn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tbTitle);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.TextBox tbIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAuthors;
        private System.Windows.Forms.Button button1;
    }
}