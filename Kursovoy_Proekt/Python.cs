﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Python : Back_End
    {
        public override void Develop_Python()
        {
            Console.WriteLine("We can develop BackEnd on Python");
        }

        public override void Develop_PHP()
        {
            Console.WriteLine("We can't develop BackEnd on PHP");
        }
    }
}
