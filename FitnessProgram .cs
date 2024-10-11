﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public FitnessProgram() { }

         public string FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duaration { get; set; }
        public string Price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duaration, string price)
        {
            this.FitnessProgramId = fitnessProgramId;
            this.Title = title;
            this.Duaration = duaration;
            this.Price = price;
        }

       


        public override string ToString()
        {
            return $"{FitnessProgramId}, Title: {Title}, Duration: {Duaration}, Price: {Price}";
        }

        public virtual string DisplayFitnessProgramInfo()
        {
            return $"{FitnessProgramId}, Title: {Title}, Duration: {Duaration}, Price: {Price}";
        }
    }
}
