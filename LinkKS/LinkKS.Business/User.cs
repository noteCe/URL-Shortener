using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    public class User : IUser
    {
        #region SignIn

        public Guid? SignIn(string email, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.USERs.FirstOrDefault(c => c.EMail == email && c.Password == password);

                return item.ID;

            }
        }

        #endregion


        #region SignUp

        public Guid SignUp(string name, string email, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = new USER();

                item.ID = Guid.NewGuid();
                item.Name = name;
                item.EMail = email;
                item.Password = password;
                item.CreatedDate = DateTime.Now;

                dc.USERs.InsertOnSubmit(item);
                dc.SubmitChanges();

                return item.ID;
            }
        }

        #endregion

        #region UpdateProfile

        public void UpdateProfile(Guid userId, string name, string email, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.USERs.First(c => c.ID == userId);
                item.Name = name;
                item.EMail = email;
                item.Password = password;

                dc.SubmitChanges();
            }
        }
        #endregion

    }
}
