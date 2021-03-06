﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactCalculateWebApplication.Models
{
    public class InputDataModel
    {
        [Key]
        public int Key { get; set; }

        public double Air_Spend { get; set; }
        public double Air_Pressure { get; set; }
        public double Air_Temperature { get; set; }
        public double Smoke_Temperature { get; set; }
        public double Viscosity { get; set; }
        public double Melt_Temperature { get; set; }
        public double CO_Percentage { get; set; }
        public double CO2_Percentage { get; set; }
        public double N2_Percentage { get; set; }
        public double O2_Percentage { get; set; }

        public static InputDataModel GetDefaultData()
        {
            return new InputDataModel
            {
                Air_Spend = 5850,
                Air_Pressure = 70,
                Air_Temperature = 610.2,
                Smoke_Temperature = 146.5,
                Viscosity = 22,
                Melt_Temperature = 1521,
                CO_Percentage = 8.7,
                CO2_Percentage = 12.4,
                N2_Percentage = 77.67,
                O2_Percentage = 1.23
            };
        }


    }
}
