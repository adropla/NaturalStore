<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="Natural_Store.Pages.Listing"
    MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
        <%
            Response.Write(
                "<span>123123</span>");
            foreach (Natural_Store.Models.StoreItem storeItem in GetStoreItems())
            {
                Response.Write(String.Format(@"
                    <div class='item'>
                        <h3>{0}</h3>
                        {1}
                        <h4>{2:c}</h4>
                    </div>",
                    storeItem.Name, storeItem.Description, storeItem.Price));
            }
        %>
    </div>
    <div class="pager">
        <%
            for (int i = 1; i <= MaxPage; i++)
            {
                Response.Write(
                    String.Format("<a href='/Pages/Listing.aspx?page={0}' {1}>{2}</a>",
                        i, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</asp:Content>
