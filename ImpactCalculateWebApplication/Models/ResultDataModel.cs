using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImpactCalculateWebApplication.Models
{
    public class ResultDataModel
    {
        [Key]
        public int Key { get; set; }

        public A_AV_VW Gas { get; set; } = new A_AV_VW();
        public A_AV_VW Device { get; set; } = new A_AV_VW();

        public double Waste_Difference { get; set; }

    }
    
    public class A_AV_VW
    {
        [Key]
        public int Key { get; set; }

        public double A { get; set; }
        public double V_Alpha { get; set; }
        public double V_Waste { get; set; }

    }

}
