using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Db1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ThucHanhC#\Db1\Db1\App_Data\Database1.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "select * from LOAIHANG";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.rbList.DataSource = dt;
                this.rbList.DataTextField = "Tenloai";
                this.rbList.DataValueField = "Maloai";
                this.rbList.DataBind();

                this.DropDownList1.DataSource = dt;
                this.DropDownList1.DataTextField = "Tenloai";
                this.DropDownList1.DataValueField = "Maloai";
                this.DropDownList1.DataBind();
                this.DropDownList1.DataSource = dt;

                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void rbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            String MaLoai = this.rbList.SelectedItem.Value;
            Context.Items["ml"] = MaLoai;
            Server.Transfer("MatHang.aspx");

        }
    }
}