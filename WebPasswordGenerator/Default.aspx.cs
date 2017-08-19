using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

namespace GeradorSenhasWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string[] GetPasswords(string characters, int minSize, int maxSize, int numberPasswords)
        {
            //WSPasswordGenerator.PasswordGeneratorClient wsPasswordGenerator = new WSPasswordGenerator.PasswordGeneratorClient();
            //return wsPasswordGenerator.getPasswords(characters, minSize, maxSize, numberPasswords);

            WcfPasswordGenerator.PasswordGeneratorClient wcfPasswordGenerator = new WcfPasswordGenerator.PasswordGeneratorClient();
            return wcfPasswordGenerator.GetPasswords(characters, minSize, maxSize, numberPasswords);
        }
    }
}
