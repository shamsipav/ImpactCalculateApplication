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
            Input = InputDataModel.GetDefaulData();
        }







    }
}
