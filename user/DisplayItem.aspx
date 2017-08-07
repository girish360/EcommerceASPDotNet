<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="DisplayItem.aspx.cs" Inherits="user_DisplayItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
    <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            
                <li class="last">
                    <a href="ProductDescription.aspx?id=<%#Eval("id") %>"><img src="../<%#Eval("product_image") %>" alt=""/></a>
                    <div class="product-info">
                        <h3><%#Eval("product_name") %></h3>
                        <div class="product-desc">
                            <h4>Available Quantity: <%#Eval("product_qty") %></h4>
                            <p><%#Eval("product_description") %> </p>
                            <strong class="price">$<%#Eval("product_price") %></strong>
                        </div>
                    </div>
                </li>
            
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

