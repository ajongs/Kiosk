
namespace Kiosk_addChild
{
    partial class DrinkMenu_MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkMenu_MenuForm));
            this.CokePB = new System.Windows.Forms.PictureBox();
            this.SodaPB = new System.Windows.Forms.PictureBox();
            this.IceAmericanoPB = new System.Windows.Forms.PictureBox();
            this.IceteePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CokePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IceAmericanoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IceteePB)).BeginInit();
            this.SuspendLayout();
            // 
            // CokePB
            // 
            this.CokePB.Image = ((System.Drawing.Image)(resources.GetObject("CokePB.Image")));
            this.CokePB.Location = new System.Drawing.Point(265, 264);
            this.CokePB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CokePB.Name = "CokePB";
            this.CokePB.Size = new System.Drawing.Size(250, 252);
            this.CokePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CokePB.TabIndex = 6;
            this.CokePB.TabStop = false;
            this.CokePB.Click += new System.EventHandler(this.CokePB_Click);
            // 
            // SodaPB
            // 
            this.SodaPB.Image = ((System.Drawing.Image)(resources.GetObject("SodaPB.Image")));
            this.SodaPB.Location = new System.Drawing.Point(7, 264);
            this.SodaPB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SodaPB.Name = "SodaPB";
            this.SodaPB.Size = new System.Drawing.Size(250, 252);
            this.SodaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SodaPB.TabIndex = 7;
            this.SodaPB.TabStop = false;
            this.SodaPB.Click += new System.EventHandler(this.SodaPB_Click);
            // 
            // IceAmericanoPB
            // 
            this.IceAmericanoPB.Image = ((System.Drawing.Image)(resources.GetObject("IceAmericanoPB.Image")));
            this.IceAmericanoPB.Location = new System.Drawing.Point(265, 4);
            this.IceAmericanoPB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IceAmericanoPB.Name = "IceAmericanoPB";
            this.IceAmericanoPB.Size = new System.Drawing.Size(250, 252);
            this.IceAmericanoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IceAmericanoPB.TabIndex = 8;
            this.IceAmericanoPB.TabStop = false;
            this.IceAmericanoPB.Click += new System.EventHandler(this.IceAmericanoPB_Click);
            // 
            // IceteePB
            // 
            this.IceteePB.Image = ((System.Drawing.Image)(resources.GetObject("IceteePB.Image")));
            this.IceteePB.Location = new System.Drawing.Point(7, 4);
            this.IceteePB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IceteePB.Name = "IceteePB";
            this.IceteePB.Size = new System.Drawing.Size(250, 252);
            this.IceteePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IceteePB.TabIndex = 9;
            this.IceteePB.TabStop = false;
            this.IceteePB.Click += new System.EventHandler(this.IceteePB_Click);
            // 
            // DrinkMenu_MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 515);
            this.Controls.Add(this.CokePB);
            this.Controls.Add(this.SodaPB);
            this.Controls.Add(this.IceAmericanoPB);
            this.Controls.Add(this.IceteePB);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DrinkMenu_MenuForm";
            this.Text = "DrinkMenu_MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.CokePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SodaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IceAmericanoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IceteePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CokePB;
        private System.Windows.Forms.PictureBox SodaPB;
        private System.Windows.Forms.PictureBox IceAmericanoPB;
        private System.Windows.Forms.PictureBox IceteePB;
    }
}