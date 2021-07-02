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
    public partial class UserControl1 : UserControl
    {
        Product product;
        Form1 f1;
        public UserControl1(Product product, Form1 form1)
        {
            InitializeComponent();
            lblProduct.Text = product.GetPname();
            lblPrice.Text = product.GetPrice().ToString();          
            this.product = product;
            f1 = form1;
        }
        
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            f1.deleteList(this, lblProduct.Text);

        }
        
        private void CountNmeric_ValueChanged(object sender, EventArgs e)
        {
            // 0으로 개수 내려갈 수 없게 고정
            if (CountNmeric.Value == 0) CountNmeric.Value = 1;
            //프로덕트맵에서 객체 찾아서 개수증가
            product.SetNum(Convert.ToInt32(CountNmeric.Value));
            f1.addNum(product);
            //개수에 따라서 가격증가
            //int updateLblPrice2 = Convert.ToInt32(CountNmeric.Value) * product.GetPrice();
            int updateLblPrice2 = product.GetNum() * product.GetPrice();
            lblPrice.Text = updateLblPrice2.ToString();
        }
        public void ClinkNumeric()
        {
            //처음에 밸류 1로 줘야함
            CountNmeric.Value = 1;
            CountNmeric.Click += new EventHandler(CountNmeric_ValueChanged);
        }

    }
}
