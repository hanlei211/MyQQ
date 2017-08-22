namespace MyQQ
{
    partial class Frm_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Register));
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.grpBaseInfo = new System.Windows.Forms.GroupBox();
            this.sex_female = new System.Windows.Forms.RadioButton();
            this.sex_male = new System.Windows.Forms.RadioButton();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtAPwd = new System.Windows.Forms.TextBox();
            this.lab_aPwd = new System.Windows.Forms.Label();
            this.lab_pwd = new System.Windows.Forms.Label();
            this.lab_sex = new System.Windows.Forms.Label();
            this.lab_age = new System.Windows.Forms.Label();
            this.lab_nick = new System.Windows.Forms.Label();
            this.grpDetailInfo = new System.Windows.Forms.GroupBox();
            this.cmb_blood = new System.Windows.Forms.ComboBox();
            this.cmb_star = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lab_blood = new System.Windows.Forms.Label();
            this.lab_star = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.grpBaseInfo.SuspendLayout();
            this.grpDetailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageLogo
            // 
            this.imageLogo.BackColor = System.Drawing.Color.Transparent;
            this.imageLogo.Image = global::MyQQ.Properties.Resources.Logo;
            this.imageLogo.Location = new System.Drawing.Point(0, 0);
            this.imageLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(104, 302);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // grpBaseInfo
            // 
            this.grpBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBaseInfo.Controls.Add(this.sex_female);
            this.grpBaseInfo.Controls.Add(this.sex_male);
            this.grpBaseInfo.Controls.Add(this.txtNick);
            this.grpBaseInfo.Controls.Add(this.txtAge);
            this.grpBaseInfo.Controls.Add(this.txtPwd);
            this.grpBaseInfo.Controls.Add(this.txtAPwd);
            this.grpBaseInfo.Controls.Add(this.lab_aPwd);
            this.grpBaseInfo.Controls.Add(this.lab_pwd);
            this.grpBaseInfo.Controls.Add(this.lab_sex);
            this.grpBaseInfo.Controls.Add(this.lab_age);
            this.grpBaseInfo.Controls.Add(this.lab_nick);
            this.grpBaseInfo.Location = new System.Drawing.Point(118, 8);
            this.grpBaseInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBaseInfo.Name = "grpBaseInfo";
            this.grpBaseInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBaseInfo.Size = new System.Drawing.Size(300, 142);
            this.grpBaseInfo.TabIndex = 1;
            this.grpBaseInfo.TabStop = false;
            this.grpBaseInfo.Text = "注册基本信息";
            this.grpBaseInfo.Enter += new System.EventHandler(this.grpBaseInfo_Enter);
            // 
            // sex_female
            // 
            this.sex_female.AutoSize = true;
            this.sex_female.Location = new System.Drawing.Point(159, 65);
            this.sex_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sex_female.Name = "sex_female";
            this.sex_female.Size = new System.Drawing.Size(35, 16);
            this.sex_female.TabIndex = 11;
            this.sex_female.TabStop = true;
            this.sex_female.Text = "女";
            this.sex_female.UseVisualStyleBackColor = true;
            // 
            // sex_male
            // 
            this.sex_male.AutoSize = true;
            this.sex_male.Location = new System.Drawing.Point(103, 65);
            this.sex_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sex_male.Name = "sex_male";
            this.sex_male.Size = new System.Drawing.Size(35, 16);
            this.sex_male.TabIndex = 10;
            this.sex_male.TabStop = true;
            this.sex_male.Text = "男";
            this.sex_male.UseVisualStyleBackColor = true;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(96, 14);
            this.txtNick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(132, 21);
            this.txtNick.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(96, 38);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 21);
            this.txtAge.TabIndex = 8;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(96, 83);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(132, 21);
            this.txtPwd.TabIndex = 6;
            // 
            // txtAPwd
            // 
            this.txtAPwd.Location = new System.Drawing.Point(96, 106);
            this.txtAPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAPwd.Name = "txtAPwd";
            this.txtAPwd.Size = new System.Drawing.Size(132, 21);
            this.txtAPwd.TabIndex = 5;
            // 
            // lab_aPwd
            // 
            this.lab_aPwd.AutoSize = true;
            this.lab_aPwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lab_aPwd.Location = new System.Drawing.Point(39, 113);
            this.lab_aPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_aPwd.Name = "lab_aPwd";
            this.lab_aPwd.Size = new System.Drawing.Size(53, 12);
            this.lab_aPwd.TabIndex = 4;
            this.lab_aPwd.Text = "重复密码";
            // 
            // lab_pwd
            // 
            this.lab_pwd.AutoSize = true;
            this.lab_pwd.Location = new System.Drawing.Point(63, 90);
            this.lab_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_pwd.Name = "lab_pwd";
            this.lab_pwd.Size = new System.Drawing.Size(29, 12);
            this.lab_pwd.TabIndex = 3;
            this.lab_pwd.Text = "密码";
            // 
            // lab_sex
            // 
            this.lab_sex.AutoSize = true;
            this.lab_sex.Location = new System.Drawing.Point(63, 67);
            this.lab_sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_sex.Name = "lab_sex";
            this.lab_sex.Size = new System.Drawing.Size(29, 12);
            this.lab_sex.TabIndex = 2;
            this.lab_sex.Text = "性别";
            // 
            // lab_age
            // 
            this.lab_age.AutoSize = true;
            this.lab_age.Location = new System.Drawing.Point(63, 45);
            this.lab_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_age.Name = "lab_age";
            this.lab_age.Size = new System.Drawing.Size(29, 12);
            this.lab_age.TabIndex = 1;
            this.lab_age.Text = "年龄";
            // 
            // lab_nick
            // 
            this.lab_nick.AutoSize = true;
            this.lab_nick.Location = new System.Drawing.Point(63, 16);
            this.lab_nick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_nick.Name = "lab_nick";
            this.lab_nick.Size = new System.Drawing.Size(29, 12);
            this.lab_nick.TabIndex = 0;
            this.lab_nick.Text = "昵称";
            // 
            // grpDetailInfo
            // 
            this.grpDetailInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpDetailInfo.Controls.Add(this.cmb_blood);
            this.grpDetailInfo.Controls.Add(this.cmb_star);
            this.grpDetailInfo.Controls.Add(this.txt_name);
            this.grpDetailInfo.Controls.Add(this.lab_blood);
            this.grpDetailInfo.Controls.Add(this.lab_star);
            this.grpDetailInfo.Controls.Add(this.lab_name);
            this.grpDetailInfo.Location = new System.Drawing.Point(118, 154);
            this.grpDetailInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetailInfo.Name = "grpDetailInfo";
            this.grpDetailInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetailInfo.Size = new System.Drawing.Size(300, 115);
            this.grpDetailInfo.TabIndex = 0;
            this.grpDetailInfo.TabStop = false;
            this.grpDetailInfo.Text = "选填详细信息";
            // 
            // cmb_blood
            // 
            this.cmb_blood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_blood.FormattingEnabled = true;
            this.cmb_blood.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmb_blood.Location = new System.Drawing.Point(96, 83);
            this.cmb_blood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_blood.Name = "cmb_blood";
            this.cmb_blood.Size = new System.Drawing.Size(132, 20);
            this.cmb_blood.TabIndex = 5;
            // 
            // cmb_star
            // 
            this.cmb_star.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_star.FormattingEnabled = true;
            this.cmb_star.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.cmb_star.Location = new System.Drawing.Point(96, 56);
            this.cmb_star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_star.Name = "cmb_star";
            this.cmb_star.Size = new System.Drawing.Size(132, 20);
            this.cmb_star.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(96, 28);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 21);
            this.txt_name.TabIndex = 3;
            // 
            // lab_blood
            // 
            this.lab_blood.AutoSize = true;
            this.lab_blood.Location = new System.Drawing.Point(63, 85);
            this.lab_blood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_blood.Name = "lab_blood";
            this.lab_blood.Size = new System.Drawing.Size(29, 12);
            this.lab_blood.TabIndex = 2;
            this.lab_blood.Text = "血型";
            // 
            // lab_star
            // 
            this.lab_star.AutoSize = true;
            this.lab_star.Location = new System.Drawing.Point(63, 56);
            this.lab_star.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_star.Name = "lab_star";
            this.lab_star.Size = new System.Drawing.Size(29, 12);
            this.lab_star.TabIndex = 1;
            this.lab_star.Text = "星座";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Location = new System.Drawing.Point(39, 30);
            this.lab_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(53, 12);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "真实姓名";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.Location = new System.Drawing.Point(183, 280);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(73, 29);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Location = new System.Drawing.Point(317, 280);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(65, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 319);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grpDetailInfo);
            this.Controls.Add(this.grpBaseInfo);
            this.Controls.Add(this.imageLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Register";
            this.Load += new System.EventHandler(this.Frm_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.grpBaseInfo.ResumeLayout(false);
            this.grpBaseInfo.PerformLayout();
            this.grpDetailInfo.ResumeLayout(false);
            this.grpDetailInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.GroupBox grpBaseInfo;
        private System.Windows.Forms.GroupBox grpDetailInfo;
        private System.Windows.Forms.RadioButton sex_female;
        private System.Windows.Forms.RadioButton sex_male;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtAPwd;
        private System.Windows.Forms.Label lab_aPwd;
        private System.Windows.Forms.Label lab_pwd;
        private System.Windows.Forms.Label lab_sex;
        private System.Windows.Forms.Label lab_age;
        private System.Windows.Forms.Label lab_nick;
        private System.Windows.Forms.ComboBox cmb_blood;
        private System.Windows.Forms.ComboBox cmb_star;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lab_blood;
        private System.Windows.Forms.Label lab_star;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}