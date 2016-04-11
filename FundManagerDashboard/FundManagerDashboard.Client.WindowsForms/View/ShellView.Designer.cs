using ReactiveUI.Winforms;

namespace FundManagerDashboard.Client.WindowsForms.View
{
    partial class ShellView
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
            this.AddPanel = new ReactiveUI.Winforms.ViewModelControlHost();
            this.StocksList = new ReactiveUI.Winforms.ViewModelControlHost();
            this.FundSummary = new ReactiveUI.Winforms.ViewModelControlHost();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPanel
            // 
            this.AddPanel.CacheViews = false;
            this.AddPanel.DefaultContent = null;
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPanel.Location = new System.Drawing.Point(3, 3);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(95, 144);
            this.AddPanel.TabIndex = 0;
            this.AddPanel.ViewLocator = null;
            this.AddPanel.ViewModel = null;
            // 
            // StocksList
            // 
            this.StocksList.CacheViews = false;
            this.StocksList.DefaultContent = null;
            this.StocksList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StocksList.Location = new System.Drawing.Point(3, 153);
            this.StocksList.Name = "StocksList";
            this.StocksList.Size = new System.Drawing.Size(95, 231);
            this.StocksList.TabIndex = 1;
            this.StocksList.ViewLocator = null;
            this.StocksList.ViewModel = null;
            // 
            // FundSummary
            // 
            this.FundSummary.CacheViews = false;
            this.FundSummary.DefaultContent = null;
            this.FundSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FundSummary.Location = new System.Drawing.Point(110, 3);
            this.FundSummary.Name = "FundSummary";
            this.FundSummary.Size = new System.Drawing.Size(254, 387);
            this.FundSummary.TabIndex = 2;
            this.FundSummary.ViewLocator = null;
            this.FundSummary.ViewModel = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FundSummary, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 393);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.StocksList, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddPanel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(101, 387);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShellView";
            this.Size = new System.Drawing.Size(367, 393);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ViewModelControlHost AddPanel;
        private ViewModelControlHost StocksList;
        private ViewModelControlHost FundSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
