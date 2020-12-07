using System;
using System.Collections.Generic;
using System.Text;
using ImpactCalculateWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ImpactCalculateWebApplication
{
    class ImpactCalculationDBContext : DbContext
    {
        public DbSet<SourceData> Sources { get; set; }
        public DbSet<InputDataModel> Inputs { get; set; }
        public DbSet<ResultDataModel> Result { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=ImpactCalculateDB.db");

        
    }

    // Исходные данные
    #region Sources

    public class SourceData
    {
    
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

    // Результаты 
    #region Results

    public class ResultData
    {

        public int ResultDataId { get; set; }


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
