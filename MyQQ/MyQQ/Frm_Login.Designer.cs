namespace MyQQ
{
    partial class Frm_Login
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.piboxClose = new System.Windows.Forms.PictureBox();
            this.cboxRemeber = new System.Windows.Forms.CheckBox();
            this.cboxAutoLogin = new System.Windows.Forms.CheckBox();
            this.piboxLogin = new System.Windows.Forms.PictureBox();
            this.linklblReg = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(134, 200);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 14);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Location = new System.Drawing.Point(134, 231);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(191, 14);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPwd_KeyPress);
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(368, 0);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(33, 29);
            this.pboxMin.TabIndex = 2;
            this.pboxMin.TabStop = false;
            // 
            // piboxClose
            // 
            this.piboxClose.BackColor = System.Drawing.Color.Transparent;
            this.piboxClose.Location = new System.Drawing.Point(407, 0);
            this.piboxClose.Name = "piboxClose";
            this.piboxClose.Size = new System.Drawing.Size(29, 29);
            this.piboxClose.TabIndex = 3;
            this.piboxClose.TabStop = false;
            this.piboxClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cboxRemeber
            // 
            this.cboxRemeber.AutoSize = true;
            this.cboxRemeber.Location = new System.Drawing.Point(134, 262);
            this.cboxRemeber.Name = "cboxRemeber";
            this.cboxRemeber.Size = new System.Drawing.Size(106, 22);
            this.cboxRemeber.TabIndex = 4;
            this.cboxRemeber.Text = "记住密码";
            this.cboxRemeber.UseVisualStyleBackColor = true;
            this.cboxRemeber.CheckedChanged += new System.EventHandler(this.cboxRemeber_CheckedChanged);
            this.cboxRemeber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxRemeber_KeyPress);
            // 
            // cboxAutoLogin
            // 
            this.cboxAutoLogin.AutoSize = true;
            this.cboxAutoLogin.Location = new System.Drawing.Point(257, 262);
            this.cboxAutoLogin.Name = "cboxAutoLogin";
            this.cboxAutoLogin.Size = new System.Drawing.Size(106, 22);
            this.cboxAutoLogin.TabIndex = 5;
            this.cboxAutoLogin.Text = "自动登录";
            this.cboxAutoLogin.UseVisualStyleBackColor = true;
            this.cboxAutoLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxAutoLogin_KeyPress);
            // 
            // piboxLogin
            // 
            this.piboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.piboxLogin.Location = new System.Drawing.Point(134, 278);
            this.piboxLogin.Name = "piboxLogin";
            this.piboxLogin.Size = new System.Drawing.Size(201, 50);
            this.piboxLogin.TabIndex = 6;
            this.piboxLogin.TabStop = false;
            this.piboxLogin.Click += new System.EventHandler(this.piboxLogin_Click);
            // 
            // linklblReg
            // 
            this.linklblReg.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linklblReg.AutoSize = true;
            this.linklblReg.BackColor = System.Drawing.SystemColors.Control;
            this.linklblReg.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblReg.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linklblReg.Location = new System.Drawing.Point(338, 216);
            this.linklblReg.Name = "linklblReg";
            this.linklblReg.Size = new System.Drawing.Size(80, 18);
            this.linklblReg.TabIndex = 7;
            this.linklblReg.TabStop = true;
            this.linklblReg.Text = "申请账号";
            this.linklblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblReg_LinkClicked);
            // 
            // Frm_Login
            // 
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(432, 331);
            this.Controls.Add(this.linklblReg);
            this.Controls.Add(this.piboxLogin);
            this.Controls.Add(this.cboxAutoLogin);
            this.Controls.Add(this.cboxRemeber);
            this.Controls.Add(this.piboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtID);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Q友登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piboxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox piboxClose;
        private System.Windows.Forms.CheckBox cboxRemeber;
        private System.Windows.Forms.CheckBox cboxAutoLogin;
        private System.Windows.Forms.PictureBox piboxLogin;
        private System.Windows.Forms.LinkLabel linklblReg;
    }
}

