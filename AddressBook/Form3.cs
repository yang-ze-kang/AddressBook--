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
using System.Text.RegularExpressions;

namespace AddressBook
{
    public partial class Form3 : Form
    {
        private Form1 f1;
        int funFlag = 0;//功能区分（1-3:添加、修改、删除）
        int searchState = 0;//查询方式
        string searchInfor = "";//查询内容
        string path = "C:\\Users\\60382\\Desktop\\addressbook.txt";//文件路径
        public Form3()
        {
            InitializeComponent();
            LoadComboBox();
        }

        public Form3(Form1 f1,int funFlag)
        {
            InitializeComponent();
            this.f1 = f1;
            this.funFlag = funFlag;
            LoadComboBox();
        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_search.SelectedItem.ToString())
            {
                case "学号":
                    searchState = 1;
                    break;
                case "姓名":
                    searchState = 2;
                    break;
                case "工作单位":
                    searchState = 4;
                    break;
                case "电话号码":
                    searchState = 5;
                    break;
                case "E-mail":
                    searchState = 6;
                    break;
            }
        }

        private void pb_search_Click(object sender, EventArgs e)
        {
            searchInfor = this.tb_search.Text;
            if (searchInfor == "")
            {
                MessageBox.Show("请输入查询内容");
                return;
            }
            if (searchState == 0)
            {
                MessageBox.Show("请选择查询方式");
                return;
            }
            string file = MyText.ReadText(path);
            file = file.Replace("$","\r\n");
            //string file = File.ReadAllText(path, UTF8Encoding.Default);
            string[] item = Regex.Split(file, "\r\n");
            int pos = 0;
            while(pos<item.Length-1)//查询
            {
                string[] component = Regex.Split(item[pos], " ");
                if (searchInfor == component[searchState - 1]) break;
                pos++;
            }
            if(pos==item.Length)
            {
                MessageBox.Show("未查询到相应联系人！");
                return;
            }
            else
            {
                switch(funFlag)
                {
                    case 2://修改联系人信息
                        Form2 f2 = new Form2(f1, item[pos] + " " + Convert.ToString(pos));
                        f2.Text = "修改联系人信息";
                        f2.Show();
                        break;
                    case 3://锁定要删除的联系人
                        f1.adressBook.Items[pos].Selected = true;
                        break;
                }
                
                this.Dispose();
            }
        }

        private void LoadComboBox()
        {
            this.cb_search.Items.Add("学号");
            this.cb_search.Items.Add("姓名");
            this.cb_search.Items.Add("工作单位");
            this.cb_search.Items.Add("电话号码");
            this.cb_search.Items.Add("E-mail");
        }
    }
}
