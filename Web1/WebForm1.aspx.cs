using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "测试VS2013中使用Github";
            this.form1.Name = "fm1";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "hello";
        }
    }
}