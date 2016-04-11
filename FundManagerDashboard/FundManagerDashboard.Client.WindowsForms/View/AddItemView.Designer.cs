namespace FundManagerDashboard.Client.WindowsForms.View
{
    partial class AddItemView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelStockType = new System.Windows.Forms.Label();
            this.PanelStockPrice = new System.Windows.Forms.Label();
            this.PanelStockQuantity = new System.Windows.Forms.Label();
            this.stockType = new System.Windows.Forms.ComboBox();
            this.stockQuantity = new System.Windows.Forms.TextBox();
            this.stockPrice = new System.Windows.Forms.TextBox();
            this.PanelAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.PanelStockType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelStockPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanelStockQuantity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockQuantity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.stockPrice, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 80);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelStockType
            // 
            this.PanelStockType.AutoSize = true;
            this.PanelStockType.Location = new System.Drawing.Point(3, 0);
            this.PanelStockType.Name = "PanelStockType";
            this.PanelStockType.Size = new System.Drawing.Size(35, 13);
            this.PanelStockType.TabIndex = 0;
            this.PanelStockType.Text = "label1";
            // 
            // PanelStockPrice
            // 
            this.PanelStockPrice.AutoSize = true;
            this.PanelStockPrice.Location = new System.Drawing.Point(3, 25);
            this.PanelStockPrice.Name = "PanelStockPrice";
            this.PanelStockPrice.Size = new System.Drawing.Size(35, 13);
            this.PanelStockPrice.TabIndex = 1;
            this.PanelStockPrice.Text = "label2";
            // 
            // PanelStockQuantity
            // 
            this.PanelStockQuantity.AutoSize = true;
            this.PanelStockQuantity.Location = new System.Drawing.Point(3, 50);
            this.PanelStockQuantity.Name = "PanelStockQuantity";
            this.PanelStockQuantity.Size = new System.Drawing.Size(35, 13);
            this.PanelStockQuantity.TabIndex = 2;
            this.PanelStockQuantity.Text = "label3";
            // 
            // stockType
            // 
            this.stockType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stockType.FormattingEnabled = true;
            this.stockType.Location = new System.Drawing.Point(103, 3);
            this.stockType.Name = "stockType";
            this.stockType.Size = new System.Drawing.Size(317, 21);
            this.stockType.TabIndex = 3;
            // 
            // stockQuantity
            // 
            this.stockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockQuantity.Location = new System.Drawing.Point(103, 53);
            this.stockQuantity.Name = "stockQuantity";
            this.stockQuantity.Size = new System.Drawing.Size(317, 20);
            this.stockQuantity.TabIndex = 5;
            // 
            // stockPrice
            // 
            this.stockPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockPrice.Location = new System.Drawing.Point(103, 28);
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.Size = new System.Drawing.Size(317, 20);
            this.stockPrice.TabIndex = 6;
            // 
            // PanelAdd
            // 
            this.PanelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAdd.Location = new System.Drawing.Point(350, 123);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(75, 23);
            this.PanelAdd.TabIndex = 6;
            this.PanelAdd.Text = "button1";
            this.PanelAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PanelHeader, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PanelAdd, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 150);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // PanelHeader
            // 
            this.PanelHeader.AutoEllipsis = true;
            this.PanelHeader.AutoSize = true;
            this.PanelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanelHeader.Location = new System.Drawing.Point(6, 1);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(47, 15);
            this.PanelHeader.TabIndex = 0;
            this.PanelHeader.Text = "label1";
            // 
            // AddItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "AddItemView";
            this.Size = new System.Drawing.Size(429, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PanelAdd;
        private System.Windows.Forms.ComboBox stockType;
        private System.Windows.Forms.Label PanelStockQuantity;
        private System.Windows.Forms.Label PanelStockPrice;
        private System.Windows.Forms.Label PanelStockType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label PanelHeader;
        private System.Windows.Forms.TextBox stockQuantity;
        private System.Windows.Forms.TextBox stockPrice;
    }
}
