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
using System.IO;

public partial class Controls_WebArticlel : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
            ddlbind();
    }




    private void ddlbind()
    {
        Articles a = new Articles();
        ddlwebcats.DataSource = a.WebAppTypes();
        ddlwebcats.DataValueField = "CategoryID";
        ddlwebcats.DataTextField = "CategoryName";
        ddlwebcats.DataBind();
    }



    protected void btnAddNew_Click(object sender, EventArgs e)
    {

        #region button visibility
        //			if(btnAddNew.Text=="Cancel")
        //			{
        //							
        //				btnSave.CommandArgument=string.Empty;
        //				btnAddNew.Text="Add New";
        //				btnSave.Visible=false;
        //				return;
        //			}
        //
        //			btnSave.Visible=true;
        //			btnSave.CommandArgument="Add";
        //			btnAddNew.Text="Cancel";
        #endregion

        #region
        Articles newone = new Articles();
      //  WebicaModule.Classes.LinkDB link = new WebicaModule.Classes.LinkDB();

        string a;
        if (chkShowPic.Checked)		// this picks up whether the "Has Image" checkbox has been ticked and passes a 1 or 0
        { a = "1"; }
        else { a = "0"; }



        if (PersonImage.PostedFile.ContentLength < 0.5)
        {
            string NewRecID = newone.AddNew_WebArticle(

                        Int32.Parse(ddlwebcats.SelectedValue),
                        txtWebArticle.Text.Trim(),
                    txtWebArticle2.Text.Trim(),
                        txtTitle.Text.Trim(),
                        txtPublish.Text,
                        a,
                        txtArtType.Text.Trim(),
                            txtKeywords.Text.Trim());

            //						link.AddLink( 0, 14, Context.User.Identity.Name, "Title", UrlField.Text, "MobileUrlField",2,"DescriptionField Text" );
            //				link.UpdateHtmlText(28,DesktopText.Text,"alo","alo again");
        }
        else
        {

            Int32 intImageSize;
            string strImageType;
            Stream ImageStream;

            #region
            //				int imageLength;
            //				int imageHeight;
            //  imageLength=PersonImage.PostedFile.InputStream.
            #endregion

            intImageSize = PersonImage.PostedFile.ContentLength;
            strImageType = PersonImage.PostedFile.ContentType;
            ImageStream = PersonImage.PostedFile.InputStream;


            byte[] ImageContent = new byte[intImageSize];
            Int32 intStatus;
            intStatus = ImageStream.Read(ImageContent, 0, intImageSize);
            string NewRecID = newone.AddNew_WebArticle(Int32.Parse(ddlwebcats.SelectedValue), (txtWebArticle.Text.Trim()), (txtWebArticle2.Text.Trim()), txtTitle.Text.Trim(), txtPublish.Text, a, txtArtType.Text.Trim(), txtKeywords.Text.Trim(), ImageContent);


            //				link.AddLink( 0, 14, Context.User.Identity.Name, "Title", UrlField.Text, "MobileUrlField",2,"DescriptionField Text" );
            //				link.UpdateHtmlText(28,DesktopText.Text,"alo","alo again");
            //				link.AddLink( moduleId, itemId, Context.User.Identity.Name, TitleField.Text, UrlField.Text, MobileUrlField.Text, Int32.Parse(ViewOrderField.Text), DescriptionField.Text );


        }
        #endregion

        #region reobot
        //			create a loop for implementing an tomated record input robot
        //			int x=0;
        //			int y=1;
        //
        //
        //// newone.AddNew_WebArticle(int CategoryID,string WebArticle,string Title,string publish, string picture, string ArtType, string Keywords
        //			newone.AddNew_WebArticle( 
        //				CategoryID,
        //				WebArticle,
        //				Title,
        //				publish, 
        //				picture, 
        //				ArtType,
        //				Keywords

        #endregion

        

    }


    void InsertNewArticle()
    {

        Articles newone = new Articles();
    //    WebicaModule.Classes.LinkDB link = new WebicaModule.Classes.LinkDB();

        string a;
        if (chkShowPic.Checked)		// this picks up whether the "Has Image" checkbox has been ticked and passes a 1 or 0
        { a = "1"; }
        else { a = "0"; }



        if (PersonImage.PostedFile.ContentLength < 0.5)
        {
            string NewRecID = newone.AddNew_WebArticle(

                Int32.Parse(ddlwebcats.SelectedValue),
                txtWebArticle.Text.Trim(),
                    txtWebArticle2.Text.Trim(),
                txtTitle.Text.Trim(),
                txtPublish.Text,
                a,
                txtArtType.Text.Trim(),
                txtKeywords.Text.Trim());


            lblPK.Text = NewRecID;
            ViewHyperLink.NavigateUrl = "~/Web.aspx?id=" + NewRecID;


        }
        else
        {

            Int32 intImageSize;
            string strImageType;
            Stream ImageStream;

            intImageSize = PersonImage.PostedFile.ContentLength;
            strImageType = PersonImage.PostedFile.ContentType;
            ImageStream = PersonImage.PostedFile.InputStream;


            byte[] ImageContent = new byte[intImageSize];
            Int32 intStatus;
            intStatus = ImageStream.Read(ImageContent, 0, intImageSize);
            string NewRecID = newone.AddNew_WebArticle(Int32.Parse(ddlwebcats.SelectedValue), (txtWebArticle.Text.Trim()), (txtWebArticle2.Text.Trim()), txtTitle.Text.Trim(), txtPublish.Text, a, txtArtType.Text.Trim(), txtKeywords.Text.Trim(), ImageContent);


            lblPK.Text = NewRecID;
            ViewHyperLink.NavigateUrl = "~/Web.aspx?id=" + NewRecID;
        }

    }


    private void AddImage()
    {
        Int32 intImageSize;
        string strImageType;
        Stream ImageStream;

        intImageSize = PersonImage.PostedFile.ContentLength;
        strImageType = PersonImage.PostedFile.ContentType;
        ImageStream = PersonImage.PostedFile.InputStream;



        byte[] ImageContent = new byte[intImageSize];
        Int32 intStatus;
        intStatus = ImageStream.Read(ImageContent, 0, intImageSize);
    }





    protected void btnSearch_Click(object sender, EventArgs e)
    {
        populateDataGrid();
        #region learning example
        //			if(txbSearch.Text.Length>=1.5)
        //			{
        //
        //				string find=txbSearch.Text;
        //				string Numberfound;
        //
        //				WebicaApps.Articles art = new WebicaApps.Articles()	;
        //					
        //				DataSet ds=art.searchArticles(find);
        //				Numberfound=ds.Tables["SearchResult"].Rows.Count.ToString();
        //
        //				
        //				lblrows.Text=Numberfound;
        //						
        //				dg.DataSource=ds;
        //				dg.DataBind();
        //							
        //			}
        //			else return;
        #endregion
    }






    protected void btnSave_Click(object sender, EventArgs e)
    {
        InsertNewArticle();
    }


    private void populateDataGrid()
    {
        if (txbSearch.Text.Length >= 1.5)
        {

            string find = txbSearch.Text;
            string Numberfound;

            Articles art = new Articles();

            DataSet ds = art.searchArticles(find);
            Numberfound = ds.Tables["SearchResult"].Rows.Count.ToString();


            lblrows.Text = Numberfound;

            dg.DataSource = ds;
            dg.DataBind();

        }
        else return;


    }







    protected void dg_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
    {
        dg.CurrentPageIndex = e.NewPageIndex;
        populateDataGrid();
    }
    protected void dg_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        if ((e.Item.ItemType == ListItemType.Pager) | (
                e.Item.ItemType == ListItemType.Header))
        { return; }

        btnSave.Visible = true;
        LinkButton btn = (LinkButton)e.CommandSource;
        if (btn.Text == "Edit")
        {
            // set the button for the next user action
            btnSave.Text = "Update";
            btnSave.CommandArgument = "Update";
            btnAddNew.Visible = false;

            txtWebArticle.Text = ((Label)e.Item.FindControl("WebArticle")).Text;
            txtTitle.Text = ((Label)e.Item.FindControl("Title")).Text;

        }
    }
}
