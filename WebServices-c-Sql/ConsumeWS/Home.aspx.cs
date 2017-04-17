using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ConsumeWS
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WsDb.DBSoapClient ws = new WsDb.DBSoapClient();
            DataSet ds = ws.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}