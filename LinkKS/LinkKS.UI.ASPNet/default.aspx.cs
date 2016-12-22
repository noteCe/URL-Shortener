using LinkKS.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinkKS.UI.ASPNet
{
    public partial class _default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnGetir_Click(object sender, EventArgs e)
        {
            var binding = new BasicHttpBinding();
            var adress = new EndpointAddress("http://localhost:64615/LinkKSService.svc");
            var channel = ChannelFactory<ILinkKSServiceContract>.CreateChannel(binding, adress);

            var user = channel.GetUserProfile(new Guid("EE05A40E-04E6-4E36-998F-B93A6DB62568"));

            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
        }
    }
}