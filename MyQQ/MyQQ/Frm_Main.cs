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
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        int fromUserID;  //消息发送者
        int friendHeadID; //发消息好友的头像ID
        int messageImageIndex = 0;
        public static string nickName = "";
        public static string strFlag = "[离线]";
        DataOperator dataOper = new DataOperator();

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ShowInfo();
            ShowFriendList();
        }

        public void ShowInfo()
        {
            int headID = 0;
            string sql = "select NickName,HeadID,Sign from tb_User  where  ID ="+PublicClass.loginID +"";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            if (dataReader.Read())
            {
                if (!(dataReader["NickName"] is DBNull))
                {
                    nickName = dataReader["NickName"].ToString();
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);
                txtSign.Text = dataReader["Sign"].ToString();
            }
            dataReader.Close();
            DataOperator.connection.Close();
            this.Text = PublicClass.loginID.ToString();
            pbxHead.Image = imageListHead.Images[headID];
            lblName.Text = nickName + "(" + PublicClass.loginID + ")";
        }

        public void ShowFriendList()
        {
            lvFriend.Items.Clear();
            string sql = "select  FriendID,NickName,HeadID,Flag from tb_User,tb_Friend  where  tb_Friend.HostID =" + PublicClass.loginID + " and tb_User.ID = tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);
            int i = lvFriend.Items.Count;
            while (dataReader.Read())
            {
                if (dataReader["Flag"].ToString() == "0")
                {
                    strFlag = "[离线]";
                }
                else
                {
                    strFlag = "[在线]";
                }
                string strTemp = dataReader["NickName"].ToString();
                string strFriendName = strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');

                lvFriend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[0];
                i++;
            }
            dataReader.Close();
            DataOperator.connection.Close();
        }
    }
}
