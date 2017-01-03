using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Diagnostics;
using Models;
using System.Data.Entity;

namespace oliveoilwebapp
{

    public class Global : System.Web.HttpApplication
    {
        public int index_ActivePage = 0;

        protected void Application_Start(object sender, EventArgs e)
        {
            Debug.WriteLine("Global started");
            // Initialize the product database.
            Database.SetInitializer(new ProductDatabaseInitializer());
        }

    }
}

