using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Web;
using SQL = System.Data.SqlClient;

namespace Webica
{





    #region The Copy Object, a Seperate Class - used like a struct for high speed single record retreval to web page
    /// <summary>
    /// Struct to hold Web Article returned by sqldatareader
    /// </summary>
    public class Thecopy
    {
        public string monologue = "There is no Article in the database that currently matches the id you requested"; // string.Empty;
        public string mono2 = " ";    // = WebArticle2
        public string Title = "There is no Title with this id value";			//string.Empty;
        public string keywords = string.Empty;
        DateTime d1 = DateTime.Now;
        public int hasPic;
        public int WebArtID;
        public int hasCode;
        public string Code = String.Empty;              // this is output into the textbox1 control on the UIcontrol.ascx, used to display code as text


    }
    #endregion



    public class Articles
    {
        #region connection area
        private string result;
        private static string SafeConfigString(string configSection, string configKey, string defaultValue)
        {
            NameValueCollection configSettings =
             System.Configuration.ConfigurationManager.GetSection(configSection) as NameValueCollection;
            //  ConfigurationSettings.GetConfig(configSection) as NameValueCollection;

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

        #endregion


        #region constructor ,,, not used
        //		public Articles()
        //		{
        //			//
        //			// TODO: Add constructor logic here
        //			//
        //		}
        #endregion



        //This POPULATES the UI control the text content
        #region Copy Reader := reads DBrecord text from WebArticle table and calls piture display method if records pic flag is set=1

        public Thecopy GetWebArticleByCategoryAndID(int WebArtID, int CategoryID)
        {
            //	if (!Regex.IsMatch(AppType.ToString(), @"^\d{1}$", RegexOptions.Compiled))
            //	return null;
            ///		
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_read_web_articles_by_CategoryID_and_id", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmWebArtID = new SqlParameter("@WebArtID", SqlDbType.Int, 4);
            prmWebArtID.Value = WebArtID;
            cmd.Parameters.Add(prmWebArtID);

            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            SqlParameter prmWebArticle = new SqlParameter("@WebArticle", SqlDbType.NVarChar, 3800);
            prmWebArticle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle);

            SqlParameter prmWebArticle2 = new SqlParameter("@WebArticle2", SqlDbType.NVarChar, 3800);
            prmWebArticle2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle2);

            SqlParameter prmArticleTitle = new SqlParameter("@Title", SqlDbType.VarChar, 250);
            prmArticleTitle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmArticleTitle);

