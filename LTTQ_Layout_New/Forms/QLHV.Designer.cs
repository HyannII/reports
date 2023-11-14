using System.Drawing;

namespace LTTQ_Layout_New.Forms
{
    partial class QLHV
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
            this.MasterPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MasterPanel
            // 
            this.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterPanel.Location = new System.Drawing.Point(0, 0);
            this.MasterPanel.Name = "MasterPanel";
            this.MasterPanel.Size = new System.Drawing.Size(800, 450);
            this.MasterPanel.TabIndex = 0;
            this.MasterPanel.BackColor = Color.FromArgb(8, 8, 8);
            // 
            // QLHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MasterPanel);
            this.Name = "QLHV";
            this.Text = "QLHV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MasterPanel;
    }
}