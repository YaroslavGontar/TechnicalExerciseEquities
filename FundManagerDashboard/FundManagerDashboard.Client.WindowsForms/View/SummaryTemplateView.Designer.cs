namespace FundManagerDashboard.Client.WindowsForms.View
{
    partial class SummaryTemplateView
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
            this.titleName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.summaryTotalNumber = new System.Windows.Forms.Label();
            this.totalStockWeight = new System.Windows.Forms.Label();
            this.totalNumber = new System.Windows.Forms.Label();
            this.totalMarketValue = new System.Windows.Forms.Label();
            this.summaryTotalStockWeight = new System.Windows.Forms.Label();
            this.summaryTotalMarketValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleName.Location = new System.Drawing.Point(8, 10);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(47, 15);
            this.titleName.TabIndex = 0;
            this.titleName.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 140);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.summaryTotalNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalStockWeight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.totalNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalMarketValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.summaryTotalStockWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.summaryTotalMarketValue, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 98);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // summaryTotalNumber
            // 
            this.summaryTotalNumber.AutoSize = true;
            this.summaryTotalNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryTotalNumber.Location = new System.Drawing.Point(3, 0);
            this.summaryTotalNumber.Name = "summaryTotalNumber";
            this.summaryTotalNumber.Size = new System.Drawing.Size(134, 32);
            this.summaryTotalNumber.TabIndex = 3;
            this.summaryTotalNumber.Text = "label1";
            this.summaryTotalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalStockWeight
            // 
            this.totalStockWeight.AutoSize = true;
            this.totalStockWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalStockWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalStockWeight.Location = new System.Drawing.Point(143, 64);
            this.totalStockWeight.Name = "totalStockWeight";
            this.totalStockWeight.Size = new System.Drawing.Size(102, 34);
            this.totalStockWeight.TabIndex = 8;
            this.totalStockWeight.Text = "label3";
            this.totalStockWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalNumber
            // 
            this.totalNumber.AutoSize = true;
            this.totalNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalNumber.Location = new System.Drawing.Point(143, 0);
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.Size = new System.Drawing.Size(102, 32);
            this.totalNumber.TabIndex = 4;
            this.totalNumber.Text = "label2";
            this.totalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalMarketValue
            // 
            this.totalMarketValue.AutoSize = true;
            this.totalMarketValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalMarketValue.Location = new System.Drawing.Point(143, 32);
            this.totalMarketValue.Name = "totalMarketValue";
            this.totalMarketValue.Size = new System.Drawing.Size(102, 32);
            this.totalMarketValue.TabIndex = 6;
            this.totalMarketValue.Text = "label2";
            this.totalMarketValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // summaryTotalStockWeight
            // 
            this.summaryTotalStockWeight.AutoSize = true;
            this.summaryTotalStockWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryTotalStockWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryTotalStockWeight.Location = new System.Drawing.Point(3, 64);
            this.summaryTotalStockWeight.Name = "summaryTotalStockWeight";
            this.summaryTotalStockWeight.Size = new System.Drawing.Size(134, 34);
            this.summaryTotalStockWeight.TabIndex = 7;
            this.summaryTotalStockWeight.Text = "label4";
            this.summaryTotalStockWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // summaryTotalMarketValue
            // 
            this.summaryTotalMarketValue.AutoSize = true;
            this.summaryTotalMarketValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryTotalMarketValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryTotalMarketValue.Location = new System.Drawing.Point(3, 32);
            this.summaryTotalMarketValue.Name = "summaryTotalMarketValue";
            this.summaryTotalMarketValue.Size = new System.Drawing.Size(134, 32);
            this.summaryTotalMarketValue.TabIndex = 5;
            this.summaryTotalMarketValue.Text = "label1";
            this.summaryTotalMarketValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.titleText);
            this.panel2.Controls.Add(this.titleName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 40);
            this.panel2.TabIndex = 2;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleText.Location = new System.Drawing.Point(61, 10);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(47, 15);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "label1";
            // 
            // SummaryTemplateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(200, 140);
            this.Name = "SummaryTemplateView";
            this.Size = new System.Drawing.Size(250, 140);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label summaryTotalNumber;
        private System.Windows.Forms.Label totalNumber;
        private System.Windows.Forms.Label totalStockWeight;
        private System.Windows.Forms.Label summaryTotalStockWeight;
        private System.Windows.Forms.Label totalMarketValue;
        private System.Windows.Forms.Label summaryTotalMarketValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
