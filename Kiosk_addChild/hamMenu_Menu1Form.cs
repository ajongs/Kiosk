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
    public partial class hamMenu_Menu1Form : Form
    {
        private static int MOZZA = 8;
        private static int DOUBLE = 9;
        private static int HOTCRISPI = 10;
        private static int BIGBOOL = 11;
        int cntMozza = 0;
        int cntDouble = 0;
        int cntHotcrispi = 0;
        int cntBigbool = 0;
        Form1 f1;
        public hamMenu_Menu1Form(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
            f1.set_HamMenu1Form(this);
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
            cntMozza = 0;
            cntDouble = 0;
            cntHotcrispi = 0;
            cntBigbool = 0;
        }
        public void resetOne(String name)
        {
            if (name == f1.menulist[MOZZA].name)
                cntMozza = 0;
            if (name == f1.menulist[DOUBLE].name)
                cntDouble = 0;
            if (name == f1.menulist[HOTCRISPI].name)
                cntHotcrispi = 0;
            if (name == f1.menulist[BIGBOOL].name)
                cntBigbool = 0;
        }

        private void MozzaBurPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[MOZZA].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[MOZZA].code, f1.menulist[MOZZA].name, ++cntMozza, f1.menulist[MOZZA].price);

        }

        private void DoubleBurPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[DOUBLE].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[DOUBLE].code, f1.menulist[DOUBLE].name, ++cntDouble, f1.menulist[DOUBLE].price);
        }

        private void HotCriBurPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
           
            if (f1.checkListPanel(f1.menulist[HOTCRISPI].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[HOTCRISPI].code, f1.menulist[HOTCRISPI].name, ++cntHotcrispi, f1.menulist[HOTCRISPI].price);
        }

        private void BicbulBurPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
           if (f1.checkListPanel(f1.menulist[BIGBOOL].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[BIGBOOL].code, f1.menulist[BIGBOOL].name, ++cntBigbool, f1.menulist[BIGBOOL].price);

        }
    }
}
