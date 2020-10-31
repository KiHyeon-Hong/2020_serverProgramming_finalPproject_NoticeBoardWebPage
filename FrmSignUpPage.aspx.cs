using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _201533892NoticeBoard
{
    public partial class FrmSignUpPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i <= 12; i++)
                    birthMon.Items.Add(new ListItem(i.ToString(), i.ToString()));

                for (int i = 1; i <= 31; i++)
                    birthDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            Member mem = new Member(0, id.Text, pwd.Text, userName.Text, int.Parse(birthMon.Text), int.Parse(birthDay.Text), phoneNum.Text, int.Parse(alarm.SelectedValue));

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string insertSql = "insert into Member(id, pwd, userName, birthMon, birthDay, phoneNum, alarm) values(@id, @pwd, @userName, @birthMon, @birthDay, @phoneNum, @alarm)";
            SqlCommand cmd = new SqlCommand(insertSql, conn);

            cmd.Parameters.AddWithValue("@id", mem.getId());
            cmd.Parameters.AddWithValue("@pwd", mem.getPwd());
            cmd.Parameters.AddWithValue("@userName", mem.getUserName());
            cmd.Parameters.AddWithValue("@birthMon", mem.getBirthMon());
            cmd.Parameters.AddWithValue("@birthDay", mem.getBirthDay());
            cmd.Parameters.AddWithValue("@phoneNum", mem.getPhoneNum());
            cmd.Parameters.AddWithValue("@alarm", mem.getAlarm());

            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("~/FrmLoginPage.aspx");
        }
    }
}