
namespace Kiosk_addChild
{
    partial class HamMenuParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamMenuParentForm));
            this.HamArrowPanel = new System.Windows.Forms.Panel();
            this.btnHamRight = new System.Windows.Forms.Button();
            this.btnHamLeft = new System.Windows.Forms.Button();
            this.chosePanel = new System.Windows.Forms.Panel();
            this.HamArrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HamArrowPanel
            // 
            this.HamArrowPanel.Controls.Add(this.btnHamRight);
            this.HamArrowPanel.Controls.Add(this.btnHamLeft);
            this.HamArrowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HamArrowPanel.Location = new System.Drawing.Point(0, 412);
            this.HamArrowPanel.Name = "HamArrowPanel";
            this.HamArrowPanel.Size = new System.Drawing.Size(456, 36);
            this.HamArrowPanel.TabIndex = 11;
            // 
            // btnHamRight
            // 
            this.btnHamRight.FlatAppearance.BorderSize = 0;
            this.btnHamRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamRight.Image = ((System.Drawing.Image)(resources.GetObject("btnHamRight.Image")));
            this.btnHamRight.Location = new System.Drawing.Point(300, 2);
            this.btnHamRight.Name = "btnHamRight";
            this.btnHamRight.Size = new System.Drawing.Size(156, 31);
            this.btnHamRight.TabIndex = 3;
            this.btnHamRight.UseVisualStyleBackColor = true;
            this.btnHamRight.Click += new System.EventHandler(this.btnHamRight_Click);
            // 
            // btnHamLeft
            // 
            this.btnHamLeft.FlatAppearance.BorderSize = 0;
            this.btnHamLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHamLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnHamLeft.Image")));
            this.btnHamLeft.Location = new System.Drawing.Point(0, 2);
            this.btnHamLeft.Name = "btnHamLeft";
            this.btnHamLeft.Size = new System.Drawing.Size(156, 31);
            this.btnHamLeft.TabIndex = 2;
            this.btnHamLeft.UseVisualStyleBackColor = true;
            this.btnHamLeft.Click += new System.EventHandler(this.btnHamLeft_Click);
            // 
            // chosePanel
            // 
            this.chosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chosePanel.Location = new System.Drawing.Point(0, 0);
            this.chosePanel.Name = "chosePanel";
            this.chosePanel.Size = new System.Drawing.Size(456, 412);
            this.chosePanel.TabIndex = 12;
            // 
            // HamMenuParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 448);
            this.Controls.Add(this.chosePanel);
            this.Controls.Add(this.HamArrowPanel);
            this.Name = "HamMenuParentForm";
            this.Text = "SetMenuParentForm";
            this.Load += new System.EventHandler(this.SetMenuParentForm_Load);
            this.HamArrowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HamArrowPanel;
        private System.Windows.Forms.Button btnHamRight;
        private System.Windows.Forms.Button btnHamLeft;
        private System.Windows.Forms.Panel chosePanel;
    }
}