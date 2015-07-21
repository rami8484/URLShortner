namespace URLShortner
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourceURL = new System.Windows.Forms.TextBox();
            this.textBoxURLAfterShortening = new System.Windows.Forms.TextBox();
            this.buttonShortenURL = new System.Windows.Forms.Button();
            this.buttonOpenAddToDatabase = new System.Windows.Forms.Button();
            this.buttonGetSourceURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL After shortening";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSourceURL
            // 
            this.textBoxSourceURL.Location = new System.Drawing.Point(126, 10);
            this.textBoxSourceURL.Name = "textBoxSourceURL";
            this.textBoxSourceURL.Size = new System.Drawing.Size(341, 20);
            this.textBoxSourceURL.TabIndex = 2;
            // 
            // textBoxURLAfterShortening
            // 
            this.textBoxURLAfterShortening.Location = new System.Drawing.Point(126, 82);
            this.textBoxURLAfterShortening.Name = "textBoxURLAfterShortening";
            this.textBoxURLAfterShortening.Size = new System.Drawing.Size(341, 20);
            this.textBoxURLAfterShortening.TabIndex = 3;
            // 
            // buttonShortenURL
            // 
            this.buttonShortenURL.Location = new System.Drawing.Point(392, 53);
            this.buttonShortenURL.Name = "buttonShortenURL";
            this.buttonShortenURL.Size = new System.Drawing.Size(75, 23);
            this.buttonShortenURL.TabIndex = 4;
            this.buttonShortenURL.Text = "Shorten URL";
            this.buttonShortenURL.UseVisualStyleBackColor = true;
            this.buttonShortenURL.Click += new System.EventHandler(this.buttonShortenURL_Click);
            // 
            // buttonOpenAddToDatabase
            // 
            this.buttonOpenAddToDatabase.Location = new System.Drawing.Point(16, 172);
            this.buttonOpenAddToDatabase.Name = "buttonOpenAddToDatabase";
            this.buttonOpenAddToDatabase.Size = new System.Drawing.Size(164, 23);
            this.buttonOpenAddToDatabase.TabIndex = 5;
            this.buttonOpenAddToDatabase.Text = "Add words to database";
            this.buttonOpenAddToDatabase.UseVisualStyleBackColor = true;
            this.buttonOpenAddToDatabase.Click += new System.EventHandler(this.buttonOpenAddToDatabase_Click);
            // 
            // buttonGetSourceURL
            // 
            this.buttonGetSourceURL.Location = new System.Drawing.Point(392, 109);
            this.buttonGetSourceURL.Name = "buttonGetSourceURL";
            this.buttonGetSourceURL.Size = new System.Drawing.Size(102, 23);
            this.buttonGetSourceURL.TabIndex = 6;
            this.buttonGetSourceURL.Text = "Get source URL";
            this.buttonGetSourceURL.UseVisualStyleBackColor = true;
            this.buttonGetSourceURL.Click += new System.EventHandler(this.buttonGetSourceURL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 263);
            this.Controls.Add(this.buttonGetSourceURL);
            this.Controls.Add(this.buttonOpenAddToDatabase);
            this.Controls.Add(this.buttonShortenURL);
            this.Controls.Add(this.textBoxURLAfterShortening);
            this.Controls.Add(this.textBoxSourceURL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSourceURL;
        private System.Windows.Forms.TextBox textBoxURLAfterShortening;
        private System.Windows.Forms.Button buttonShortenURL;
        private System.Windows.Forms.Button buttonOpenAddToDatabase;
        private System.Windows.Forms.Button buttonGetSourceURL;
    }
}

