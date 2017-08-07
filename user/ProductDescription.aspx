<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.master" AutoEventWireup="true" CodeFile="ProductDescription.aspx.cs" Inherits="user_ProductDescription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" Runat="Server">
     <asp:Repeater ID="d1" runat="server">
        <HeaderTemplate>
            
        </HeaderTemplate>
        <ItemTemplate>
                <div style="height: 300px; width: 600px; border-style: solid; border-width: 1px; ">
                    <div style="height: 300px; width: 200px; float: left; border-style: solid; border-width: 1px;">
                        <img src="../<%#Eval("product_image") %>" height="300px" width="200px"/>
                    </div>
                    <div style="height: 300px; width: 395px; float: left;border-style: solid; border-width: 1px; ">
                        Item Name = <%#Eval("product_name") %> <br/>
                        Product Description = <%#Eval("product_description") %><br/>
                        Product Price = <%#Eval("product_price") %> <br/>
                        Product Quantity = <%#Eval("product_qty") %>

                    </div>
                </div>  
        </ItemTemplate>
        <FooterTemplate>
            
        </FooterTemplate>
    </asp:Repeater>
    <br/>
    <asp:Button ID="b1" runat="server" Text="Add to Cart" OnClick="b1_Click"/>
</asp:Content>

