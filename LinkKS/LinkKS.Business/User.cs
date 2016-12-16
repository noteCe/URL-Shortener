using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    public class User : IUser
    {
        public Guid? SignIn(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Guid SignUp(string name, string email, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfile(Guid userId, string name, string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
