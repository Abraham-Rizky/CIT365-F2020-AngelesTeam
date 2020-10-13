namespace MegaDesk_Abraham
{
    partial class ViewAllQuotes
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
            this.dgvAllQuotes = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMainMenu
            // 
            this.returnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenu.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenu.Location = new System.Drawing.Point(875, 395);
            this.returnToMainMenu.Name = "returnToMainMenu";
            this.returnToMainMenu.Size = new System.Drawing.Size(183, 43);
            this.returnToMainMenu.TabIndex = 1;
            this.returnToMainMenu.Text = "&Back to main menu";
            this.returnToMainMenu.UseVisualStyleBackColor = true;
            this.returnToMainMenu.Click += new System.EventHandler(this.returnToMainMenu_Click);
            // 
            // dgvAllQuotes
            // 
            this.dgvAllQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvAllQuotes.Location = new System.Drawing.Point(12, 12);
            this.dgvAllQuotes.Name = "dgvAllQuotes";
            this.dgvAllQuotes.RowHeadersWidth = 92;
            this.dgvAllQuotes.Size = new System.Drawing.Size(1046, 377);
            this.dgvAllQuotes.TabIndex = 2;
            // 
            // customer_name
            // 
            this.customer_name.HeaderText = "Customer Name";
            this.customer_name.MinimumWidth = 11;
            this.customer_name.Name = "customer_name";
            this.customer_name.Width = 225;
            // 
            // quote_date
            // 
            this.quote_date.HeaderText = "Quote Date";
            this.quote_date.MinimumWidth = 11;
            this.quote_date.Name = "quote_date";
            this.quote_date.Width = 225;
            // 
            // desk_material
            // 
            this.desk_material.HeaderText = "Desk Material";
            this.desk_material.MinimumWidth = 11;
            this.desk_material.Name = "desk_material";
            this.desk_material.Width = 225;
            // 
            // desk_area
            // 
            this.desk_area.HeaderText = "Desk Area";
            this.desk_area.MinimumWidth = 11;
            this.desk_area.Name = "desk_area";
            this.desk_area.Width = 225;
            // 
            // material_cost
            // 
            this.material_cost.HeaderText = "Material Cost";
            this.material_cost.MinimumWidth = 11;
            this.material_cost.Name = "material_cost";
            this.material_cost.Width = 225;
            // 
            // material_oversize
            // 
            this.material_oversize.HeaderText = "Oversize Cost";
            this.material_oversize.MinimumWidth = 11;
            this.material_oversize.Name = "material_oversize";
            this.material_oversize.Width = 225;
            // 
            // drawer_amount
            // 
            this.drawer_amount.HeaderText = "Drawer Amount";
            this.drawer_amount.MinimumWidth = 11;
            this.drawer_amount.Name = "drawer_amount";
            this.drawer_amount.Width = 225;
            // 
            // drawer_cost
            // 
            this.drawer_cost.HeaderText = "Drawer Cost";
            this.drawer_cost.MinimumWidth = 11;
            this.drawer_cost.Name = "drawer_cost";
            this.drawer_cost.Width = 225;
            // 
            // shipping_cost
            // 
            this.shipping_cost.HeaderText = "Shipping Cost";
            this.shipping_cost.MinimumWidth = 11;
            this.shipping_cost.Name = "shipping_cost";
            this.shipping_cost.Width = 225;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total Price";
            this.total_price.MinimumWidth = 11;
            this.total_price.Name = "total_price";
            this.total_price.Width = 225;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.dgvAllQuotes);
            this.Controls.Add(this.returnToMainMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnToMainMenu;
        private System.Windows.Forms.DataGridView dgvAllQuotes;
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
    }
}