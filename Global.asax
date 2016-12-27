<%@ Application Language="C#" %>
<%@ Import Namespace="System.Data.Entity" %>
<%@ Import Namespace="WebSite1.App_Code.Models" %>


<script runat="server">

    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {

            // Initialize the product database.
            Database.SetInitializer(new ProductDatabaseInitializer());

        }
    }


</script>
