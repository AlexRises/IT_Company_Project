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
        public abstract Design_2 Create_Design_2();
        public abstract Front_End_2 Create_Front_End_2();
        public abstract Back_End_2 Create_Back_End_2();
        public abstract Mobile_2 Create_Mobile_2();

        public void TemplateMethod()
        {
            Start_Design_Development();
            Start_FrontEnd_Development();
            Start_BackEnd_Development();
            Start_Mobile_Development();
            Finish_Design_Development();
            Finish_FrontEnd_Development();
            Finish_BackEnd_Development();
            Finish_Mobile_Development();

        }

        public abstract void Start_Design_Development();
        public abstract void Start_FrontEnd_Development();
        public abstract void Start_BackEnd_Development();
        public abstract void Start_Mobile_Development();
        public abstract void Finish_Design_Development();
        public abstract void Finish_FrontEnd_Development();
        public abstract void Finish_BackEnd_Development();
        public abstract void Finish_Mobile_Development();

    }
}
