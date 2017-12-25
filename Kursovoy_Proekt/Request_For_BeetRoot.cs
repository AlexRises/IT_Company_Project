using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Request_For_BeetRoot
    {
        Design BeetRoot_Design;
        Front_End BeetRoot_FrontEnd;
        Back_End BeetRoot_BackEnd;
        Mobile BeetRoot_Mobile;

        public Request_For_BeetRoot(IT_Company_Factory request)
        {
            BeetRoot_Design = request.Create_Design();
            BeetRoot_FrontEnd = request.Create_Front_End();
            BeetRoot_BackEnd = request.Create_Back_End();
            BeetRoot_Mobile = request.Create_Mobile();
        }

        public void Request_For_Development_Design()
        {
            BeetRoot_Design.Develop_Photoshop_Design();
        }
            
    }
}
