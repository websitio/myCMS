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
using visual = System.Web.UI.WebControls.Image;



public partial class Controls_UIcontent : System.Web.UI.UserControl
{

    #region my declared page properties

    //#region Category property
    //private int _webCategory;
    //public int CategoryID
    //{
    //    get { return _webCategory; }
    //    set { _webCategory = value; }
    //}
    #endregion

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


    #region other names for properties
    //		private int _categoryID;
    //		public int CategoryID
    //		{
    //			get{ return _categoryID;}
    //			set{ _categoryID=value;}
    //		}



    //		private string _cat;
    //		public string Cat
    //		{
    //			get{return _cat;}
    //			set{_cat=(Request.QueryString["cat"]);}
    //
    //		}
    #endregion

    #region id property
    private int _articleID;
    

    public int WebArtID
    {
        get { return _articleID; }
        set { _articleID = value; }
    }

    private int _LeaderID;
    public int LeaderID
    {
        get { return _LeaderID; }
        set { _LeaderID = Int32.Parse(Resources.startpage.ArtNo); }
    }


    #endregion

    #region has a picture to show property
    private int _hasPic;
    public int hasPic
    {
        get { return _hasPic; }
        set { hasPic = value; }
    }



    private int _hasCode;
    public int hasCode 
     {
         get { return _hasCode; }
         set { hasCode = value; }
     }



    #endregion


    #region old
    // public string hasImage;




    //private string googlefy()
    //{
    //    if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] != null)
    //    {
    //        _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);
    //        _id = Int32.Parse(Request.QueryString["cid"]);
    //        string title = Webica.Articles.getWebArticlePageTitle(CategoryID,id );
    //        return title;
    //    }


    //    if (Request.QueryString["CategoryID"] != null && Request.QueryString["cid"] == null)
    //    {
    //        _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);

    //        string title = Webica.Articles.getWebArticlePageTitle(CategoryID);
    //        return title;
    //    }


    //    return string.Empty;
    //}




    //protected override void Render(System.Web.UI.HtmlTextWriter writer)
    //{

    //    //	writer.Write("<HTML><HEAD><TITLE>Time for some joined-up thinking......    -    John Mulkearns - Webica.NET and </TITLE></HEAD><BODY>"); 
    //    writer.Write("<HTML><HEAD><TITLE>" + googlefy() + "</TITLE></HEAD><BODY>");
    //    base.Render(writer);
    //    writer.Write("</BODY></HTML>");

    //}

    #endregion


    #region	//**********************  P.A.G.E  L.O.A.D ******************************************

