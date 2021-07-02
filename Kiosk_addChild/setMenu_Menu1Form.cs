using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kiosk_addChild
{
    public partial class setMenu_Menu1Form : Form
    {
        Form1 f1;
        private const int MIRACLE = 0;
        private const int FOLDERHOT = 1;
        private const int FOLDERBEP = 2;
        private const int WAGU = 3;
        int cntMiracle = 0;
        int cntfolderHot = 0;
        int cntFolderBep = 0;
        int cntWagu = 0;
        public setMenu_Menu1Form(Form1 Form1)
        {
            InitializeComponent();
            f1 = Form1;
            f1.set_Setmenu1Form(this);

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
            cntMiracle = 0;
            cntfolderHot = 0;
            cntFolderBep = 0;
            cntWagu = 0;
        }
        public void resetOne(String name)
        {
            if (name == f1.menulist[MIRACLE].name)
                cntMiracle = 0;
            if (name == f1.menulist[FOLDERHOT].name)
                cntfolderHot = 0;
            if (name == f1.menulist[FOLDERBEP].name)
                cntFolderBep = 0;
            if (name == f1.menulist[WAGU].name)
                cntWagu = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            
             //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
             
            if (f1.checkListPanel(f1.menulist[MIRACLE].name))
            {
                return; 
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[MIRACLE].code, f1.menulist[MIRACLE].name, ++cntMiracle, f1.menulist[MIRACLE].price);
            
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[FOLDERHOT].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[FOLDERHOT].code, f1.menulist[FOLDERHOT].name, ++cntfolderHot, f1.menulist[FOLDERHOT].price);

        }


        private void FolBepSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
           
            if (f1.checkListPanel(f1.menulist[FOLDERBEP].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[FOLDERBEP].code, f1.menulist[FOLDERBEP].name, ++cntFolderBep, f1.menulist[FOLDERBEP].price);
        }

        private void WaguSet_Click(object sender, EventArgs e)
        {
            //checkListPanel 이미 존재하면 true, 존재하지 않으면 false
            if (f1.checkListPanel(f1.menulist[WAGU].name))
            {
                return;
                //트루이면 리스트를 더하지 않는다
            }
            addList(f1.menulist[WAGU].code, f1.menulist[WAGU].name, ++cntWagu, f1.menulist[WAGU].price);
        }
    }
}
