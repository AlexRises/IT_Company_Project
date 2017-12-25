using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Attract_Group:IT_Company_Factory
    {
        public override Design Create_Design()
        {
            return new Photoshop_Illustator_Design();
        }

        public override Front_End Create_Front_End()
        {
            return new VueJS();
        }

        public override Back_End Create_Back_End()
        {
            return new PHP();
        }

        public override Mobile Create_Mobile()
        {
            return new iOS();
        }

        public override void Start_Design_Development()
        {
            Console.WriteLine("We have started Design Development");
        }

        public override void Start_FrontEnd_Development()
        {
            Console.WriteLine("We have started FrontEnd Development");
        }
        public override void Start_BackEnd_Development()
        {
            Console.WriteLine("We have started BackEnd Development");
        }

        public override void Start_Mobile_Development()
        {
            Console.WriteLine("We have started Mobile Development");
        }
    }
}
