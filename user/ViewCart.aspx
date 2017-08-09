<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="ViewCart.aspx.cs" Inherits="user_ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
    <div>
       
        <asp:DataList ID="d1" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><img src="../<%#Eval("product_image") %>" height="100" width="100"/></td>
                    <td><%#Eval("product_name") %></td>
                    <td><%#Eval("product_description") %></td>
                    <td><%#Eval("product_price") %></td>
                    <td><%#Eval("product_qty") %></td>
                    <td><a href="deleteCart.aspx?id=<%#Eval("id") %>"> Delete </a></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:DataList>
    </div>
</asp:Content>