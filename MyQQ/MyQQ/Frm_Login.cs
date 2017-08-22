using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        DataOperator dataOper = new DataOperator();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();//退出当前应用
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
          

        }

        //【验证 用户登录】
        private bool ValidateInput()
        {
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (txtID.Text.Length > 10)
            {
                MessageBox.Show("请输入正确的登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (txtID.Text.Length > 10 && txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入登录密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            return true;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断是否为数字
            if(Char.IsDigit(e.KeyChar)|| (e.KeyChar == '\r') || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = false;
        }

        //【安全登录】
        private void piboxLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql = "select count(*) from  tb_User where ID = " + int.Parse(txtID.Text.Trim()) + " and Pwd = " + txtPwd.Text.Trim() + "";

                int num = dataOper.ExecSQL(sql);

                if (num == 1)
                {
                    PublicClass.loginID = int.Parse(txtID.Text.Trim());

                    if (cboxRemeber.Checked)
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember = 1 where  ID = " + int.Parse(txtID.Text.Trim()));

                        if (cboxAutoLogin.Checked)

                            dataOper.ExecSQLResult("update tb_User set AutoLogin = 1 where  ID = " + int.Parse(txtID.Text.Trim()));
                    }
                    else
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember = 0 where  ID = " + int.Parse(txtID.Text.Trim()));

                        if (cboxAutoLogin.Checked)

                            dataOper.ExecSQLResult("update tb_User set AutoLogin = 0 where  ID = " + int.Parse(txtID.Text.Trim()));
                    }

                    dataOper.ExecSQLResult("update tb_User set Flag =1 where  ID = " + int.Parse(txtID.Text.Trim()));

                    Frm_Main frmMain = new Frm_Main();

                    frmMain.Show();

                    this.Visible = false;  //隐藏 登录窗体
                }

                else
                {
                    MessageBox.Show("输入的用户名 或密码错误！","登录提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                piboxLogin_Click(sender, e);
        }

        private void cboxAutoLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                piboxLogin_Click(sender, e);
        }

        private void cboxRemeber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                piboxLogin_Click(sender, e);
        }

        private void cboxRemeber_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxRemeber.Checked)
                cboxAutoLogin.Checked = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();

            try {
                string sql = "select  Pwd,Remember,AutoLogin from  tb_User where ID = " + int.Parse(txtID.Text.Trim()) + "";

                DataSet ds = dataOper.GetDataSet(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)
                    {
                        cboxRemeber.Checked = true;
                        txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                        {
                            cboxAutoLogin.Checked = true;
                            piboxLogin_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frmRegister = new Frm_Register();
            frmRegister.Show();
        }

        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }



































































}
