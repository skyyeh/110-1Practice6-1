using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice6_1
{
    public partial class CheckBoxCom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("book") == "buy")
            {
                Response.Write("要購買書籍");
            }
            else if (Request.Form.Get("book") == "nbuy")
            {
                Response.Write("沒有要購買書籍");
            }
            else if(Request.Form.Get("book") == "科幻書")
                {
                    Response.Write("科幻書");
                }
            else
                {
                    Response.Write("教科書");
                }
            }

        }
    }
