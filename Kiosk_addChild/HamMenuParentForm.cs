using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_addChild
{
    public partial class HamMenuParentForm : Form
    {
        
        // private Button currentButton;
        private Form activeForm = null;
        private Form1 f1;
        public HamMenuParentForm(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
        }
        private void openMenuForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            chosePanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnHamRight_Click(object sender, EventArgs e)
        {
            openMenuForm(new hamMenu_Menu2Form(f1));
        }

        private void btnHamLeft_Click(object sender, EventArgs e)
        {
            openMenuForm(new hamMenu_Menu1Form(f1));
        }

        private void SetMenuParentForm_Load(object sender, EventArgs e)
        {
            openMenuForm(new hamMenu_Menu1Form(f1));
        }
    }
}
