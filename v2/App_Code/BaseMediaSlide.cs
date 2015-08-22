using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BaseMediaSlide
/// </summary>
public abstract class BaseMediaSlide : System.Web.UI.UserControl
{
    public String SlideId { get; set; }
    protected String ContentClassAttribute = String.Empty;
    public abstract String getMediaContentHtml(String id);
    public void setContentClassAttribute(String attribute)
    {
        this.ContentClassAttribute = attribute;
    }
}