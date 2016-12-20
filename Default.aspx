<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link href="Stylesheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div id="section0">
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="title0" runat="server" Text="Projet Huile d'Olive Portuguaise"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu0" runat="server" Orientation="Horizontal" StaticEnableDefaultPopOutImage="False" OnMenuItemClick="Menu0_MenuItemClick">
         <Items>
        <asp:MenuItem ImageUrl="~/assets/tab0_unslct.png"
                      Text="about us" Value="0"></asp:MenuItem>
        <asp:MenuItem ImageUrl="~/assets/tab1_unslct.png" 
                      Text="shop" Value="1"></asp:MenuItem>
        <asp:MenuItem ImageUrl="~/assets/tab2_unslct.png" 
                      Text="contact" Value="2" >
           
        </asp:MenuItem>
        </Items>
        </asp:Menu>
        <div runat="server" id="section1">
        <asp:MultiView ID="MultiView0" runat="server" ActiveViewIndex ="0">
          <%--View0----------------------------------------------------------------------------------------%>
              <asp:View ID="View0" runat="server">
              <table>
              <tr>
                <td class="TabArea" style="height: 2000px">
                    <br />
                    <br />
                    TAB VIEW 0
                    INSERT YOUR CONENT IN HERE
                    CHANGE SELECTED IMAGE URL AS NECESSARY
                </td>
            </tr>
             </table>
            </asp:View>
          <%--View1----------------------------------------------------------------------------------------%>
            <asp:View ID="View1" runat="server">
                  <table>
              <tr>
                <td class="TabArea" style="height: 2000px">
                    <br />
                    <br />
                    TAB VIEW 1
                    INSERT YOUR CONENT IN HERE
                    CHANGE SELECTED IMAGE URL AS NECESSARY
                </td>
            </tr>
             </table>
            </asp:View>
             <%--View2----------------------------------------------------------------------------------------%>
            <asp:View ID="View2" runat="server">
                     <table>
              <tr>
                <td class="TabArea" style="height: 2000px">
                    <br />
                    <br />
                    TAB VIEW 2
                    INSERT YOUR CONENT IN HERE
                    CHANGE SELECTED IMAGE URL AS NECESSARY
                </td>
            </tr>
             </table>
            </asp:View>
        </asp:MultiView>
       </div>
    </form>
    </div>
</body>
</html>
