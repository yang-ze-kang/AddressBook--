namespace AddressBook
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tv_id = new System.Windows.Forms.TextBox();
            this.tv_phoneNum = new System.Windows.Forms.TextBox();
            this.tv_workAddress = new System.Windows.Forms.TextBox();
            this.tv_name = new System.Windows.Forms.TextBox();
            this.tv_Email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_woman = new System.Windows.Forms.RadioButton();
            this.rb_man = new System.Windows.Forms.RadioButton();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(77, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "工作单位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(77, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(77, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "电话号码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(53, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // tv_id
            // 
            this.tv_id.Location = new System.Drawing.Point(141, 52);
            this.tv_id.Name = "tv_id";
            this.tv_id.Size = new System.Drawing.Size(163, 25);
            this.tv_id.TabIndex = 0;
            this.tv_id.Tag = "1";
            // 
            // tv_phoneNum
            // 
            this.tv_phoneNum.Location = new System.Drawing.Point(141, 252);
            this.tv_phoneNum.Name = "tv_phoneNum";
            this.tv_phoneNum.Size = new System.Drawing.Size(163, 25);
            this.tv_phoneNum.TabIndex = 4;
            // 
            // tv_workAddress
            // 
            this.tv_workAddress.Location = new System.Drawing.Point(141, 199);
            this.tv_workAddress.Name = "tv_workAddress";
            this.tv_workAddress.Size = new System.Drawing.Size(163, 25);
            this.tv_workAddress.TabIndex = 3;
            // 
            // tv_name
            // 
            this.tv_name.Location = new System.Drawing.Point(141, 99);
            this.tv_name.Name = "tv_name";
            this.tv_name.Size = new System.Drawing.Size(163, 25);
            this.tv_name.TabIndex = 1;
            this.tv_name.Tag = "2";
            // 
            // tv_Email
            // 
            this.tv_Email.Location = new System.Drawing.Point(141, 306);
            this.tv_Email.Name = "tv_Email";
            this.tv_Email.Size = new System.Drawing.Size(163, 25);
            this.tv_Email.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_woman);
            this.groupBox1.Controls.Add(this.rb_man);
            this.groupBox1.Location = new System.Drawing.Point(141, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rb_woman
            // 
            this.rb_woman.AutoSize = true;
            this.rb_woman.Font = new System.Drawing.Font("楷体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_woman.Location = new System.Drawing.Point(90, 17);
            this.rb_woman.Name = "rb_woman";
            this.rb_woman.Size = new System.Drawing.Size(47, 21);
            this.rb_woman.TabIndex = 1;
            this.rb_woman.TabStop = true;
            this.rb_woman.Text = "女";
            this.rb_woman.UseVisualStyleBackColor = true;
            this.rb_woman.CheckedChanged += new System.EventHandler(this.rb_woman_CheckedChanged);
            // 
            // rb_man
            // 
            this.rb_man.AutoSize = true;
            this.rb_man.Font = new System.Drawing.Font("楷体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_man.Location = new System.Drawing.Point(16, 17);
            this.rb_man.Name = "rb_man";
            this.rb_man.Size = new System.Drawing.Size(47, 21);
            this.rb_man.TabIndex = 0;
            this.rb_man.TabStop = true;
            this.rb_man.Text = "男";
            this.rb_man.UseVisualStyleBackColor = true;
            this.rb_man.CheckedChanged += new System.EventHandler(this.rb_man_CheckedChanged);
            // 
            // bt_ok
            // 
            this.bt_ok.Font = new System.Drawing.Font("楷体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_ok.Location = new System.Drawing.Point(57, 371);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(115, 38);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "确定";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("楷体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_back.Location = new System.Drawing.Point(215, 371);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(115, 38);
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "取消";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 501);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tv_Email);
            this.Controls.Add(this.tv_name);
            this.Controls.Add(this.tv_workAddress);
            this.Controls.Add(this.tv_phoneNum);
            this.Controls.Add(this.tv_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tv_id;
        private System.Windows.Forms.TextBox tv_phoneNum;
        private System.Windows.Forms.TextBox tv_workAddress;
        private System.Windows.Forms.TextBox tv_name;
        private System.Windows.Forms.TextBox tv_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_man;
        private System.Windows.Forms.RadioButton rb_woman;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_back;
    }
}