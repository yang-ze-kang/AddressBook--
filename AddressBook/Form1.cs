using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddressBook;
using System.IO;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\60382\\Desktop\\addressbook.txt";
        public Form1()
        {
            InitializeComponent();
            this.adressBook.Columns.Add("学号", 100, HorizontalAlignment.Center);
            this.adressBook.Columns.Add("姓名", 100, HorizontalAlignment.Center);
            this.adressBook.Columns.Add("性别", 100, HorizontalAlignment.Center);
            this.adressBook.Columns.Add("工作单位", 100, HorizontalAlignment.Center);
            this.adressBook.Columns.Add("电话号码", 100, HorizontalAlignment.Center);
            this.adressBook.Columns.Add("E-mail", 100, HorizontalAlignment.Center);
            this.adressBook.View = System.Windows.Forms.View.Details;
            LoadMessages();
        }

        private int itemOld = -1;
        private void AdressBook_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Bt_insert_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Text = "新建联系人";
            f2.Show();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (this.adressBook.SelectedItems.Count > 0)//已选中联系人
            {
                MessageBox.Show("您将要删除该联系人！");
                //定位
                int pos = this.adressBook.SelectedItems[0].Index;
                //显示删除
                this.adressBook.Items.RemoveAt(pos);
                //文件删除
                string file = MyText.ReadText(path);
                file = file.Replace("$", "\r\n");
                string[] records = Regex.Split(file, "\r\n");
                for (int i = pos; i < records.Length - 1; i++)
                    records[i] = records[i + 1];
                file = "";
                for (int i = 0; i < records.Length - 2; i++)
                    file += records[i]+"$";
                MyText.WrtieText(file, path);
            }
            else//未选中联系人
            {
                Form3 f3 = new Form3(this,3);
                f3.Show();
            }
        }

        private void LoadMessages()
        {
            string file = MyText.ReadText(path);
            //string file = File.ReadAllText(path, UTF8Encoding.Default);
            file=file.Replace("$", "\r\n");
            string[] records = Regex.Split(file, "\r\n");
            this.adressBook.BeginUpdate();
            for (int i = 0; i < records.Length-1; i++)//不加载最后一个空行
            {
                string[] components = Regex.Split(records[i], " ");
                ListViewItem item = new ListViewItem(components);
                this.adressBook.Items.Add(item);
            }
            this.adressBook.EndUpdate();
        }

        private void bt_modify_Click(object sender, EventArgs e)
        {
            if (this.adressBook.SelectedItems.Count > 0)
            {
                int pos = this.adressBook.SelectedItems[0].Index;
                ListViewItem lv = this.adressBook.Items[pos];
                string s = lv.SubItems[0].Text + " "//组合信息准备向下一个窗口发送
                          + lv.SubItems[1].Text + " "
                          + lv.SubItems[2].Text + " "
                          + lv.SubItems[3].Text + " "
                          + lv.SubItems[4].Text + " "
                          + lv.SubItems[5].Text + " "
                          + Convert.ToString(pos);
                //     lv.SubItems[3].Text, lv.SubItems[4].Text, lv.SubItems[5].Text
                // Linkman infor = new Linkman(lv.SubItems[0].Text, lv.SubItems[1].Text, lv.SubItems[2].Text,
                //     lv.SubItems[3].Text, lv.SubItems[4].Text, lv.SubItems[5].Text);
                // Form2 f = new Form2(infor); 
                Form2 f = new Form2(this, s);
                f.Text = "修改联系人信息";
                f.Show();
            }
            else
            {
                Form3 f3 = new Form3(this,2);
                f3.Show();
            }
        }

        private void tb_sta_Click(object sender, EventArgs e)
        {
            int manNum, womanNum, sumNum;
            string file = MyText.ReadText(path);
            file = file.Replace("$", "\r\n");
            //string file = File.ReadAllText(path, UTF8Encoding.Default);
            string[] items = Regex.Split(file, "\r\n");
            sumNum = items.Length - 1;
            manNum = 0;
            womanNum = 0;
            for(int i=0;i<items.Length-1;i++)
            {
                string[] component = Regex.Split(items[i], " ");
                if (component[2] == "男") manNum++;
                else womanNum++;
            }
            string res = "男生有" + Convert.ToString(manNum) + "人\n"
                + "女生有" + Convert.ToString(womanNum) + "人\n"
                + "总共有" + Convert.ToString(sumNum) + "人";
            MessageBox.Show(res);
        }

        private void iv_search_Click(object sender, EventArgs e)
        {
            string search = this.tb_search.Text;
            if(search=="")
            {
                this.adressBook.Items.Clear();
                LoadMessages();
            }
            else
            {
                this.adressBook.Update();
                this.adressBook.Items.Clear();
                string file = MyText.ReadText(path);
                file = file.Replace("$","\r\n");
                string[] items = Regex.Split(file, "\r\n");
                for(int i=0;i<items.Length-1;i++)
                {
                    string[] component = Regex.Split(items[i], " ");
                    for(int j=0;j<component.Length;j++)
                    {
                        if(search==component[j])
                        {
                            ListViewItem item = new ListViewItem(component);
                            this.adressBook.Items.Add(item);
                            break;
                        }
                    }
                }
                this.adressBook.EndUpdate();
            }
        }

        private void AdressBook_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
