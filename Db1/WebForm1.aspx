    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Db1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="rbList" runat="server" CssClass="auto-style1" AutoPostBack="True" OnSelectedIndexChanged="rbList_SelectedIndexChanged"></asp:RadioButtonList>
           
            Loại hàng: <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" Width="344px"></asp:DropDownList>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("TenLoai")%>'></asp:HyperLink>
                </ItemTemplate>

            </asp:DataList>
        </div>
    </form>
</body>
</html>
    