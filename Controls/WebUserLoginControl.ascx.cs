using System;
using System.Collections.Generic;
using System.Linq;


using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;





public partial class Controls_WebUserLoginControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }






    private void LogonProcess()
    {

        //UserDB AccountSystem = new UserDB;

        // string UserLoginNumber =AccountSystem


        UserDB AccountSystem = new UserDB();
        string UserLoginNumber = AccountSystem.UserLoginDetails(txbUserName.Text, txbPassword.Text);
        if (UserLoginNumber != "")
        {
            Label1.Text = "No " + UserLoginNumber;

        }

        UserLoginDetails UserDetails = AccountSystem.GetUserLoginDetails(Int32.Parse(UserLoginNumber));
        Response.Cookies["CMSuser_LogonName"].Value = UserDetails.LoginName;

        Response.Cookies["CMSuser_LogonName"].Expires = DateTime.Now.AddMinutes(3);

        FormsAuthentication.RedirectFromLoginPage(UserLoginNumber, CheckBox1.Checked);





    }




    protected void LoginBtn_Click(object sender, EventArgs e)
    {
        LogonProcess();
    }
}