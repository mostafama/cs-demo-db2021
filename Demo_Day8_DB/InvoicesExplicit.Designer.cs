
namespace Demo_Day8_DB
{
    partial class InvoicesExplicit
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
            this.invoicesDGrid = new System.Windows.Forms.DataGridView();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDetailsDGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesDGrid
            // 
            this.invoicesDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoicesDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.CustomerID,
            this.InvoiceDate,
            this.ProductTotal,
            this.Shipping,
            this.SalesTax,
            this.InvoiceTotal});
            this.invoicesDGrid.Location = new System.Drawing.Point(12, 35);
            this.invoicesDGrid.MultiSelect = false;
            this.invoicesDGrid.Name = "invoicesDGrid";
            this.invoicesDGrid.RowTemplate.Height = 27;
            this.invoicesDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicesDGrid.Size = new System.Drawing.Size(776, 184);
            this.invoicesDGrid.TabIndex = 0;
            // 
            // InvoiceID
            // 
            this.InvoiceID.DataPropertyName = "InvoiceID";
            this.InvoiceID.HeaderText = "ID";
            this.InvoiceID.Name = "InvoiceID";
            this.InvoiceID.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.DataPropertyName = "InvoiceDate";
            this.InvoiceDate.HeaderText = "Date";
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // ProductTotal
            // 
            this.ProductTotal.DataPropertyName = "ProductTotal";
            this.ProductTotal.HeaderText = "Sub Total";
            this.ProductTotal.Name = "ProductTotal";
            // 
            // Shipping
            // 
            this.Shipping.DataPropertyName = "Shipping";
            this.Shipping.HeaderText = "Shipping";
            this.Shipping.Name = "Shipping";
            // 
            // SalesTax
            // 
            this.SalesTax.DataPropertyName = "SalesTax";
            this.SalesTax.HeaderText = "Tax";
            this.SalesTax.Name = "SalesTax";
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.DataPropertyName = "InvoiceTotal";
            this.InvoiceTotal.HeaderText = "Total";
            this.InvoiceTotal.Name = "InvoiceTotal";
            // 
            // invoiceDetailsDGrid
            // 
            this.invoiceDetailsDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceDetailsDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailsDGrid.Location = new System.Drawing.Point(12, 256);
            this.invoiceDetailsDGrid.Name = "invoiceDetailsDGrid";
            this.invoiceDetailsDGrid.ReadOnly = true;
            this.invoiceDetailsDGrid.RowTemplate.Height = 27;
            this.invoiceDetailsDGrid.Size = new System.Drawing.Size(776, 182);
            this.invoiceDetailsDGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoices";
            // 
            // InvoicesExplicit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoiceDetailsDGrid);
            this.Controls.Add(this.invoicesDGrid);
            this.Name = "InvoicesExplicit";
            this.Text = "Invoices Explicit";
            this.Load += new System.EventHandler(this.InvoicesExplicit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceTotal;
        private System.Windows.Forms.DataGridView invoiceDetailsDGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}