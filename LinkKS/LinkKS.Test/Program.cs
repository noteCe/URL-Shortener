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
            var link = new Link();
            //var shortLink = link.Shorten("http://www.empatik.com", null, "12345");
            link.UpdatePassword(new Guid("0D7FA621-1BBE-44C1-BBDF-D3B497FC16D5"), "789");

        }
    }
}
