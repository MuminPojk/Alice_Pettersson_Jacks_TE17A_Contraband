using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Jacks_TE17A_Contraband
{
    class Car
    {
       


        public int passenger;
        public int contraBandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        public bool Examine()
        {

            if (contraBandAmount > 0)// Om bilen som undersöks har nåågot olagligt gods så kommer det returnas false
            {

                Console.WriteLine("This car has contraband, Get them boys!!!");
                return true;

            }
            else if (contraBandAmount == 0)// Om bilen som undersöks inte har nåågot olagligt gods så kommer det returnas true
            {

                Console.WriteLine("It is fine, this car is clean");
                return false;

            }

            return false;


        }


    }
}
