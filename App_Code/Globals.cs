using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;


/// <summary>
/// Summary description for Globals
/// </summary>
public class Globals : System.Web.HttpApplication
{
	public Globals()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        Application["OnlineUsers"] = 7;
    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }






    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
        Application.Lock();
        Application["OnlineUsers"] = (int)Application["OnlineUsers"] + 1;
        Application.UnLock();

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.


        Application.Lock();
        Application["OnlineUsers"] = (int)Application["OnlineUsers"] - 1;
        Application.UnLock();

    }



    protected void Application_BeginRequest(Object sender, EventArgs e)
    {

     //   if(Request.Browser.Crawler) {
       //     Response.Redirect("http://www.webica.net/webcrawler.aspx");
  //      }
    //    else{

        int ma =Request.Browser.MajorVersion;
      //  int js =Convert.ToInt32(Request.Browser.EcmaScriptVersion);
        string br = Request.Browser.Browser;
     //   int mi = Request.Browser.MinorVersion;


// if (Request.Browser.Browser == "IE" && ma>4.9 && Request.Browser.JavaScript)
  //      if (Request.Browser.Browser == "IE" && ma > 4.9 && Request.Browser.EcmaScriptVersion)
    //   if ((br== "IE") & (ma > 4.9) & (js=1))
       

    //    {

            HttpContext incoming = HttpContext.Current;
            string oldpath = incoming.Request.Path.ToLower();

            if (oldpath.Length > 16)
            {


                //     string oldpath = "http://localhost/webica/Webica%20Article%20Web%20Applications,%20talk%20to%20one%20or%20more_0_9.aspx";
                string CategoryID;
                string WebArtID;


                int length = oldpath.Length;   // the length of the url

                if ((oldpath.IndexOf("_") > 1))
                {
                    int no = oldpath.IndexOf("_");    // position of the _ character deliberatly placed in string currently entirly generated by sproc


                //    int difference = (length - 5) - no;           // this trims the file extension (.aspx) off the string and tells me the length of the "working bit remaining"

                int difference = length  - no;

                string ArticleRef = (oldpath.Substring(no, difference)).ToString();               // ArticleRef looks like _0_39 for example url above

                    // now we need to know the position of the 2nd "_" in the ArticleRef

                    int Pos2nd_ = ArticleRef.IndexOf("_", 1);

                    CategoryID = ArticleRef.Substring(1, (Pos2nd_ - 1));
                    WebArtID = ArticleRef.Substring((Pos2nd_ + 1), (difference - Pos2nd_ - 1));
                    // now that the positions of the two "_" characters are known the CategoryID and WebarticleID can be extrated ready for the actual querystring)

                    incoming.RewritePath("Web.aspx?CategoryID=" + CategoryID + "&cid=" + WebArtID);
           //     }

       //         else { incoming.RewritePath(oldpath); } // end of test to see if "_" is in request string


            } // end of if oldpath length text


            #region old

            //HttpContext incoming = HttpContext.Current; 
            //string oldpath = incoming.Request.Path.ToLower();
            //string Categoryid; // id requested 
            //string WebArtID;



            //                    // Regular expressions to grab the page id from the pageX.aspx 
            //                            Regex regex = new Regex(@"Web(Categoryid+).aspx", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace); 
            //                    MatchCollection filter = regex.Matches(oldpath); 

            //                    if (filter.Count > 0) 
            //                    { 
            //                    // Extract the id and send it to display.aspx 
            //                        Categoryid = filter[0].Groups[1].ToString();
            //                    incoming.RewritePath("Web.aspx?id=" + Categoryid); 
            //                    } 
            //                    else {
            //                    // diplay old path 
            //                    incoming.RewritePath(oldpath ) ;
            //                    }

            #endregion


       }
        //else {   Response.Redirect("http://www.webica.net/html/upgrade.htm");

        //}


 //       }  // end of Is Crawler

}           // end of function






}           //eoc
