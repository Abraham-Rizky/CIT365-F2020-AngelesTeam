namespace MegaDesk_Abraham
{
    partial class AddQuote
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
            this.returnToMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.currentDate = new System.Windows.Forms.Label();
            this.shippingBox = new System.Windows.Forms.ListBox();
            this.drawerBox = new System.Windows.Forms.ComboBox();
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.returnToMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.returnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenu.Location = new System.Drawing.Point(462, 470);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(155, 43);
            this.returnToMainMenu.TabIndex = 8;
            this.returnToMainMenu.Text = "&Back to main menu";
            this.returnToMainMenu.UseVisualStyleBackColor = false;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desk Width (in.)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(54, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desk Depth (in.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(54, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(54, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Desktop Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(54, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Shipping method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(54, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Today\'s Date";
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(225, 133);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(297, 33);
            this.widthBox.TabIndex = 2;
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            // 
            // depthBox
            // 
            this.depthBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBox.Location = new System.Drawing.Point(225, 173);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(297, 33);
            this.depthBox.TabIndex = 3;
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthBox_KeyPress);
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthBox_Validating);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameBox.Location = new System.Drawing.Point(225, 93);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(297, 33);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameBox_Validating);
            // 
            // materialBox
            // 
            this.materialBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Items.AddRange(new object[] {
            "Select one item below",
            "Oak",
            "Laminate",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialBox.Location = new System.Drawing.Point(225, 251);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(297, 29);
            this.materialBox.TabIndex = 5;
            this.materialBox.Validating += new System.ComponentModel.CancelEventHandler(this.materialBox_Validating);
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentDate.Location = new System.Drawing.Point(221, 398);
            this.currentDate.MaximumSize = new System.Drawing.Size(300, 0);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(108, 21);
            this.currentDate.TabIndex = 18;
            this.currentDate.Text = "dd-mm-yyyy";
            // 
            // shippingBox
            // 
            this.shippingBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBox.FormattingEnabled = true;
            this.shippingBox.ItemHeight = 21;
            this.shippingBox.Items.AddRange(new object[] {
            "Normal - 14 days",
            "3 Day",
            "5 Day",
            "7 Day"});
            this.shippingBox.Location = new System.Drawing.Point(225, 293);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(144, 88);
            this.shippingBox.TabIndex = 6;
            this.shippingBox.Validating += new System.ComponentModel.CancelEventHandler(this.shippingBox_Validating);
            // 
            // drawerBox
            // 
            this.drawerBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerBox.FormattingEnabled = true;
            this.drawerBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerBox.Location = new System.Drawing.Point(225, 213);
            this.drawerBox.Name = "drawerBox";
            this.drawerBox.Size = new System.Drawing.Size(297, 29);
            this.drawerBox.TabIndex = 4;
            this.drawerBox.Validating += new System.ComponentModel.CancelEventHandler(this.drawerBox_Validating);
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewQuoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.viewQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuoteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteButton.ForeColor = System.Drawing.Color.White;
            this.viewQuoteButton.Location = new System.Drawing.Point(462, 410);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(155, 43);
            this.viewQuoteButton.TabIndex = 7;
            this.viewQuoteButton.Text = "&Submit Quote";
            this.viewQuoteButton.UseVisualStyleBackColor = false;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewQuoteButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.drawerBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.shippingBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.currentDate);
            this.groupBox1.Controls.Add(this.errorLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.materialBox);
            this.groupBox1.Controls.Add(this.customerNameBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.widthBox);
            this.groupBox1.Controls.Add(this.depthBox);
            this.groupBox1.Controls.Add(this.returnToMainMenu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(33, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 529);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please fill in the form below:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(54, 42);
            this.errorLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(14, 21);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = " ";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(708, 593);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.ListBox shippingBox;
        private System.Windows.Forms.ComboBox drawerBox;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorLabel;
    }
}