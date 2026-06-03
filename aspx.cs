using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnHello_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "Hello from ASP.NET Framework!";
    }
}