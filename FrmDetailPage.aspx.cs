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
    public partial class FrmDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
        }

        protected void boardUpdate_Click(object sender, EventArgs e)
        {
            string writeId = Request.QueryString["wid"].ToString();

            Response.Redirect("~/FrmUpdatePage.aspx?wid=" + writeId);
        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FrmMainPage.aspx");
        }
    }
}