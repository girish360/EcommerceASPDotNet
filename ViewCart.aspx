﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="ViewCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="b1" Text="View Cart" OnClick="b1_Click" runat="server"/>
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><img src="<%#Eval("product_image") %>" height="100" width="100"/></td>
                    <td><%#Eval("product_name") %></td>
                    <td><%#Eval("product_description") %></td>
                    <td><%#Eval("product_price") %></td>
                    <td><%#Eval("product_qty") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>