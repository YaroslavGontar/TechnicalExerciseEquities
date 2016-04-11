namespace FundManagerDashboard.Client.WindowsForms.View
{
    partial class StockListView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainStockGrid = new BrightIdeasSoftware.DataListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainStockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MainStockGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 1;
            // 
            // MainStockGrid
            // 
            this.MainStockGrid.AllColumns.Add(this.olvColumn1);
            this.MainStockGrid.AllColumns.Add(this.olvColumn2);
            this.MainStockGrid.AllColumns.Add(this.olvColumn3);
            this.MainStockGrid.AllColumns.Add(this.olvColumn4);
            this.MainStockGrid.AllColumns.Add(this.olvColumn5);
            this.MainStockGrid.AllColumns.Add(this.olvColumn6);
            this.MainStockGrid.AllColumns.Add(this.olvColumn7);
            this.MainStockGrid.AlternateRowBackColor = System.Drawing.Color.AliceBlue;
            this.MainStockGrid.AutoGenerateColumns = false;
            this.MainStockGrid.CellEditUseWholeCell = false;
            this.MainStockGrid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
            this.MainStockGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainStockGrid.DataSource = null;
            this.MainStockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainStockGrid.FullRowSelect = true;
            this.MainStockGrid.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.MainStockGrid.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.MainStockGrid.Location = new System.Drawing.Point(0, 0);
            this.MainStockGrid.Name = "MainStockGrid";
            this.MainStockGrid.Size = new System.Drawing.Size(148, 148);
            this.MainStockGrid.TabIndex = 0;
            this.MainStockGrid.UseAlternatingBackColors = true;
            this.MainStockGrid.UseCellFormatEvents = true;
            this.MainStockGrid.UseCompatibleStateImageBehavior = false;
            this.MainStockGrid.UseNotifyPropertyChanged = true;
            this.MainStockGrid.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Type";
            this.olvColumn1.FillsFreeSpace = true;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Name";
            this.olvColumn2.FillsFreeSpace = true;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Price";
            this.olvColumn3.AspectToStringFormat = "{0:C}";
            this.olvColumn3.FillsFreeSpace = true;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Quantity";
            this.olvColumn4.FillsFreeSpace = true;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "MarketValue";
            this.olvColumn5.AspectToStringFormat = "{0:C}";
            this.olvColumn5.FillsFreeSpace = true;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "TransactionCost";
            this.olvColumn6.AspectToStringFormat = "{0:C}";
            this.olvColumn6.FillsFreeSpace = true;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "StockWeight";
            this.olvColumn7.AspectToStringFormat = "{0:P}";
            this.olvColumn7.FillsFreeSpace = true;
            // 
            // StockListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "StockListView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainStockGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private BrightIdeasSoftware.DataListView MainStockGrid;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
    }
}
