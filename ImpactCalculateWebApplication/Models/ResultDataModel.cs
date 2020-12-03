using System;
using System.Collections.Generic;
using System.Text;

namespace ImpactCalculateWebApplication.Models
{
    public class ResultDataModel
    {
        public A_AV_VW Gas { get; set; }
        public A_AV_VW Device { get; set; }

        public double Waste_Difference { get; set; }

    }
    
    public class A_AV_VW
    {
        public double A { get; set; }
        public double V_Alpha { get; set; }
        public double V_Waste { get; set; }
    }
}
