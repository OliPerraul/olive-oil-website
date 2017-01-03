using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Models;
using System.Diagnostics;

public partial class ShopPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    public IQueryable<Category> GetCategories()
    {
        Debug.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        var _db = new Models.ProductContext();
        IQueryable<Category> query = _db.Categories;
        return query;
    }
}
