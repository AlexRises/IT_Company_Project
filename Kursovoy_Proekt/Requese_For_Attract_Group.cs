using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Request_For_Attract_Group
    {
        Design Attract_Group_Design;
        Front_End Attract_Group_FrontEnd;
        Back_End Attract_Group_BackEnd;
        Mobile Attract_Group_Mobile;

        public Request_For_Attract_Group(IT_Company_Factory request)
        {
            Attract_Group_Design = request.Create_Design();
            Attract_Group_FrontEnd = request.Create_Front_End();
            Attract_Group_BackEnd = request.Create_Back_End();
            Attract_Group_Mobile = request.Create_Mobile();
        }

        public void Request_For_Development_Design()
        {
            Attract_Group_Design.Develop_Photoshop_Illustator_Design();
        }

        public void Request_For_Development_FrontEnd()
        {
            Attract_Group_FrontEnd.Develop_VueJS();
        }

        public void Request_For_Development_BackEnd_on_Python()
        {
            Attract_Group_BackEnd.Develop_Python();
        }

        public void Request_For_Development_BackEnd_on_PHP()
        {
            Attract_Group_BackEnd.Develop_PHP();
        }
        public void Request_For_Development_Mobile()
        {
            Attract_Group_Mobile.Develop_iOS();
        }
    }
}
