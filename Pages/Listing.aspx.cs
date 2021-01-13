using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Natural_Store.Models;
using Natural_Store.Models.Repository;
using System.Web.Routing;

namespace Natural_Store.Pages
{
    public partial class Listing : Page
    {
        private Repository repository = new Repository();
        private int pageSize = 4;
        protected int CurrentPage
        {
            get
            {
                int page;
                page = int.TryParse(Request.QueryString["page"], out page) ? page : 1;
                return page > MaxPage ? MaxPage : page;
            }
        }
        protected int MaxPage
        {
            get
            {
                return (int)Math.Ceiling((decimal)repository.StoreItems.Count() / pageSize);
            }
        }
        private int GetPageFromRequest()
        {
            int page;
            string reqValue = (string)RouteData.Values["page"] ??
                Request.QueryString["page"];
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }

        protected IEnumerable<StoreItem> GetStoreItems()
        {
            return repository.StoreItems
                .OrderBy(g => g.Id)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}