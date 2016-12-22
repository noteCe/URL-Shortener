using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LinkKS.DTO;

namespace LinkKS.ServiceContract
{
    [ServiceContract]
    public interface ILinkKSServiceContract
    {

        [OperationContract]
        Guid UserSignUp(string name, string eMail, string password);

        [OperationContract]
        void UpdateLinkPassword(Guid linkId, string password);

        [OperationContract]
        DTO_USER GetUserProfile(Guid userId);


    }
}
