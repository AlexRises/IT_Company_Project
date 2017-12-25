using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Photoshop_Design : Design
    {
        public override void Develop_Photoshop_Design()
        {
            Console.WriteLine("We can develop Design in Photoshop");
        }

        public override void Develop_Photoshop_Illustator_Design()
        {
            Console.WriteLine("We don't develop Design both in Photoshop and Illustrator");
        }
    }
}
    