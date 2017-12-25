using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Android : Mobile
    {
        public override void Develop_Android()
        {
            Console.WriteLine("We can develop mobile app for Android");
        }

        public override void Develop_iOS()
        {
            Console.WriteLine("We can't develop mobile app for iOS");
        }
    }
}
