namespace MegaDesk_Abraham
{
    partial class MainMenu
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
            this.addNewQuote = new System.Windows.Forms.Button();
            this.viewQuote = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deskPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewQuote
            // 
            this.addNewQuote.FlatAppearance.BorderSize = 2;
            this.addNewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.addNewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuote.ForeColor = System.Drawing.Color.White;
            this.addNewQuote.Location = new System.Drawing.Point(34, 27);
            this.addNewQuote.Name = "addNewQuote";
            this.addNewQuote.Size = new System.Drawing.Size(148, 47);
            this.addNewQuote.TabIndex = 0;
            this.addNewQuote.Text = "&Add New Quote";
            this.addNewQuote.UseVisualStyleBackColor = true;
            this.addNewQuote.Click += new System.EventHandler(this.addNewQuote_Click);
            // 
            // viewQuote
            // 
            this.viewQuote.FlatAppearance.BorderSize = 2;
            this.viewQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.viewQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuote.ForeColor = System.Drawing.Color.White;
            this.viewQuote.Location = new System.Drawing.Point(34, 81);
            this.viewQuote.Name = "viewQuote";
            this.viewQuote.Size = new System.Drawing.Size(148, 47);
            this.viewQuote.TabIndex = 1;
            this.viewQuote.Text = "&View Quote";
            this.viewQuote.UseVisualStyleBackColor = true;
            this.viewQuote.Click += new System.EventHandler(this.viewQuote_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.FlatAppearance.BorderSize = 2;
            this.searchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.searchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.Color.White;
            this.searchQuotes.Location = new System.Drawing.Point(34, 134);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(148, 47);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "&Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(34, 189);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deskPicture
            // 
            this.deskPicture.Image = global::MegaDesk_Abraham.Properties.Resources.desk_small;
            this.deskPicture.Location = new System.Drawing.Point(242, 64);
            this.deskPicture.Name = "deskPicture";
            this.deskPicture.Size = new System.Drawing.Size(215, 172);
            this.deskPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deskPicture.TabIndex = 4;
            this.deskPicture.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(494, 270);
            this.Controls.Add(this.deskPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuote);
            this.Controls.Add(this.addNewQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.deskPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewQuote;
        private System.Windows.Forms.Button viewQuote;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox deskPicture;
    }
}

