using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_Jacks_TE17A_Contraband
{
    class Program
    {
        static void Main(string[] args)
        {

             Random generator = new Random();
            Car car = new Car();

             List<Car> listOfCars = new List<Car>();

            Console.WriteLine("Hur många bilar ska skapas?");
            string input = Console.ReadLine();

           
            int resultat;
            bool lyckad = int.TryParse(input, out resultat);

            while (resultat < 0)// Om spelaren inte skrivit in ett tal under 0 får den inte gå vidare
            {

                Console.WriteLine("Nä det där funkar ju inte, försök igen");
              

                input = Console.ReadLine();
                lyckad = int.TryParse(input, out resultat);

            }


            Console.WriteLine("yeehaw");
            Console.WriteLine("Då kan vi gå vidare");
            Console.WriteLine("Vilken bil vill du snoka i? Välj från 0 och uppåt till så mänga bilar som du har valt");

            input = Console.ReadLine();
           

            int amountCleanCars = generator.Next(0, resultat);// Antal clean cars är mellan 0 och det som spelaren skrev in
            int amountContraBandCars = resultat - amountCleanCars;// Antal bilar med olagligt gods är det som blir över av det tal som spelaren skrev in

            for (int i = 0; i < amountCleanCars; i++)// Här skapas det lika många clean cars som amountCleanCars anger, Dessa läggs sedan in i en lista
            {

               CleanCar cleanCar = new CleanCar();

                listOfCars.Add(cleanCar);


            }
            for (int i = 0; i < amountContraBandCars; i++)// Här skapas det lika många contraband cars som amountContraBandCars anger, Dessa läggs sedan in i samma lista som clean cars
            {

                ContraBandCar contraBandCar = new ContraBandCar();

                listOfCars.Add(contraBandCar);

            }


           
         
            bool contraBand = car.Examine();



            Console.ReadLine();

        }
    }
}
