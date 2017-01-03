<%@ Page Language="C#" AutoEventWireup="true" Inherits="ShopPage" MasterPageFile ="~/Pages/MasterPage.master" Codebehind="ShopPage.aspx.cs" %>

<asp:Content runat="server" ID="content" ContentPlaceHolderId="content_shop">

        <h2>Wingtip Toys can help you find the perfect gift.</h2>
        <p class="lead">We're all about transportation toys. You can order 
                any of our toys today. Each toy listing has detailed 
                information to help you choose the right toy.</p>
    <p class="lead">&nbsp;</p>

   
        <div id="CategoryMenu" style="text-align: center">       
            <asp:ListView ID="categoryList"  
                ItemType="Models.Category" 
                runat="server"
                SelectMethod="GetCategories" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <a href="ProductList.aspx?id=<%#: Item.CategoryID %>">
                        <%#: Item.CategoryName %>
                        </a>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
            </asp:ListView>
 

       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
       <p class="lead">&nbsp;</p>
    
</asp:Content>