    protected void Page_Load(object sender, EventArgs e)
    {
 
        
#region querystring analysis
                                                                                                                                    //		kc_admin.read_web_articles_latest_by_CategoryID
                                                                                                                                    //	    kc_admin.read_web_articles_by_CategoryID_and_id 
                                                                                                                                    //		kc_admin.read_web_articles_by_id


					                                                                    	                                    	// eg request for Web.aspx     ... go to homepage   NO id and NO Category supplied

			if(Request.QueryString["cid"]==null & Request.QueryString["CategoryID"]==null)
            {

                int LeadID = Int32.Parse(Resources.startpage.ArtNo);

       //       currently place lead articleid in web.config

                getWebArticleByWebArtid(LeadID);  


         	}				 
							                                                                                                                // eg request for Web.aspx?CategoryID=3     ... go to latest page for this Category   NO id but a Category IS supplied							
							                                                                                                                // ***************** kc_admin.read_web_articles_latest_by_CategoryID

			if(Request.QueryString["cid"] ==null && Request.QueryString["CategoryID"] !=null ) 
			{
				CategoryID = Int32.Parse(Request.QueryString["CategoryID"]);			
					getWebArticleByCategory(CategoryID);		
			}

						                                                                                                                        // eg request for Web.aspx?CategoryID=3&id=50     ... go to specific page within a Category
						                                                                                                                        // **********kc_admin.read_web_articles_by_CategoryID_and_id 
			if(Request.QueryString["cid"] !=null && Request.QueryString["CategoryID"] !=null)
			{
				WebArtID = Int32.Parse(Request.QueryString["cid"]);
				CategoryID = Int32.Parse(Request.QueryString["CategoryID"]);
				getWebArticleByCategoryAndID(WebArtID,CategoryID);		
			}
        
			                                                                                                                                //** extra bit  for page "title" not <html>title</title> yet!!
			                                                                                                                                // _admin.read_web_articles_by_id
			if((Request.QueryString["CategoryID"])!=null)
            { _categoryID = Int32.Parse((Request.QueryString["CategoryID"])); }

#endregion querystring analysis

			getPageName(CategoryID);
        //   MoveAds2();
        //   MoveAds();
        // internationalisation of Labels

        //    _WiFiLabel.Text = Resources.intStrings.WifiService;

        //     _hiLabel.Text = Resources.intStrings.hi;
        //       _hiLabel.Text = Resources.Resource.Welcome;


        // *** the .ascx code for following is in a TextFile called
        // ** DeveloperPlaygroundbitsfromUIcontent.ascx.txt

        //uno_FindLabel.Text = Resources.Resource.Search;
        //    uno_LoveLabel.Text = Resources.Resource.Love;
        //    uno_TransLabel.Text = Resources.Resource.Learn;
        //    uno_AirportLabel.Text = Resources.Resource.Fly;
        //    uno_RadioLabel.Text = Resources.Resource.Radio;

        //     uno_NoBookFees.Text = Resources.Resource.promo1;



        //uno_Apartments.Text = Resources.Resource.Fly;

        //uno_RadioLabel.Text = Resources.Resource.Radio;
        //uno_NoBookFees.Text = Resources.Resource.promo1;


        //    uno_BookNow.Text = Resources.Resource.promo2;

        // http://www.booking.com/searchresults.html?city=900039399&aid=332892&Best-Prices=CafeFlorinSpecials



        //○⦾⦿  ⚫⚪• 🔅😷   Search4Accommodation.NavigateUrl = "http://www.cafeflorin.com/SearchAndBook.aspx?http://www.booking.com/searchresults.html?city=900039399&aid=332892&Best-Prices=CafeFlorinSpecials";




        //  Search4Accommodation.ImageUrl = "http://www.cafeflorin.com/img/SearchButton.png";




        /*○⦾⦿  ⚫⚪• 🔅😷   Search4Accommodation.Text = Resources.Resource.promo2;

        uno_BestPrice.Text = Resources.Resource.promo3;
        */ 


         // **************************************  cfMap.Text = Resources.Resource.map;


            // *** the .ascx code for following is also in a TextFile called
            // ** DeveloperPlaygroundbitsfromUIcontent.ascx.txt
        
        //_ChatLabel.Text = Resources.Resource.extra1;
        //    _RadioLabel.Text = Resources.Resource.extra2;
        //    _VideoLabel.Text = Resources.Resource.extra3;
        //    _PicsLabel.Text = Resources.Resource.extra4;

        //    uno_Discount_Vouchers.Text = Resources.Resource.promo5;




        /* Main Site Menu setup */








        /*

            picHolidayAccom.ImageUrl = "http://www.cafeflorin.com/img/" + Resources.Resource.pic1;
            picNoBookFee.ImageUrl = "http://www.cafeflorin.com/img/" + Resources.Resource.pic2;
            picBestPrice.ImageUrl = "http://www.cafeflorin.com/img/" + Resources.Resource.pic3;

            picRememberThisPage.ImageUrl = "http://www.cafeflorin.com/img/" + Resources.Resource.pic6;
           picRememberThisPage.Attributes.Add("onclick", "window.external.AddFavorite(location.href,document.title);");
           picRememberThisPage.Attributes.Add("onmouseover", "style.cursor='hand';");


 
           YumboCentrum.ImageUrl = "http://www.cafeflorin.com/images/idilogo.jpg";
           YumboCentrum.Width = 130;
        
         //   YumboCentrum.ImageUrl = "http://www.cafeflorin.com/img/" + Resources.Resource.pic4;
           YumboCentrum.NavigateUrl = "http://www.intercambiodeidiomas.es/";
           YumboCentrum.Target = "_blank";

        */











	#endregion Page load
        

    }

    

