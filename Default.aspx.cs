using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_PreInit()//run when the page is loaded
    {
        Debug.WriteLine("website started");// website started

        foreach (MenuItem item in Menu0.Items)
        {
            string temp = item.Text;
            item.Text = "<span class=\"menuItems\">" + temp + "</span>";//assign correct style
        }
    }



    protected void Menu0_MenuItemClick(object sender, EventArgs e)
    {
        Menu menu = (Menu)sender;//type cast sender from Object to Menu
        MenuItem curr_item = menu.SelectedItem;
        
        int index = Convert.ToInt32(curr_item.Value); //retrieve curr index
        MultiView0.ActiveViewIndex = index; //change the current view index

        AdjustMenuImageUrl(menu);
       // OffsetMenuItemText(menu);
        ChangeSectionColor(curr_item);//change the color of the section associated with the current menu item

               
    }

    public void OffsetMenuItemText(Menu menu)
    {
        MenuItem curr_item = menu.SelectedItem;

        Debug.WriteLine(curr_item.Text);                    
        string text = curr_item.Text;
        curr_item.Text = "<span class=\"@menuItemSlct$\">" + text+ "</span>";//assign correct style to curr menu item


     }

    public void AdjustMenuImageUrl(Menu menu) //convert color to hex code
    {
        MenuItem curr_item = menu.SelectedItem;

        string path = curr_item.ImageUrl; //rertrieve image path
        int stringpos = path.IndexOf("_");
        string path_root = path.Substring(0, stringpos+1);
       
        curr_item.ImageUrl = path_root + "slct.png";

        foreach (MenuItem item in menu.Items)
        {
            if (item.Value != menu.SelectedItem.Value)
            {
                path = item.ImageUrl; //rertrieve image path
                stringpos = path.IndexOf("_");
                path_root = path.Substring(0, stringpos + 1);
                item.ImageUrl = path_root + "unslct.png"; //reset other tabs to unselected image
            }
        }
    }

    private void ChangeSectionColor(MenuItem curr_item) //convert color to hex code
    {
        var path = Server.MapPath(curr_item.ImageUrl);// turn the ~/ portion of the path in to the real location it resildes on your hard drive.

        byte[] bmData = new WebClient().DownloadData(path); //DownloadData function from
        MemoryStream stream = new MemoryStream(bmData);
        System.Drawing.Bitmap bm = (Bitmap)System.Drawing.Bitmap.FromStream(stream);
        stream.Close();

        Color color = bm.GetPixel(0, bm.Height/2);

        section1.Style["Background-Color"] = HexConverter(color);
    }



    private static String HexConverter(System.Drawing.Color c) //convert color to hex code
    {
        return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
    }


}



