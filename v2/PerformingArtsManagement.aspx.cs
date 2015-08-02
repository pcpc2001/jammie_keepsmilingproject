using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    public static readonly String MainNavContorlId = "nav_item_performing_arts_management";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public override string getMainNavSelectedControlId()
    {
        return MainNavContorlId;
    }
}