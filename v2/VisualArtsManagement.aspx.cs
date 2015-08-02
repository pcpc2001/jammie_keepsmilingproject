using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    public static readonly String MainNavControlId = "nav_item_visual_arts_management";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public override string getMainNavSelectedControlId()
    {
        return MainNavControlId;
    }
}