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
    public partial class hamMenu_Menu2Form : Form
    {

        private static int WAGU = 12;
        private static int AZ = 13;
        int cntWagu = 0;
        int cntAZ = 0;
        Form1 f1;
        public hamMenu_Menu2Form(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
            f1.set_HamMenu2Form(this);
        }
        private void addList(int pcode, string name, int cnt, int price)
        {
            if (cnt > 1)
            {
                return;
            }
            Product product = new Product(pcode, name, cnt, price);
            f1.addList(product);
        }
        public void reset()
        {
            cntWagu = 0;
            cntAZ = 0;
        }
        public void resetOne(String name)
        {
            if (name == f1.menulist[WAGU].name)
                cntWagu = 0;
            if (name == f1.menulist[AZ].name)
                cntAZ = 0;
        }

        private void WaguPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[WAGU].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[WAGU].code, f1.menulist[WAGU].name, ++cntWagu, f1.menulist[WAGU].price);

        }

        private void AzPB_Click(object sender, EventArgs e)
        {
            if (f1.checkListPanel(f1.menulist[AZ].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[AZ].code, f1.menulist[AZ].name, ++cntAZ, f1.menulist[AZ].price);
        }
    }
}
