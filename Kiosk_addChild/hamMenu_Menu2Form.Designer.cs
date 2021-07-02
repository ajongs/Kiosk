
namespace Kiosk_addChild
{
    partial class hamMenu_Menu2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hamMenu_Menu2Form));
            this.AzPB = new System.Windows.Forms.PictureBox();
            this.WaguPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AzPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaguPB)).BeginInit();
            this.SuspendLayout();
            // 
            // AzPB
            // 
            this.AzPB.Image = ((System.Drawing.Image)(resources.GetObject("AzPB.Image")));
            this.AzPB.Location = new System.Drawing.Point(232, 3);
            this.AzPB.Name = "AzPB";
            this.AzPB.Size = new System.Drawing.Size(219, 202);
            this.AzPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AzPB.TabIndex = 4;
            this.AzPB.TabStop = false;
            this.AzPB.Click += new System.EventHandler(this.AzPB_Click);
            // 
            // WaguPB
            // 
            this.WaguPB.Image = ((System.Drawing.Image)(resources.GetObject("WaguPB.Image")));
            this.WaguPB.Location = new System.Drawing.Point(6, 3);
            this.WaguPB.Name = "WaguPB";
            this.WaguPB.Size = new System.Drawing.Size(219, 202);
            this.WaguPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WaguPB.TabIndex = 5;
            this.WaguPB.TabStop = false;
            this.WaguPB.Click += new System.EventHandler(this.WaguPB_Click);
            // 
            // hamMenu_Menu2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 412);
            this.Controls.Add(this.AzPB);
            this.Controls.Add(this.WaguPB);
            this.Name = "hamMenu_Menu2Form";
            this.Text = "setMenu_Menu1Form";
            ((System.ComponentModel.ISupportInitialize)(this.AzPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaguPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AzPB;
        private System.Windows.Forms.PictureBox WaguPB;
    }
}