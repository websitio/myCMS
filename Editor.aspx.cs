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

public partial class Editor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        lblMssg.Text = User.Identity.Name.ToString();



        #region	//**********************  P.A.G.E  L.O.A.D  EXPERIMENT ******************************************


        //   LinkButton LinkButton2new = (LinkButton)Page.Form.FindControl("DetailsView1:LinkButton2new");
     //   LinkButton2new.Text = Resources.intStrings.LinkButton2new;


        // LinkButton1Insert

    //  LinkButton LinkButton1Insert = (LinkButton)Page.Form.FindControl("DetailsView1:LinkButton1Insert");
        //LinkButton1Insert.Text = Resources.intStrings.LinkButton1Insert;


        //Control controlToFind = FindControlRecursive(DetailsView1, "LinkButton2new");
        //if (controlToFind != null)
        //{
        //    LinkButton ButtonNameFound = (LinkButton)controlToFind;
        //    ButtonNameFound.Text = Resources.intStrings.LinkButton2new;
        // }
     #endregion




    }

   



    private Control FindControlRecursive(Control ctrlRoot, string sControldID)
    {

        if (ctrlRoot.ID == sControldID)
        {
            return ctrlRoot;
        }

        foreach (Control ctl in ctrlRoot.Controls)
        {
            Control ctlFound = FindControlRecursive(ctl, sControldID);

            if (ctlFound != null)
            {
                return ctlFound;
             }
            
             }
             return null;
    }




}
