
namespace Kiosk_addChild
{
    partial class Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.pwBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "관리자만 접근할 수 있는 화면입니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(75, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호를 입력해주세요";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(78, 131);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 21);
            this.tb.TabIndex = 2;
            // 
            // pwBtn
            // 
            this.pwBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pwBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.pwBtn.Location = new System.Drawing.Point(195, 129);
            this.pwBtn.Name = "pwBtn";
            this.pwBtn.Size = new System.Drawing.Size(53, 23);
            this.pwBtn.TabIndex = 3;
            this.pwBtn.Text = "확인";
            this.pwBtn.UseVisualStyleBackColor = true;
            this.pwBtn.Click += new System.EventHandler(this.pwBtn_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 194);
            this.Controls.Add(this.pwBtn);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Manager";
            this.Text = "관리자";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button pwBtn;
    }
}