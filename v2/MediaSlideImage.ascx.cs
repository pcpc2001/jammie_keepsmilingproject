using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MediaSlideImage : BaseMediaSlide
{
    public static readonly String KEY_SRC = "src";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public override string getMediaContentHtml(String id)
    {
        return String.Format("<img id=\"{0}\"{1} src=\"{2}\" />",
            id,
            this.ContentClassAttribute,
            this.getSrcAttribute());
    }

    private String getSrcAttribute()
    {
        String src = this.Attributes[KEY_SRC].ToString();
        if (src == null)
            return String.Empty;
        return src;
    }
}