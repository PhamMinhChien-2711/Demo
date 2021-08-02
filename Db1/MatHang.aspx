<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="Db1.MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="653px">
                <Columns>
                  
                    <asp:TemplateField HeaderText="Hình Ảnh">
                       
                        <ItemTemplate >
                            <asp:Image ID="Image1" ImageUrl='<%# "~/images/"+Eval("Hinh")%>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField >
                  
                    <asp:BoundField DataField="TenSp" HeaderText="Tên Hàng" />
                    <asp:BoundField DataField="MoTa" HeaderText="Mô Tả" />
                    <asp:BoundField DataField="Gia" HeaderText="Đơn Giá" />
                </Columns>
            </asp:GridView>

    </form>
</body>
</html>
