
namespace Kiosk_addChild
{
    partial class DrinkMenuParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkMenuParentForm));
            this.DirnkArrowPanel = new System.Windows.Forms.Panel();
            this.chosePanel = new System.Windows.Forms.Panel();
            this.btnHamLeft = new System.Windows.Forms.Button();
            this.btnHamRight = new System.Windows.Forms.Button();
            this.DirnkArrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirnkArrowPanel
            // 
            this.DirnkArrowPanel.Controls.Add(this.btnHamRight);
            this.DirnkArrowPanel.Controls.Add(this.btnHamLeft);
            this.DirnkArrowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DirnkArrowPanel.Location = new System.Drawing.Point(0, 412);
            this.DirnkArrowPanel.Name = "DirnkArrowPanel";
            this.DirnkArrowPanel.Size = new System.Drawing.Size(456, 36);
            this.DirnkArrowPanel.TabIndex = 12;
            // 
            // chosePanel
            // 
            this.chosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chosePanel.Location = new System.Drawing.Point(0, 0);
            this.chosePanel.Name = "chosePanel";
            this.chosePanel.Size = new System.Drawing.Size(456, 412);
            this.chosePanel.TabIndex = 13;
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
            // 
            // DrinkMenuParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 448);
            this.Controls.Add(this.chosePanel);
            this.Controls.Add(this.DirnkArrowPanel);
            this.Name = "DrinkMenuParentForm";
            this.Text = "DrinkMenuParentForm";
            this.Load += new System.EventHandler(this.DrinkMenuParentForm_Load);
            this.DirnkArrowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DirnkArrowPanel;
        private System.Windows.Forms.Panel chosePanel;
        private System.Windows.Forms.Button btnHamRight;
        private System.Windows.Forms.Button btnHamLeft;
    }
}