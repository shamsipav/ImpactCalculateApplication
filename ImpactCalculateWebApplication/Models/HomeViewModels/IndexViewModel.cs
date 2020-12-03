using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactCalculateWebApplication.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public InputDataModel Input { get; set; }

        public ResultDataModel Result { get; set; }

        public IndexViewModel()
        {
            Input = InputDataModel.GetDefaultData();
        }

        public void CalculateResult()
        {
            Result.Gas.A = 1f / (1f - 3.76f * (Input.O2_Percentage - 0.5f * Input.CO_Percentage) / Input.N2_Percentage);
            //Result.Gas.V_Alpha = Result.Gas.A*
        }

        public static uint rowCounter = 1;
    }
}
