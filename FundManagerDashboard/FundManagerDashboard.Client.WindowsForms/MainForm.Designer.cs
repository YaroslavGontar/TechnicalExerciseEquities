using ReactiveUI.Winforms;

namespace FundManagerDashboard.Client.WindowsForms
{
    partial class MainForm
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
            this.controlHost = new ReactiveUI.Winforms.RoutedControlHost();
            this.SuspendLayout();
            // 
            // controlHost
            // 
            this.controlHost.DefaultContent = null;
            this.controlHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHost.Location = new System.Drawing.Point(0, 0);
            this.controlHost.Name = "controlHost";
            this.controlHost.Router = null;
            this.controlHost.Size = new System.Drawing.Size(809, 511);
            this.controlHost.TabIndex = 0;
            this.controlHost.ViewLocator = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.controlHost);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RoutedControlHost controlHost;
    }
}

