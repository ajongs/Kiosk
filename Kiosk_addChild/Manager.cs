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
    public partial class Manager : Form
    {
        public bool systemOff = false;
        public Manager()
        {
            InitializeComponent();
        }

        private void pwBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb.Text) == 1234)
            {
                if(MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }
    }
}
