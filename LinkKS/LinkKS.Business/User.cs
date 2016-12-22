using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkKS.DTO;

namespace LinkKS.Business
{
    public class User : IUser
    {
        public DTO_USER GetProfile(Guid userId)
        {
           
            using (var dc = new LinkKSDataContext())
            {
                return dc.USERs.Where(x => x.ID == userId).Select(c => new DTO_USER
                {
                    Name = c.Name,
                    Email=c.EMail,
                    Password=c.Password

                }).FirstOrDefault();
            }
        }
        #region SignIn

        public Guid? SignIn(string email, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var id = dc.USERs.Where(x => x.EMail == email && x.Password == password).Select(c => c.ID).FirstOrDefault();

                if (id == Guid.Empty) // Empty=0
                {
                    return null;
                }
                return id;

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
