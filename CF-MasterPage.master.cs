using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CF_MasterPage : System.Web.UI.MasterPage
{

    #region my properties

    private int _categoryID;
    public int CategoryID
    {
        get { return _categoryID; }
        set { _categoryID = value; }
    }


    private int _id;
    public int id
    {
        get { return _id; }
        set { id = value; }
    }


    #endregion




    #region Google-fy section that WAS in Web.aspx, the page that uses this control

    public string googlefy()
    {
        if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] != null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);
            _id = Int32.Parse(Request.QueryString["cid"]);

            string title = Webica.Articles.getWebArticlePageTitle(CategoryID, id);
            return title;
        }


        if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] == null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

            string title = Webica.Articles.getWebArticlePageTitle(CategoryID);
            return title;
        }

        string CF = Resources.Home.Title;

            
            
        //    "Gay Gran Canaria Best prices and places here. Cafe Gay Florin has cheapest holiday accommodation hotels apartments and bungalows from Cafe Gay Florin based in Playa del Ingles ";
        // return string.Empty;
        return CF;



    }



    protected override void Render(System.Web.UI.HtmlTextWriter writer)
    {

        //	writer.Write("<HTML><HEAD><TITLE>Time for some joined-up thinking......    -    John Mulkearns - Webica.NET and </TITLE></HEAD><BODY>"); 

        writer.Write("<HTML><HEAD><TITLE>" + googlefy() + "</TITLE></HEAD><BODY>");
        base.Render(writer);
        writer.Write("</BODY></HTML>");

    }


    #endregion





    public string URLforFaceBook()
    {
        if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] != null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);
            _id = Int32.Parse(Request.QueryString["cid"]);

            string title = Webica.Articles.getWebArticlePageTitle(CategoryID, id);
            string url = "http://www.cafeflorin.com/" + title + "_" + (Request.QueryString["CategoryID"]) + "_" + (Request.QueryString["cid"] + ".aspx");

            return url;
        }


        if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] == null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

            string title = Webica.Articles.getWebArticlePageTitle(CategoryID);
            return title;
        }
        string PDI = "The best little Cafe Bar in Gran Canaria has more to offer you on holiday than you would believe";
        // return string.Empty;
        string url2 = "http://www.cafeflorin.com/" + PDI + "_" + (Request.QueryString["CategoryID"]) + "_" + (Request.QueryString["cid"] + ".aspx");
        return url2;

    }



    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
}
