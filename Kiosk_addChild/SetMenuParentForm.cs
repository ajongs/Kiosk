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
    
    public partial class SetMenuParentForm : Form
    {
        Form1 f1;
        private Form activeForm = null;
        public SetMenuParentForm(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
        }
        
        private void openMenuForm(Form childForm)
        {
            if (activeForm == childForm)
                return;
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
        //계속 새로운 form 만들고 폼에 값은 값있으면 출력x
        private void btnSetRight_Click(object sender, EventArgs e)
        { 
            openMenuForm(new setMenu_Menu2Form(f1));
        }

        private void btnSetLeft_Click(object sender, EventArgs e)
        {
            openMenuForm(new setMenu_Menu1Form(f1));
        }

        private void SetMenuParentForm_Load(object sender, EventArgs e)
        { 
            openMenuForm(new setMenu_Menu1Form(f1));
        }
    }
}


