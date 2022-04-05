using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//This is a Gay cpntrol for Gay information for Gay places to stay



public partial class Controls_WebUserControl9 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ExtraControl();

        
        // positionGayAptsTable
    }


    public void ExtraControl()
    {
       if (Request.QueryString["GayDear"] == "YesDear")
        {
            // _categoryID = Int32.Parse(Request.QueryString["CategoryID"]);
           // position the Apartments
            positionGayAptsTable.Attributes.Add("style", "z-index: 22107; position:absolute; top: 296px; left: 1108px; width: 130px; height: 468px");
       //   GayBungalowsFlags.Attributes.Add("style", "z-index: 107; position:absolute; top: 256px; left: 119px");
         //  PositionGayHotelsTable.Attributes.Add("style", "z-index: 107; position:absolute; top: 800px; left: 1121px");
           
           // show gay more stuff
           HeadsUP.Attributes.Add("style", "position:absolute; top:163px; left:390px; width:184px; height:20px; color: #0B4279;    font-family: Arial, Helvetica, sans-serif; z-index: 92010; font-size: 20px; font-weight: bold");
     
        }

    }


}
