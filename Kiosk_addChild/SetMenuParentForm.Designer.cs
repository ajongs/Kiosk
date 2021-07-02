
namespace Kiosk_addChild
{
    partial class SetMenuParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMenuParentForm));
            this.SetArrowPanel = new System.Windows.Forms.Panel();
            this.btnSetRight = new System.Windows.Forms.Button();
            this.btnSetLeft = new System.Windows.Forms.Button();
            this.chosePanel = new System.Windows.Forms.Panel();
            this.SetArrowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetArrowPanel
            // 
            this.SetArrowPanel.Controls.Add(this.btnSetRight);
            this.SetArrowPanel.Controls.Add(this.btnSetLeft);
            this.SetArrowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetArrowPanel.Location = new System.Drawing.Point(0, 412);
            this.SetArrowPanel.Name = "SetArrowPanel";
            this.SetArrowPanel.Size = new System.Drawing.Size(456, 36);
            this.SetArrowPanel.TabIndex = 12;
            // 
            // btnSetRight
            // 
            this.btnSetRight.FlatAppearance.BorderSize = 0;
            this.btnSetRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetRight.Image = ((System.Drawing.Image)(resources.GetObject("btnSetRight.Image")));
            this.btnSetRight.Location = new System.Drawing.Point(300, 2);
            this.btnSetRight.Name = "btnSetRight";
            this.btnSetRight.Size = new System.Drawing.Size(156, 31);
            this.btnSetRight.TabIndex = 3;
            this.btnSetRight.UseVisualStyleBackColor = true;
            this.btnSetRight.Click += new System.EventHandler(this.btnSetRight_Click);
            // 
            // btnSetLeft
            // 
            this.btnSetLeft.FlatAppearance.BorderSize = 0;
            this.btnSetLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnSetLeft.Image")));
            this.btnSetLeft.Location = new System.Drawing.Point(0, 2);
            this.btnSetLeft.Name = "btnSetLeft";
            this.btnSetLeft.Size = new System.Drawing.Size(156, 31);
            this.btnSetLeft.TabIndex = 2;
            this.btnSetLeft.UseVisualStyleBackColor = true;
            this.btnSetLeft.Click += new System.EventHandler(this.btnSetLeft_Click);
            // 
            // chosePanel
            // 
            this.chosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chosePanel.Location = new System.Drawing.Point(0, 0);
            this.chosePanel.Name = "chosePanel";
            this.chosePanel.Size = new System.Drawing.Size(456, 412);
            this.chosePanel.TabIndex = 13;
            // 
            // SetMenuParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 448);
            this.Controls.Add(this.chosePanel);
            this.Controls.Add(this.SetArrowPanel);
            this.Name = "SetMenuParentForm";
            this.Text = "SetMenuParentForm";
            this.Load += new System.EventHandler(this.SetMenuParentForm_Load);
            this.SetArrowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SetArrowPanel;
        private System.Windows.Forms.Button btnSetRight;
        private System.Windows.Forms.Button btnSetLeft;
        private System.Windows.Forms.Panel chosePanel;
    }
}