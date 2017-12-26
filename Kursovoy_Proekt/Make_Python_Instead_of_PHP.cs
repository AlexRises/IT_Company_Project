using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovoy_Proekt
{
    public class Make_Python_Instead_of_PHP : Switch_The_Python
    {
        public Python Attract_Group_BackEnd = new Python();

        /*public Make_Python_Instead_of_PHP(IT_Company_Factory request)
        {
            Attract_Group_BackEnd = request.Create_Back_End();
        }*/


        public void Switch1()
        {
            Attract_Group_BackEnd.Develop_Python();
        }


    }
}
