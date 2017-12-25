using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public abstract class Attract_Group:IT_Company_Factory
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
    }
}
