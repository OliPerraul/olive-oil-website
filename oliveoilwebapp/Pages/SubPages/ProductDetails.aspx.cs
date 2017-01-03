using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Web.ModelBinding;
using System.Diagnostics;

public partial class ProductDetails : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<Product> GetProduct( [QueryString("ProductID")] int? productId, [RouteData] string productName)
    {
      var _db = new Models.ProductContext(); //skims off the query of all products except the matching ID one.
      IQueryable<Product> query = _db.Products;
        if (productId.HasValue && productId > 0)
        {
            query = query.Where(p => p.ProductID == productId);
        }
        else if (!String.IsNullOrEmpty(productName))
        {
            query = query.Where(p => String.Compare(p.ProductName, productName) == 0);
            //Compares two specified String objects and returns an
            //integer that indicates their relative position in the sort order.
            //if string.compare()== 0,  strA occurs in the same position as strB in the sort order. 
        }
        else
        {
            query = null;
        }

        return query;
    }
  }
