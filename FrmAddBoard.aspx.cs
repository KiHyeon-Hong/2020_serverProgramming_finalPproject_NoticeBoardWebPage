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
    public partial class FrmAddBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void boardStore_Click(object sender, EventArgs e)
        {
            Member mem = (Member)Session["user"];
            int userId = mem.getUserId();

            Write write = new Write(0, title.Text, body.Text, DateTime.Now, DateTime.Now, mem.getUserId());

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string insertSql = "insert into Write(title, body, createDay, updateDay, userId) values(@title, @body, @createDay, @updateDay, @userId)";
            SqlCommand cmd = new SqlCommand(insertSql, conn);

            cmd.Parameters.AddWithValue("@title", write.getTitle());
            cmd.Parameters.AddWithValue("@body", write.getBody());
            cmd.Parameters.AddWithValue("@createDay", write.getCreateDay());
            cmd.Parameters.AddWithValue("@updateDay", write.getUpdateDay());
            cmd.Parameters.AddWithValue("@userId", write.getUserId());

            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("~/FrmMainPage.aspx");
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FrmMainPage.aspx");
        }
    }
}