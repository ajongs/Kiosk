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
    public partial class DrinkMenuParentForm : Form
    {
        Form1 f1;
        public DrinkMenuParentForm(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
        }

        private void DrinkMenuParentForm_Load(object sender, EventArgs e)
        {
            Form childForm = new DrinkMenu_MenuForm(f1);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            chosePanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
