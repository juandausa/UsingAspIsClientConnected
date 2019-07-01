using System.Web.UI;

namespace WebForms.Utils
{
    public static class MasterPageExtensions
    {
        public static bool IsClientConnected(this MasterPage masterPage)
        {
            return masterPage.Response.IsClientConnected;
        }
    }
}