    void getWebArticleByCategoryAndID(int WebArtID, int CategoryID)
    {
        
        Articles content = new Articles();

        if (WebArtID > 0.5)
        {
            Thecopy column = content.GetWebArticleByCategoryAndID(WebArtID, CategoryID);
       //     TextBox1.Text = column.monologue.ToString();
          //  TextBox1.Text = column.Code.ToString();
            Literal1.Text = column.monologue.ToString();
            Literal2.Text = column.mono2.ToString();
            lblTitle.Text = column.Title.ToString();
       


            
            _hasCode = column.hasCode;
            if (_hasCode > 0.5) {

              
                // onclick="zoompart1(),this.src='images/folder_opened.gif';" onmouseout="this.src='images/folder.gif';"	alt="" src="../images/folder.gif"
                showPDAbutt();
                                                }
            //    TextBox1.Visible = true; 
            
            _hasPic = column.hasPic;
            if (_hasPic > 0.5) {
                column2txt.Style.Add("style", "z-index: 107; left: 330px; width: 285px; position: absolute; top: 248px; height: 100px");
                addpic(); }

        }

        else
        {
            Thecopy column = content.GetWebArticleByCategoryAndID(0, 1);
         //   TextBox1.Text = column.monologue.ToString();
            Literal1.Text = column.monologue.ToString();
            Literal2.Text = column.mono2.ToString();
            lblTitle.Text = column.Title.ToString();
        
            _hasPic = column.hasPic;
            _hasCode = column.hasCode;
      
         //   if (_hasCode > 0.5) { TextBox1.Visible = true; }
        }
    }  // eof




    #region this adds the pic to the page

    private void addpic()
    {
        Divplaceholder2.Style.Add("style","z-index: 105; left: 309px; width: 276px; position: absolute; top: 40px; height: 100px");
        column2txt.Style.Add("style", "z-index: 107; left: 330px; width: 285px; position: absolute; top: 248px; height: 100px");
        visual img = new visual();
        PlaceHolder2.Controls.Add(img);
        img.Width = 325;
        img.Height = 200;

        int height = ((int)img.Height.Value);
        int width = ((int)img.Width.Value);
        if (Request.QueryString["cid"] != null)
        {
            img.ImageUrl = "..\\DBGraphic.aspx?cid=" + Request.QueryString["cid"];
        }
        else { img.ImageUrl = "..\\DBGraphic.aspx?cid=" + _articleID; }


        if (Request.QueryString["cid"] == null & Request.QueryString["CategoryID"] == null)
        {
            int LeadID = Int32.Parse(Resources.startpage.ArtNo);
            img.ImageUrl = "..\\DBGraphic.aspx?cid=" + LeadID;
        }


    }





    #endregion


    public void getPageName(int CategoryID)
    {

        if (Request.QueryString["CategoryID"] != null)
        { CategoryID = Int32.Parse(Request.QueryString["CategoryID"]); }

        Articles content = new Articles();
        if (CategoryID > -0.5)
        {
            Title.Text = content.getPageName(CategoryID);
            Catlabel.Text = "Read more on " + Title.Text.ToString()+ " below.";   //+" "+ Literal1.Text.Length.ToString();
           // TitleShadow.Text = Title.Text;
        }
    }


    void getWebArticleByCategory(int CategoryID)
    {

        Articles content = new Articles();

        if (CategoryID > -0.5)
        {
            Thecopy column = content.GetWebArticleByCategory(CategoryID);
         //   TextBox1.Text = column.monologue.ToString();
            Literal1.Text = column.monologue.ToString();
            Literal2.Text = column.mono2.ToString();
            lblTitle.Text = column.Title.ToString();

            _hasPic = column.hasPic;


            // _hasPic=true;
            if (_hasPic > 0.5)
            {
                column2txt.Style.Add("style", "z-index: 107; left: 330px; width: 285px; position: absolute; top: 248px; height: 100px");
                // column2txt is a client wide html div tag that holds the pacholder, it was made a htmlgeneric server control by adding the runat=server
                // this was done a its position needs to change depending uplon other screen elements
                _articleID = column.WebArtID;
                addpic(); 

            }
            //			hasImage="1";}

            _hasCode = column.hasCode;
          //  if (_hasCode > 0.5) { TextBox1.Visible = true; showPDAbutt(); }
         //    MoveAds();
           // butthold.Visible = true; 

        }
        else
        {
            Thecopy column = content.GetWebArticleByCategory(CategoryID); ;
            // TextBox1.Text = column.monologue.ToString();
            Literal1.Text = column.monologue.ToString();
            Literal2.Text = column.mono2.ToString();
            lblTitle.Text = column.Title.ToString();
      
            _hasPic = column.hasPic;
            _hasCode = column.hasCode;
          //  if (_hasCode > 0.5) { TextBox1.Visible = true;  }  //  butthold.Visible = true; 
          
        }

     //    MoveAds();
     //    butthold.Visible = true;
        Label2.Text = content.ArticleCount(CategoryID).ToString();
    }  // eof get2

