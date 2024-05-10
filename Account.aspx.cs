using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Member_Account : System.Web.UI.Page
{
    private DS_USER.USERMST_SELECTDataTable UDT = new DS_USER.USERMST_SELECTDataTable();
    private DS_USERTableAdapters.USERMST_SELECTTableAdapter UAdapter = new DS_USERTableAdapters.USERMST_SELECTTableAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UDT = UAdapter.SELECT();
            GridView3.DataSource = UDT;
            GridView3.DataBind();
            lbl.Text = GridView3.Rows.Count.ToString();
        }
    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        // You can add code here to handle the selection change event
    }
}
