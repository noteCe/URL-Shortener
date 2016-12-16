using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    public class Link : ILink
    {
        #region Shorten link kısaltma metodu
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
        #endregion

        #region GenerateShortLink rastgele deger üretme metodu
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
        #endregion

        #region UpdateExpireDate 
        public void UpdateExpireDate(Guid linkId, DateTime? expireDate)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.LINKs.First(c => c.ID == linkId);
                item.ExpireDate = expireDate;

                dc.SubmitChanges();
            }
        }
        #endregion

        #region UpdateNotification
        public void UpdateNotification(Guid linkId, bool notification)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.LINKs.First(c => c.ID == linkId);
                item.Notification = notification;

                dc.SubmitChanges();
            }
        }

        #endregion

        #region UpdateOneShot
        public void UpdateOneShot(Guid linkId, bool oneShot)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.LINKs.First(c => c.ID == linkId);
                item.OneShot = oneShot;

                dc.SubmitChanges();
            }
        }
        #endregion

        #region UpdatePassword
        public void UpdatePassword(Guid linkId, string password)
        {
            using (var dc = new LinkKSDataContext())
            {
                var item = dc.LINKs.First(c => c.ID == linkId);
                item.Password = password;

                dc.SubmitChanges();
            }
        }
        #endregion
    }
}