    public void Display2ndTitle()
    {
        lblTitle2.Visible = true;
  //      lblTitle2.CssClass = "pageTitle";
        lblTitle2.Text = "Gran Canaria Happy Gay Cafe Best Tourist Info Holday Sunshine book cheap flights";
        column2txt.Style.Add("style", "z-index: 107; left: 330px; width: 285px; position: absolute; top: 248px; height: 100px");
    }
            // need to refine this logic more,, if i display a label2 here ( top of 2nd column) then i do'nt want a pic displayed there.

    
    
    //public void MoveAds()
    //{
    //    if (Literal2.Text.Length >3.5)
    //        {
    //            addsright.Style.Add("style", "z-index: 9999; left: 342px; position: absolute; top: 714px; width:132px; height: 525px; font-size: 9pt; color: #00cc00; font-family: Arial; ");
    //          // addsbot.Style.Add("style", "FONT-SIZE: 9pt; z-index: 1999; left: 1225px; width: 165px; color: #00cc00; font-family: 'Arial Black'; position: absolute; top: 966px; height: 675px");

    //        }
    //      }



    //private void MoveAds2()
    //{
    //          if (Literal1.Text.Length<390)
    //    {
    //        addsbot.Style.Add("style", "z-index: 9999; left:442px; position: absolute; top: 150px; width:132px; height: 675px; font-size: 9pt; color: #00cc00; font-family: Arial; ");
    //    //          addsbot.Style.Add("style", "FONT-SIZE: 9pt; z-index: 1999; left: 36px; width: 165px; color: #00cc00; font-family: 'Arial Black'; position: absolute; top: 777px; height: 675px");
    //        adiv.Style.Add("style", "z-index: 2007; left: 1000px; position: absolute; top: 200px; background-color: #99cc66; width: 22px; height: 22px;");
    
    //    }
    //   }




    void showPDAbutt()
    {

        ifolder1.Visible = true; ifolder1.Attributes.Add("onclick", "zoompart1();");
        ifolder1.Attributes.Add("onmouseover", "this.src='images/anizoom.gif';");
        //         ifolder1.Attributes.Add("onmouseover", "this.style.cursor='hand'");
        ifolder1.Attributes.Add("onmouseout", "this.src='images/PDA.gif';");
    //    PDAlbl.Visible = true;
    }

    void getWebArticleByWebArtid(int WebArtID)
    {

        Articles content = new Articles();

        //if (WebArtID > 0.5)
        //{
            Thecopy column = content.GetWebArticleByArticleID(WebArtID);
            //     TextBox1.Text = column.monologue.ToString();
   //        TextBox1.Text = column.Code.ToString();           
          Literal1.Text = column.monologue.ToString();
            Literal2.Text = column.mono2.ToString(); 
            lblTitle.Text = column.Title.ToString();


            _hasCode = column.hasCode;
            if (_hasCode > 0.5)
            {


                // onclick="zoompart1(),this.src='images/folder_opened.gif';" onmouseout="this.src='images/folder.gif';"	alt="" src="../images/folder.gif"
                showPDAbutt();

            //    TextBox1.Visible = true;
            }

            _hasPic = column.hasPic;
            if (_hasPic > 0.5)
            {
                column2txt.Style.Add("style", "z-index: 107; left: 330px; width: 285px; position: absolute; top: 248px; height: 100px");
                addpic();
            }

    //    }

        //else
        //{
        //    Thecopy column = content.GetWebArticleByArticleID(1);
        //    TextBox1.Text = column.monologue.ToString();
        //    Literal1.Text = column.monologue.ToString();
        //    Literal2.Text = column.mono2.ToString();
        //    lblTitle.Text = column.Title.ToString();
        //    _hasPic = column.hasPic;
        //    _hasCode = column.hasCode;

        //    if (_hasCode > 0.5) { TextBox1.Visible = true; }
        //}
    }  // eof
















}
