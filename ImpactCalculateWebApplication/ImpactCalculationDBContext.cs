using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ImpactCalculateWebApplication
{
    class ImpactCalculationDBContext : DbContext
    {
        public DbSet<SourceData> Sources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ImpactCalculateDB.db");

        
    }

    // Исходные данные
    #region Sources

    public class SourceData
    {
        //public SourceData(double? Air_Sp, double? Air_Pr, double? Air_Temp, double? Smoke_Temp, double? Visc,
        //    double? Melt_Temp, double? CO_Perc, double? CO2_Perc, double? O2_Perc, double? N2_Perc)
        //{
        //    Air_Spend = Air_Sp;
        //    Air_Pressure = Air_Pr;
        //    Air_Temperature = Air_Temp;
        //    Smoke_Temperature = Smoke_Temp;
        //    Viscosity = Visc;
        //    Melt_Temperature = Melt_Temp;
        //    CO_Percentage = CO2_Perc;
        //    CO2_Percentage = CO2_Perc;
        //    O2_Percentage = O2_Perc;
        //    N2_Percentage = N2_Perc;
        //}
        public int SourceDataId { get; set; }
        

        public double? Air_Spend { get; set; }
        public double? Air_Pressure { get; set; }
        public double? Air_Temperature { get; set; }
        public double? Smoke_Temperature { get; set; }
        public double? Viscosity { get; set; }
        public double? Melt_Temperature { get; set; }
        public double? CO_Percentage { get; set; }
        public double? CO2_Percentage { get; set; }
        public double? O2_Percentage { get; set; }
        public double? N2_Percentage { get; set; }

    }

    #endregion Sources

}
