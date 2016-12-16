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
            var shortLink = link.Shorten("http://www.empatik.com", null, "12345");

        }
    }
}
