
namespace Kiosk_addChild
{
    partial class Form1 
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPb = new System.Windows.Forms.PictureBox();
            this.MenuBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSetMenu = new System.Windows.Forms.Button();
            this.btnHbg = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.creditPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.payButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.totalBarPanel = new System.Windows.Forms.Panel();
            this.lblTPrice = new System.Windows.Forms.Label();
            this.lblTCnt = new System.Windows.Forms.Label();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).BeginInit();
            this.MenuBarPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.creditPanel.SuspendLayout();
            this.totalBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logoPb);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(521, 80);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPb
            // 
            this.logoPb.Image = ((System.Drawing.Image)(resources.GetObject("logoPb.Image")));
            this.logoPb.Location = new System.Drawing.Point(59, -28);
            this.logoPb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoPb.Name = "logoPb";
            this.logoPb.Size = new System.Drawing.Size(399, 134);
            this.logoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPb.TabIndex = 0;
            this.logoPb.TabStop = false;
            this.logoPb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoPb_MouseDown);
            // 
            // MenuBarPanel
            // 
            this.MenuBarPanel.BackColor = System.Drawing.Color.Linen;
            this.MenuBarPanel.Controls.Add(this.btnSetMenu);
            this.MenuBarPanel.Controls.Add(this.btnHbg);
            this.MenuBarPanel.Controls.Add(this.btnDrink);
            this.MenuBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBarPanel.Location = new System.Drawing.Point(0, 80);
            this.MenuBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuBarPanel.Name = "MenuBarPanel";
            this.MenuBarPanel.Size = new System.Drawing.Size(521, 51);
            this.MenuBarPanel.TabIndex = 1;
            // 
            // btnSetMenu
            // 
            this.btnSetMenu.FlatAppearance.BorderSize = 0;
            this.btnSetMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMenu.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetMenu.Location = new System.Drawing.Point(3, 4);
            this.btnSetMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetMenu.Name = "btnSetMenu";
            this.btnSetMenu.Size = new System.Drawing.Size(167, 50);
            this.btnSetMenu.TabIndex = 1;
            this.btnSetMenu.Text = "세트 메뉴";
            this.btnSetMenu.UseVisualStyleBackColor = true;
            this.btnSetMenu.Click += new System.EventHandler(this.btnSetMenu_Click);
            // 
            // btnHbg
            // 
            this.btnHbg.FlatAppearance.BorderSize = 0;
            this.btnHbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHbg.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHbg.Location = new System.Drawing.Point(176, 4);
            this.btnHbg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHbg.Name = "btnHbg";
            this.btnHbg.Size = new System.Drawing.Size(167, 50);
            this.btnHbg.TabIndex = 2;
            this.btnHbg.Text = "햄버거";
            this.btnHbg.UseVisualStyleBackColor = true;
            this.btnHbg.Click += new System.EventHandler(this.btnHbg_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.FlatAppearance.BorderSize = 0;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDrink.Location = new System.Drawing.Point(349, 4);
            this.btnDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(167, 50);
            this.btnDrink.TabIndex = 3;
            this.btnDrink.Text = "음료/커피";
            this.btnDrink.UseVisualStyleBackColor = true;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 131);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(521, 560);
            this.MenuPanel.TabIndex = 2;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.scrollPanel);
            this.bottomPanel.Controls.Add(this.creditPanel);
            this.bottomPanel.Controls.Add(this.totalBarPanel);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bottomPanel.Location = new System.Drawing.Point(0, 691);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(521, 334);
            this.bottomPanel.TabIndex = 3;
            // 
            // scrollPanel
            // 
            this.scrollPanel.Controls.Add(this.listPanel);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 48);
            this.scrollPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(521, 217);
            this.scrollPanel.TabIndex = 3;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(521, 217);
            this.listPanel.TabIndex = 0;
            this.listPanel.WrapContents = false;
            // 
            // creditPanel
            // 
            this.creditPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.creditPanel.Controls.Add(this.deleteBtn);
            this.creditPanel.Controls.Add(this.payButton);
            this.creditPanel.Controls.Add(this.btnAdmin);
            this.creditPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creditPanel.Location = new System.Drawing.Point(0, 265);
            this.creditPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creditPanel.Name = "creditPanel";
            this.creditPanel.Size = new System.Drawing.Size(521, 69);
            this.creditPanel.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AnimationHoverSpeed = 0.07F;
            this.deleteBtn.AnimationSpeed = 0.03F;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BaseColor = System.Drawing.Color.Silver;
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.CheckedBaseColor = System.Drawing.SystemColors.GrayText;
            this.deleteBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.CheckedForeColor = System.Drawing.Color.White;
            this.deleteBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.CheckedImage")));
            this.deleteBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Image = null;
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.LineColor = System.Drawing.Color.Silver;
            this.deleteBtn.Location = new System.Drawing.Point(152, 6);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnHoverLineColor = System.Drawing.Color.Silver;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 10;
            this.deleteBtn.Size = new System.Drawing.Size(168, 56);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "취소하기";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // payButton
            // 
            this.payButton.AnimationHoverSpeed = 0.07F;
            this.payButton.AnimationSpeed = 0.03F;
            this.payButton.BackColor = System.Drawing.Color.Transparent;
            this.payButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.payButton.BorderColor = System.Drawing.Color.Black;
            this.payButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.payButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.payButton.CheckedForeColor = System.Drawing.Color.White;
            this.payButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("payButton.CheckedImage")));
            this.payButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.payButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.payButton.FocusedColor = System.Drawing.Color.Empty;
            this.payButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.ForeColor = System.Drawing.Color.Black;
            this.payButton.Image = null;
            this.payButton.ImageSize = new System.Drawing.Size(20, 20);
            this.payButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.payButton.Location = new System.Drawing.Point(339, 6);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.payButton.Name = "payButton";
            this.payButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.payButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.payButton.OnHoverForeColor = System.Drawing.Color.White;
            this.payButton.OnHoverImage = null;
            this.payButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.payButton.OnPressedColor = System.Drawing.Color.Black;
            this.payButton.Radius = 10;
            this.payButton.Size = new System.Drawing.Size(168, 56);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "결제하기";
            this.payButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(1, 2);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(77, 66);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // totalBarPanel
            // 
            this.totalBarPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalBarPanel.Controls.Add(this.lblTPrice);
            this.totalBarPanel.Controls.Add(this.lblTCnt);
            this.totalBarPanel.Controls.Add(this.lblOrderList);
            this.totalBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalBarPanel.Location = new System.Drawing.Point(0, 0);
            this.totalBarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalBarPanel.Name = "totalBarPanel";
            this.totalBarPanel.Size = new System.Drawing.Size(521, 48);
            this.totalBarPanel.TabIndex = 1;
            // 
            // lblTPrice
            // 
            this.lblTPrice.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.lblTPrice.Location = new System.Drawing.Point(378, 0);
            this.lblTPrice.Name = "lblTPrice";
            this.lblTPrice.Size = new System.Drawing.Size(120, 48);
            this.lblTPrice.TabIndex = 0;
            this.lblTPrice.Text = "0";
            this.lblTPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTCnt
            // 
            this.lblTCnt.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTCnt.Location = new System.Drawing.Point(269, 0);
            this.lblTCnt.Name = "lblTCnt";
            this.lblTCnt.Size = new System.Drawing.Size(99, 48);
            this.lblTCnt.TabIndex = 0;
            this.lblTCnt.Text = "0개";
            this.lblTCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderList
            // 
            this.lblOrderList.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrderList.Location = new System.Drawing.Point(25, 0);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(170, 48);
            this.lblOrderList.TabIndex = 0;
            this.lblOrderList.Text = "총주문내역";
            this.lblOrderList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 1025);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MenuBarPanel);
            this.Controls.Add(this.logoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPb)).EndInit();
            this.MenuBarPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.scrollPanel.ResumeLayout(false);
            this.creditPanel.ResumeLayout(false);
            this.totalBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel logoPanel;
        public System.Windows.Forms.PictureBox logoPb;
        public System.Windows.Forms.FlowLayoutPanel MenuBarPanel;
        public System.Windows.Forms.Button btnSetMenu;
        public System.Windows.Forms.Button btnHbg;
        public System.Windows.Forms.Button btnDrink;
        public System.Windows.Forms.Panel MenuPanel;
        public System.Windows.Forms.Panel bottomPanel;
        public System.Windows.Forms.Panel creditPanel;
        public System.Windows.Forms.Button btnAdmin;
        public System.Windows.Forms.Panel totalBarPanel;
        public System.Windows.Forms.Label lblTPrice;
        public System.Windows.Forms.Label lblTCnt;
        public System.Windows.Forms.Label lblOrderList;
        public Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        public Guna.UI.WinForms.GunaAdvenceButton payButton;
        public System.Windows.Forms.Panel scrollPanel;
        public System.Windows.Forms.FlowLayoutPanel listPanel;
    }
}

