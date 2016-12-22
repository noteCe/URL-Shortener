using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using LinkKS.ServiceContract;
using LinkKS.Business;
using LinkKS.DTO;

namespace LinkKS.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LinkKSService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LinkKSService.svc or LinkKSService.svc.cs at the Solution Explorer and start debugging.
    public class LinkKSService : ILinkKSServiceContract
    {
        public DTO_USER GetUserProfile(Guid userId)
        {
            var userProfile = new User();
           return userProfile.GetProfile(userId);

        }

        public void UpdateLinkPassword(Guid linkId, string password)
        {
            var link = new Link();
            link.UpdatePassword(linkId, password);
        }

        public Guid UserSignUp(string name, string eMail, string password)
        {
            var user = new User();
           return user.SignUp(name, eMail, password);
        }
    }
}
