using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Request_For_Attract_Group
    {
        Design_2 Attract_Group_Design_2;
        Front_End_2 Attract_Group_FrontEnd_2;
        Back_End Attract_Group_BackEnd;
        Back_End_2 Attract_Group_BackEnd_2;
        Mobile_2 Attract_Group_Mobile_2;

        public Request_For_Attract_Group(IT_Company_Factory request)
        {
            Attract_Group_Design_2 = request.Create_Design_2();
            Attract_Group_FrontEnd_2 = request.Create_Front_End_2();
            Attract_Group_BackEnd_2 = request.Create_Back_End_2();
            Attract_Group_Mobile_2 = request.Create_Mobile_2();
            Attract_Group_BackEnd = request.Create_Back_End();
        }

        public void Request_For_Development_Design()
        {
            Attract_Group_Design_2.Develop_Photoshop_Illustator_Design();
        }

        public void Request_For_Development_FrontEnd()
        {
            Attract_Group_FrontEnd_2.Develop_VueJS();
        }

        public void Request_For_Development_BackEnd_on_Python()
        {
            Attract_Group_BackEnd.Develop_Python();
        }

        public void Request_For_Development_BackEnd_on_PHP()
        {
            Attract_Group_BackEnd_2.Develop_PHP();
        }
        public void Request_For_Development_Mobile()
        {
            Attract_Group_Mobile_2.Develop_iOS();
        }


    }
}
