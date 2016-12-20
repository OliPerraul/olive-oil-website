using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_PreInit()
    {
        Debug.WriteLine("website started");// website started

        foreach (MenuItem item in Menu0.Items )
        {
            string temp = item.Text;
            item.Text = "<span class=\"menuItems0\">"+temp+"</span>";//assign correct style
         }
     }
 


    protected void Menu0_MenuItemClick(object sender, EventArgs e)
    {
        Menu menu =(Menu) sender;//type cast sender from Object to Menu
        int index =Convert.ToInt32(menu.SelectedItem.Value); //retrieve curr index
        menu.SelectedItem.ImageUrl = "~/assets/SelectedButton.png";
        MultiView0.ActiveViewIndex = index; //change the current view index

        foreach (MenuItem item in menu.Items)
        {
            if (item.Value != menu.SelectedItem.Value)
                item.ImageUrl = "~/assets/InitialImage.png"; //reset other tabs to unselected image

        }
    }

  
}