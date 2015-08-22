using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MediaSlideEmptyFiller : BaseMediaSlide
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public override string getMediaContentHtml(string id)
    {
        return String.Format("<div id=\"{0}\"{1}/>",
            id,
            this.ContentClassAttribute
            );
    }
}