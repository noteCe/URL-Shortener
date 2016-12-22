﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.ServiceContract
{
    [ServiceContract]
    interface ILinkKSServiceContract
    {

        [OperationContract]
        Guid UserSignUp(string name, string eMail, string password);

        [OperationContract]
        void UpdateLinkPassword(Guid linkId, string password);



    }
}
