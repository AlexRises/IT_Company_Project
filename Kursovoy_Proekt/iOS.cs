using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class iOS : Mobile
    {
        public override void Develop_iOS()
        {
            Console.WriteLine("We can develop an app for iOS");
        }

        public override void Develop_Android()
        {
            Console.WriteLine("We can't develop an app for Android");
        }

    }
}
