using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;
namespace Kiosk_addChild
{

    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        private ProductMap productMap = new ProductMap();
        private setMenu_Menu1Form setMenu1Form;
        private setMenu_Menu2Form setMenu2Form;
        private hamMenu_Menu1Form hamMenu1Form;
        private hamMenu_Menu2Form hamMenu2Form;
        private DrinkMenu_MenuForm drinkMenuForm;
        int totalCnt = 0;
        int totalPrice = 0;
        public List<Menu> menulist;
        public Form1()
        {
            InitializeComponent();
        }
        //세트 메뉴 reset 함수 사용하기 위해 종속
        public void set_Setmenu1Form(setMenu_Menu1Form form)
        {
            this.setMenu1Form = form;
        }
        public void set_Setmenu2Form(setMenu_Menu2Form form)
        {
            this.setMenu2Form = form;
        }
        public void set_HamMenu1Form(hamMenu_Menu1Form form)
        {
            this.hamMenu1Form = form;
        }
        public void set_HamMenu2Form(hamMenu_Menu2Form form)
        {
            this.hamMenu2Form = form;
        }
        public void set_DrinkMenu1Form(DrinkMenu_MenuForm form)
        {
            this.drinkMenuForm = form;
        }
        // formboardStyle을 none으로 하면 폼이 드래그 안됌
        // 아래 Dll을 임포트하면 ReleaseCapture와 SendMessage 함수를 사용해 드래그 가능
        // 원하는 판넬에 마우스 다운시 이 두가지 함수 호출하면 됌.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.White;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.Font = new System.Drawing.Font("돋움", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in MenuBarPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Linen;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                }
            }
        }
        List<UserControl1> listu = new List<UserControl1>();
        int cntList = 0;
        public void addList(Product product)
        {
            UserControl1 usercontrol = new UserControl1(product, this);
            listu.Add(usercontrol);
            listu[cntList].Name = "list" + cntList.ToString();
            listPanel.Controls.Add(listu[cntList]);
            cntList++;
            usercontrol.ClinkNumeric();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            btnSetMenu.PerformClick();

            //파일 입출력
            StreamReader rd = new StreamReader(File.OpenRead("Menu.txt"));
            
            menulist = new List<Menu>();
            List<String> list = new List<string>();
            int i = 0;
            while (!rd.EndOfStream)
            {
                //파일자료 리스트로 읽기
                list.Add(rd.ReadLine());

                //레코드 프로퍼티로 읽기
                Menu menu = new Menu();
                menu.code = int.Parse(list[i].Split(',')[0]);
                menu.name = list[i].Split(',')[1];
                menu.price = int.Parse(list[i].Split(',')[2]);
                menulist.Add(menu);
                i++;
            }
        }
        private void openMenuForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MenuPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnSetMenu_Click(object sender, EventArgs e)
        {
            openMenuForm(new SetMenuParentForm(this));
            ActivateButton(sender);
        }

        private void btnHbg_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openMenuForm(new HamMenuParentForm(this));
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openMenuForm(new DrinkMenuParentForm(this));
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.ShowDialog();
        }

        private void logoPb_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            List<Product> list2 = productMap.deleteAll();
            for(int i=0; i<list2.Count; i++)
            {
                MessageBox.Show("삭제됌" + list2[i].GetPname());
            }
            listPanel.Controls.Clear();
            setMenu1Form.reset();
            if(setMenu2Form != null)
                setMenu2Form.reset();
            if (hamMenu1Form != null)
                hamMenu1Form.reset();
            if (hamMenu2Form != null)
                hamMenu2Form.reset();
            if (drinkMenuForm != null)
                drinkMenuForm.reset();
            totalBarUpdate(ref totalCnt, ref totalPrice);
        }
        
        public void deleteList(Control control, string name)
        {
            //컨트롤 삭제
            control.Dispose();
            //판넬에서 제거
            listPanel.Controls.Remove(control);
            //Map에 저장된 product 삭제
            productMap.DeleteProduct(name);
            setMenu1Form.resetOne(name);
            if(setMenu2Form!=null)
                setMenu2Form.resetOne(name);
            if (hamMenu1Form != null)
                hamMenu1Form.resetOne(name);
            if (hamMenu2Form != null)
                hamMenu2Form.resetOne(name);
            if (drinkMenuForm != null)
                drinkMenuForm.resetOne(name);
            totalBarUpdate(ref totalCnt, ref totalPrice);
        }
        
        public void addNum(Product product)
        {
            //총 개수 구하기
            //producMap에서 모든 product 가져와서 값 더함
            productMap.SetProduct(product.GetPname(), product);
            totalBarUpdate(ref totalCnt, ref totalPrice);
            
        }

        private void totalBarUpdate(ref int totalCnt, ref int totalPrice)
        {
            totalCnt = 0;
            totalPrice = 0;
            List<Product> list = productMap.showAll();
            for (int i = 0; i < list.Count; i++)
            {
                totalPrice += list[i].GetNum() * list[i].GetPrice();
                totalCnt += list[i].GetNum();
            }
            lblTCnt.Text = totalCnt.ToString() + "개";
            lblTPrice.Text = totalPrice.ToString();
        }
        public bool checkListPanel(string name)
        {
            List<Product> list = productMap.showAll();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].GetPname() == name)
                    return true;
            }
            return false;
        }

        private void payButton_Click(object sender, EventArgs e)
        {

            List<Product> list = productMap.showAll();

            var requestJson = JsonConvert.SerializeObject(list.ToArray(), Formatting.Indented);

            
            String uri = "http://localhost:8080/orderProduct";
            //uri 사용시 문의하세요
            WebClient webClient = new WebClient();

            //POST 방식
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.Encoding = UTF8Encoding.UTF8;
            string responseJson = webClient.UploadString(uri, requestJson);
            
            MessageBox.Show(responseJson);
            deleteBtn.PerformClick();
        }
    }
}
