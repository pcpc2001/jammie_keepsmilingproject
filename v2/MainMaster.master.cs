using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.UI.HtmlControls;

public partial class MainMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Set active main nav <a> tag
        if (this.ContentPlaceHolder1.Page.GetType().IsSubclassOf(typeof(BasePage)))
        {
            BasePage contentPage = (BasePage)this.ContentPlaceHolder1.Page;

            Control navItemDiv = this.FindControl(contentPage.getMainNavSelectedControlId());
            if (navItemDiv != null)
            {
                //Control aControl = navItemDiv.Controls[0];
                foreach (Control cont in navItemDiv.Controls)
                {
                    HtmlControl htmlCont = (HtmlControl)cont;
                    htmlCont.Attributes.Add("class", "active");
                    //if (cont.GetType().IsInstanceOfType(typeof(HtmlAnchor)))
                    //{
                    //    HtmlAnchor a = (HtmlAnchor)cont;
                    //    a.Attributes.Add("class", "active");
                    //}
                }
                
            }
        }
    }
}
