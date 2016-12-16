using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    public class Link : ILink
    {
        public string Shorten(string longLink, Guid? userId, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = new LINK();

                item.ID = Guid.NewGuid();
                item.LongLink = longLink;
                //item.ShortLink =
                item.UserID = userId;
                item.Password = password;
                item.CreatedDate = DateTime.Now;

                dc.LINKs.InsertOnSubmit(item);
                dc.SubmitChanges();

                return item.ShortLink;

            }
        }

        public bool UpdateExpireDate(Guid linkId, DateTime? expireDate)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNotification(Guid linkId, bool notification)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOneShot(Guid linkId, bool oneShot)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePassword(Guid linkId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
