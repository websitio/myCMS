#region using

using System;
using System.Web.UI;
using Webica;
#endregion


public partial class Web : BasePage

{


    #region protecteds'
    //protected System.Web.UI.WebControls.PlaceHolder PlaceHolder2;
    //protected System.Web.UI.WebControls.Button Button1;
    //protected System.Web.UI.WebControls.Button btn;
    //protected System.Web.UI.WebControls.Button btn2;
    //protected System.Web.UI.WebControls.Label Label1;
    //protected System.Web.UI.WebControls.PlaceHolder PlaceHolder1;

    #endregion

    //#region my properties


    private int _categoryID;
    public int CategoryID
    {
        get { return _categoryID; }
        set { CategoryID = value; }
    }

    //#endregion


    private void Page_Load(object sender, System.EventArgs e)
    {


        populatRepeater2();
       
    }

    public Web()
    {
        Page.Init += new System.EventHandler(Page_Init);

    }


    private void Page_Init(object sender, EventArgs e)
    {
        if (PlaceHolder1.Controls.Count < 2)
        {
            LoadUserControl("BackControl.ascx");
            LoadUserControl("UIContent.ascx");
            //             LoadUserControl("BoxAdsControl.ascx");
            LoadUserControl("Menu.ascx");




            //  if (Request.QueryString["CategoryID"] != "16")
            //  { LoadUserControl("Products_Books.ascx"); }

            //                 LoadUserControl("TranslatorControl.ascx");


            //     The logic is any number between 2 and 15, i.e  not for Category 1 Button for all others up to but not higher than 15
            // note that categories 16, 17 & 18 are assigned to APARTMENTS BUGALOWS and HOTELSL respectively.

            if (Request.QueryString["CategoryID"] != null)
            {
                if (Int32.Parse(Request.QueryString["CategoryID"]) > 1.5 && Int32.Parse(Request.QueryString["CategoryID"]) < 15.5)
                { LoadUserControl("Products_Books.ascx"); }
            }






            

            //   if (Request.QueryString["CategoryID"] == "17")
            //   {
            //       LoadUserControl("BoxAccommodationControl.ascx");
            //       LoadUserControl("Bungalows.ascx");

            //   }



            
        }

    

    }








    public void ExtraControl()
    {
        if (Request.QueryString["CategoryID"] == "7")
        {
            // _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

            LoadUserControl("WebUserControl9.ascx");

            // HideControl("Bungalows.ascx");
        }

    }




    private void LoadFeature(string UCname)
    {
        Control c1 = LoadControl("Features\\" + UCname);

        PlaceHolder1.Controls.Add(c1);
        c1.ID = UCname;
    }






    private void LoadUserControl(string UCname)
    {
        Control c1 = LoadControl("Controls\\" + UCname);

        PlaceHolder1.Controls.Add(c1);
        c1.ID = UCname;
    }


    private void unLoadUserEditControl(string UCname)
    {

        Control c1 = (Control)this.FindControl(UCname);
        if (c1 != null)
        {
            //    c1 = unLoadControl("controls\\" + UCname);
            PlaceHolder1.Controls.Remove(c1);
        }


    }




    private void HideControl(string UCname)
    {

        Control c1 = (Control)this.FindControl(UCname);
        if (c1 != null)
        {
            c1.Visible = false;
        }

    }


    #region
    //public override string StyleSheetTheme
    //{
    //    get
    //    {
    //        return base.StyleSheetTheme;
    //    }
    //    set
    //    {
    //        base.StyleSheetTheme = "pdi.css";
    //    }
    //}
    #endregion


    #region Web Form Designer generated code
    override protected void OnInit(EventArgs e)
    {
        //
        // CODEGEN: This call is required by the ASP.NET Web Form Designer.
        //
        InitializeComponent();
        base.OnInit(e);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        //this.btn.Click += new System.EventHandler(this.btn_Click);
        //this.btn2.Click += new System.EventHandler(this.btn2_Click);
        this.Load += new System.EventHandler(this.Page_Load);

    }
    #endregion

    //private void btn_Click(object sender, System.EventArgs e)
    //{
    //    unLoadUserEditControl("SelectWebApp.ascx");
    //    LoadUserControl("WebArticlesPrevious.ascx");
    //    LoadUserControl("WebArticle.ascx");


    //    btn.Text = "Remove Editor";
    //}



    //private void btn2_Click(object sender, System.EventArgs e)
    //{

    //    //WebicaModule.controls.WebArticle wa =(WebicaModule.controls.WebArticle)Page.FindControl("WebArticle.ascx");
    //    //            if(PlaceHolder1.Controls.Contains(wa))
    //    //            {	PlaceHolder1.Controls.Remove(wa);	
    //    //            wa.Dispose();}
    //    //// unLoadUserEditControl

    //}

    //protected void btn_Click1(object sender, EventArgs e)
    //{
    //    unLoadUserEditControl("SelectWebApp.ascx");
    //    LoadUserControl("WebArticlesPrevious.ascx");

    //}


    private void populatRepeater2()
    {

        if (Request.QueryString["CategoryID"] != null)
        {
            _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

            Articles History = new Articles();
            Repeater2.DataSource = History.getArticlesPreviousTitles(CategoryID);
            Repeater2.DataBind();

        }

        if (Request.QueryString["CategoryID"] == null)
        {

            Articles History = new Articles();
            Repeater2.DataSource = History.getArticlesPreviousTitles(1);
            Repeater2.DataBind();

        }

    }




}

