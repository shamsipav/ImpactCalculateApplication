using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactCalculateWebApplication.Models
{
    public class InputDataModel
    {
        public double Air_Spend { get; set; }
        public double Air_Pressure { get; set; }
        public double Air_Temperature { get; set; }
        public double Smoke_Temperature { get; set; }
        public double Viscosity { get; set; }
        public double Melt_Temperature { get; set; }
        public double CO_Percentage { get; set; }
        public double CO2_Percentage { get; set; }
        public double O2_Percentage { get; set; }
        public double N2_Percentage { get; set; }

        public static InputDataModel GetDefaultData()
        {
            return new InputDataModel
            {
                Air_Pressure = 1,
                Air_Spend = 2,
                Air_Temperature = 3,
                CO2_Percentage = 4,
                CO_Percentage = 5,
                O2_Percentage = 6,
                N2_Percentage = 7,
                Melt_Temperature = 8,
                Smoke_Temperature = 9,
                Viscosity = 0.5f
            };
        }


    }
}
