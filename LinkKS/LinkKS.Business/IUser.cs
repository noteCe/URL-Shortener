using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    interface IUser
    {

        Guid SignUp(string name, string email, string password);
        Guid? SignIn(string email, string password);//şifre doğruysa userid, yanlışsa null
        void UpdateProfile(Guid userId, string name, string email, string password);
    }
}
