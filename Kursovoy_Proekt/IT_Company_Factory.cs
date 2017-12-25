using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
   public abstract class IT_Company_Factory
    {
        public abstract Design Create_Design();
        public abstract Front_End Create_Front_End();
        public abstract Back_End Create_Back_End();
        public abstract Mobile Create_Mobile();
    }
}
