using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public FitnessProgram() { }

        public FitnessProgram(string fitnessProgramId, string title, string duaration, string price)
        {
            this.FitnessProgramId = fitnessProgramId;
            this.Title = title;
            this.Duaration = duaration;
            this.Price = price;
        }

        private string FitnessProgramId { get; set; }
        private string Title { get; set; }
        private string Duaration { get; set; }
        private string Price { get; set; }

    }
}
