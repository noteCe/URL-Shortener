using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkKS.Business
{
    interface ILink
    {
        //Üye ise UserId'i gelecek, üye değilse null gelecek. notification checkbox ı üye olanlara visible, üye olmayanlara visible
        //gözükecek.
        string Shorten(string longLink, Guid? userId, string password);
        
        //Linkin sadece son kullanım tarihini güncellemek
        bool UpdateExpireDate(Guid linkId, DateTime? expireDate);

        //Linkin sadece şifresini güncellemek
        bool UpdatePassword(Guid linkId, string password);

        //Linkin sadece bildirim ayarını güncellemek
        bool UpdateNotification(Guid linkId, bool notification);

        //Linkin sadece bir kullanımlık olup olmadığını güncellemek
        bool UpdateOneShot(Guid linkId, bool oneShot);

        //UpdateStatus(Guid linkId, enum_tipinde_deger);

    }
}
