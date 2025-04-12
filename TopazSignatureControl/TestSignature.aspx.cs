using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TopazSignatureControl
{
    public partial class TestSignature : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TopazSignatureControl.PadMode = 0;
            TopazSignatureControl.StartSignature();
            
        }

        protected void ConfirmSignatureBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine($"Signature is: {TopazSignatureControl.GetSignature()}");
        }

        protected void ClearSignature_Click(object sender, EventArgs e)
        {
            TopazSignatureControl.ClearSignature();
        }
    }
}