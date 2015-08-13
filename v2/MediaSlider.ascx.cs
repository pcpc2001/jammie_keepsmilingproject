using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MediaSlider : System.Web.UI.UserControl
{
    public static readonly String KEY_CONTENT_CLASS = "ContentClass";

    [PersistenceMode(PersistenceMode.InnerProperty)]
    public List<BaseMediaSlide> MediaSlideElements { get; set; }

    //public MediaSlideImage ImageSlide { get; set; }

    public int getMediaElementCount()
    {
        return this.MediaSlideElements == null ? 0 : this.MediaSlideElements.Count;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        String contentAttr = this.getAttributeContentClass();
        if (contentAttr != null || contentAttr.Length > 0)
        {
            contentAttr = String.Format("{0}=\"{1}\"",
                "class",
                contentAttr);
        }
        foreach (BaseMediaSlide element in this.MediaSlideElements)
        {
            element.setContentClassAttribute(contentAttr);
        }

        /// Code to register start up script.
        //ClientScriptManager cs = this.Page.ClientScript;
        //String csName = "initScript";
        //Type cstype = this.GetType();
        
        //if (!cs.IsStartupScriptRegistered(cstype, csName))
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(String.Format("<script type=text/javascript>init(); setMediaCount({0}); getDummy();</script>",
        //        this.getMediaElementCount()));

        //    cs.RegisterStartupScript(cstype, csName, sb.ToString());
        //}
    }

    private String getAttributeContentClass()
    {
        String contentClass = this.Attributes[KEY_CONTENT_CLASS].ToString();
        if (contentClass == null)
        {
            return String.Empty;
        }
        return contentClass;
    }

    protected String renderSliderElements(String elementIdPrefix)
    {
        StringBuilder sb = new StringBuilder();
        String prefix = elementIdPrefix;
        if (prefix == null || prefix.Length <= 0)
        {
            prefix = "sliderElement";
        }
        for (int i = 0; i < this.MediaSlideElements.Count; i++)
        {
            String id = String.Format("{0}{1}", prefix, i.ToString());
            sb.AppendLine(this.MediaSlideElements[i].getMediaContentHtml(id));
        }
        return sb.ToString();
    }
}