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


public partial class Controls_BackControl : System.Web.UI.UserControl
{





    //#region my properties


    private int _categoryID;
    public int CategoryID
    {
        get { return _categoryID; }
        set { CategoryID = value; }
    }

    //#endregion







    protected void Page_Load(object sender, EventArgs e)
    {
       
    }







}
