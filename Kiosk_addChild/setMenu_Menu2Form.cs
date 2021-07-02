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
    public partial class setMenu_Menu2Form : Form
    {
        Form1 f1;
        private static int AZSET = 4;
        private static int DOUBLESET = 5;
        private static int CHICKSET = 6;
        private static int TREXSET = 7;
        int cntAZ = 0;
        int cntDouble = 0;
        int cntChick = 0;
        int cntTrex = 0;
        public setMenu_Menu2Form(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
            f1.set_Setmenu2Form(this);
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
            cntAZ = 0;
            cntDouble = 0;
            cntChick = 0;
            cntTrex = 0;
        }
        public void resetOne(String name)
        {
            if (name == f1.menulist[AZSET].name)
                cntAZ = 0;
            if (name == f1.menulist[DOUBLESET].name)
                cntDouble = 0;
            if (name == f1.menulist[CHICKSET].name)
                cntChick = 0;
            if (name == f1.menulist[TREXSET].name)
                cntTrex = 0;
        }
        private void picAZSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 
            if (f1.checkListPanel(f1.menulist[AZSET].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[AZSET].code, f1.menulist[AZSET].name, ++cntAZ, f1.menulist[AZSET].price);
        }

        private void doubleSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[DOUBLESET].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[DOUBLESET].code, f1.menulist[DOUBLESET].name, ++cntDouble, f1.menulist[DOUBLESET].price);
        }

        private void ChickSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[CHICKSET].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[CHICKSET].code, f1.menulist[CHICKSET].name, ++cntChick, f1.menulist[CHICKSET].price);
        }

        private void TRexSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[TREXSET].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[TREXSET].code, f1.menulist[TREXSET].name, ++cntTrex, f1.menulist[TREXSET].price);
        }
    }
}
