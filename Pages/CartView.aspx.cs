using System;
using System.Collections.Generic;
using GameStore.Models;
using GameStore.Pages.Helpers;

namespace Natural_Store.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        	
        }

        public IEnumerable<CartLine> GetCartLines()
        {
            return SessionHelper.GetCart(Session).Lines;
        }

        public decimal CartTotal
        {
            get
            {
                return SessionHelper.GetCart(Session).ComputeTotalValue();
            }
        }

        public string ReturnUrl
        {
            get
            {
                return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL);
            }
        }
    }
}