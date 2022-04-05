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

using System.Data.SqlClient;

public partial class IP : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = cip().ToString();
   //     recordIP(cip());
        Profiler();
      //  listIPs();
    }




    public string cip()
    {
        System.Web.HttpBrowserCapabilities browser = Request.Browser;
        string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
       return ip;

    }

    private void recordIP(string ipaddr)
    {
        SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand("kc_admin.web_insertIP", cnn);
        cmd.CommandType = CommandType.StoredProcedure;

        
        SqlParameter param = cmd.Parameters.Add("@IP", System.Data.SqlDbType.VarChar, 15);
        param.Value = ipaddr;

        try
        {
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }

    
    }

    public string Profiler()
    {

        System.Web.HttpBrowserCapabilities browser = Request.Browser;
        string ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
        string s = "Analysis of this PC reveals the following<br>" + " .NET  version installed = " + browser.ClrVersion + "<br><br>Web browser capabilities are ...<br>"
            + "  1) Type = " + browser.Type + "<br>"
            + "  2) Name = " + browser.Browser + "<br>"
            + "  3) Version = " + browser.Version + "<br>"
            + "  4) Major Version = " + browser.MajorVersion + "<br>"
            + "  5) Minor Version = " + browser.MinorVersion + "<br>"
            + "  6) Platform = " + browser.Platform + "<br>"
            + "  7) Is Beta = " + browser.Beta + "<br>"
            + "  8) Is Crawler = " + browser.Crawler + "<br>"
            + "  9) Is AOL = " + browser.AOL + "<br>"
            + "10) Is Win16 = " + browser.Win16 + "<br>"
            + "11) Is Win32 = " + browser.Win32 + "<br>"
            + "12) Supports Frames = " + browser.Frames + "<br>"
            + "13) Supports Tables = " + browser.Tables + "<br>"
            + "14) Supports Cookies = " + browser.Cookies + "<br>"
            + "15) Supports VBScript = " + browser.VBScript + "<br>"
            + "16) Supports JavaScript = " + browser.JavaScript + "<br>"
            + "17) JavaScript version = " + browser.EcmaScriptVersion + "<br>"
            + "18) Microsoft DOM  version= " + browser.MSDomVersion + "<br>"
            + "19) W3C DOM version = " + browser.W3CDomVersion + "<br>"
            + "20) Supports Java Applets = " + browser.JavaApplets + "<br>"
            + "21) Supports ActiveX Controls = " + browser.ActiveXControls + "<br>"
               + "================================================="+"<br>"
            + "22) Name of User = " + Request.ServerVariables["AUTH_USER"] + "<br>"
            + "23) Headers = " + Request.ServerVariables["ALL_HTTP"] + "<br>"
            + "24) Headers = " + Request.ServerVariables["ALL_RAW"] + "<br>"
            + "25) Meta Base = " + Request.ServerVariables["APPL_MD+PATH"] + "<br>"
            + "26) Path = " + Request.ServerVariables["APPL_PHYSICAL_PATH"] + "<br>"
            + "27) Password = " + Request.ServerVariables["AUTH_PASSWORD"] + "<br>"
            + "28) Headers = " + Request.ServerVariables["AUTH_TYPE"] + "<br>"
            + "29) Cookie = " + Request.ServerVariables["CERT_COOKIE"] + "<br>"
            + "30) Flag = " + Request.ServerVariables["CERT_FLAGS"] + "<br>"
            + "31) Cert Issuer = " + Request.ServerVariables["CERT_ISSUER"] + "<br>"
            + "32) CERT_KEYSIZE = " + Request.ServerVariables["CERT_KEYSIZE"] + "<br>"
            + "33) CERT_SECRETKEYSIZE = " + Request.ServerVariables["CERT_SECRETKEYSIZE"] + "<br>"
            + "34) CERT_SERIALNUMBER = " + Request.ServerVariables["CERT_SERIALNUMBER"] + "<br>"
            + "35) CERT_SERVER_SUBJECT = " + Request.ServerVariables["CERT_SERVER_SUBJECT"] + "<br>"
            + "36) CERT_SUBJECT = " + Request.ServerVariables["CERT_SUBJECT"] + "<br>"
            + "37) CONTENT_LENGTH = " + Request.ServerVariables["CONTENT_LENGTH"] + "<br>"
            + "38) GATEWAY_INTERFACE = " + Request.ServerVariables["GATEWAY_INTERFACE"] + "<br>"
            + "39) HTTP_ACCEPT = " + Request.ServerVariables["HTTP_ACCEPT"] + "<br>" + "<br>"

            + "40) HTTP_ACCEPT_LANGUAGE = " + Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"] + "<br>" + "<br>"
            + "41) HTTP_COOKIE = " + Request.ServerVariables["HTTP_COOKIE"] + "<br>"
            + "42) HTTP_USER_AGENT = " + Request.ServerVariables["HTTP_USER_AGENT"] + "<br>"
            + "43) HTTP_ACCEPT = " + Request.ServerVariables["HTTP_ACCEPT"] + "<br>"
            + "44) HTTPS = " + Request.ServerVariables["HTTPS"] + "<br>"
            + "45) HTTPS_KEYSIZE = " + Request.ServerVariables["HTTPS_KEYSIZE"] + "<br>"
            + "46) HTTPS_SECRETKEYSIZE = " + Request.ServerVariables["HTTPS_SECRETKEYSIZE"] + "<br>"
            + "47) HTTPS_SERVER_ISSUER = " + Request.ServerVariables["HTTPS_SERVER_ISSUER"] + "<br>"
            + "48) HTTPS_SERVER_SUBJECT = " + Request.ServerVariables["HTTPS_SERVER_SUBJECT"] + "<br>"
            + "49) INSTANCE_ID = " + Request.ServerVariables["INSTANCE_ID"] + "<br>"
            + "50) INSTANCE_META_PATH = " + Request.ServerVariables["INSTANCE_META_PATH"] + "<br>"
           + "51) LOCAL_ADDR = " + Request.ServerVariables["LOCAL_ADDR"] + "<br>"
            + "52) LOGON_ADDR = " + Request.ServerVariables["LOGON_ADDR"] + "<br>"
            + "53) PATH_INFO = " + Request.ServerVariables["PATH_INFO"] + "<br>"
            + "54) PATH_TRANSLATED = " + Request.ServerVariables["PATH_TRANSLATED"] + "<br>"
            + "55) QUERY_STRING = " + Request.ServerVariables["QUERY_STRING"] + "<br>"
            + "56) REMOTE_ADDR = " + Request.ServerVariables["REMOTE_ADDR"] + "<br>"
            + "57) REMOTE_HOST = " + Request.ServerVariables["REMOTE_HOST"] + "<br>"
            + "58) REMOTE_USER = " + Request.ServerVariables["REMOTE_USER"] + "<br>"
            + "59) REQUEST_METHOD = " + Request.ServerVariables["REQUEST_METHOD"] + "<br>"

            + "60) SCRIPT NAME = " + Request.ServerVariables["SCRIPT_NAME"] + "<br>"
            + "61) Headers = " + Request.ServerVariables["SERVER_PORT"] + "<br>"
            + "62) Headers = " + Request.ServerVariables["SERVER_PORT_SECURE"] + "<br>"
            + "63) Headers = " + Request.ServerVariables["SERVER_PROTOCOL"] + "<br>"
            + "64) Headers = " + Request.ServerVariables["SERVER_SOFTWARE"] + "<br>"
            + "65) URL = " + Request.ServerVariables["URL"] + "<br>"


            + "IP address this PC address is presenting to Webica.NET server (your Gateway/Firewall) is " + ip;
        Label2.Text = s;

        return s;
        



    }


    //private void listIPs()
    //{
    //    utils u = new utils();
    //    Repeater1.DataSource = u.IPLog();
    //    Repeater1.DataBind();
    //}




}
