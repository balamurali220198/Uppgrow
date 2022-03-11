using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace UpGrow.Admin_Bal
{
    public class Message
    {

        #region "MessageBox"
        public void ShowAlertMessage(string error)
        {

            Page page = HttpContext.Current.Handler as Page;

            if (page != null)
            {

                error = error.Replace("'", "\'");

                ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + error + "');", true);

            }
        }
        #endregion
    }
}