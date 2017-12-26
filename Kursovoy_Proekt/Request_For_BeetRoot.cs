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
        
        public void Request_For_Development_FrontEnd()
        {
            BeetRoot_FrontEnd.Develop_AngularJS();
        }

        public void Request_For_Development_BackEnd()
        {
            BeetRoot_BackEnd.Develop_Python();
        }
        public void Request_For_Development_Mobile()
        {
            BeetRoot_Mobile.Develop_Android();
        }

        int price_for_design = 500;
        int execution_time_for_Design_in_hours = 50;

        public int Get_Price_For_Design()
        {
            return this.price_for_design;
        }
        public int Get_Execution_Time_For_Design_in_Hours()
        {
            return this.execution_time_for_Design_in_hours;
        }
        int price_for_FrontEnd = 2500;
        int execution_time_for_frontend_in_hours = 160;

        public int Get_Price_For_FrontEnd()
        {
            return this.price_for_FrontEnd;
        }
        public int Get_Execution_Time_For_FrontEnd_in_Hours()
        {
            return this.execution_time_for_frontend_in_hours;
        }

        int price_for_Python = 3400;
        int execution_time_for_Python_in_hours = 230;

        public int Get_Price_For_BackEnd_Python()
        {
            return this.price_for_Python;
        }
        public int Get_Execution_Time_For_Python_in_Hours()
        {
            return this.execution_time_for_Python_in_hours;
        }

        int price_for_Android = 6800;
        int execution_time_for_Android_in_hours = 420;
        public int Get_Price_For_App_Development_on_Android()
        {
            return this.price_for_Android;
        }
        public int Get_Execution_Time_For_Android_in_Hours()
        {
            return this.execution_time_for_Android_in_hours;
        }

       

    }
}
