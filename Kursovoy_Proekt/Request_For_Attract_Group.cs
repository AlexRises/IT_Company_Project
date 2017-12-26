using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Request_For_Attract_Group : Swtich_To_Python
    {
        /*List<object> list_1 = new List<object>()
        {
           Attract_Group_Design_Ex,
           Attract_Group_FrontEnd_Ex,
           Attract_Group_BackEnd_Ex,
           Attract_Group_BackEnd_2_Ex,
           Attract_Group_Mobile_Ex
        };
        list_1.Count();*/
        

        Design_2 Attract_Group_Design_2;
        Front_End_2 Attract_Group_FrontEnd_2;
        Back_End Attract_Group_BackEnd;
        Back_End_2 Attract_Group_BackEnd_2;
        Mobile_2 Attract_Group_Mobile_2;

        int technologies = 5;

        public Request_For_Attract_Group(IT_Company_Factory request)
        {
            Attract_Group_Design_2 = request.Create_Design_2();
            Attract_Group_FrontEnd_2 = request.Create_Front_End_2();
            Attract_Group_BackEnd_2 = request.Create_Back_End_2();
            Attract_Group_Mobile_2 = request.Create_Mobile_2();
            Attract_Group_BackEnd = request.Create_Back_End();
        }

        public int Technologies_Company_Develop()
        {
            return this.technologies;
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
        /*Price and Execution*/

        int price_for_design = 700;
        int execution_time_for_design_in_hours = 30;

        public int Get_Price_For_Design()
        {
            return this.price_for_design;
        }
        public int Get_Execution_Time_For_Design_in_Hours()
        {
            return this.execution_time_for_design_in_hours;
        }

        int price_for_FrontEnd = 3500;
        int execution_time_for_frontend_in_hours = 120;

        public int Get_Price_For_FrontEnd()
        {
            return this.price_for_FrontEnd;
        }
        public int Get_Execution_Time_For_FrontEnd_in_Hours()
        {
            return this.execution_time_for_frontend_in_hours;
        }

        int price_for_Python = 4700;
        int execution_time_for_Python_in_hours = 150;

        public int Get_Price_For_BackEnd_Python()
        {
            return this.price_for_Python;
        }
        public int Get_Execution_Time_For_Python_in_Hours()
        {
            return this.execution_time_for_Python_in_hours;
        }

        int price_for_PHP = 3100;
        int execution_time_for_PHP_in_hours = 210;

        public int Get_Price_For_BackEnd_PHP()
        {
            return this.price_for_PHP;
        }
        public int Get_Execution_Time_For_PHP_in_Hours()
        {
            return this.execution_time_for_PHP_in_hours;
        }

        int price_for_iOS = 8800;
        int execution_time_for_iOS_in_hours = 250;
      

        public int Get_Price_For_App_Development_on_iOS()
        {
            return this.price_for_iOS;
        }
        public int Get_Execution_Time_For_iOS_in_Hours()
        {
            return this.execution_time_for_iOS_in_hours;
        }

        public void Switch_The_Technology()
        {
            Attract_Group_BackEnd.Develop_Python();
        }

    }

}

