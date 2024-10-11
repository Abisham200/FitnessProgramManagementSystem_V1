using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class IndividualFitnessProgram : FitnessProgram
    {
        public string SubscriptionType { get; set; }
        public string needPersonalTrainer { get; set; }
        public IndividualFitnessProgram() : base()
        {
        }

        public string DisplayIndividualFitnessProgramInfo() {
            return $"{FitnessProgramId}, Title: {Title}, Duration: {Duaration}, Price: {Price} ,SubscriptionType{SubscriptionType}, needPersonalTrainer{needPersonalTrainer} ";
        }
    }
}
