
namespace Kiosk_addChild
{
    partial class setMenu_Menu2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setMenu_Menu2Form));
            this.TRexSet = new System.Windows.Forms.PictureBox();
            this.ChickSet = new System.Windows.Forms.PictureBox();
            this.doubleSet = new System.Windows.Forms.PictureBox();
            this.AZSet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TRexSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AZSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TRexSet
            // 
            this.TRexSet.Image = ((System.Drawing.Image)(resources.GetObject("TRexSet.Image")));
            this.TRexSet.Location = new System.Drawing.Point(232, 211);
            this.TRexSet.Name = "TRexSet";
            this.TRexSet.Size = new System.Drawing.Size(219, 202);
            this.TRexSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TRexSet.TabIndex = 2;
            this.TRexSet.TabStop = false;
            this.TRexSet.Click += new System.EventHandler(this.TRexSet_Click);
            // 
            // ChickSet
            // 
            this.ChickSet.Image = ((System.Drawing.Image)(resources.GetObject("ChickSet.Image")));
            this.ChickSet.Location = new System.Drawing.Point(6, 211);
            this.ChickSet.Name = "ChickSet";
            this.ChickSet.Size = new System.Drawing.Size(219, 202);
            this.ChickSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChickSet.TabIndex = 3;
            this.ChickSet.TabStop = false;
            this.ChickSet.Click += new System.EventHandler(this.ChickSet_Click);
            // 
            // doubleSet
            // 
            this.doubleSet.Image = ((System.Drawing.Image)(resources.GetObject("doubleSet.Image")));
            this.doubleSet.Location = new System.Drawing.Point(232, 3);
            this.doubleSet.Name = "doubleSet";
            this.doubleSet.Size = new System.Drawing.Size(219, 202);
            this.doubleSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doubleSet.TabIndex = 4;
            this.doubleSet.TabStop = false;
            this.doubleSet.Click += new System.EventHandler(this.doubleSet_Click);
            // 
            // AZSet
            // 
            this.AZSet.Image = ((System.Drawing.Image)(resources.GetObject("AZSet.Image")));
            this.AZSet.Location = new System.Drawing.Point(6, 3);
            this.AZSet.Name = "AZSet";
            this.AZSet.Size = new System.Drawing.Size(219, 202);
            this.AZSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AZSet.TabIndex = 5;
            this.AZSet.TabStop = false;
            this.AZSet.Click += new System.EventHandler(this.picAZSet_Click);
            // 
            // setMenu_Menu2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 412);
            this.Controls.Add(this.TRexSet);
            this.Controls.Add(this.ChickSet);
            this.Controls.Add(this.doubleSet);
            this.Controls.Add(this.AZSet);
            this.Name = "setMenu_Menu2Form";
            this.Text = "setMenu_Menu1Form";
            ((System.ComponentModel.ISupportInitialize)(this.TRexSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChickSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doubleSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AZSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TRexSet;
        private System.Windows.Forms.PictureBox ChickSet;
        private System.Windows.Forms.PictureBox doubleSet;
        private System.Windows.Forms.PictureBox AZSet;
    }
}