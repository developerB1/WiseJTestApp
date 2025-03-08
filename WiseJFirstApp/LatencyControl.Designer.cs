namespace WiseJFirstApp
{
    partial class LatencyControl
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

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLatency = new Wisej.Web.Label();
            this.pictureBoxIcon = new Wisej.Web.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLatency
            // 
            this.labelLatency.AutoSize = true;
            this.labelLatency.Location = new System.Drawing.Point(24, 66);
            this.labelLatency.Name = "labelLatency";
            this.labelLatency.Size = new System.Drawing.Size(75, 18);
            this.labelLatency.TabIndex = 0;
            this.labelLatency.Text = "labelLatency";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/wifi.svg";
            this.pictureBoxIcon.Location = new System.Drawing.Point(24, 13);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(51, 47);
            // 
            // LatencyControl
            // 
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelLatency);
            this.Name = "LatencyControl";
            this.Size = new System.Drawing.Size(122, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label labelLatency;
        private Wisej.Web.PictureBox pictureBoxIcon;
    }
}
