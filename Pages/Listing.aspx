<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="Natural_Store.Pages.Listing"
    MasterPageFile="~/Pages/Store.Master" %>
<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
        <%
            foreach (Natural_Store.Models.StoreItem storeItem in GetStoreItems())
            {
                Response.Write(String.Format(@"
                        <div class='item'>
                            <h3>{0}</h3>
                            {1}
                            <h4>{2:c}</h4>
                            <button name='add' type='submit' value='{3}'>
                                Добавить в корзину
                            </button>
                        </div>",
                    storeItem.Name, storeItem.Description, storeItem.Price, storeItem.StoreItemId));
            }
        %>
    </div>
    <div class="pager">
        <%
            for (int i = 1; i <= MaxPage; i++)
            {
                string category = (string)Page.RouteData.Values["category"]
                    ?? Request.QueryString["category"];
                
                string path = RouteTable.Routes.GetVirtualPath(null, null,
                    new RouteValueDictionary() { {"category", category}, { "page", i } }).VirtualPath;
                Response.Write(
                    String.Format("<a href='{0}' {1}>{2}</a>",
                        path, i == CurrentPage ? "class='selected'" : "", i));
            }
        %>
    </div>
</asp:Content>
