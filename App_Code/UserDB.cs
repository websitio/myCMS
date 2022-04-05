using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SQL = System.Data.SqlClient;
/// <summary>
/// Summary description for UserDB
/// </summary>
public class UserLoginDetails
{

    public string LoginName;
    public string LoginPassword;
    public int LoginUserNumber;

}


public class UserDB
{


    //public UserDB()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}


    public UserLoginDetails GetUserLoginDetails(int userLoginNumber)
    {

        SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand("kc_admin.sp_GetUserLoginDetails", cnn);
        cmd.CommandType = CommandType.StoredProcedure;


        SqlParameter prmUserLoginNumber = new SqlParameter("@UserLoginNum", SqlDbType.Int, 4);
        prmUserLoginNumber.Value = userLoginNumber;
        cmd.Parameters.Add(prmUserLoginNumber);

        SqlParameter prmLoginName = new SqlParameter("@LoginName", SqlDbType.NVarChar, 50);
        prmLoginName.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmLoginName);


        SqlParameter prmLoginPassword = new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50);
        prmLoginPassword.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmLoginPassword);

        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();

        UserLoginDetails myUserLoginDetails = new UserLoginDetails();


        myUserLoginDetails.LoginName = ((string)prmLoginName.Value);


        myUserLoginDetails.LoginPassword = ((string)prmLoginPassword.Value);
        // return myUserLoginDetails();



        return myUserLoginDetails;


    }

    public string UserLoginDetails(string LoginName, string LoginPassword)
    {


        SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand("kc_admin.sp_UserLogin", cnn);
        cmd.CommandType = CommandType.StoredProcedure;


        SqlParameter prmLoginName = new SqlParameter("@LoginName", SqlDbType.NVarChar, 50);
        prmLoginName.Value = LoginName;
        cmd.Parameters.Add(prmLoginName); ;

        SqlParameter prmLoginPassword = new SqlParameter("@LoginPassword", SqlDbType.NVarChar, 50);
        prmLoginPassword.Value = LoginName;
        cmd.Parameters.Add(prmLoginPassword);

        SqlParameter prmUserLoginNumber = new SqlParameter("@UserLoginNum", SqlDbType.Int, 4);
        prmUserLoginNumber.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(prmUserLoginNumber);

        cnn.Open();
        cmd.ExecuteNonQuery();
        cnn.Close();


        int UserLoginNumber = ((int)prmUserLoginNumber.Value);
        if (UserLoginNumber == 0)
        {
            return null;
        }

        else
        {
            return UserLoginNumber.ToString();

        }

    }

}
