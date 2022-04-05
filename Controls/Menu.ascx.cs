using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Webica;


public partial class Controls_Menu : System.Web.UI.UserControl
{






    protected void Page_Load(object sender, EventArgs e)
    {
        ListController();
  //      populatRepeater2();
    }


    private void ListController()
    {
        Webica.Articles a = new Webica.Articles();
        Repeater1.DataSource = a.WebAppTypes();
        Repeater1.DataBind();
    //    Repeater2.DataSource = a.WebArts3Top();
  //      Repeater2.DataBind();
    }



    private void Repeater1_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
    {


        if ((e.Item.ItemType == ListItemType.Item) || (e.Item.ItemType == ListItemType.AlternatingItem))
        {

            HyperLink hl = (HyperLink)Repeater1.FindControl("HyperLink1");
            if (Repeater1.Controls.Contains(hl))
            {
                string a = String.Empty;
                Response.Write("alo");
            }
        }
        
    }











}
