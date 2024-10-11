﻿using System;
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

        public override string DisplayFitnessProgramInfo() {
            return base.DisplayFitnessProgramInfo() + $"SubscriptionType{SubscriptionType}, needPersonalTrainer{needPersonalTrainer} ";
        }
    }
}
