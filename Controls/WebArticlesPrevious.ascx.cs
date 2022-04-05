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


public partial class Controls_WebArticlesPrevious : System.Web.UI.UserControl
{
    private int _categoryID;
    public int CategoryID
    {
        get { return _categoryID; }
        set { CategoryID = value; }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        populatGrid();
    }




    private void populatGrid()
    {

        if (Request.QueryString["CategoryID"] != null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

            Articles History = new Articles();
            GridView1.DataSource = History.getArticlesPreviousTitles(CategoryID);
            GridView1.DataBind();
            getPageName(_categoryID);
        }

        else
        {
            Articles History = new Articles();
            GridView1.DataSource = History.getArticlesPreviousTitles(1);
            GridView1.DataBind();
            getPageName(1);
        }






    }



    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        populatGrid();
    }
    
    
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        String atitle = e.Row.Cells[0].Text.ToString();
        e.Row.Cells[0].Attributes.Add("title", atitle);


        //if ((e.Row.RowType == DataControlRowType.DataRow))
            
        //    {

        //    String title = e.Row.Cells[0].Text.ToString();
        //    e.Row.Cells[0].Attributes.Add("title", title);
        //    #region old way
        //    //if ((e.Row.RowType == ListItemType.Item) || (e.Row.RowType == ListItemType.AlternatingItem))
        ////{
            
        ////    String title = e.Row.Cells[0].Text.ToString();
        //    //    e.Row.Cells[0].Attributes.Add("title", title);
        //    #endregion
            
        //}


        

    }







    public void getPageName(int CategoryID)
    {

        if (Request.QueryString["CategoryID"] != null)
        { CategoryID = Int32.Parse(Request.QueryString["CategoryID"]); }

        Articles content = new Articles();
        if (CategoryID > -0.5)
        {
          Label1.Text = content.getPageName(CategoryID);

        }
    }








}           //eoc
