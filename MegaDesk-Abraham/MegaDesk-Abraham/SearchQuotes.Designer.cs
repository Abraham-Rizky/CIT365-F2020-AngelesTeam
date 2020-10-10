namespace MegaDesk_Abraham
{
    partial class SearchQuotes
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
            this.dgvSearchQuotes = new System.Windows.Forms.DataGridView();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quote_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_oversize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawer_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawer_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchQuote = new System.Windows.Forms.Button();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.returnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenu.Location = new System.Drawing.Point(876, 395);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(183, 43);
            this.returnToMainMenu.TabIndex = 2;
            this.returnToMainMenu.Text = "&Back to main menu";
            this.returnToMainMenu.UseVisualStyleBackColor = true;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // dgvSearchQuotes
            // 
            this.dgvSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_name,
            this.quote_date,
            this.desk_material,
            this.desk_area,
            this.material_cost,
            this.material_oversize,
            this.drawer_amount,
            this.drawer_cost,
            this.shipping_cost,
            this.total_price});
            this.dgvSearchQuotes.Location = new System.Drawing.Point(13, 12);
            this.dgvSearchQuotes.Name = "dgvSearchQuotes";
            this.dgvSearchQuotes.ReadOnly = true;
            this.dgvSearchQuotes.Size = new System.Drawing.Size(1046, 377);
            this.dgvSearchQuotes.TabIndex = 3;
            // 
            // customer_name
            // 
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.Name = "customer_name";
            // 
            // quote_date
            // 
            this.quote_date.HeaderText = "Quote Date";
            this.quote_date.Name = "quote_date";
            // 
            // desk_material
            // 
            this.desk_material.HeaderText = "Desk Material";
            this.desk_material.Name = "desk_material";
            // 
            // desk_area
            // 
            this.desk_area.HeaderText = "Desk Area";
            this.desk_area.Name = "desk_area";
            // 
            // material_cost
            // 
            this.material_cost.HeaderText = "Material Cost";
            this.material_cost.Name = "material_cost";
            // 
            // material_oversize
            // 
            this.material_oversize.HeaderText = "Oversize Cost";
            this.material_oversize.Name = "material_oversize";
            // 
            // drawer_amount
            // 
            this.drawer_amount.HeaderText = "Drawer Amount";
            this.drawer_amount.Name = "drawer_amount";
            // 
            // drawer_cost
            // 
            this.drawer_cost.HeaderText = "Drawer Cost";
            this.drawer_cost.Name = "drawer_cost";
            // 
            // shipping_cost
            // 
            this.shipping_cost.HeaderText = "Shipping Cost";
            this.shipping_cost.Name = "shipping_cost";
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            // 
            // btnSearchQuote
            // 
            this.btnSearchQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSearchQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchQuote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuote.ForeColor = System.Drawing.Color.White;
            this.btnSearchQuote.Location = new System.Drawing.Point(676, 395);
            this.btnSearchQuote.Name = "btnSearchQuote";
            this.btnSearchQuote.Size = new System.Drawing.Size(183, 43);
            this.btnSearchQuote.TabIndex = 2;
            this.btnSearchQuote.Text = "&Search Quote";
            this.btnSearchQuote.UseVisualStyleBackColor = true;
            this.btnSearchQuote.Click += new System.EventHandler(this.btnSearchQuote_Click);
            // 
            // materialBox
            // 
            this.materialBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(154, 401);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(297, 29);
            this.materialBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desktop Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.dgvSearchQuotes);
            this.Controls.Add(this.btnSearchQuote);
            this.Controls.Add(this.returnToMainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenu;
        private System.Windows.Forms.DataGridView dgvSearchQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quote_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_oversize;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawer_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawer_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.Button btnSearchQuote;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.Label label5;
    }
}