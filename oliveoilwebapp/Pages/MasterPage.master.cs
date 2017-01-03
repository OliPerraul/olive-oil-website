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
using oliveoilwebapp;

using Models;


public partial class MasterPage : System.Web.UI.MasterPage
{
    List<string> urlList = new List<string>(); //url list


    protected void Page_Load(object sender, EventArgs e) //page load event 
    {

    }

    protected void Page_Init()//run when the page is loaded
    {
        foreach (MenuItem item in Menu0.Items)
        {

            string temp = item.Text;
            item.Text = "<span class=\"menuItems\">" + temp + "</span>";//assign correct style

        }

        Menu0_init();//init menu buttons

    }

    void Menu0_init()
    {
        int index = ((Global)HttpContext.Current.ApplicationInstance).index_ActivePage;
        MultiView0.ActiveViewIndex = index;
        MenuItem curr_item = Menu0.Items[index];

        foreach(MenuItem item in Menu0.Items)//check for correct curr item
        {
            urlList.Add(item.NavigateUrl); //add nav url to the list
            item.NavigateUrl = ""; //clear out the navigate url to make sure the click event is fired
       }

        


        AdjustMenuImageUrl(curr_item); //adjust button images
        ChangeSectionColor(curr_item);//change the color of the section associated with the current menu item

    }


    protected void Menu0_MenuItemClick(object sender, EventArgs e)
    {
        Menu menu = (Menu)sender;//type cast sender from Object to Menu
        MenuItem curr_item = menu.SelectedItem;

        int index = Convert.ToInt32(curr_item.Value); //retrieve curr index
        ((Global)HttpContext.Current.ApplicationInstance).index_ActivePage = index; //change curr page index

    
        string link = urlList[index];//get url from the list
        Response.Redirect(link);// go there

    }

    public void OffsetMenuItemText(Menu menu)
    {
        MenuItem curr_item = menu.SelectedItem;

        Debug.WriteLine(curr_item.Text);
        string text = curr_item.Text;
        curr_item.Text = "<span class=\"@menuItemSlct$\">" + text + "</span>";//assign correct style to curr menu item


    }

    public void AdjustMenuImageUrl(MenuItem curr_item) //convert color to hex code
    {
        string path = curr_item.ImageUrl; //rertrieve image path
        int stringpos = path.IndexOf("_");
        string path_root = path.Substring(0, stringpos + 1);

        curr_item.ImageUrl = path_root + "slct.png";

     }

    private void ChangeSectionColor(MenuItem curr_item) //convert color to hex code
    {
        var path = Server.MapPath(curr_item.ImageUrl);// turn the ~/ portion of the path in to the real location it resildes on your hard drive.

        byte[] bmData = new WebClient().DownloadData(path); //DownloadData function from
        MemoryStream stream = new MemoryStream(bmData);
        System.Drawing.Bitmap bm = (Bitmap)System.Drawing.Bitmap.FromStream(stream);
        stream.Close();

        Color color = bm.GetPixel(0, bm.Height / 2);

        section_multiview.Style["Background-Color"] = HexConverter(color);
    }



    private static String HexConverter(System.Drawing.Color c) //convert color to hex code
    {
        return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
    }


}