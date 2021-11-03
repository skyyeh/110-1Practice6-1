﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice6_1
{
    public partial class DDList : System.Web.UI.Page
    {
        string[,] sa_Place = new string[2, 3] { { "基隆", "台北", "新北" }, { "苗栗", "台中", "南投" } };
        protected void Page_Load(object sender, EventArgs e)
        {


            if (IsPostBack == false)
            {

                ListItem o_Li = new ListItem("北區", "北區");
                ddl_Area.Items.Add(o_Li);

                o_Li = new ListItem("中區", "中區");
                ddl_Area.Items.Add(o_Li);



                for (int i_Ct = 0; i_Ct < 3; i_Ct++)
                {
                    o_Li = new ListItem(sa_Place[0, i_Ct], sa_Place[0, i_Ct]);
                    ddl_Place.Items.Add(o_Li);
                }
            }

        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();

            ListItem o_Li;

            if (ddl_Area.SelectedValue == "北區")
            {
                o_Li = new ListItem("基隆", "基隆");
                ddl_Place.Items.Add(o_Li);

                o_Li = new ListItem("台北", "台北");
                ddl_Place.Items.Add(o_Li);

                o_Li = new ListItem("新北", "新北");
                ddl_Place.Items.Add(o_Li);
            }
            else
            {
                o_Li = new ListItem("苗栗", "苗栗");
                ddl_Place.Items.Add(o_Li);

                o_Li = new ListItem("台中", "台中");
                ddl_Place.Items.Add(o_Li);

                o_Li = new ListItem("南投", "南投");
                ddl_Place.Items.Add(o_Li);
            }
        }
    }
}