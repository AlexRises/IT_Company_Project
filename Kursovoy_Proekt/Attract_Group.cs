using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Attract_Group:IT_Company_Factory
    {
        public override Design_2 Create_Design_2()
        {
            return new Photoshop_Illustator_Design();
        }

        public override Front_End_2 Create_Front_End_2()
        {
            return new VueJS();
        }

        public override Back_End_2 Create_Back_End_2()
        {
            return new PHP();
        }

        public override Back_End Create_Back_End()
        {
            return new Python();
        }

        public override Mobile_2 Create_Mobile_2()
        {
            return new iOS();
        }

        public override Design Create_Design()
        {
            return null;
        }
        public override Front_End Create_Front_End()
        {
            return null;
        }

        public override Mobile Create_Mobile()
        {
            return null;
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

        public override void Finish_Design_Development()
        {
            Console.WriteLine("We have finished Design Development");
        }

        public override void Finish_FrontEnd_Development()
        {
            Console.WriteLine("We have finished FrontEnd Development");
        }
        public override void Finish_BackEnd_Development()
        {
            Console.WriteLine("We have finished BackEnd Development");
        }

        public override void Finish_Mobile_Development()
        {
            Console.WriteLine("We have finished Mobile Development");
        }
    }
}
