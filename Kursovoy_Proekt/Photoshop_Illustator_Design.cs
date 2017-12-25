using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
   public class Photoshop_Illustator_Design:Design 
    {
        public override void Develop_Photoshop_Illustator_Design()
        {
            Console.WriteLine("We can develop Design in Photoshop and in Illustrator");
        }

        public override void Develop_Photoshop_Design()
        {
            Console.WriteLine("We don't develop Desing only in Photoshop");
        }
    }
}
