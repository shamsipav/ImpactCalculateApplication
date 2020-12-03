using System;
using System.Collections.Generic;
using System.Text;

namespace ImpactCalculateWebApplication.Models
{
    public class CocksModel
    {
        public Cocks Kemerovo_3_4 { get; set; } = new Cocks() 
        {
            Q = 6911,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.70},
                {Element.A, 11.98},
                {Element.C, 83.37},
                {Element.H, 1.08},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.41},
            }
        };
        
        public Cocks Kemerovo_60_1_2 { get; set; } = new Cocks()
        {
            Q = 6999,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.31},
                {Element.A, 11.37},
                {Element.C, 83.37},
                {Element.H, 1.01},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.34},
            }
        };

        public Cocks Gubaha_3_4 { get; set; } = new Cocks()
        {
            Q = 6956,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.59},
                {Element.A, 11.53},
                {Element.C, 83.37},
                {Element.H, 0.81},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.65},
            }
        };
        public Cocks Gubaha_60_1_2 { get; set; } = new Cocks()
        {
            Q = 7003,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.19},
                {Element.A, 11.03},
                {Element.C, 83.37},
                {Element.H, 0.92},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.48},
            }
        };

        public Cocks Chehiya_3_4 { get; set; } = new Cocks()
        {
            Q = 7149,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.79},
                {Element.A, 8.40},
                {Element.C, 83.37},
                {Element.H, 0.97},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.61},
            }
        };
        public Cocks Chehiya_60_90_1_2 { get; set; } = new Cocks()
        {
            Q = 7027,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 1.12},
                {Element.A, 9.73},
                {Element.C, 83.37},
                {Element.H, 1.34},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.52},
            }
        };

        public Cocks Harkov_3_4 { get; set; } = new Cocks()
        {
            Q = 6931,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.47},
                {Element.A, 11.66},
                {Element.C, 83.37},
                {Element.H, 0.82},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 1.64},
            }
        };
        public Cocks Harkov_60_1_2 { get; set; } = new Cocks()
        {
            Q = 6985,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.53},
                {Element.A, 10.75},
                {Element.C, 83.37},
                {Element.H, 0.92},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 1.37},
            }
        };

        public Cocks Alza_Invest_1_2 { get; set; } = new Cocks()
        {
            Q = 6909,
            PercentOf = new Dictionary<Element, double>()
            {
                {Element.W, 0.54},
                {Element.A, 11.81},
                {Element.C, 83.37},
                {Element.H, 0.75},
                {Element.O, 1.32},
                {Element.N, 1.14},
                {Element.S, 0.51},
            }
        };

    }
    public enum Element
    {
        W, A, C, H, O, N, S
    }

    public class Cocks
    {
        public double Q { get; set; }
        public Dictionary<Element, double> PercentOf = new Dictionary<Element, double>();
        
    }
}
