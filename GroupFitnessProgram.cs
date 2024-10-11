﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class GroupFitnessProgram : FitnessProgram
    {
        public string ScheduleName { get; set; }
        public string GroupCapacity { get; set; }
        public GroupFitnessProgram() : base()
        {
        }

        public string DisplayGroupFitnessProgramInfo() { 
        return $"{FitnessProgramId}, Title: {Title}, Duration: {Duaration}, Price: {Price} ,ScheduleName{ScheduleName}, GroupCapacity{GroupCapacity} ";
        }
    }
}