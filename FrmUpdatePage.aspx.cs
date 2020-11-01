using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _201533892NoticeBoard
{
    public partial class FrmUpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string writeId = Request.QueryString["wid"].ToString();

                SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                conn.Open();

                string selectSql = "select * from Member, Write where Member.userId = Write.userId and writeId = @writeId";
                SqlCommand cmd = new SqlCommand(selectSql, conn);

                cmd.Parameters.AddWithValue("@writeId", writeId);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                //Fill로 채운다
                da.Fill(ds, "Board");

                foreach (DataRow item in ds.Tables["Board"].Rows)
                {
                    title.Text = $"{item["title"].ToString()}";
                    body.Text = $"{item["body"].ToString()}";
                }

                conn.Close();
            }
        }

        protected void boardUpdate_Click(object sender, EventArgs e)
        {
            string writeId = Request.QueryString["wid"].ToString();

            Member mem = (Member)Session["user"];
            int userId = mem.getUserId();
            
            Write write = new Write(int.Parse(writeId), title.Text, body.Text, DateTime.Now, DateTime.Now, mem.getUserId());

            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string updateSql = "update Write set title=@title, body=@body where writeId=@writeId";
            SqlCommand cmd = new SqlCommand(updateSql, conn);

            cmd.Parameters.AddWithValue("@writeId", int.Parse(write.getWriteId().ToString()));
            cmd.Parameters.AddWithValue("@title", write.getTitle());
            cmd.Parameters.AddWithValue("@body", write.getBody());

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