            SqlParameter prmHasPic = new SqlParameter("@hasPic", SqlDbType.Int, 4);
            prmHasPic.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasPic);

            SqlParameter prmHasCode = new SqlParameter("@hasCode", SqlDbType.Int, 4);
            prmHasCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasCode);

            SqlParameter prmCode = new SqlParameter("@Code", SqlDbType.NVarChar, 2500);
            prmCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmCode);



            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            Thecopy columntext = new Thecopy();

            if (prmWebArticle.Value != DBNull.Value)
            { columntext.monologue = ((string)prmWebArticle.Value).Trim(); }

            if (prmWebArticle2.Value != DBNull.Value)
            { columntext.mono2 = ((string)prmWebArticle2.Value).Trim(); }


            if (prmArticleTitle.Value != DBNull.Value)
            { columntext.Title = ((string)prmArticleTitle.Value).Trim(); }
            if (prmHasPic.Value != DBNull.Value)
            { columntext.hasPic = ((int)prmHasPic.Value); }

            if (prmHasCode.Value != DBNull.Value)
            { columntext.hasCode = ((int)prmHasCode.Value); }

            if (prmCode.Value != DBNull.Value)
            { columntext.Code = ((string)prmCode.Value).Trim(); }


            if (prmHasPic.Value != (DBNull.Value))
            {
                columntext.hasPic = ((int)prmHasPic.Value);
                return columntext;
            }
            else
                // 			{ columntext.hasPic=false;}


                return columntext;

        }


        public Thecopy GetWebArticleByCategory(int CategoryID)
        {
            //	if (!Regex.IsMatch(AppType.ToString(), @"^\d{1}$", RegexOptions.Compiled))
            //	return null;
            //	
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_read_web_articles_latest_by_CategoryID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            SqlParameter prmWebArtID = new SqlParameter("@WebArtID", SqlDbType.Int, 4);
            prmWebArtID.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArtID);


            SqlParameter prmWebArticle = new SqlParameter("@WebArticle", SqlDbType.NVarChar, 3800);
            prmWebArticle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle);

            SqlParameter prmWebArticle2 = new SqlParameter("@WebArticle2", SqlDbType.NVarChar, 3800);
            prmWebArticle2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle2);

            SqlParameter prmArticleTitle = new SqlParameter("@Title", SqlDbType.VarChar, 250);
            prmArticleTitle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmArticleTitle);

            SqlParameter prmHasPic = new SqlParameter("@hasPic", SqlDbType.Int, 4);
            prmHasPic.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasPic);


            SqlParameter prmHasCode = new SqlParameter("@hasCode", SqlDbType.Int, 4);
            prmHasCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasCode);

            SqlParameter prmCode = new SqlParameter("@Code", SqlDbType.NVarChar, 3800);
            prmCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmCode);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            Thecopy columntext = new Thecopy();

            if (prmWebArticle.Value != DBNull.Value)
            { columntext.monologue = ((string)prmWebArticle.Value).Trim(); }


            if (prmWebArticle2.Value != DBNull.Value)
            { columntext.mono2 = ((string)prmWebArticle2.Value).Trim(); }

            if (prmArticleTitle.Value != DBNull.Value)
            { columntext.Title = ((string)prmArticleTitle.Value).Trim(); }
            if (prmHasPic.Value != DBNull.Value)
            { columntext.hasPic = ((int)prmHasPic.Value); }

            if (prmWebArtID.Value != DBNull.Value)
            { columntext.WebArtID = ((int)prmWebArtID.Value); }

            if (prmHasCode.Value != DBNull.Value)
            { columntext.hasCode = ((int)prmHasCode.Value); }


            if (prmCode.Value != DBNull.Value)
            { columntext.Code = ((string)prmCode.Value); }



            if (prmHasPic.Value != (DBNull.Value))
            {
                columntext.hasPic = ((int)prmHasPic.Value);
                return columntext;
            }
            else
                // 			{ columntext.hasPic=false;}

                return columntext;

        }


        #endregion



        public SqlDataReader ArticleTitles()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("CFcom_ArticleTitles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }



        public DataSet getArticlesPreviousTitles(int CategoryID)
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_previous_articles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            DataSet ds = new DataSet();
            da.Fill(ds, "ArticlesPrevious");

            return ds;

        }


        // kc_admin.CFcomgetWebArticlePageTitle
        public static string getWebArticlePageTitle(int CategoryID, int WebArtID)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);

            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_getWebArticlePageTitle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmWebArtID = new SqlParameter("@WebArtID", SqlDbType.Int, 4);
            prmWebArtID.Value = WebArtID;
            cmd.Parameters.Add(prmWebArtID);

            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            SqlParameter prmArticleTitle = new SqlParameter("@Title", SqlDbType.VarChar, 250);
            prmArticleTitle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmArticleTitle);

            string pageTitleforGoogle = "Applied Web solutions using .Net technologies for Business Government and Humanitarian bodies."; // string.Empty;

            cnn.Open();
            //string pageTitleforGoogle;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Title"].Value != DBNull.Value)
            {
                pageTitleforGoogle = (string)cmd.Parameters["@Title"].Value;
            }
            cnn.Close();
            cnn.Dispose();
            //			if(pageTitleforGoogle!=string.Empty)
            //			{			return pageTitleforGoogle;}
            //			else return "wanker";
            return pageTitleforGoogle;

        }


        // kc_admin.CFcomgetWebArticleCategoryPageTitle
        public static string getWebArticlePageTitle(int CategoryID)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_getWebArticleCategoryPageTitle", cnn);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            SqlParameter prmArticleTitle = new SqlParameter("@Title", SqlDbType.VarChar, 250);
            prmArticleTitle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmArticleTitle);

            string pageTitleforGoogle = "Gran Canaria Canary Islands Internet WiFi Cafe Florin Playa del Ingles Maspalomas"; // string.Empty;

            cnn.Open();
            //string pageTitleforGoogle;
            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Title"].Value != DBNull.Value)
            {
                pageTitleforGoogle = (string)cmd.Parameters["@Title"].Value;
            }
            cnn.Close();
            cnn.Dispose();
            //			if(pageTitleforGoogle!=string.Empty)
            //			{			return pageTitleforGoogle;}
            //			else return "wanker";
            return pageTitleforGoogle;

        }





        #region This sets the pages "Title", the web pages Category Name from the Web_Category table ( re: old sites menu & links)
        public string getPageName(int CategoryID)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_page_name", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmCategoryID = new SqlParameter("@CategoryID", SqlDbType.Int, 4);
            prmCategoryID.Value = CategoryID;
            cmd.Parameters.Add(prmCategoryID);

            SqlParameter prmPagename = new SqlParameter("@PageName", SqlDbType.VarChar, 50);
            prmPagename.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmPagename);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


            if (prmPagename.Value != DBNull.Value)
            {
                string pgName = ((string)prmPagename.Value).Trim();

                return pgName;
            }
            else { return "Cafe Florin"; }


        }


        #endregion



        #region Region = To Add New Article To Database     1 method -- overloaded

        public string AddNew_WebArticle(int CatgegoryID, string WebArticle, string WebArticle2, string Title, string publish, string picture, string ArtType, string keywords)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_articles_addnew", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters to SPROC


            SqlParameter p = cmd.Parameters.Add("@CatgegoryID", SqlDbType.Int); p.Value = CatgegoryID;  //1
            p = cmd.Parameters.Add("@WebArticle", System.Data.SqlDbType.NText); p.Value = WebArticle;
            p = cmd.Parameters.Add("@WebArticle2", System.Data.SqlDbType.NText); p.Value = WebArticle2;
            p = cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250); p.Value = Title;
            p = cmd.Parameters.Add("@publish", SqlDbType.VarChar, 1); p.Value = publish;
            p = cmd.Parameters.Add("@picture", SqlDbType.NVarChar, 1); p.Value = picture;
            p = cmd.Parameters.Add("@ArtType", SqlDbType.NVarChar, 50); p.Value = ArtType;
            p = cmd.Parameters.Add("@keywords", SqlDbType.NVarChar, 250); p.Value = keywords;
            p = cmd.Parameters.Add("@WebArtID", System.Data.SqlDbType.Int, 4); p.Direction = ParameterDirection.Output;


            #region
            //			cmd.Parameters.Add("@CatgegoryID",SqlDbType.Int).Value=CatgegoryID;
            //			cmd.Parameters.Add("@WebArticle", SqlDbType.NText).Value = WebArticle;
            //			cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title;
            //			cmd.Parameters.Add("@publish", SqlDbType.VarChar, 1).Value = publish;
            //			cmd.Parameters.Add("@picture", SqlDbType.NVarChar, 1).Value = picture;
            //			// @picture
            //			cmd.Parameters.Add("@ArtType", SqlDbType.NVarChar, 50).Value = ArtType;
            //			cmd.Parameters.Add("@keywords", SqlDbType.NVarChar, 250).Value = keywords;
            #endregion


            cnn.Open();
            int id;
            cmd.ExecuteNonQuery();
            id = (int)cmd.Parameters["@WebArtID"].Value;
            cnn.Close();
            string WebArtID = id.ToString();
            return WebArtID;
        }


        public string AddNew_WebArticle(int CatgegoryID, string WebArticle, string WebArticle2, string Title, string publish, string picture, string ArtType, string keywords, byte[] ImageContent)
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_articles_addnew", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add Parameters to SPROC


            SqlParameter p = cmd.Parameters.Add("@CatgegoryID", SqlDbType.Int); p.Value = CatgegoryID;  //1
            p = cmd.Parameters.Add("@WebArticle", System.Data.SqlDbType.NText); p.Value = WebArticle;
            p = cmd.Parameters.Add("@WebArticle2", System.Data.SqlDbType.NText); p.Value = WebArticle2;
            p = cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250); p.Value = Title;
            p = cmd.Parameters.Add("@publish", SqlDbType.VarChar, 1); p.Value = publish;
            p = cmd.Parameters.Add("@picture", SqlDbType.NVarChar, 1); p.Value = picture;
            p = cmd.Parameters.Add("@ArtType", SqlDbType.NVarChar, 50); p.Value = ArtType;
            p = cmd.Parameters.Add("@keywords", SqlDbType.NVarChar, 250); p.Value = keywords;
            p = cmd.Parameters.Add("@ImageContent", SqlDbType.Image); p.Value = ImageContent;
            p = cmd.Parameters.Add("@WebArtID", System.Data.SqlDbType.Int, 4); p.Direction = ParameterDirection.Output;

            #region alt shortcut to typing params
            //			cmd.Parameters.Add("@CatgegoryID",SqlDbType.Int).Value=CatgegoryID;
            //			cmd.Parameters.Add("@WebArticle", SqlDbType.NText).Value = WebArticle;
            //
            //			cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 250).Value = Title;
            //
            //			cmd.Parameters.Add("@publish", SqlDbType.VarChar, 1).Value = publish;
            //			cmd.Parameters.Add("@picture", SqlDbType.NVarChar, 1).Value = picture;
            //			cmd.Parameters.Add("@ArtType", SqlDbType.NVarChar, 50).Value = ArtType;
            //			cmd.Parameters.Add("@keywords", SqlDbType.NVarChar, 250).Value = keywords;
            //			cmd.Parameters.Add("@ImageContent",SqlDbType.Image).Value=ImageContent;
            //			 cmd.Parameters.Add("@WebArtID", System.Data.SqlDbType.Int, 4 );
            //			cmd.Parameters.
            //			cmd.Parameters.Direction=ParameterDirection.Output;	

            #endregion

            cnn.Open();
            int id;
            cmd.ExecuteNonQuery();
            id = (int)cmd.Parameters["@WebArtID"].Value;
            cnn.Close();
            string WebArtID = id.ToString();
            return WebArtID;

        }


        #endregion



        #region Update Article

        // NOTE   
        // probably need to overload this when updating the image as well
        // NOTE currently this method is NOT called by the ALL-IN-ONE-CRUD editor



        public string Update_WebArticle(int WebArtID,		//1
            int CatgegoryID,						//2
            int SubCatgegoryID,
            string WebArticle,		//3
            string Title,				//4
            string Header,
            string Footer,
            string ArtType,
            string publish,			//5
            string keywords,			//6
            DateTime updated,
            byte[] ImageContent,		//7
            bool picture)					//8
        {
            // NOTE currently this method is NOT called by the ALL-IN-ONE-CRUD editor
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcomweb_articles_update", cnn);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlParameter returnParam = new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4);
            returnParam.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(returnParam);

            SqlParameter param = cmd.Parameters.Add("@WebArtID", System.Data.SqlDbType.Int, 4);
            param.Value = WebArtID;  //1 WebArtID

            param = cmd.Parameters.Add("@CatgegoryID", System.Data.SqlDbType.Int, 4);
            param.Value = CatgegoryID;  //2 CatgegoryID

            param = cmd.Parameters.Add("@SubCatgegoryID", System.Data.SqlDbType.Int, 4);
            param.Value = SubCatgegoryID;  //3 SubCatgegoryID

            param = cmd.Parameters.Add("@WebArticle", System.Data.SqlDbType.NText);
            param.Value = WebArticle;  //4 WebArticle

            param = cmd.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar, 250);
            param.Value = Title;  //5 WebArticle

            param = cmd.Parameters.Add("@Header", System.Data.SqlDbType.VarChar, 50);
            param.Value = Header;  //6 Header

            param = cmd.Parameters.Add("@Footer", System.Data.SqlDbType.VarChar, 50);
            param.Value = Footer;  //7 Footer

            param = cmd.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar, 250);
            param.Value = Title;  //5 WebArticle

            param = cmd.Parameters.Add("@picture", System.Data.SqlDbType.Bit);
            param.Value = picture;		//8 picture

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }

            catch (SQL.SqlException e)
            {

                if (e.Number == 50004)
                    return e.ToString();
            }

            return result = "Done!";
        }





        #endregion


        public DataSet GetArticletitle()
        {
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("CFcom_web_ArticleTitles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            ds.DataSetName = "urlset";
            da.Fill(ds, "url");

            return ds;
        }






        // should be renamed to Web Site Cartegories when reorganisized.
        public SqlDataReader WebAppTypes()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_getwebcats", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }




        // redundent, only used for Bear Site
        public SqlDataReader WebArts3Top()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.BEARweb_3top", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }





        // kc_admin.BEARweb_crawlerArticles


        public SqlDataReader WebArtsAllCrawler()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_crawlerArticles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }



        public DataSet WebArtsAllSetsCrawler()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_crawlerArticles", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            ds.DataSetName = "urlset";
            da.Fill(ds, "url");



            return ds;
        }



        public DataSet GoogleSiteMap()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_web_Google", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataSet ds = new DataSet();
            ds.DataSetName = "urlset";
            da.Fill(ds, "url");



            return ds;
        }



        // obsolete redundent proc call.
        public SqlDataReader WebAppExampleTypes()
        {
            // SqlConnection cnn = new SqlConnection(DatabaseConnectionString);
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.BEARweb_AppExampleTypes", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }



        private void ReadImage()
        {
            string strImageID = HttpContext.Current.Request.QueryString["cid"];

            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("Select PersonImageType, PersonImage from person Where PersonID=" + strImageID, cnn);


            cnn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                HttpContext.Current.Response.ContentType = "gif";
                HttpContext.Current.Response.BinaryWrite((byte[])dr["imgdata"]);



            }


            //Response.ContentType = dr["imgtype"].ToString();
            //	Response.BinaryWrite( (byte[]) dr["imgdata"] );


        }


        #region write a link,, Just a learning sample from IBuySpy Portal

        //		   int moduleId = 0;
        //		public int AddLink(int moduleId, int itemId, String userName, String title, String url, String mobileUrl, int viewOrder, String description) 
        //		{
        //
        ////			if (userName.Length < 1) 
        ////			{
        ////				userName = "unknown";
        ////			}
        //
        //			// Create Instance of Connection and Command Object
        //			SqlConnection myConnection = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["PconnectionString"]);
        //			SqlCommand myCommand = new SqlCommand("Portal_AddLink", myConnection);
        //
        //			// Mark the Command as a SPROC
        //			myCommand.CommandType = CommandType.StoredProcedure;
        //
        //			// Add Parameters to SPROC
        //			SqlParameter parameterItemID = new SqlParameter("@ItemID", SqlDbType.Int, 4);
        //			parameterItemID.Direction = ParameterDirection.Output;
        //			myCommand.Parameters.Add(parameterItemID);
        //
        //			SqlParameter parameterModuleID = new SqlParameter("@ModuleID", SqlDbType.Int, 4);
        //			parameterModuleID.Value = moduleId;
        //			myCommand.Parameters.Add(parameterModuleID);
        //
        //			SqlParameter parameterUserName = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
        //			parameterUserName.Value = userName;
        //			myCommand.Parameters.Add(parameterUserName);
        //
        //			SqlParameter parameterTitle = new SqlParameter("@Title", SqlDbType.NVarChar, 100);
        //			parameterTitle.Value = title;
        //			myCommand.Parameters.Add(parameterTitle);
        //
        //			SqlParameter parameterDescription = new SqlParameter("@Description", SqlDbType.NVarChar, 100);
        //			parameterDescription.Value = description;
        //			myCommand.Parameters.Add(parameterDescription);
        //
        //			SqlParameter parameterUrl = new SqlParameter("@Url", SqlDbType.NVarChar, 100);
        //			parameterUrl.Value = url;
        //			myCommand.Parameters.Add(parameterUrl);
        //
        //			SqlParameter parameterMobileUrl = new SqlParameter("@MobileUrl", SqlDbType.NVarChar, 100);
        //			parameterMobileUrl.Value = mobileUrl;
        //			myCommand.Parameters.Add(parameterMobileUrl);
        //
        //			SqlParameter parameterViewOrder = new SqlParameter("@ViewOrder", SqlDbType.Int, 4);
        //			parameterViewOrder.Value = viewOrder;
        //			myCommand.Parameters.Add(parameterViewOrder);
        //
        //			myConnection.Open();
        //			myCommand.ExecuteNonQuery();
        //			myConnection.Close();
        //
        //			return (int)parameterItemID.Value;
        //		}
        #endregion

        // obsolete
        public DataSet searchArticles(string searchString)
        {
            SqlConnection cnn = new SQL.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SQL.SqlCommand cmd = new SQL.SqlCommand("web_article_Search", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SQL.SqlParameter param1 = new SQL.SqlParameter("@searchString", SqlDbType.VarChar, 128);
            param1.Value = searchString;
            cmd.Parameters.Add(param1);

            SQL.SqlDataAdapter da = new SQL.SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataSet empty = new DataSet();
            try
            {
                cnn.Open();
                da.Fill(ds, "SearchResult");
                cnn.Close();
            }

            catch (SQL.SqlException e)
            {


                //	if (e.Number == 50002)


                //		return nonefound;
                // catch (Exception ex){throw (ex);}

                return empty;
            }

            cnn.Close();
            return ds;

        }






        public Thecopy GetWebArticleByArticleID(int WebArtID)
        {
            //	if (!Regex.IsMatch(AppType.ToString(), @"^\d{1}$", RegexOptions.Compiled))
            //	return null;
            ///		
            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_read_web_articles_by_id", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmWebArtID = new SqlParameter("@WebArtID", SqlDbType.Int, 4);
            prmWebArtID.Value = WebArtID;
            cmd.Parameters.Add(prmWebArtID);

            SqlParameter prmWebArticle = new SqlParameter("@WebArticle", SqlDbType.NVarChar, 3800);
            prmWebArticle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle);

            SqlParameter prmWebArticle2 = new SqlParameter("@WebArticle2", SqlDbType.NVarChar, 3800);
            prmWebArticle2.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmWebArticle2);

            SqlParameter prmArticleTitle = new SqlParameter("@Title", SqlDbType.VarChar, 250);
            prmArticleTitle.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmArticleTitle);

            SqlParameter prmHasPic = new SqlParameter("@hasPic", SqlDbType.Int, 4);
            prmHasPic.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasPic);

            SqlParameter prmHasCode = new SqlParameter("@hasCode", SqlDbType.Int, 4);
            prmHasCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmHasCode);

            SqlParameter prmCode = new SqlParameter("@Code", SqlDbType.NVarChar, 2500);
            prmCode.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmCode);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            Thecopy columntext = new Thecopy();

            if (prmWebArticle.Value != DBNull.Value)
            { columntext.monologue = ((string)prmWebArticle.Value).Trim(); }

            if (prmWebArticle2.Value != DBNull.Value)
            { columntext.mono2 = ((string)prmWebArticle2.Value).Trim(); }


            if (prmArticleTitle.Value != DBNull.Value)
            { columntext.Title = ((string)prmArticleTitle.Value).Trim(); }
            if (prmHasPic.Value != DBNull.Value)
            { columntext.hasPic = ((int)prmHasPic.Value); }

            if (prmHasCode.Value != DBNull.Value)
            { columntext.hasCode = ((int)prmHasCode.Value); }

            if (prmCode.Value != DBNull.Value)
            { columntext.Code = ((string)prmCode.Value).Trim(); }


            if (prmHasPic.Value != (DBNull.Value))
            {
                columntext.hasPic = ((int)prmHasPic.Value);
                return columntext;
            }
            else
                // 			{ columntext.hasPic=false;}


                return columntext;

        }







        public string ArticleCount(int categoryid)
        {

            SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            SqlCommand cmd = new SqlCommand("kc_admin.CFcom_WebArtCount", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter prmcategoryid = new SqlParameter("@categoryid", SqlDbType.Int, 4);
            prmcategoryid.Value = categoryid;
            cmd.Parameters.Add(prmcategoryid);

            SqlParameter prmNumOfArts = new SqlParameter("@NumOfArts", SqlDbType.NVarChar, 6);
            prmNumOfArts.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(prmNumOfArts);


            cnn.Open();
            cmd.ExecuteNonQuery();
            string num = (prmNumOfArts.Value.ToString());
            cnn.Close();
            return num;

        }





    }		// eoc
}  // eon


