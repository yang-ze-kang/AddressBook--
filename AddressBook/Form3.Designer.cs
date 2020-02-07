namespace AddressBook
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pb_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(306, 103);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(121, 31);
            this.cb_search.TabIndex = 0;
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_search.Location = new System.Drawing.Point(68, 99);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(232, 34);
            this.tb_search.TabIndex = 1;
            // 
            // pb_search
            // 
            this.pb_search.Image = ((System.Drawing.Image)(resources.GetObject("pb_search.Image")));
            this.pb_search.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_search.InitialImage")));
            this.pb_search.Location = new System.Drawing.Point(443, 99);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(35, 34);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_search.TabIndex = 2;
            this.pb_search.TabStop = false;
            this.pb_search.Click += new System.EventHandler(this.pb_search_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 238);
            this.Controls.Add(this.pb_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.cb_search);
            this.Name = "Form3";
            this.Text = "查询";
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pb_search;
    }
}