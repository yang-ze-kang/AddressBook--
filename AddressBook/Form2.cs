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
    
    public partial class Form2 : Form
    {
        Form1 f1;
        int funFlag = 0;//判断是何种功能
        string sex = "";
        string path = "C:\\Users\\60382\\Desktop\\addressbook.txt";//文件路径
        int pos;//item位置

        public Form2()
        {
            InitializeComponent();
            funFlag = 0;
        }

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        public Form2(Form1 f1,string s)
        {
            InitializeComponent();
            this.f1 = f1;
            funFlag=1;
            string[] infor = Regex.Split(s, " ");
            this.tv_id.Text = infor[0];
            this.tv_name.Text = infor[1];
            if (infor[2] == "男") this.rb_man.Checked = true;
            else this.rb_woman.Checked = true;
            this.tv_workAddress.Text = infor[3];
            this.tv_phoneNum.Text = infor[4];
            this.tv_Email.Text = infor[5];
            pos = Convert.ToInt32(infor[6]);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (this.rb_man.Checked) sex = "男";
            else if (this.rb_woman.Checked) sex = "女";
            else
            {
                MessageBox.Show("请选择性别！");
                return;
            }
            string itemS = this.tv_id.Text + " "
                    + this.tv_name.Text + " "
                    + sex + " "
                    + this.tv_workAddress.Text + " "
                    + this.tv_phoneNum.Text + " "
                    + this.tv_Email.Text;//从输入框获取信息
            if (funFlag == 0)//添加
            {
                string[] item = Regex.Split(itemS, " ");
                //判断是进行更新还是修改
                string file = MyText.ReadText(path);
                file = file.Replace("$", "\r\n");
                string[] items = Regex.Split(file, "\r\n");
                int pos = 0;
                while(pos<items.Length-1)
                {
                    string[] component = Regex.Split(items[pos]," ");
                    if (item[0] == component[0]) break;
                    pos++;
                }
                //更新显示列表、写入文件
                f1.adressBook.Update();
                ListViewItem newItem = new ListViewItem(item);
                if (pos == items.Length - 1)
                {
                    f1.adressBook.Items.Add(newItem);
                    MyText.AppendText(itemS + "$", path);
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    f1.adressBook.Items[pos] = newItem;
                    Modify(itemS, pos);
                    MessageBox.Show("更新成功！");
                } 
                f1.adressBook.EndUpdate();
                this.Dispose(false);
            }
            else if (funFlag == 1)//修改
            {
                //更新显示列表
                string[] itemSS = Regex.Split(itemS, " ");
                ListViewItem item = new ListViewItem(itemSS);
                f1.adressBook.Update();
                f1.adressBook.Items[pos] = item;
                f1.adressBook.EndUpdate();
                //更新文件
                Modify(itemS, pos);
                this.Dispose(false);
            }
        }

        private void rb_man_CheckedChanged(object sender, EventArgs e)
        {
            sex = "男";
        }

        private void rb_woman_CheckedChanged(object sender, EventArgs e)
        {
            sex = "女";
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
        }

        private void Modify(string newItem,int pos)
        {
            string file = MyText.ReadText(path);
            file = file.Replace("$","\r\n");
            string[] record = Regex.Split(file, "\r\n");
            record[pos] = newItem;
            string outFile = "";
            for (int i = 0; i < record.Length - 1; i++)
                outFile += record[i] + "$";
            MyText.WrtieText(outFile, path);
        }
    }
}
