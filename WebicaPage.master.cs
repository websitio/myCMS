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

public partial class WebicaPage : System.Web.UI.MasterPage
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

        string CF = "Maspalomas celebrates after GAY PRIDE 2010 acclaimed across the World, felicitaciones orgullo Gay";
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












    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
