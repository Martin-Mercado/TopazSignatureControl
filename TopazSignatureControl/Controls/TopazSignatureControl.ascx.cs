using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TopazSignatureControl.Controls
{
    public partial class TopazSignatureControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // 0 = Cursor
        // 1 = Tableta Topaz
        public void StartSignature( int padMode = 0)
        {
            PadModeHf.Value = padMode.ToString();

            Page.ClientScript.RegisterStartupScript(
                this.GetType(),
                "StartSignature",
                "startSignature();",
                true
            );
        }

        public void ClearSignature()
        {
            Page.ClientScript.RegisterStartupScript(
               this.GetType(),
               "ClearSignature",
               "ClearSignature();",
               true
           );
        }

        public string GetSignature() 
        {
            Page.ClientScript.RegisterStartupScript(
               this.GetType(),
               "SignatureDone",
               "signatureDone();",
               true
            );

            return SignatureHf.Value;
        }
    }
}