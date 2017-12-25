using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class BeetRoot : IT_Company_Factory
    {
        public override Design Create_Design()
        {
            return new Photoshop_Design();
        }

        public override Front_End Create_Front_End()
        {
            return new AngularJS();
        }

        public override Back_End Create_Back_End()
        {
            return new Python();
        }

        public override Mobile Create_Mobile()
        {
            return new Android();
        }
    }
}
