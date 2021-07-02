
namespace Kiosk_addChild
{
    partial class UserControl1
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.CountNmeric = new Guna.UI.WinForms.GunaNumeric();
            this.lblProduct = new Guna.UI.WinForms.GunaLabel();
            this.lblPrice = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteUnitBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountNmeric
            // 
            this.CountNmeric.BaseColor = System.Drawing.Color.White;
            this.CountNmeric.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CountNmeric.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CountNmeric.ButtonForeColor = System.Drawing.Color.White;
            this.CountNmeric.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountNmeric.ForeColor = System.Drawing.Color.Black;
            this.CountNmeric.Location = new System.Drawing.Point(239, 3);
            this.CountNmeric.Maximum = ((long)(9999999));
            this.CountNmeric.Minimum = ((long)(0));
            this.CountNmeric.Name = "CountNmeric";
            this.CountNmeric.Size = new System.Drawing.Size(75, 30);
            this.CountNmeric.TabIndex = 0;
            this.CountNmeric.Text = "gunaNumeric1";
            this.CountNmeric.Value = ((long)(0));
            this.CountNmeric.ValueChanged += new System.EventHandler(this.CountNmeric_ValueChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(40, 7);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(123, 28);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "AZ버거 세트";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(330, 4);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(101, 29);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "8,500";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.deleteUnitBtn);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(432, 36);
            this.panel1.TabIndex = 3;
            // 
            // deleteUnitBtn
            // 
            this.deleteUnitBtn.AnimationHoverSpeed = 0.07F;
            this.deleteUnitBtn.AnimationSpeed = 0.03F;
            this.deleteUnitBtn.BaseColor = System.Drawing.Color.White;
            this.deleteUnitBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteUnitBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deleteUnitBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteUnitBtn.CheckedForeColor = System.Drawing.Color.White;
            this.deleteUnitBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteUnitBtn.CheckedImage")));
            this.deleteUnitBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteUnitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteUnitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteUnitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteUnitBtn.ForeColor = System.Drawing.Color.White;
            this.deleteUnitBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteUnitBtn.Image")));
            this.deleteUnitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteUnitBtn.LineColor = System.Drawing.Color.White;
            this.deleteUnitBtn.Location = new System.Drawing.Point(3, 2);
            this.deleteUnitBtn.Name = "deleteUnitBtn";
            this.deleteUnitBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.deleteUnitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteUnitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteUnitBtn.OnHoverImage = null;
            this.deleteUnitBtn.OnHoverLineColor = System.Drawing.Color.White;
            this.deleteUnitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteUnitBtn.Size = new System.Drawing.Size(40, 33);
            this.deleteUnitBtn.TabIndex = 3;
            this.deleteUnitBtn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.CountNmeric);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(432, 36);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaNumeric CountNmeric;
        private Guna.UI.WinForms.GunaLabel lblProduct;
        private Guna.UI.WinForms.GunaLabel lblPrice;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton deleteUnitBtn;
    }
}
