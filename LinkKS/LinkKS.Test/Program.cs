using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkKS.Business;

namespace LinkKS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //var link = new Link();
            //var shortLink = link.Shorten("http://www.empatik.com", null, "12345");
            // link.UpdatePassword(new Guid("0D7FA621-1BBE-44C1-BBDF-D3B497FC16D5"), "789");
            // link.UpdateExpireDate(new Guid("0D7FA621-1BBE-44C1-BBDF-D3B497FC16D5"), new DateTime(2016, 12, 16));
            //link.UpdateNotification(new Guid("0D7FA621-1BBE-44C1-BBDF-D3B497FC16D5"), true);
            //link.UpdateOneShot(new Guid("0D7FA621-1BBE-44C1-BBDF-D3B497FC16D5"), true);

            var user = new User();
            // var id = user.SignUp("saliha", "salihayesilyurt@hotmail.com", "1234");
            //user.UpdateProfile(new Guid("EE05A40E-04E6-4E36-998F-B93A6DB62568"), "saliha", "salihayesilyurt@hotmail.com", "753");

            var item = user.SignIn("salihayesilyurt@hotmail.com", "753");
            Console.WriteLine(item);
            Console.ReadKey();

        }
    }
}
