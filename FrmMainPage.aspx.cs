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
    public partial class FrmMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            conn.Open();

            string selectSql = "select * from Member, Write where Member.userId = Write.userId";
            SqlCommand cmd = new SqlCommand(selectSql, conn);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Fill로 채운다
            da.Fill(ds, "BoardList");

            string myBoard =
                "<table border=\"1\" style=\"width: 100 %; \">" +
                    "<tr>" +
                        "<td>" +
                            "제목" +
                        "</td>" +
                        "<td>" +
                            "작성자" +
                        "</td>" +
                        "<td>" +
                            "작성 날짜" +
                        "</td>" +
                    "</tr>";

            foreach (DataRow item in ds.Tables["BoardList"].Rows)
            {
                myBoard +=
                    $"<tr>" +
                        $"<td>" +
                            //$"{item["title"].ToString()}" +
                            $"<a href='FrmDetailPage.aspx?wid={item["writeId"].ToString()}'>{item["title"].ToString()}</a>" +
                        $"</td>" +
                        $"<td>" +
                            $"{item["userName"].ToString()}" +
                            //"<asp:TextBox ID=\"test\" runat=\"server\"></asp:TextBox>" +
                            //"<a href='www.naver.com'>test</a>" +
                        $"</td>" +
                        $"<td>" +
                            $"{item["createDay"].ToString()}" +
                        $"</td>" +
                    $"</tr>";
            }

            myBoard += "</table>";

            board.Text = myBoard;
        }

        protected void addBoard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FrmAddBoard.aspx");
        }
    }
}