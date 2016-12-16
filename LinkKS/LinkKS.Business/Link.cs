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
                item.ShortLink = this.GenerateShortLink(dc);
                item.UserID = userId;
                item.Password = password;
                item.CreatedDate = DateTime.Now;

                dc.LINKs.InsertOnSubmit(item);
                dc.SubmitChanges();

                return item.ShortLink;

            }
        }

        private const string ValidChars = "0123456789abcdefghijklmnopqrstuwvxyz";
        private string GenerateShortLink(LinkKSDataContext dc)
        {

            var rnd = new Random();
            while (true)
            {
                var shortLink = "";

                for (int i = 0; i < 6; i++)
                {
                    var index = rnd.Next(Link.ValidChars.Length);
                    shortLink += Link.ValidChars[index];
                }
                if (!dc.LINKs.Any(c => c.ShortLink == shortLink))
                {
                    return shortLink;
                }
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
