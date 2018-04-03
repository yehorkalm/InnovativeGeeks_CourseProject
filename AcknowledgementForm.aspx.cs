﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AcknowledgementForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["Status"].Equals("Fail"))
        {
            LabelAcknowledgement.Text = "Transcation unSuccessful!";

        }
        else
        {
            LabelAcknowledgement.Text = "Transcation Successful!";

        }

    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}