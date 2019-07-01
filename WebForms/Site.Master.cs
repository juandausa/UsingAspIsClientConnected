using System;
using System.Web.UI;
using WebForms.Utils;


namespace WebForms
{
    public partial class SiteMaster : MasterPage
    {
        static int TotalRequest { get; set; }
        static int TotalEfectiveRequest { get; set; }
        protected override void OnInit(EventArgs e)
        {
            TotalRequest += 1;
            if (!this.IsClientConnected())
            {
                Response.End();
                return;
            }

            TotalEfectiveRequest += 1;
        }
    }
}