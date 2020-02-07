namespace AddressBook
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adressBook = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_insert = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.iv_search = new System.Windows.Forms.PictureBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_modify = new System.Windows.Forms.Button();
            this.tb_sta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // adressBook
            // 
            this.adressBook.FullRowSelect = true;
            this.adressBook.HideSelection = false;
            this.adressBook.Location = new System.Drawing.Point(12, 95);
            this.adressBook.Name = "adressBook";
            this.adressBook.Size = new System.Drawing.Size(800, 252);
            this.adressBook.TabIndex = 0;
            this.adressBook.UseCompatibleStateImageBehavior = false;
            this.adressBook.SelectedIndexChanged += new System.EventHandler(this.AdressBook_SelectedIndexChanged);
            this.adressBook.DoubleClick += new System.EventHandler(this.AdressBook_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "通讯录";
            // 
            // bt_insert
            // 
            this.bt_insert.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_insert.Location = new System.Drawing.Point(31, 373);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(80, 35);
            this.bt_insert.TabIndex = 2;
            this.bt_insert.Text = "插入";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.Bt_insert_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(588, 64);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(193, 25);
            this.tb_search.TabIndex = 5;
            // 
            // iv_search
            // 
            this.iv_search.BackColor = System.Drawing.SystemColors.Control;
            this.iv_search.Image = ((System.Drawing.Image)(resources.GetObject("iv_search.Image")));
            this.iv_search.InitialImage = ((System.Drawing.Image)(resources.GetObject("iv_search.InitialImage")));
            this.iv_search.Location = new System.Drawing.Point(787, 64);
            this.iv_search.Name = "iv_search";
            this.iv_search.Size = new System.Drawing.Size(25, 25);
            this.iv_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iv_search.TabIndex = 6;
            this.iv_search.TabStop = false;
            this.iv_search.Click += new System.EventHandler(this.iv_search_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_delete.Location = new System.Drawing.Point(229, 373);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(80, 35);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "删除";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_modify
            // 
            this.bt_modify.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_modify.Location = new System.Drawing.Point(131, 373);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(80, 35);
            this.bt_modify.TabIndex = 8;
            this.bt_modify.Text = "修改";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // tb_sta
            // 
            this.tb_sta.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_sta.Location = new System.Drawing.Point(327, 373);
            this.tb_sta.Name = "tb_sta";
            this.tb_sta.Size = new System.Drawing.Size(80, 35);
            this.tb_sta.TabIndex = 9;
            this.tb_sta.Text = "统计";
            this.tb_sta.UseVisualStyleBackColor = true;
            this.tb_sta.Click += new System.EventHandler(this.tb_sta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 479);
            this.Controls.Add(this.tb_sta);
            this.Controls.Add(this.bt_modify);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.iv_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressBook);
            this.Name = "Form1";
            this.Text = "Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.iv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.PictureBox iv_search;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_modify;
        public System.Windows.Forms.ListView adressBook;
        private System.Windows.Forms.Button tb_sta;
        public System.Windows.Forms.TextBox tb_search;
    }
}

