using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BasePage
/// </summary>
public abstract class BasePage : System.Web.UI.Page
{
    public abstract String getMainNavSelectedControlId();
}