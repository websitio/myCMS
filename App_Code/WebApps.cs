using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


/// <summary>
/// Summary description for WebApps
/// </summary>
public class WebApps
{
	public WebApps()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private static string SafeConfigString(string configSection, string configKey, string defaultValue)
    {


         NameValueCollection configSettings = System.Configuration.ConfigurationManager.GetSection(configSection) as NameValueCollection;
           
        if (configSettings != null)
        {
            string configValue = configSettings[configKey] as string;
            if (configValue != null)
            {
                return configValue;
            }
        }

        return defaultValue;
    }

    static public String DatabaseConnectionString
    {
        get
        {
            return SafeConfigString("appSettings", "ConnectionString", string.Empty);
        }
    }


 
    /// <summary>
    /// datasource for datalist
    /// input AppType integer
    /// returns Datatable
    /// //	if (!Regex.IsMatch(AppType.ToString(), @"^\d{1}$", RegexOptions.Compiled))
    //	return null;
    /// </summary>
    public DataTable GetWebApps(int AppType)
    {

        SqlConnection sqlConnection = new SqlConnection(DatabaseConnectionString);

        //		SqlConnection sqlConnection = new SqlConnection("server=(local);database=WEB;Integrated Security=SSPI");
        try
        {
            SqlDataAdapter sqlAdapter1 = new SqlDataAdapter("Select * from WebApps where AppType=" + AppType, sqlConnection);
            DataSet Apps = new DataSet();
            sqlAdapter1.Fill(Apps, "WebApps");
            return Apps.Tables[0];
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            sqlConnection.Close();
        }
    }



    public DataRow GetWebApp(int AppID)
    {
        //		if (!Regex.IsMatch(AppID.ToString(), @"^\d{2}$", RegexOptions.Compiled))
        //		return null;

        SqlConnection sqlConnection = new SqlConnection(DatabaseConnectionString);
        //			SqlConnection sqlConnection = new SqlConnection("server=(local);database=WEB;Integrated Security=SSPI");
        try
        {
            SqlDataAdapter sqlAdapter1 = new SqlDataAdapter("Select * from WebApps where AppID=" + AppID, sqlConnection);
            DataSet App = new DataSet();
            sqlAdapter1.Fill(App, "WebApps");
            // Cache["myApp"]= App;
            return App.Tables[0].Rows[0];
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            sqlConnection.Close();
        }
    }


    public SqlDataReader GetCategories()
    {
        SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
        SqlCommand cmd = new SqlCommand("web_categories");
        cmd.CommandType = CommandType.StoredProcedure;

        cnn.Open();
        SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        return dr;


    }



    public DataSet GetWebAppType()
    {
        // SqlConnection cnn = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand("kc_admin.web_getapptypes", cnn);
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;

        DataSet ds = new DataSet();
        da.Fill(ds, "WebAppType");

        return ds;
    }






}
