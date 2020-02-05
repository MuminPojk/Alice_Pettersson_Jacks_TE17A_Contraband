using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Jacks_TE17A_Contraband
{
    class ContraBandCar: Car
    {


        public ContraBandCar()
        {



            contraBandAmount = generator.Next(1,4);



        }



    }
}
