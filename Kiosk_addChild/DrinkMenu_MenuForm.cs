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
    public partial class DrinkMenu_MenuForm : Form
    {
        private static int ICETEE = 14;
        private static int ICEAMERICANO = 15;
        private static int SODA = 16;
        private static int COKE = 17;
        int cntIcetee = 0;
        int cntIceAmericano = 0;
        int cntSoda = 0;
        int cntCoke = 0;
        Form1 f1;
        public DrinkMenu_MenuForm(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
            f1.set_DrinkMenu1Form(this);
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
            cntIcetee = 0;
            cntIceAmericano = 0;
            cntSoda = 0;
            cntCoke = 0;
        }
        public void resetOne(String name)
        {
            if (name == f1.menulist[ICETEE].name)
                cntIcetee = 0;
            if (name == f1.menulist[ICEAMERICANO].name)
                cntIceAmericano = 0;
            if (name == f1.menulist[SODA].name)
                cntSoda = 0;
            if (name == f1.menulist[COKE].name)
                cntCoke = 0;
        }
        private void IceteePB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[ICETEE].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[ICETEE].code, f1.menulist[ICETEE].name, ++cntIcetee, f1.menulist[ICETEE].price);
        }

        private void IceAmericanoPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[ICEAMERICANO].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[ICEAMERICANO].code, f1.menulist[ICEAMERICANO].name, ++cntIceAmericano, f1.menulist[ICEAMERICANO].price);
        }

        private void SodaPB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[SODA].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[SODA].code, f1.menulist[SODA].name, ++cntSoda, f1.menulist[SODA].price);
        }

        private void CokePB_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false

            if (f1.checkListPanel(f1.menulist[COKE].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[COKE].code, f1.menulist[COKE].name, ++cntCoke, f1.menulist[COKE].price);
        }
    }
}
