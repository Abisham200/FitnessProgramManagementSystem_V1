using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var FitnessProgram1 = new FitnessProgram("FIT_001", "BeginnersYOGA", "3months","10.00");
            //Console.WriteLine(FitnessProgram1);
            Menu();

            

            Console.ReadLine();
        }

        public static void Menu()
        {
            var fitnessProgram = new FitnessProgramManager();
            while (true)
            {
                Console.WriteLine("FitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");

                string MenuInput = Console.ReadLine();
                bool status = true;
                switch (MenuInput)
                {
                    case "1":
                        fitnessProgram.CreateFitnessProgram();
                        break;
                    case "2":
                        fitnessProgram.ReadFitnessPrograms();
                        break;
                    case "3":
                        fitnessProgram.UpdateFitnessProgram();
                        break;
                    case "4":
                        fitnessProgram.DeleteFitnessProgram();
                        break;
                    case "5":
                        status = false;
                        break;

                }
            }
        }
    }
}
