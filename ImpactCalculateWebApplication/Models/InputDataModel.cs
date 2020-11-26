using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactCalculateWebApplication.Models
{
    public class InputDataModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }
        public int Number5 { get; set; }


        public static InputDataModel GetDefaulData()
        {
            return new InputDataModel
            {
                Number1 = 1,
                Number2 = 1,
                Number3 = 1,
                Number4 = 1,
                Number5 = 1
            };
        }
    }
}
