using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactCalculateWebApplication.Models.HomeViewModels
{
    public class IndexViewModel
    {
        public List<InputDataModel> Inputs { get; set; }

        public List<ResultDataModel> Results { get; set; }

        public IndexViewModel()
        {
            Inputs = new List<InputDataModel>();
            Inputs[0]= InputDataModel.GetDefaultData();
        }

        public void CalculateResults()
        {
            foreach(InputDataModel input in Inputs)
            {
                Results.Add(CalculateResult(input));
            }
            
        }

        public ResultDataModel CalculateResult(InputDataModel input)
        { 
            var result = new ResultDataModel();
            result.Gas.A = 1f / (1f - 3.76f * (input.O2_Percentage - 0.5f * input.CO_Percentage) / input.N2_Percentage);

            //result.Gas.V_Alpha = result.Gas.A*


            return result;
        }

        public static uint rowCounter = 1;
    }
}
