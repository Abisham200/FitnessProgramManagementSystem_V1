﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {

        public FitnessProgramManager()
        {
            FitnessProgramList = new List<FitnessProgram>();
        }
        public List<FitnessProgram> FitnessProgramList;

        public void CreateFitnessProgram()
        {
            Console.WriteLine("Enter Fitness Program ID :");
            var FitnessProgramId = Console.ReadLine();
            Console.WriteLine("Enter Fitness Program Title :");
            var Title = Console.ReadLine();
            Console.WriteLine("Enter Fitness Program Duaration :");
            var Duaration = Console.ReadLine();
            Console.WriteLine("Enter Fitness Program Price :");
            var Price = ValidateFitnessProgramPrice();

            var FitnessProgram = new FitnessProgram()
            {
                FitnessProgramId = FitnessProgramId,
                Title = Title,
                Duaration = Duaration,
                Price = Price,
            };

            this.FitnessProgramList.Add(FitnessProgram);
            Console.WriteLine("Fitness Program Added SuccesFully");

        }

        public void ReadFitnessPrograms()
        {
            if (FitnessProgramList.Count == 0)
            {
                Console.WriteLine("No Programs available");
            }
            else
            {
                foreach (var item in FitnessProgramList)
                {
                    Console.WriteLine(item);
                }

            }
        }

        public void UpdateFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var ProgramId = Console.ReadLine();

            var Findprogram = this.FitnessProgramList.Where(D => D.FitnessProgramId == ProgramId).FirstOrDefault();
            if (Findprogram != null)
            {

                FitnessProgramList.Remove(Findprogram);

                Console.WriteLine("Enter Fitness Program ID :");
                var nFitnessProgramId = Console.ReadLine();
                Console.WriteLine("Enter Fitness Program Title :");
                var nTitle = Console.ReadLine();
                Console.WriteLine("Enter Fitness Program Duaration :");
                var nDuaration = Console.ReadLine();
                Console.WriteLine("Enter Fitness Program Price :");
                var nPrice = ValidateFitnessProgramPrice();

                var nFitnessProgram = new FitnessProgram
                {
                    FitnessProgramId = nFitnessProgramId,
                    Title = nTitle,
                    Duaration = nDuaration,
                    Price = nPrice,
                };

                this.FitnessProgramList.Add(nFitnessProgram);
                Console.WriteLine("Fitness Program UPDATED SuccesFully");

            }
            else
            {
                Console.WriteLine("iNVALID ID");
            }
        }

        public void DeleteFitnessProgram()
        {
            Console.WriteLine("Enter Program Id");
            var ProgramId = Console.ReadLine();

            var Findprogram = this.FitnessProgramList.Where(D => D.FitnessProgramId == ProgramId).FirstOrDefault();
            if (Findprogram != null)
            {

                FitnessProgramList.Remove(Findprogram);
                Console.WriteLine("Program Deleted successFully");

            }
            else
            {
                Console.WriteLine("INVALID Id");
            }
        }

        public decimal ValidateFitnessProgramPrice()
        { 
        decimal init = 0;
            Console.WriteLine("ENTER THE PRICE");
            decimal price = int.Parse(Console.ReadLine());

            if (price < 0)
            {
                init = price;
                Console.WriteLine("Price added");
                

            }
            else {
               
            }
            return init;
        }
    }
}
