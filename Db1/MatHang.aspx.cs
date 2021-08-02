using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Db1
{
    public partial class MatHang : System.Web.UI.Page
    {
        String cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ThucHanhC#\Db1\Db1\App_Data\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            String maloai = Context.Items["ml"].ToString();
            SqlConnection con = new SqlConnection(cnn);
            try
            {
                con.Open();
                string query = "select * from SANPHAM where Maloai='" + maloai + "'";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                this.GridView1.DataSource = reader;
                this.GridView1.DataBind();

            }
            catch(SqlException err)
            {
                Response.Write("<b>Lỗi</b>" + err.Message + "<p/>");
            }
            finally { con.Close(); }
        }
    }
}