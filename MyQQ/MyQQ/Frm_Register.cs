using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }

        private void grpBaseInfo_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            cmb_star.SelectedIndex = cmb_blood.SelectedIndex = 0;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (txtNick.Text.Trim() == "" || txtNick.Text.Length > 20)
            {
                MessageBox.Show("昵称输入有误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtNick.Focus();
                return;
            }

            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("年龄输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return;
            }

            if (!sex_male.Checked && !sex_female.Checked)
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lab_sex.Focus();
                return;
            }

            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }
            if (txtAPwd.Text.Trim() == "" )
            {
                MessageBox.Show("请再次输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAPwd.Focus();
                return;
            }

            if (txtAPwd.Text.Trim() != txtPwd.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不同!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAPwd.Focus();
                return;
            }

            int myQQNum = 0;
            string message;
            string sex = sex_male.Checked ? sex_male.Text : sex_female.Text;
            string sql = string.Format(" insert into tb_User (Pwd ,NickName ,Sex,Age ,Name ,Star, BloodType) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'); select @@Identity from tb_User",
                txtPwd.Text.Trim(),txtNick.Text.Trim(),sex, int.Parse(txtAge.Text.Trim()),txt_name.Text.Trim(),cmb_star.Text,cmb_blood.Text);
            SqlCommand command = new SqlCommand(sql,DataOperator.connection);
            DataOperator.connection.Open();
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                sql = "select SCOPE_IDENTITY() from  tb_User";
                command = new SqlCommand(sql, DataOperator.connection);
                myQQNum = Convert.ToInt32(command.ExecuteScalar());
                message = string.Format("注册成功！ 你的qq号码是" + myQQNum);
            }
            else
            {
                message = "注册失败，请重试！";
            }
            DataOperator.connection.Close();
            MessageBox.Show(message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
