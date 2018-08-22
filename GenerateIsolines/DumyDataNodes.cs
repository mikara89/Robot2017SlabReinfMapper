using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateIsolines
{

    public class Nodes
    {
        public int FE_ID { get; set; } 
        public int NodeID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Ax_Bottom { get; set; }
        public double Ay_Bottom { get; set; }
        public double Ax_Top { get; set; }
        public double Ay_Top { get; set; }
    }

    public static class DumyDataNodes
    {
        public static List<Nodes> GetNodesResourses
        {
            get
            {
                return JsonConvert.DeserializeObject<List<Nodes>>(StrJson); ;
            }
        }

        public static List<Nodes> GetNodesLimits
        {
            get
            {
                return JsonConvert.DeserializeObject<List<Nodes>>(SlabLim); ;
            }
        }


       

        private static string SlabLim=> @"[
 {
   'X': 0.33,
   'Y': 8.38
 },
 {
   'X': 0.33,
   'Y': 7.76
 },
 {
   'X': 0,
   'Y': 7.76
 },
 {
   'X': 0,
   'Y': 1.22
 },
 {
   'X': 3.62,
   'Y': 1.22
 },
 {
   'X': 3.62,
   'Y': 0.62
 },
 {
   'X': 6.52,
   'Y': 0.62
 },
 {
   'X': 6.52,
   'Y': 1.12
 },
 {
   'X': 10.14,
   'Y': 1.12
 },
 {
   'X': 10.14,
   'Y': 0.62
 },
 {
   'X': 15.95,
   'Y': 0.62
 },
 {
   'X': 15.95,
   'Y': 1.22
 },
 {
   'X': 19.55,
   'Y': 1.22
 },
 {
   'X': 19.55,
   'Y': 7.76
 },
 {
   'X': 19.23,
   'Y': 7.76
 },
 {
   'X': 19.23,
   'Y': 8.38
 },
 {
   'X': 19.55,
   'Y': 8.38
 },
 {
   'X': 19.55,
   'Y': 12.44
 },
 {
   'X': 19.55,
   'Y': 14.24
 },
 {
   'X': 18.37,
   'Y': 14.24
 },
 {
   'X': 18.37,
   'Y': 14.12
 },
 {
   'X': 9.94,
   'Y': 14.12
 },
 {
   'X': 9.94,
   'Y': 10.16
 },
 {
   'X': 7.06,
   'Y': 10.16
 },
 {
   'X': 7.06,
   'Y': 14.02
 },
 {
   'X': 0,
   'Y': 14.02
 },
 {
   'X': 0,
   'Y': 8.38
 },
 {
   'X': 0.33,
   'Y': 8.38
 }
]";

        private static string StrJson => @"[ 
 {
   'Panel': 171,
   'Node': 53,
   'X': 3.1,
   'Y': 1.22,
   'Ax_Bottom': 0.33,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.57
 },
 {
   'Panel': 171,
   'Node': 55,
   'X': 9.64,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 59,
   'X': 4.48,
   'Y': 14.02,
   'Ax_Bottom': 0.58,
   'Ay_Bottom': 0,
   'Ax_Top': 1.24,
   'Ay_Top': 4.99
 },
 {
   'Panel': 171,
   'Node': 62,
   'X': 17.95,
   'Y': 14.02,
   'Ax_Bottom': 0.5,
   'Ay_Bottom': 1.24,
   'Ax_Top': 2.29,
   'Ay_Top': 1.1
 },
 {
   'Panel': 171,
   'Node': 94,
   'X': 1.4,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.87,
   'Ay_Top': 3.78
 },
 {
   'Panel': 171,
   'Node': 95,
   'X': 7.06,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.46,
   'Ax_Top': 0,
   'Ay_Top': 0.47
 },
 {
   'Panel': 171,
   'Node': 96,
   'X': 9.94,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.01,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 97,
   'X': 12.65,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.64
 },
 {
   'Panel': 171,
   'Node': 98,
   'X': 13.9,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.6,
   'Ay_Top': 4.96
 },
 {
   'Panel': 171,
   'Node': 99,
   'X': 19.55,
   'Y': 10.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.04,
   'Ax_Top': 0.12,
   'Ay_Top': 0.88
 },
 {
   'Panel': 171,
   'Node': 100,
   'X': 19.55,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.18
 },
 {
   'Panel': 171,
   'Node': 101,
   'X': 19.55,
   'Y': 7.23,
   'Ax_Bottom': 2.28,
   'Ay_Bottom': 0.1,
   'Ax_Top': 1.9,
   'Ay_Top': 5.68
 },
 {
   'Panel': 171,
   'Node': 102,
   'X': 19.55,
   'Y': 2.44,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.38,
   'Ay_Top': 4.85
 },
 {
   'Panel': 171,
   'Node': 103,
   'X': 18.92,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.29,
   'Ay_Top': 1.29
 },
 {
   'Panel': 171,
   'Node': 104,
   'X': 17.1,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.53
 },
 {
   'Panel': 171,
   'Node': 105,
   'X': 6.89,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 106,
   'X': 0.8,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.43,
   'Ay_Top': 1.01
 },
 {
   'Panel': 171,
   'Node': 107,
   'X': 0,
   'Y': 2.44,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.84,
   'Ay_Top': 8.13
 },
 {
   'Panel': 171,
   'Node': 108,
   'X': 0,
   'Y': 7.23,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.36,
   'Ay_Top': 8.06
 },
 {
   'Panel': 171,
   'Node': 109,
   'X': 6.52,
   'Y': 2.44,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 10.1,
   'Ay_Top': 10.35
 },
 {
   'Panel': 171,
   'Node': 110,
   'X': 6.52,
   'Y': 7.23,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 11.43,
   'Ay_Top': 11.41
 },
 {
   'Panel': 171,
   'Node': 111,
   'X': 13.04,
   'Y': 2.44,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 11.59,
   'Ay_Top': 12.48
 },
 {
   'Panel': 171,
   'Node': 112,
   'X': 13.04,
   'Y': 7.23,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 10.37,
   'Ay_Top': 13.64
 },
 {
   'Panel': 171,
   'Node': 113,
   'X': 1.4,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 10.13,
   'Ay_Top': 12.05
 },
 {
   'Panel': 171,
   'Node': 114,
   'X': 6.52,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.53,
   'Ay_Top': 3.16
 },
 {
   'Panel': 171,
   'Node': 115,
   'X': 7.95,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.61,
   'Ay_Top': 5.62
 },
 {
   'Panel': 171,
   'Node': 116,
   'X': 18.05,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 9.72,
   'Ay_Top': 10.69
 },
 {
   'Panel': 171,
   'Node': 117,
   'X': 0,
   'Y': 13.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.38,
   'Ay_Top': 4.89
 },
 {
   'Panel': 171,
   'Node': 118,
   'X': 0,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.08,
   'Ax_Top': 0,
   'Ay_Top': 0.84
 },
 {
   'Panel': 171,
   'Node': 145,
   'X': 18.15,
   'Y': 12.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.28,
   'Ay_Top': 2.93
 },
 {
   'Panel': 171,
   'Node': 332,
   'X': 0,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.61,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 336,
   'X': 0.4,
   'Y': 1.22,
   'Ax_Bottom': 0.11,
   'Ay_Bottom': 0.04,
   'Ax_Top': 1.11,
   'Ay_Top': 2.86
 },
 {
   'Panel': 171,
   'Node': 411,
   'X': 13.04,
   'Y': 8.48,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.18,
   'Ay_Top': 6.75
 },
 {
   'Panel': 171,
   'Node': 417,
   'X': 13.04,
   'Y': 8.07,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.53
 },
 {
   'Panel': 171,
   'Node': 418,
   'X': 13.04,
   'Y': 7.65,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.8
 },
 {
   'Panel': 171,
   'Node': 535,
   'X': 13.06,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.57
 },
 {
   'Panel': 171,
   'Node': 536,
   'X': 13.48,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.89
 },
 {
   'Panel': 171,
   'Node': 628,
   'X': 13.04,
   'Y': 1.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 633,
   'X': 13.04,
   'Y': 2,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.64
 },
 {
   'Panel': 171,
   'Node': 634,
   'X': 13.04,
   'Y': 1.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 1071,
   'X': 19.55,
   'Y': 12.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.21
 },
 {
   'Panel': 171,
   'Node': 1080,
   'X': 19.55,
   'Y': 11.77,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.06,
   'Ax_Top': 0,
   'Ay_Top': 0.37
 },
 {
   'Panel': 171,
   'Node': 1081,
   'X': 19.55,
   'Y': 11.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.07,
   'Ax_Top': 0.29,
   'Ay_Top': 1.01
 },
 {
   'Panel': 171,
   'Node': 1154,
   'X': 0.33,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.38
 },
 {
   'Panel': 171,
   'Node': 1159,
   'X': 0.86,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.27
 },
 {
   'Panel': 171,
   'Node': 1269,
   'X': 0,
   'Y': 14.02,
   'Ax_Bottom': 1.18,
   'Ay_Bottom': 3.15,
   'Ax_Top': 0,
   'Ay_Top': 0.16
 },
 {
   'Panel': 171,
   'Node': 1275,
   'X': 0.47,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.66
 },
 {
   'Panel': 171,
   'Node': 1276,
   'X': 0.93,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.08
 },
 {
   'Panel': 171,
   'Node': 1549,
   'X': 6.84,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.15,
   'Ax_Top': 0,
   'Ay_Top': 1.54
 },
 {
   'Panel': 171,
   'Node': 1557,
   'X': 7.39,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 2063,
   'X': 7.06,
   'Y': 10.16,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.18,
   'Ay_Top': 2.01
 },
 {
   'Panel': 171,
   'Node': 2082,
   'X': 7.06,
   'Y': 10.65,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.92,
   'Ay_Top': 0.48
 },
 {
   'Panel': 171,
   'Node': 2083,
   'X': 7.06,
   'Y': 11.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.08,
   'Ay_Top': 0.62
 },
 {
   'Panel': 171,
   'Node': 2084,
   'X': 7.06,
   'Y': 11.61,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.89,
   'Ay_Top': 0.5
 },
 {
   'Panel': 171,
   'Node': 2085,
   'X': 7.06,
   'Y': 12.09,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.86,
   'Ay_Top': 0.58
 },
 {
   'Panel': 171,
   'Node': 2086,
   'X': 7.06,
   'Y': 12.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.86,
   'Ay_Top': 0.69
 },
 {
   'Panel': 171,
   'Node': 2087,
   'X': 7.06,
   'Y': 13.06,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.83,
   'Ay_Top': 0.82
 },
 {
   'Panel': 171,
   'Node': 2088,
   'X': 7.06,
   'Y': 13.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.33,
   'Ay_Top': 1.14
 },
 {
   'Panel': 171,
   'Node': 2190,
   'X': 9.94,
   'Y': 10.16,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.36,
   'Ay_Top': 6.65
 },
 {
   'Panel': 171,
   'Node': 2203,
   'X': 9.94,
   'Y': 13.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.79,
   'Ay_Top': 1.38
 },
 {
   'Panel': 171,
   'Node': 2204,
   'X': 9.94,
   'Y': 13.06,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.59,
   'Ay_Top': 1.31
 },
 {
   'Panel': 171,
   'Node': 2205,
   'X': 9.94,
   'Y': 12.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.79,
   'Ay_Top': 1.41
 },
 {
   'Panel': 171,
   'Node': 2206,
   'X': 9.94,
   'Y': 12.09,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.81,
   'Ay_Top': 1.4
 },
 {
   'Panel': 171,
   'Node': 2207,
   'X': 9.94,
   'Y': 11.61,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.78,
   'Ay_Top': 1.38
 },
 {
   'Panel': 171,
   'Node': 2208,
   'X': 9.94,
   'Y': 11.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 2209,
   'X': 9.94,
   'Y': 10.65,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.35,
   'Ay_Top': 0.79
 },
 {
   'Panel': 171,
   'Node': 3103,
   'X': 19.23,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.04,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 3109,
   'X': 18.64,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.18
 },
 {
   'Panel': 171,
   'Node': 3317,
   'X': 6.52,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 3322,
   'X': 6.52,
   'Y': 1.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.52,
   'Ax_Top': 0.12,
   'Ay_Top': 0.63
 },
 {
   'Panel': 171,
   'Node': 3402,
   'X': 6.52,
   'Y': 7.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.45,
   'Ax_Top': 0.96,
   'Ay_Top': 0.76
 },
 {
   'Panel': 171,
   'Node': 3472,
   'X': 0,
   'Y': 7.76,
   'Ax_Bottom': 0.29,
   'Ay_Bottom': 4.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 3551,
   'X': 0,
   'Y': 1.83,
   'Ax_Bottom': 2.13,
   'Ay_Bottom': 4.27,
   'Ax_Top': 0.55,
   'Ay_Top': 0.58
 },
 {
   'Panel': 171,
   'Node': 3605,
   'X': 19.55,
   'Y': 7.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.16,
   'Ax_Top': 1.9,
   'Ay_Top': 3.08
 },
 {
   'Panel': 171,
   'Node': 3627,
   'X': 19.55,
   'Y': 1.22,
   'Ax_Bottom': 0.6,
   'Ay_Bottom': 1.97,
   'Ax_Top': 0.11,
   'Ay_Top': 1.51
 },
 {
   'Panel': 171,
   'Node': 3635,
   'X': 19.55,
   'Y': 1.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.67,
   'Ax_Top': 3.85,
   'Ay_Top': 3.67
 },
 {
   'Panel': 171,
   'Node': 3688,
   'X': 15.95,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.16,
   'Ay_Top': 4.5
 },
 {
   'Panel': 171,
   'Node': 3693,
   'X': 16.53,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.7
 },
 {
   'Panel': 171,
   'Node': 3758,
   'X': 18.05,
   'Y': 12.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 7.1,
   'Ay_Top': 5.89
 },
 {
   'Panel': 171,
   'Node': 3770,
   'X': 18.85,
   'Y': 12.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.19
 },
 {
   'Panel': 171,
   'Node': 4201,
   'X': 0.33,
   'Y': 7.76,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 0.13,
   'Ax_Top': 4.34,
   'Ay_Top': 4.39
 },
 {
   'Panel': 171,
   'Node': 4204,
   'X': 3.62,
   'Y': 1.22,
   'Ax_Bottom': 1.46,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.86
 },
 {
   'Panel': 171,
   'Node': 4205,
   'X': 3.62,
   'Y': 0.62,
   'Ax_Bottom': 0.58,
   'Ay_Bottom': 0.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4206,
   'X': 6.52,
   'Y': 0.62,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 0.22,
   'Ax_Top': 0.15,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4207,
   'X': 6.52,
   'Y': 1.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 4208,
   'X': 10.14,
   'Y': 1.12,
   'Ax_Bottom': 0.11,
   'Ay_Bottom': 0.71,
   'Ax_Top': 1.46,
   'Ay_Top': 0.96
 },
 {
   'Panel': 171,
   'Node': 4209,
   'X': 10.14,
   'Y': 0.62,
   'Ax_Bottom': 0.18,
   'Ay_Bottom': 0.31,
   'Ax_Top': 0.3,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4210,
   'X': 15.95,
   'Y': 0.62,
   'Ax_Bottom': 1.62,
   'Ay_Bottom': 0.27,
   'Ax_Top': 0,
   'Ay_Top': 0.05
 },
 {
   'Panel': 171,
   'Node': 4214,
   'X': 19.23,
   'Y': 7.76,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 0,
   'Ax_Top': 4.54,
   'Ay_Top': 4.87
 },
 {
   'Panel': 171,
   'Node': 4217,
   'X': 19.55,
   'Y': 12.44,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.66,
   'Ay_Top': 1.29
 },
 {
   'Panel': 171,
   'Node': 4218,
   'X': 19.55,
   'Y': 14.24,
   'Ax_Bottom': 0.33,
   'Ay_Bottom': 0.3,
   'Ax_Top': 0.09,
   'Ay_Top': 0.07
 },
 {
   'Panel': 171,
   'Node': 4219,
   'X': 18.37,
   'Y': 14.24,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.03,
   'Ax_Top': 1.21,
   'Ay_Top': 0.59
 },
 {
   'Panel': 171,
   'Node': 4220,
   'X': 18.37,
   'Y': 14.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.85,
   'Ax_Top': 1.64,
   'Ay_Top': 0.47
 },
 {
   'Panel': 171,
   'Node': 4221,
   'X': 9.94,
   'Y': 14.12,
   'Ax_Bottom': 0.84,
   'Ay_Bottom': 0.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4227,
   'X': 4.84,
   'Y': 13.9,
   'Ax_Bottom': 1.31,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.58
 },
 {
   'Panel': 171,
   'Node': 4228,
   'X': 4.84,
   'Y': 13.7,
   'Ax_Bottom': 2.14,
   'Ay_Bottom': 0.4,
   'Ax_Top': 1.13,
   'Ay_Top': 2.11
 },
 {
   'Panel': 171,
   'Node': 4229,
   'X': 4.48,
   'Y': 13.7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.43,
   'Ay_Top': 1.82
 },
 {
   'Panel': 171,
   'Node': 4230,
   'X': 4.48,
   'Y': 13.9,
   'Ax_Bottom': 0.58,
   'Ay_Bottom': 0,
   'Ax_Top': 1.24,
   'Ay_Top': 4.99
 },
 {
   'Panel': 171,
   'Node': 4232,
   'X': 6.84,
   'Y': 7.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.53,
   'Ay_Top': 4.23
 },
 {
   'Panel': 171,
   'Node': 4235,
   'X': 5.1,
   'Y': 8.38,
   'Ax_Bottom': 1.35,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.08
 },
 {
   'Panel': 171,
   'Node': 4236,
   'X': 5.1,
   'Y': 8.06,
   'Ax_Bottom': 1.52,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.55
 },
 {
   'Panel': 171,
   'Node': 4237,
   'X': 4.74,
   'Y': 8.06,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.32
 },
 {
   'Panel': 171,
   'Node': 4238,
   'X': 4.74,
   'Y': 8.38,
   'Ax_Bottom': 2.51,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.03
 },
 {
   'Panel': 171,
   'Node': 4239,
   'X': 11.62,
   'Y': 8.38,
   'Ax_Bottom': 2.45,
   'Ay_Bottom': 0,
   'Ax_Top': 1.52,
   'Ay_Top': 3.84
 },
 {
   'Panel': 171,
   'Node': 4240,
   'X': 11.62,
   'Y': 8.06,
   'Ax_Bottom': 0.26,
   'Ay_Bottom': 0,
   'Ax_Top': 2.15,
   'Ay_Top': 4.17
 },
 {
   'Panel': 171,
   'Node': 4241,
   'X': 11.26,
   'Y': 8.06,
   'Ax_Bottom': 3.7,
   'Ay_Bottom': 0.56,
   'Ax_Top': 0,
   'Ay_Top': 1.34
 },
 {
   'Panel': 171,
   'Node': 4242,
   'X': 11.26,
   'Y': 8.38,
   'Ax_Bottom': 2.67,
   'Ay_Bottom': 0,
   'Ax_Top': 0.9,
   'Ay_Top': 3.59
 },
 {
   'Panel': 171,
   'Node': 4243,
   'X': 14.76,
   'Y': 8.38,
   'Ax_Bottom': 2.73,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.23
 },
 {
   'Panel': 171,
   'Node': 4244,
   'X': 14.76,
   'Y': 8.06,
   'Ax_Bottom': 3.08,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.21
 },
 {
   'Panel': 171,
   'Node': 4245,
   'X': 14.4,
   'Y': 8.06,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 0,
   'Ax_Top': 0.26,
   'Ay_Top': 4.27
 },
 {
   'Panel': 171,
   'Node': 4246,
   'X': 14.4,
   'Y': 8.38,
   'Ax_Bottom': 1.39,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.92
 },
 {
   'Panel': 171,
   'Node': 4247,
   'X': 15.29,
   'Y': 14.02,
   'Ax_Bottom': 3.41,
   'Ay_Bottom': 0.58,
   'Ax_Top': 0,
   'Ay_Top': 0.84
 },
 {
   'Panel': 171,
   'Node': 4248,
   'X': 15.29,
   'Y': 13.7,
   'Ax_Bottom': 3.48,
   'Ay_Bottom': 1.05,
   'Ax_Top': 0,
   'Ay_Top': 0.69
 },
 {
   'Panel': 171,
   'Node': 4249,
   'X': 14.93,
   'Y': 13.7,
   'Ax_Bottom': 3.55,
   'Ay_Bottom': 1.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4250,
   'X': 14.93,
   'Y': 14.02,
   'Ax_Bottom': 1.85,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.63
 },
 {
   'Panel': 171,
   'Node': 4315,
   'X': 13.04,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.62
 },
 {
   'Panel': 171,
   'Node': 4316,
   'X': 9.19,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 4317,
   'X': 8.73,
   'Y': 1.22,
   'Ax_Bottom': 0.46,
   'Ay_Bottom': 0,
   'Ax_Top': 0.07,
   'Ay_Top': 1.29
 },
 {
   'Panel': 171,
   'Node': 4318,
   'X': 8.27,
   'Y': 1.22,
   'Ax_Bottom': 1.22,
   'Ay_Bottom': 0.58,
   'Ax_Top': 0.51,
   'Ay_Top': 1.1
 },
 {
   'Panel': 171,
   'Node': 4319,
   'X': 7.81,
   'Y': 1.22,
   'Ax_Bottom': 1.16,
   'Ay_Bottom': 1.06,
   'Ax_Top': 1.22,
   'Ay_Top': 1.16
 },
 {
   'Panel': 171,
   'Node': 4320,
   'X': 7.35,
   'Y': 1.22,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 4321,
   'X': 6.52,
   'Y': 2.92,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 7.08,
   'Ay_Top': 2.28
 },
 {
   'Panel': 171,
   'Node': 4322,
   'X': 6.52,
   'Y': 3.4,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.36,
   'Ax_Top': 4.35,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4323,
   'X': 6.52,
   'Y': 3.88,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.36,
   'Ax_Top': 2.92,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4324,
   'X': 6.52,
   'Y': 4.36,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.23,
   'Ax_Top': 2.43,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4325,
   'X': 6.52,
   'Y': 4.84,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.52,
   'Ax_Top': 2.41,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4326,
   'X': 6.52,
   'Y': 5.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.21,
   'Ax_Top': 2.83,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4327,
   'X': 6.52,
   'Y': 5.8,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.23,
   'Ax_Top': 3.71,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4328,
   'X': 6.52,
   'Y': 6.28,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.37,
   'Ax_Top': 5.18,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4329,
   'X': 6.52,
   'Y': 6.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 7.92,
   'Ay_Top': 2.63
 },
 {
   'Panel': 171,
   'Node': 4330,
   'X': 13.04,
   'Y': 2.92,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 7.43,
   'Ay_Top': 2.64
 },
 {
   'Panel': 171,
   'Node': 4331,
   'X': 13.04,
   'Y': 3.4,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.28,
   'Ax_Top': 4.37,
   'Ay_Top': 0.05
 },
 {
   'Panel': 171,
   'Node': 4332,
   'X': 13.04,
   'Y': 3.88,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.48,
   'Ax_Top': 2.6,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4333,
   'X': 13.04,
   'Y': 4.36,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.49,
   'Ax_Top': 1.99,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4334,
   'X': 13.04,
   'Y': 4.84,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.93,
   'Ax_Top': 1.93,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4335,
   'X': 13.04,
   'Y': 5.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.79,
   'Ax_Top': 2.34,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4336,
   'X': 13.04,
   'Y': 5.8,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.93,
   'Ax_Top': 3.3,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4337,
   'X': 13.04,
   'Y': 6.28,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.07,
   'Ax_Top': 4.83,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4338,
   'X': 13.04,
   'Y': 6.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 7.91,
   'Ay_Top': 2.47
 },
 {
   'Panel': 171,
   'Node': 4339,
   'X': 10.48,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.8,
   'Ax_Top': 1.2,
   'Ay_Top': 0.43
 },
 {
   'Panel': 171,
   'Node': 4340,
   'X': 11.02,
   'Y': 14.02,
   'Ax_Bottom': 0.86,
   'Ay_Bottom': 0.82,
   'Ax_Top': 0.44,
   'Ay_Top': 0.66
 },
 {
   'Panel': 171,
   'Node': 4341,
   'X': 11.56,
   'Y': 14.02,
   'Ax_Bottom': 1.46,
   'Ay_Bottom': 0.67,
   'Ax_Top': 0,
   'Ay_Top': 0.88
 },
 {
   'Panel': 171,
   'Node': 4342,
   'X': 12.1,
   'Y': 14.02,
   'Ax_Bottom': 0.92,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.23
 },
 {
   'Panel': 171,
   'Node': 4343,
   'X': 18,
   'Y': 13.57,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.52,
   'Ax_Top': 3.55,
   'Ay_Top': 0.76
 },
 {
   'Panel': 171,
   'Node': 4344,
   'X': 18.05,
   'Y': 13.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.37,
   'Ax_Top': 3.59,
   'Ay_Top': 0.56
 },
 {
   'Panel': 171,
   'Node': 4345,
   'X': 18.1,
   'Y': 12.67,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.11,
   'Ax_Top': 2.77,
   'Ay_Top': 0.03
 },
 {
   'Panel': 171,
   'Node': 4346,
   'X': 14.41,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.77,
   'Ay_Top': 0.97
 },
 {
   'Panel': 171,
   'Node': 4347,
   'X': 8.42,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.56,
   'Ay_Top': 4.59
 },
 {
   'Panel': 171,
   'Node': 4348,
   'X': 8.89,
   'Y': 8.38,
   'Ax_Bottom': 0.61,
   'Ay_Bottom': 0,
   'Ax_Top': 0.75,
   'Ay_Top': 2.94
 },
 {
   'Panel': 171,
   'Node': 4349,
   'X': 9.37,
   'Y': 8.38,
   'Ax_Bottom': 1.53,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.36
 },
 {
   'Panel': 171,
   'Node': 4350,
   'X': 9.84,
   'Y': 8.38,
   'Ax_Bottom': 1.61,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.42
 },
 {
   'Panel': 171,
   'Node': 4351,
   'X': 10.31,
   'Y': 8.38,
   'Ax_Bottom': 2.28,
   'Ay_Bottom': 0.08,
   'Ax_Top': 0,
   'Ay_Top': 0.77
 },
 {
   'Panel': 171,
   'Node': 4352,
   'X': 10.79,
   'Y': 8.38,
   'Ax_Bottom': 2.95,
   'Ay_Bottom': 0.28,
   'Ax_Top': 0,
   'Ay_Top': 2.07
 },
 {
   'Panel': 171,
   'Node': 4353,
   'X': 1.88,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.99,
   'Ay_Top': 8.42
 },
 {
   'Panel': 171,
   'Node': 4354,
   'X': 2.35,
   'Y': 8.38,
   'Ax_Bottom': 0.55,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 5.16
 },
 {
   'Panel': 171,
   'Node': 4355,
   'X': 2.83,
   'Y': 8.38,
   'Ax_Bottom': 2.37,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.47
 },
 {
   'Panel': 171,
   'Node': 4356,
   'X': 3.31,
   'Y': 8.38,
   'Ax_Bottom': 3.34,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.54
 },
 {
   'Panel': 171,
   'Node': 4357,
   'X': 3.79,
   'Y': 8.38,
   'Ax_Bottom': 3.65,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.03
 },
 {
   'Panel': 171,
   'Node': 4358,
   'X': 4.26,
   'Y': 8.38,
   'Ax_Bottom': 3.34,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.95
 },
 {
   'Panel': 171,
   'Node': 4359,
   'X': 15.82,
   'Y': 14.02,
   'Ax_Bottom': 3.31,
   'Ay_Bottom': 0.92,
   'Ax_Top': 0,
   'Ay_Top': 0.38
 },
 {
   'Panel': 171,
   'Node': 4360,
   'X': 16.35,
   'Y': 14.02,
   'Ax_Bottom': 2.61,
   'Ay_Bottom': 0.89,
   'Ax_Top': 0,
   'Ay_Top': 0.51
 },
 {
   'Panel': 171,
   'Node': 4361,
   'X': 16.89,
   'Y': 14.02,
   'Ax_Bottom': 1.47,
   'Ay_Bottom': 0.89,
   'Ax_Top': 0.53,
   'Ay_Top': 0.69
 },
 {
   'Panel': 171,
   'Node': 4362,
   'X': 17.42,
   'Y': 14.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.82,
   'Ax_Top': 2,
   'Ay_Top': 0.71
 },
 {
   'Panel': 171,
   'Node': 4363,
   'X': 12.09,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.93,
   'Ay_Top': 4.89
 },
 {
   'Panel': 171,
   'Node': 4364,
   'X': 12.56,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.64,
   'Ay_Top': 5.26
 },
 {
   'Panel': 171,
   'Node': 4365,
   'X': 5.57,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.17,
   'Ay_Top': 2.35
 },
 {
   'Panel': 171,
   'Node': 4366,
   'X': 6.04,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.72,
   'Ay_Top': 2.49
 },
 {
   'Panel': 171,
   'Node': 4367,
   'X': 15.23,
   'Y': 8.38,
   'Ax_Bottom': 3.54,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.61
 },
 {
   'Panel': 171,
   'Node': 4368,
   'X': 15.7,
   'Y': 8.38,
   'Ax_Bottom': 3.81,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.18
 },
 {
   'Panel': 171,
   'Node': 4369,
   'X': 16.17,
   'Y': 8.38,
   'Ax_Bottom': 3.44,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.35
 },
 {
   'Panel': 171,
   'Node': 4370,
   'X': 16.64,
   'Y': 8.38,
   'Ax_Bottom': 2.34,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.04
 },
 {
   'Panel': 171,
   'Node': 4371,
   'X': 17.11,
   'Y': 8.38,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 0,
   'Ax_Top': 0.09,
   'Ay_Top': 4.82
 },
 {
   'Panel': 171,
   'Node': 4372,
   'X': 17.58,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.99,
   'Ay_Top': 7.7
 },
 {
   'Panel': 171,
   'Node': 4373,
   'X': 13.49,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.26,
   'Ay_Top': 4.72
 },
 {
   'Panel': 171,
   'Node': 4374,
   'X': 13.95,
   'Y': 8.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.57,
   'Ay_Top': 4.37
 },
 {
   'Panel': 171,
   'Node': 4375,
   'X': 15.56,
   'Y': 14.02,
   'Ax_Bottom': 3.41,
   'Ay_Bottom': 1.1,
   'Ax_Top': 0,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4376,
   'X': 12.37,
   'Y': 14.02,
   'Ax_Bottom': 0.18,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.22
 },
 {
   'Panel': 171,
   'Node': 4377,
   'X': 11.83,
   'Y': 14.02,
   'Ax_Bottom': 1.34,
   'Ay_Bottom': 0.49,
   'Ax_Top': 0,
   'Ay_Top': 0.73
 },
 {
   'Panel': 171,
   'Node': 4378,
   'X': 0,
   'Y': 8.88,
   'Ax_Bottom': 0.39,
   'Ay_Bottom': 0,
   'Ax_Top': 0.01,
   'Ay_Top': 2.01
 },
 {
   'Panel': 171,
   'Node': 4379,
   'X': 0,
   'Y': 9.37,
   'Ax_Bottom': 0.77,
   'Ay_Bottom': 0,
   'Ax_Top': 0.35,
   'Ay_Top': 0.9
 },
 {
   'Panel': 171,
   'Node': 4380,
   'X': 0,
   'Y': 9.87,
   'Ax_Bottom': 0.45,
   'Ay_Bottom': 1.23,
   'Ax_Top': 0.59,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4381,
   'X': 0,
   'Y': 10.36,
   'Ax_Bottom': 0.27,
   'Ay_Bottom': 2.1,
   'Ax_Top': 0.31,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4382,
   'X': 0,
   'Y': 10.85,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 2.51,
   'Ax_Top': 0.21,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4383,
   'X': 0,
   'Y': 11.35,
   'Ax_Bottom': 0.01,
   'Ay_Bottom': 2.43,
   'Ax_Top': 0.17,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4384,
   'X': 0,
   'Y': 11.84,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.8,
   'Ax_Top': 0.2,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4385,
   'X': 0,
   'Y': 12.34,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.89,
   'Ax_Top': 0.44,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4386,
   'X': 0,
   'Y': 12.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.21,
   'Ay_Top': 1.16
 },
 {
   'Panel': 171,
   'Node': 4387,
   'X': 1.91,
   'Y': 14.02,
   'Ax_Bottom': 0.32,
   'Ay_Bottom': 0,
   'Ax_Top': 0.98,
   'Ay_Top': 1.35
 },
 {
   'Panel': 171,
   'Node': 4388,
   'X': 2.43,
   'Y': 14.02,
   'Ax_Bottom': 1.24,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.39
 },
 {
   'Panel': 171,
   'Node': 4389,
   'X': 2.94,
   'Y': 14.02,
   'Ax_Bottom': 1.62,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.2
 },
 {
   'Panel': 171,
   'Node': 4390,
   'X': 3.46,
   'Y': 14.02,
   'Ax_Bottom': 1.55,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.33
 },
 {
   'Panel': 171,
   'Node': 4391,
   'X': 3.97,
   'Y': 14.02,
   'Ax_Bottom': 0.43,
   'Ay_Bottom': 0,
   'Ax_Top': 0.82,
   'Ay_Top': 3.34
 },
 {
   'Panel': 171,
   'Node': 4392,
   'X': 5,
   'Y': 14.02,
   'Ax_Bottom': 1.28,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.1
 },
 {
   'Panel': 171,
   'Node': 4393,
   'X': 5.51,
   'Y': 14.02,
   'Ax_Bottom': 2.2,
   'Ay_Bottom': 0.83,
   'Ax_Top': 0.53,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 4394,
   'X': 6.03,
   'Y': 14.02,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 1.15,
   'Ax_Top': 1.27,
   'Ay_Top': 1.05
 },
 {
   'Panel': 171,
   'Node': 4395,
   'X': 6.54,
   'Y': 14.02,
   'Ax_Bottom': 0.6,
   'Ay_Bottom': 1.26,
   'Ax_Top': 2.22,
   'Ay_Top': 0.76
 },
 {
   'Panel': 171,
   'Node': 4396,
   'X': 7.54,
   'Y': 10.16,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.47,
   'Ax_Top': 1.45,
   'Ay_Top': 0.04
 },
 {
   'Panel': 171,
   'Node': 4397,
   'X': 8.02,
   'Y': 10.16,
   'Ax_Bottom': 0.64,
   'Ay_Bottom': 0.13,
   'Ax_Top': 0.04,
   'Ay_Top': 0.09
 },
 {
   'Panel': 171,
   'Node': 4398,
   'X': 8.5,
   'Y': 10.16,
   'Ax_Bottom': 2.13,
   'Ay_Bottom': 0.98,
   'Ax_Top': 0,
   'Ay_Top': 0.31
 },
 {
   'Panel': 171,
   'Node': 4399,
   'X': 8.98,
   'Y': 10.16,
   'Ax_Bottom': 2.48,
   'Ay_Bottom': 1.05,
   'Ax_Top': 0.77,
   'Ay_Top': 1.62
 },
 {
   'Panel': 171,
   'Node': 4400,
   'X': 9.46,
   'Y': 10.16,
   'Ax_Bottom': 1.03,
   'Ay_Bottom': 3.54,
   'Ax_Top': 1.46,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4401,
   'X': 10.43,
   'Y': 14.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.52,
   'Ax_Top': 1.28,
   'Ay_Top': 0.53
 },
 {
   'Panel': 171,
   'Node': 4402,
   'X': 10.93,
   'Y': 14.12,
   'Ax_Bottom': 0.5,
   'Ay_Bottom': 0.62,
   'Ax_Top': 0.44,
   'Ay_Top': 0.66
 },
 {
   'Panel': 171,
   'Node': 4403,
   'X': 11.42,
   'Y': 14.12,
   'Ax_Bottom': 0.78,
   'Ay_Bottom': 0.46,
   'Ax_Top': 0,
   'Ay_Top': 0.19
 },
 {
   'Panel': 171,
   'Node': 4404,
   'X': 11.92,
   'Y': 14.12,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 0.31,
   'Ax_Top': 0,
   'Ay_Top': 0.19
 },
 {
   'Panel': 171,
   'Node': 4405,
   'X': 12.42,
   'Y': 14.12,
   'Ax_Bottom': 0.86,
   'Ay_Bottom': 0.31,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4406,
   'X': 12.91,
   'Y': 14.12,
   'Ax_Bottom': 1.51,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0.35,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4407,
   'X': 13.41,
   'Y': 14.12,
   'Ax_Bottom': 0.49,
   'Ay_Bottom': 0.11,
   'Ax_Top': 2.11,
   'Ay_Top': 1.08
 },
 {
   'Panel': 171,
   'Node': 4408,
   'X': 13.9,
   'Y': 14.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 12.17,
   'Ay_Top': 3.14
 },
 {
   'Panel': 171,
   'Node': 4409,
   'X': 14.4,
   'Y': 14.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.23,
   'Ay_Top': 0.57
 },
 {
   'Panel': 171,
   'Node': 4410,
   'X': 14.9,
   'Y': 14.12,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 0.13,
   'Ax_Top': 0,
   'Ay_Top': 0.23
 },
 {
   'Panel': 171,
   'Node': 4411,
   'X': 15.39,
   'Y': 14.12,
   'Ax_Bottom': 3.22,
   'Ay_Bottom': 0.7,
   'Ax_Top': 0,
   'Ay_Top': 0.32
 },
 {
   'Panel': 171,
   'Node': 4412,
   'X': 15.89,
   'Y': 14.12,
   'Ax_Bottom': 2.68,
   'Ay_Bottom': 0.62,
   'Ax_Top': 0,
   'Ay_Top': 0.02
 },
 {
   'Panel': 171,
   'Node': 4413,
   'X': 16.39,
   'Y': 14.12,
   'Ax_Bottom': 2.44,
   'Ay_Bottom': 0.75,
   'Ax_Top': 0,
   'Ay_Top': 0.44
 },
 {
   'Panel': 171,
   'Node': 4414,
   'X': 16.88,
   'Y': 14.12,
   'Ax_Bottom': 1.4,
   'Ay_Bottom': 0.69,
   'Ax_Top': 0.4,
   'Ay_Top': 0.72
 },
 {
   'Panel': 171,
   'Node': 4415,
   'X': 17.38,
   'Y': 14.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.83,
   'Ax_Top': 1.98,
   'Ay_Top': 0.75
 },
 {
   'Panel': 171,
   'Node': 4416,
   'X': 17.87,
   'Y': 14.12,
   'Ax_Bottom': 0.5,
   'Ay_Bottom': 1.24,
   'Ax_Top': 2.29,
   'Ay_Top': 1.1
 },
 {
   'Panel': 171,
   'Node': 4417,
   'X': 18.96,
   'Y': 14.24,
   'Ax_Bottom': 0.42,
   'Ay_Bottom': 0.34,
   'Ax_Top': 0.25,
   'Ay_Top': 0.26
 },
 {
   'Panel': 171,
   'Node': 4418,
   'X': 19.55,
   'Y': 13.79,
   'Ax_Bottom': 0.28,
   'Ay_Bottom': 0.67,
   'Ax_Top': 0.1,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4419,
   'X': 19.55,
   'Y': 13.34,
   'Ax_Bottom': 0.47,
   'Ay_Bottom': 0.7,
   'Ax_Top': 0.39,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4420,
   'X': 19.55,
   'Y': 12.89,
   'Ax_Bottom': 0.59,
   'Ay_Bottom': 0.48,
   'Ax_Top': 0.46,
   'Ay_Top': 0.38
 },
 {
   'Panel': 171,
   'Node': 4421,
   'X': 19.55,
   'Y': 10.38,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.07,
   'Ax_Top': 0.57,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4422,
   'X': 19.55,
   'Y': 9.88,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.57,
   'Ax_Top': 0.77,
   'Ay_Top': 0.06
 },
 {
   'Panel': 171,
   'Node': 4423,
   'X': 19.55,
   'Y': 9.38,
   'Ax_Bottom': 0.56,
   'Ay_Bottom': 0.57,
   'Ax_Top': 0.37,
   'Ay_Top': 0.25
 },
 {
   'Panel': 171,
   'Node': 4424,
   'X': 19.55,
   'Y': 8.88,
   'Ax_Bottom': 0.36,
   'Ay_Bottom': 0.13,
   'Ax_Top': 0.31,
   'Ay_Top': 0.6
 },
 {
   'Panel': 171,
   'Node': 4425,
   'X': 19.55,
   'Y': 6.76,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.18,
   'Ay_Top': 1.66
 },
 {
   'Panel': 171,
   'Node': 4426,
   'X': 19.55,
   'Y': 6.28,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.6,
   'Ax_Top': 0.37,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4427,
   'X': 19.55,
   'Y': 5.8,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.8,
   'Ax_Top': 0.16,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4428,
   'X': 19.55,
   'Y': 5.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.68,
   'Ax_Top': 0.07,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4429,
   'X': 19.55,
   'Y': 4.84,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.06,
   'Ax_Top': 0.02,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4430,
   'X': 19.55,
   'Y': 4.36,
   'Ax_Bottom': 0.02,
   'Ay_Bottom': 2.99,
   'Ax_Top': 0.01,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4431,
   'X': 19.55,
   'Y': 3.88,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.31,
   'Ax_Top': 0.09,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4432,
   'X': 19.55,
   'Y': 3.4,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.11,
   'Ax_Top': 0.53,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4433,
   'X': 19.55,
   'Y': 2.92,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.83,
   'Ay_Top': 1.83
 },
 {
   'Panel': 171,
   'Node': 4434,
   'X': 18.47,
   'Y': 1.22,
   'Ax_Bottom': 1.13,
   'Ay_Bottom': 0.49,
   'Ax_Top': 1.62,
   'Ay_Top': 2.05
 },
 {
   'Panel': 171,
   'Node': 4435,
   'X': 18.01,
   'Y': 1.22,
   'Ax_Bottom': 1.16,
   'Ay_Bottom': 0.05,
   'Ax_Top': 0.55,
   'Ay_Top': 1.69
 },
 {
   'Panel': 171,
   'Node': 4436,
   'X': 17.56,
   'Y': 1.22,
   'Ax_Bottom': 0.22,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.53
 },
 {
   'Panel': 171,
   'Node': 4437,
   'X': 15.47,
   'Y': 0.62,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.13,
   'Ax_Top': 0.32,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4438,
   'X': 14.98,
   'Y': 0.62,
   'Ax_Bottom': 1.03,
   'Ay_Bottom': 0.3,
   'Ax_Top': 0,
   'Ay_Top': 0.57
 },
 {
   'Panel': 171,
   'Node': 4439,
   'X': 14.5,
   'Y': 0.62,
   'Ax_Bottom': 1.49,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0,
   'Ay_Top': 0.76
 },
 {
   'Panel': 171,
   'Node': 4440,
   'X': 14.01,
   'Y': 0.62,
   'Ax_Bottom': 1.12,
   'Ay_Bottom': 0.83,
   'Ax_Top': 0.36,
   'Ay_Top': 0.86
 },
 {
   'Panel': 171,
   'Node': 4441,
   'X': 13.53,
   'Y': 0.62,
   'Ax_Bottom': 0.69,
   'Ay_Bottom': 1.07,
   'Ax_Top': 0.88,
   'Ay_Top': 0.72
 },
 {
   'Panel': 171,
   'Node': 4442,
   'X': 13.05,
   'Y': 0.62,
   'Ax_Bottom': 0.27,
   'Ay_Bottom': 0.18,
   'Ax_Top': 0.6,
   'Ay_Top': 0.08
 },
 {
   'Panel': 171,
   'Node': 4443,
   'X': 12.56,
   'Y': 0.62,
   'Ax_Bottom': 0.41,
   'Ay_Bottom': 0.93,
   'Ax_Top': 0.83,
   'Ay_Top': 0.55
 },
 {
   'Panel': 171,
   'Node': 4444,
   'X': 12.08,
   'Y': 0.62,
   'Ax_Bottom': 1.11,
   'Ay_Bottom': 0.72,
   'Ax_Top': 0.11,
   'Ay_Top': 0.71
 },
 {
   'Panel': 171,
   'Node': 4445,
   'X': 11.59,
   'Y': 0.62,
   'Ax_Bottom': 1.96,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0,
   'Ay_Top': 0.49
 },
 {
   'Panel': 171,
   'Node': 4446,
   'X': 11.11,
   'Y': 0.62,
   'Ax_Bottom': 2.1,
   'Ay_Bottom': 0.56,
   'Ax_Top': 0,
   'Ay_Top': 0.29
 },
 {
   'Panel': 171,
   'Node': 4447,
   'X': 10.62,
   'Y': 0.62,
   'Ax_Bottom': 1.07,
   'Ay_Bottom': 0.01,
   'Ax_Top': 0,
   'Ay_Top': 0.31
 },
 {
   'Panel': 171,
   'Node': 4448,
   'X': 9.62,
   'Y': 1.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 4449,
   'X': 9.1,
   'Y': 1.12,
   'Ax_Bottom': 0.66,
   'Ay_Bottom': 1.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4450,
   'X': 8.59,
   'Y': 1.12,
   'Ax_Bottom': 0.46,
   'Ay_Bottom': 0.02,
   'Ax_Top': 0.22,
   'Ay_Top': 0.8
 },
 {
   'Panel': 171,
   'Node': 4451,
   'X': 8.07,
   'Y': 1.12,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 0.58,
   'Ax_Top': 0.51,
   'Ay_Top': 0.75
 },
 {
   'Panel': 171,
   'Node': 4452,
   'X': 7.55,
   'Y': 1.12,
   'Ax_Bottom': 0.67,
   'Ay_Bottom': 0.92,
   'Ax_Top': 1.21,
   'Ay_Top': 0.92
 },
 {
   'Panel': 171,
   'Node': 4453,
   'X': 7.03,
   'Y': 1.12,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 4454,
   'X': 6.03,
   'Y': 0.62,
   'Ax_Bottom': 0.72,
   'Ay_Bottom': 0.35,
   'Ax_Top': 0,
   'Ay_Top': 0.1
 },
 {
   'Panel': 171,
   'Node': 4455,
   'X': 5.55,
   'Y': 0.62,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0,
   'Ay_Top': 0.28
 },
 {
   'Panel': 171,
   'Node': 4456,
   'X': 5.07,
   'Y': 0.62,
   'Ax_Bottom': 2.66,
   'Ay_Bottom': 0.86,
   'Ax_Top': 0,
   'Ay_Top': 0.55
 },
 {
   'Panel': 171,
   'Node': 4457,
   'X': 4.59,
   'Y': 0.62,
   'Ax_Bottom': 2.7,
   'Ay_Bottom': 0.7,
   'Ax_Top': 0,
   'Ay_Top': 0.25
 },
 {
   'Panel': 171,
   'Node': 4458,
   'X': 4.1,
   'Y': 0.62,
   'Ax_Bottom': 1.11,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.39
 },
 {
   'Panel': 171,
   'Node': 4459,
   'X': 2.52,
   'Y': 1.22,
   'Ax_Bottom': 0.55,
   'Ay_Bottom': 0,
   'Ax_Top': 0.2,
   'Ay_Top': 3.3
 },
 {
   'Panel': 171,
   'Node': 4460,
   'X': 1.95,
   'Y': 1.22,
   'Ax_Bottom': 1.47,
   'Ay_Bottom': 0.07,
   'Ax_Top': 0.41,
   'Ay_Top': 1.51
 },
 {
   'Panel': 171,
   'Node': 4461,
   'X': 1.37,
   'Y': 1.22,
   'Ax_Bottom': 1.74,
   'Ay_Bottom': 0.69,
   'Ax_Top': 1.35,
   'Ay_Top': 1.91
 },
 {
   'Panel': 171,
   'Node': 4462,
   'X': 0,
   'Y': 2.92,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.82,
   'Ay_Top': 1.83
 },
 {
   'Panel': 171,
   'Node': 4463,
   'X': 0,
   'Y': 3.4,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0.49,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4464,
   'X': 0,
   'Y': 3.88,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.03,
   'Ax_Top': 0.09,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4465,
   'X': 0,
   'Y': 4.36,
   'Ax_Bottom': 0.01,
   'Ay_Bottom': 2.82,
   'Ax_Top': 0.01,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4466,
   'X': 0,
   'Y': 4.84,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.19,
   'Ax_Top': 0.01,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4467,
   'X': 0,
   'Y': 5.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.78,
   'Ax_Top': 0.06,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4468,
   'X': 0,
   'Y': 5.8,
   'Ax_Bottom': 0.03,
   'Ay_Bottom': 2.02,
   'Ax_Top': 0.16,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4469,
   'X': 0,
   'Y': 6.28,
   'Ax_Bottom': 0.1,
   'Ay_Bottom': 0.85,
   'Ax_Top': 0.43,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4470,
   'X': 0,
   'Y': 6.75,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.31,
   'Ay_Top': 1.6
 },
 {
   'Panel': 171,
   'Node': 4471,
   'X': 18.7,
   'Y': 13.82,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.39,
   'Ax_Top': 0.98,
   'Ay_Top': 0.38
 },
 {
   'Panel': 171,
   'Node': 4472,
   'X': 19.12,
   'Y': 13.82,
   'Ax_Bottom': 0.3,
   'Ay_Bottom': 0.53,
   'Ax_Top': 0.43,
   'Ay_Top': 0.12
 },
 {
   'Panel': 171,
   'Node': 4473,
   'X': 0.47,
   'Y': 13.39,
   'Ax_Bottom': 0.62,
   'Ay_Bottom': 0,
   'Ax_Top': 1.86,
   'Ay_Top': 4.13
 },
 {
   'Panel': 171,
   'Node': 4474,
   'X': 0.94,
   'Y': 13.39,
   'Ax_Bottom': 0.44,
   'Ay_Bottom': 0,
   'Ax_Top': 3.03,
   'Ay_Top': 2.87
 },
 {
   'Panel': 171,
   'Node': 4475,
   'X': 1.41,
   'Y': 13.39,
   'Ax_Bottom': 0.15,
   'Ay_Bottom': 0.58,
   'Ax_Top': 1.66,
   'Ay_Top': 0.73
 },
 {
   'Panel': 171,
   'Node': 4476,
   'X': 1.88,
   'Y': 13.39,
   'Ax_Bottom': 0.35,
   'Ay_Bottom': 0,
   'Ax_Top': 0.25,
   'Ay_Top': 0.45
 },
 {
   'Panel': 171,
   'Node': 4477,
   'X': 2.35,
   'Y': 13.39,
   'Ax_Bottom': 1.45,
   'Ay_Bottom': 0.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4478,
   'X': 2.82,
   'Y': 13.39,
   'Ax_Bottom': 1.93,
   'Ay_Bottom': 0.53,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4479,
   'X': 3.29,
   'Y': 13.39,
   'Ax_Bottom': 1.96,
   'Ay_Bottom': 0.48,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4480,
   'X': 3.76,
   'Y': 13.39,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 0.4,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4481,
   'X': 4.23,
   'Y': 13.39,
   'Ax_Bottom': 1.37,
   'Ay_Bottom': 0.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4482,
   'X': 4.7,
   'Y': 13.39,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 1.12,
   'Ax_Top': 0.34,
   'Ay_Top': 0.75
 },
 {
   'Panel': 171,
   'Node': 4483,
   'X': 5.17,
   'Y': 13.39,
   'Ax_Bottom': 2.94,
   'Ay_Bottom': 1.54,
   'Ax_Top': 0.4,
   'Ay_Top': 1.09
 },
 {
   'Panel': 171,
   'Node': 4484,
   'X': 5.64,
   'Y': 13.39,
   'Ax_Bottom': 2.4,
   'Ay_Bottom': 1.39,
   'Ax_Top': 0.9,
   'Ay_Top': 1.26
 },
 {
   'Panel': 171,
   'Node': 4485,
   'X': 6.11,
   'Y': 13.39,
   'Ax_Bottom': 1.25,
   'Ay_Bottom': 1.1,
   'Ax_Top': 1.73,
   'Ay_Top': 1.35
 },
 {
   'Panel': 171,
   'Node': 4486,
   'X': 6.58,
   'Y': 13.39,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.03,
   'Ax_Top': 2.66,
   'Ay_Top': 1.43
 },
 {
   'Panel': 171,
   'Node': 4487,
   'X': 10.39,
   'Y': 13.39,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.13,
   'Ay_Top': 1.07
 },
 {
   'Panel': 171,
   'Node': 4488,
   'X': 10.85,
   'Y': 13.39,
   'Ax_Bottom': 0.71,
   'Ay_Bottom': 0.83,
   'Ax_Top': 1.38,
   'Ay_Top': 1.06
 },
 {
   'Panel': 171,
   'Node': 4489,
   'X': 11.31,
   'Y': 13.39,
   'Ax_Bottom': 1.68,
   'Ay_Bottom': 1.06,
   'Ax_Top': 0.84,
   'Ay_Top': 1.13
 },
 {
   'Panel': 171,
   'Node': 4490,
   'X': 11.77,
   'Y': 13.39,
   'Ax_Bottom': 2.24,
   'Ay_Bottom': 1,
   'Ax_Top': 0.51,
   'Ay_Top': 1.32
 },
 {
   'Panel': 171,
   'Node': 4491,
   'X': 12.22,
   'Y': 13.39,
   'Ax_Bottom': 2.54,
   'Ay_Bottom': 0.72,
   'Ax_Top': 0.5,
   'Ay_Top': 1.75
 },
 {
   'Panel': 171,
   'Node': 4492,
   'X': 12.68,
   'Y': 13.39,
   'Ax_Bottom': 1.86,
   'Ay_Bottom': 0.11,
   'Ax_Top': 1.39,
   'Ay_Top': 2.62
 },
 {
   'Panel': 171,
   'Node': 4493,
   'X': 13.14,
   'Y': 13.39,
   'Ax_Bottom': 0.74,
   'Ay_Bottom': 0,
   'Ax_Top': 2.37,
   'Ay_Top': 2.62
 },
 {
   'Panel': 171,
   'Node': 4494,
   'X': 13.6,
   'Y': 13.39,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.21,
   'Ay_Top': 2.08
 },
 {
   'Panel': 171,
   'Node': 4495,
   'X': 14.06,
   'Y': 13.39,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 0.48,
   'Ax_Top': 1.01,
   'Ay_Top': 0.16
 },
 {
   'Panel': 171,
   'Node': 4496,
   'X': 14.51,
   'Y': 13.39,
   'Ax_Bottom': 2.11,
   'Ay_Bottom': 0.55,
   'Ax_Top': 0.53,
   'Ay_Top': 1.36
 },
 {
   'Panel': 171,
   'Node': 4497,
   'X': 15.43,
   'Y': 13.39,
   'Ax_Bottom': 3.62,
   'Ay_Bottom': 1.53,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4498,
   'X': 15.89,
   'Y': 13.39,
   'Ax_Bottom': 3.59,
   'Ay_Bottom': 1.47,
   'Ax_Top': 0,
   'Ay_Top': 0.29
 },
 {
   'Panel': 171,
   'Node': 4499,
   'X': 16.35,
   'Y': 13.39,
   'Ax_Bottom': 2.98,
   'Ay_Bottom': 1.43,
   'Ax_Top': 0,
   'Ay_Top': 0.58
 },
 {
   'Panel': 171,
   'Node': 4500,
   'X': 16.8,
   'Y': 13.39,
   'Ax_Bottom': 1.89,
   'Ay_Bottom': 1.28,
   'Ax_Top': 0.71,
   'Ay_Top': 0.83
 },
 {
   'Panel': 171,
   'Node': 4501,
   'X': 17.26,
   'Y': 13.39,
   'Ax_Bottom': 0.24,
   'Ay_Bottom': 1.22,
   'Ax_Top': 2.11,
   'Ay_Top': 0.7
 },
 {
   'Panel': 171,
   'Node': 4502,
   'X': 18.63,
   'Y': 13.39,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.2,
   'Ax_Top': 1.41,
   'Ay_Top': 0.35
 },
 {
   'Panel': 171,
   'Node': 4503,
   'X': 19.09,
   'Y': 13.39,
   'Ax_Bottom': 0.28,
   'Ay_Bottom': 0.53,
   'Ax_Top': 0.62,
   'Ay_Top': 0.24
 },
 {
   'Panel': 171,
   'Node': 4504,
   'X': 0.47,
   'Y': 12.96,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.42,
   'Ay_Top': 1.61
 },
 {
   'Panel': 171,
   'Node': 4505,
   'X': 0.94,
   'Y': 12.96,
   'Ax_Bottom': 0.39,
   'Ay_Bottom': 0.62,
   'Ax_Top': 1.22,
   'Ay_Top': 0.82
 },
 {
   'Panel': 171,
   'Node': 4506,
   'X': 1.41,
   'Y': 12.96,
   'Ax_Bottom': 0.42,
   'Ay_Bottom': 0.96,
   'Ax_Top': 0.66,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4507,
   'X': 1.88,
   'Y': 12.96,
   'Ax_Bottom': 0.68,
   'Ay_Bottom': 0.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4508,
   'X': 2.35,
   'Y': 12.96,
   'Ax_Bottom': 1.46,
   'Ay_Bottom': 0.98,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4509,
   'X': 2.82,
   'Y': 12.96,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 1.11,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4510,
   'X': 3.29,
   'Y': 12.96,
   'Ax_Bottom': 2.47,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4511,
   'X': 3.76,
   'Y': 12.96,
   'Ax_Bottom': 2.05,
   'Ay_Bottom': 1.32,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4512,
   'X': 4.23,
   'Y': 12.96,
   'Ax_Bottom': 2.12,
   'Ay_Bottom': 1.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4513,
   'X': 4.7,
   'Y': 12.96,
   'Ax_Bottom': 2.62,
   'Ay_Bottom': 1.96,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4514,
   'X': 5.17,
   'Y': 12.96,
   'Ax_Bottom': 3.04,
   'Ay_Bottom': 2.02,
   'Ax_Top': 0,
   'Ay_Top': 0.26
 },
 {
   'Panel': 171,
   'Node': 4515,
   'X': 5.64,
   'Y': 12.96,
   'Ax_Bottom': 2.28,
   'Ay_Bottom': 1.67,
   'Ax_Top': 0.79,
   'Ay_Top': 0.86
 },
 {
   'Panel': 171,
   'Node': 4516,
   'X': 6.11,
   'Y': 12.96,
   'Ax_Bottom': 0.88,
   'Ay_Bottom': 1.13,
   'Ax_Top': 1.86,
   'Ay_Top': 1.26
 },
 {
   'Panel': 171,
   'Node': 4517,
   'X': 6.58,
   'Y': 12.96,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.21,
   'Ay_Top': 1.47
 },
 {
   'Panel': 171,
   'Node': 4518,
   'X': 10.39,
   'Y': 12.96,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.81,
   'Ay_Top': 1.14
 },
 {
   'Panel': 171,
   'Node': 4519,
   'X': 10.85,
   'Y': 12.96,
   'Ax_Bottom': 0.35,
   'Ay_Bottom': 0.77,
   'Ax_Top': 1.77,
   'Ay_Top': 1.05
 },
 {
   'Panel': 171,
   'Node': 4520,
   'X': 11.31,
   'Y': 12.96,
   'Ax_Bottom': 1.59,
   'Ay_Bottom': 1.24,
   'Ax_Top': 1.08,
   'Ay_Top': 0.96
 },
 {
   'Panel': 171,
   'Node': 4521,
   'X': 11.77,
   'Y': 12.96,
   'Ax_Bottom': 2.39,
   'Ay_Bottom': 1.56,
   'Ax_Top': 0.75,
   'Ay_Top': 0.94
 },
 {
   'Panel': 171,
   'Node': 4522,
   'X': 12.22,
   'Y': 12.96,
   'Ax_Bottom': 2.73,
   'Ay_Bottom': 1.77,
   'Ax_Top': 0.77,
   'Ay_Top': 0.99
 },
 {
   'Panel': 171,
   'Node': 4523,
   'X': 12.68,
   'Y': 12.96,
   'Ax_Bottom': 2.64,
   'Ay_Bottom': 1.99,
   'Ax_Top': 0.89,
   'Ay_Top': 0.8
 },
 {
   'Panel': 171,
   'Node': 4524,
   'X': 13.14,
   'Y': 12.96,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 1.95,
   'Ax_Top': 1.29,
   'Ay_Top': 0.43
 },
 {
   'Panel': 171,
   'Node': 4525,
   'X': 13.6,
   'Y': 12.96,
   'Ax_Bottom': 0.54,
   'Ay_Bottom': 1.74,
   'Ax_Top': 0.59,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4526,
   'X': 14.06,
   'Y': 12.96,
   'Ax_Bottom': 0.92,
   'Ay_Bottom': 1.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4527,
   'X': 14.51,
   'Y': 12.96,
   'Ax_Bottom': 2.77,
   'Ay_Bottom': 2.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4528,
   'X': 14.97,
   'Y': 12.96,
   'Ax_Bottom': 3.83,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4529,
   'X': 15.43,
   'Y': 12.96,
   'Ax_Bottom': 3.92,
   'Ay_Bottom': 2.1,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4530,
   'X': 15.89,
   'Y': 12.96,
   'Ax_Bottom': 3.62,
   'Ay_Bottom': 1.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4531,
   'X': 16.35,
   'Y': 12.96,
   'Ax_Bottom': 3,
   'Ay_Bottom': 1.59,
   'Ax_Top': 0,
   'Ay_Top': 0.28
 },
 {
   'Panel': 171,
   'Node': 4532,
   'X': 16.8,
   'Y': 12.96,
   'Ax_Bottom': 2.02,
   'Ay_Bottom': 1.32,
   'Ax_Top': 0.74,
   'Ay_Top': 0.94
 },
 {
   'Panel': 171,
   'Node': 4533,
   'X': 17.26,
   'Y': 12.96,
   'Ax_Bottom': 0.46,
   'Ay_Bottom': 1.13,
   'Ax_Top': 2.43,
   'Ay_Top': 1.24
 },
 {
   'Panel': 171,
   'Node': 4534,
   'X': 17.72,
   'Y': 12.96,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.67,
   'Ax_Top': 3.67,
   'Ay_Top': 0.91
 },
 {
   'Panel': 171,
   'Node': 4535,
   'X': 18.63,
   'Y': 12.96,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.23,
   'Ay_Top': 0.6
 },
 {
   'Panel': 171,
   'Node': 4536,
   'X': 19.09,
   'Y': 12.96,
   'Ax_Bottom': 0.36,
   'Ay_Bottom': 0.4,
   'Ax_Top': 0.75,
   'Ay_Top': 0.53
 },
 {
   'Panel': 171,
   'Node': 4537,
   'X': 0.47,
   'Y': 12.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.92,
   'Ax_Top': 0.56,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4538,
   'X': 0.94,
   'Y': 12.54,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 1.29,
   'Ax_Top': 0.23,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4539,
   'X': 1.41,
   'Y': 12.54,
   'Ax_Bottom': 0.52,
   'Ay_Bottom': 1.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4540,
   'X': 1.88,
   'Y': 12.54,
   'Ax_Bottom': 0.99,
   'Ay_Bottom': 1.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4541,
   'X': 2.35,
   'Y': 12.54,
   'Ax_Bottom': 1.86,
   'Ay_Bottom': 1.76,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4542,
   'X': 2.82,
   'Y': 12.54,
   'Ax_Bottom': 2.18,
   'Ay_Bottom': 1.8,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4543,
   'X': 3.29,
   'Y': 12.54,
   'Ax_Bottom': 2.33,
   'Ay_Bottom': 1.82,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4544,
   'X': 3.76,
   'Y': 12.54,
   'Ax_Bottom': 2.4,
   'Ay_Bottom': 1.94,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4545,
   'X': 4.23,
   'Y': 12.54,
   'Ax_Bottom': 2.66,
   'Ay_Bottom': 2.18,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4546,
   'X': 4.7,
   'Y': 12.54,
   'Ax_Bottom': 2.99,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4547,
   'X': 5.17,
   'Y': 12.54,
   'Ax_Bottom': 3.08,
   'Ay_Bottom': 2.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4548,
   'X': 5.64,
   'Y': 12.54,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 1.8,
   'Ax_Top': 0.51,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4549,
   'X': 6.11,
   'Y': 12.54,
   'Ax_Bottom': 0.55,
   'Ay_Bottom': 1.17,
   'Ax_Top': 1.84,
   'Ay_Top': 0.98
 },
 {
   'Panel': 171,
   'Node': 4550,
   'X': 6.58,
   'Y': 12.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.52,
   'Ay_Top': 1.4
 },
 {
   'Panel': 171,
   'Node': 4551,
   'X': 10.39,
   'Y': 12.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.15,
   'Ay_Top': 1.12
 },
 {
   'Panel': 171,
   'Node': 4552,
   'X': 10.85,
   'Y': 12.54,
   'Ax_Bottom': 0.02,
   'Ay_Bottom': 0.84,
   'Ax_Top': 1.99,
   'Ay_Top': 0.86
 },
 {
   'Panel': 171,
   'Node': 4553,
   'X': 11.31,
   'Y': 12.54,
   'Ax_Bottom': 1.33,
   'Ay_Bottom': 1.43,
   'Ax_Top': 1.19,
   'Ay_Top': 0.58
 },
 {
   'Panel': 171,
   'Node': 4554,
   'X': 11.77,
   'Y': 12.54,
   'Ax_Bottom': 2.2,
   'Ay_Bottom': 1.99,
   'Ax_Top': 0.72,
   'Ay_Top': 0.28
 },
 {
   'Panel': 171,
   'Node': 4555,
   'X': 12.22,
   'Y': 12.54,
   'Ax_Bottom': 2.67,
   'Ay_Bottom': 2.51,
   'Ax_Top': 0.41,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4556,
   'X': 12.68,
   'Y': 12.54,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 2.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4557,
   'X': 13.14,
   'Y': 12.54,
   'Ax_Bottom': 2.15,
   'Ay_Bottom': 3.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4558,
   'X': 13.6,
   'Y': 12.54,
   'Ax_Bottom': 1.45,
   'Ay_Bottom': 2.73,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4559,
   'X': 14.06,
   'Y': 12.54,
   'Ax_Bottom': 1.79,
   'Ay_Bottom': 2.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4560,
   'X': 14.51,
   'Y': 12.54,
   'Ax_Bottom': 3.12,
   'Ay_Bottom': 3.01,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4561,
   'X': 14.97,
   'Y': 12.54,
   'Ax_Bottom': 3.79,
   'Ay_Bottom': 2.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4562,
   'X': 15.43,
   'Y': 12.54,
   'Ax_Bottom': 3.79,
   'Ay_Bottom': 2.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4563,
   'X': 15.89,
   'Y': 12.54,
   'Ax_Bottom': 3.49,
   'Ay_Bottom': 2.1,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4564,
   'X': 16.35,
   'Y': 12.54,
   'Ax_Bottom': 2.89,
   'Ay_Bottom': 1.63,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4565,
   'X': 16.8,
   'Y': 12.54,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 1.07,
   'Ax_Top': 0.32,
   'Ay_Top': 0.8
 },
 {
   'Panel': 171,
   'Node': 4566,
   'X': 17.26,
   'Y': 12.54,
   'Ax_Bottom': 0.66,
   'Ay_Bottom': 0.38,
   'Ax_Top': 2.15,
   'Ay_Top': 1.98
 },
 {
   'Panel': 171,
   'Node': 4567,
   'X': 17.72,
   'Y': 12.54,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.46,
   'Ay_Top': 2.9
 },
 {
   'Panel': 171,
   'Node': 4568,
   'X': 0.47,
   'Y': 12.11,
   'Ax_Bottom': 0.04,
   'Ay_Bottom': 1.81,
   'Ax_Top': 0.1,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4569,
   'X': 0.94,
   'Y': 12.11,
   'Ax_Bottom': 0.14,
   'Ay_Bottom': 2.06,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4570,
   'X': 1.41,
   'Y': 12.11,
   'Ax_Bottom': 0.58,
   'Ay_Bottom': 2.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4571,
   'X': 1.88,
   'Y': 12.11,
   'Ax_Bottom': 1.11,
   'Ay_Bottom': 2.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4572,
   'X': 2.35,
   'Y': 12.11,
   'Ax_Bottom': 1.71,
   'Ay_Bottom': 2.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4573,
   'X': 2.82,
   'Y': 12.11,
   'Ax_Bottom': 2.21,
   'Ay_Bottom': 2.44,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4574,
   'X': 3.29,
   'Y': 12.11,
   'Ax_Bottom': 2.6,
   'Ay_Bottom': 2.32,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4575,
   'X': 3.76,
   'Y': 12.11,
   'Ax_Bottom': 2.68,
   'Ay_Bottom': 2.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4576,
   'X': 4.23,
   'Y': 12.11,
   'Ax_Bottom': 2.99,
   'Ay_Bottom': 2.48,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4577,
   'X': 4.7,
   'Y': 12.11,
   'Ax_Bottom': 3.17,
   'Ay_Bottom': 2.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4578,
   'X': 5.17,
   'Y': 12.11,
   'Ax_Bottom': 3.05,
   'Ay_Bottom': 2.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4579,
   'X': 5.64,
   'Y': 12.11,
   'Ax_Bottom': 1.87,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4580,
   'X': 6.11,
   'Y': 12.11,
   'Ax_Bottom': 0.23,
   'Ay_Bottom': 1.14,
   'Ax_Top': 1.67,
   'Ay_Top': 0.61
 },
 {
   'Panel': 171,
   'Node': 4581,
   'X': 6.58,
   'Y': 12.11,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.72,
   'Ay_Top': 1.28
 },
 {
   'Panel': 171,
   'Node': 4582,
   'X': 10.39,
   'Y': 12.11,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.39,
   'Ay_Top': 1.07
 },
 {
   'Panel': 171,
   'Node': 4583,
   'X': 10.85,
   'Y': 12.11,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.61,
   'Ax_Top': 2.04,
   'Ay_Top': 0.61
 },
 {
   'Panel': 171,
   'Node': 4584,
   'X': 11.31,
   'Y': 12.11,
   'Ax_Bottom': 0.96,
   'Ay_Bottom': 1.46,
   'Ax_Top': 1.09,
   'Ay_Top': 0.13
 },
 {
   'Panel': 171,
   'Node': 4585,
   'X': 11.77,
   'Y': 12.11,
   'Ax_Bottom': 1.86,
   'Ay_Bottom': 2.14,
   'Ax_Top': 0.13,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4586,
   'X': 12.22,
   'Y': 12.11,
   'Ax_Bottom': 2.42,
   'Ay_Bottom': 2.82,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4587,
   'X': 12.68,
   'Y': 12.11,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 3.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4588,
   'X': 13.14,
   'Y': 12.11,
   'Ax_Bottom': 2.52,
   'Ay_Bottom': 3.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4589,
   'X': 13.6,
   'Y': 12.11,
   'Ax_Bottom': 2.13,
   'Ay_Bottom': 3.5,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4590,
   'X': 14.06,
   'Y': 12.11,
   'Ax_Bottom': 2.32,
   'Ay_Bottom': 3.37,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4591,
   'X': 14.51,
   'Y': 12.11,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 3.5,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4592,
   'X': 14.97,
   'Y': 12.11,
   'Ax_Bottom': 3.65,
   'Ay_Bottom': 3.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4593,
   'X': 15.43,
   'Y': 12.11,
   'Ax_Bottom': 3.55,
   'Ay_Bottom': 2.77,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4594,
   'X': 15.89,
   'Y': 12.11,
   'Ax_Bottom': 3.24,
   'Ay_Bottom': 2.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4595,
   'X': 16.35,
   'Y': 12.11,
   'Ax_Bottom': 2.61,
   'Ay_Bottom': 1.63,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4596,
   'X': 16.8,
   'Y': 12.11,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 0.87,
   'Ax_Top': 0,
   'Ay_Top': 0.08
 },
 {
   'Panel': 171,
   'Node': 4597,
   'X': 17.26,
   'Y': 12.11,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.97,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 4598,
   'X': 17.72,
   'Y': 12.11,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.34,
   'Ay_Top': 3.81
 },
 {
   'Panel': 171,
   'Node': 4599,
   'X': 0.47,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.28,
   'Ax_Top': 0.06,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4600,
   'X': 0.94,
   'Y': 11.69,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 2.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4601,
   'X': 1.41,
   'Y': 11.69,
   'Ax_Bottom': 0.89,
   'Ay_Bottom': 2.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4602,
   'X': 1.88,
   'Y': 11.69,
   'Ax_Bottom': 1.18,
   'Ay_Bottom': 2.89,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4603,
   'X': 2.35,
   'Y': 11.69,
   'Ax_Bottom': 1.84,
   'Ay_Bottom': 2.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4604,
   'X': 2.82,
   'Y': 11.69,
   'Ax_Bottom': 2.42,
   'Ay_Bottom': 2.9,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4605,
   'X': 3.29,
   'Y': 11.69,
   'Ax_Bottom': 2.76,
   'Ay_Bottom': 2.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4606,
   'X': 3.76,
   'Y': 11.69,
   'Ax_Bottom': 2.88,
   'Ay_Bottom': 2.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4607,
   'X': 4.23,
   'Y': 11.69,
   'Ax_Bottom': 3.15,
   'Ay_Bottom': 2.68,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4608,
   'X': 4.7,
   'Y': 11.69,
   'Ax_Bottom': 3.28,
   'Ay_Bottom': 2.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4609,
   'X': 5.17,
   'Y': 11.69,
   'Ax_Bottom': 2.91,
   'Ay_Bottom': 2.46,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4610,
   'X': 5.64,
   'Y': 11.69,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4611,
   'X': 6.11,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.04,
   'Ax_Top': 1.39,
   'Ay_Top': 0.13
 },
 {
   'Panel': 171,
   'Node': 4612,
   'X': 6.58,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.68,
   'Ay_Top': 0.98
 },
 {
   'Panel': 171,
   'Node': 4613,
   'X': 10.39,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.51,
   'Ay_Top': 1.01
 },
 {
   'Panel': 171,
   'Node': 4614,
   'X': 10.85,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.37,
   'Ax_Top': 1.94,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4615,
   'X': 11.31,
   'Y': 11.69,
   'Ax_Bottom': 0.56,
   'Ay_Bottom': 1.26,
   'Ax_Top': 0.6,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4616,
   'X': 11.77,
   'Y': 11.69,
   'Ax_Bottom': 1.42,
   'Ay_Bottom': 2,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4617,
   'X': 12.22,
   'Y': 11.69,
   'Ax_Bottom': 2.02,
   'Ay_Bottom': 2.77,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4618,
   'X': 12.68,
   'Y': 11.69,
   'Ax_Bottom': 2.57,
   'Ay_Bottom': 3.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4619,
   'X': 13.14,
   'Y': 11.69,
   'Ax_Bottom': 2.64,
   'Ay_Bottom': 3.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4620,
   'X': 13.6,
   'Y': 11.69,
   'Ax_Bottom': 2.54,
   'Ay_Bottom': 4.06,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4621,
   'X': 14.06,
   'Y': 11.69,
   'Ax_Bottom': 2.62,
   'Ay_Bottom': 3.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4622,
   'X': 14.51,
   'Y': 11.69,
   'Ax_Bottom': 3.22,
   'Ay_Bottom': 3.76,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4623,
   'X': 14.97,
   'Y': 11.69,
   'Ax_Bottom': 3.37,
   'Ay_Bottom': 3.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4624,
   'X': 15.43,
   'Y': 11.69,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 2.81,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4625,
   'X': 15.89,
   'Y': 11.69,
   'Ax_Bottom': 2.94,
   'Ay_Bottom': 2.29,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4626,
   'X': 16.35,
   'Y': 11.69,
   'Ax_Bottom': 2.28,
   'Ay_Bottom': 1.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4627,
   'X': 16.8,
   'Y': 11.69,
   'Ax_Bottom': 1.15,
   'Ay_Bottom': 0.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4628,
   'X': 17.26,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.06,
   'Ax_Top': 0.8,
   'Ay_Top': 0.08
 },
 {
   'Panel': 171,
   'Node': 4629,
   'X': 17.72,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.32,
   'Ay_Top': 0.68
 },
 {
   'Panel': 171,
   'Node': 4630,
   'X': 18.18,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.21,
   'Ax_Top': 3.81,
   'Ay_Top': 1.32
 },
 {
   'Panel': 171,
   'Node': 4631,
   'X': 18.63,
   'Y': 11.69,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.91,
   'Ay_Top': 2.56
 },
 {
   'Panel': 171,
   'Node': 4632,
   'X': 19.09,
   'Y': 11.69,
   'Ax_Bottom': 0.24,
   'Ay_Bottom': 0.26,
   'Ax_Top': 1.64,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 4633,
   'X': 0.47,
   'Y': 11.26,
   'Ax_Bottom': 0.08,
   'Ay_Bottom': 2.68,
   'Ax_Top': 0.07,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4634,
   'X': 0.94,
   'Y': 11.26,
   'Ax_Bottom': 0.25,
   'Ay_Bottom': 2.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4635,
   'X': 1.41,
   'Y': 11.26,
   'Ax_Bottom': 0.78,
   'Ay_Bottom': 2.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4636,
   'X': 1.88,
   'Y': 11.26,
   'Ax_Bottom': 1.15,
   'Ay_Bottom': 3.16,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4637,
   'X': 2.35,
   'Y': 11.26,
   'Ax_Bottom': 1.93,
   'Ay_Bottom': 3.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4638,
   'X': 2.82,
   'Y': 11.26,
   'Ax_Bottom': 2.65,
   'Ay_Bottom': 3.22,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4639,
   'X': 3.29,
   'Y': 11.26,
   'Ax_Bottom': 3.1,
   'Ay_Bottom': 2.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4640,
   'X': 3.76,
   'Y': 11.26,
   'Ax_Bottom': 3.15,
   'Ay_Bottom': 2.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4641,
   'X': 4.23,
   'Y': 11.26,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 2.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4642,
   'X': 4.7,
   'Y': 11.26,
   'Ax_Bottom': 3.2,
   'Ay_Bottom': 2.5,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4643,
   'X': 5.17,
   'Y': 11.26,
   'Ax_Bottom': 2.56,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4644,
   'X': 5.64,
   'Y': 11.26,
   'Ax_Bottom': 1.3,
   'Ay_Bottom': 1.48,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4645,
   'X': 6.11,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.6,
   'Ax_Top': 1.06,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4646,
   'X': 6.58,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.62,
   'Ay_Top': 0.87
 },
 {
   'Panel': 171,
   'Node': 4647,
   'X': 10.39,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.58,
   'Ay_Top': 1.09
 },
 {
   'Panel': 171,
   'Node': 4648,
   'X': 10.85,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.03,
   'Ax_Top': 1.68,
   'Ay_Top': 0.32
 },
 {
   'Panel': 171,
   'Node': 4649,
   'X': 11.31,
   'Y': 11.26,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 0.82,
   'Ax_Top': 0.23,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4650,
   'X': 11.77,
   'Y': 11.26,
   'Ax_Bottom': 0.92,
   'Ay_Bottom': 1.57,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4651,
   'X': 12.22,
   'Y': 11.26,
   'Ax_Bottom': 1.6,
   'Ay_Bottom': 2.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4652,
   'X': 12.68,
   'Y': 11.26,
   'Ax_Bottom': 2.12,
   'Ay_Bottom': 3.24,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4653,
   'X': 13.14,
   'Y': 11.26,
   'Ax_Bottom': 2.41,
   'Ay_Bottom': 3.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4654,
   'X': 13.6,
   'Y': 11.26,
   'Ax_Bottom': 2.61,
   'Ay_Bottom': 4.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4655,
   'X': 14.06,
   'Y': 11.26,
   'Ax_Bottom': 2.92,
   'Ay_Bottom': 4.05,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4656,
   'X': 14.51,
   'Y': 11.26,
   'Ax_Bottom': 3.24,
   'Ay_Bottom': 3.77,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4657,
   'X': 14.97,
   'Y': 11.26,
   'Ax_Bottom': 3.32,
   'Ay_Bottom': 3.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4658,
   'X': 15.43,
   'Y': 11.26,
   'Ax_Bottom': 3.15,
   'Ay_Bottom': 2.86,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4659,
   'X': 15.89,
   'Y': 11.26,
   'Ax_Bottom': 2.71,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4660,
   'X': 16.35,
   'Y': 11.26,
   'Ax_Bottom': 2.32,
   'Ay_Bottom': 1.9,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4661,
   'X': 16.8,
   'Y': 11.26,
   'Ax_Bottom': 0.91,
   'Ay_Bottom': 1.51,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4662,
   'X': 17.26,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4663,
   'X': 17.72,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.21,
   'Ax_Top': 1.83,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4664,
   'X': 18.18,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1,
   'Ax_Top': 2.76,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4665,
   'X': 18.63,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.81,
   'Ax_Top': 2.69,
   'Ay_Top': 0.88
 },
 {
   'Panel': 171,
   'Node': 4666,
   'X': 19.09,
   'Y': 11.26,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.32,
   'Ax_Top': 1.95,
   'Ay_Top': 1.35
 },
 {
   'Panel': 171,
   'Node': 4667,
   'X': 0.47,
   'Y': 10.83,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 2.72,
   'Ax_Top': 0.18,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4668,
   'X': 0.94,
   'Y': 10.83,
   'Ax_Bottom': 0.05,
   'Ay_Bottom': 2.8,
   'Ax_Top': 0.09,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4669,
   'X': 1.41,
   'Y': 10.83,
   'Ax_Bottom': 0.63,
   'Ay_Bottom': 2.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4670,
   'X': 1.88,
   'Y': 10.83,
   'Ax_Bottom': 1.02,
   'Ay_Bottom': 3.16,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4671,
   'X': 2.35,
   'Y': 10.83,
   'Ax_Bottom': 1.93,
   'Ay_Bottom': 3.32,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4672,
   'X': 2.82,
   'Y': 10.83,
   'Ax_Bottom': 2.83,
   'Ay_Bottom': 3.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4673,
   'X': 3.29,
   'Y': 10.83,
   'Ax_Bottom': 3.53,
   'Ay_Bottom': 3.18,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4674,
   'X': 3.76,
   'Y': 10.83,
   'Ax_Bottom': 3.5,
   'Ay_Bottom': 2.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4675,
   'X': 4.23,
   'Y': 10.83,
   'Ax_Bottom': 3.31,
   'Ay_Bottom': 2.42,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4676,
   'X': 4.7,
   'Y': 10.83,
   'Ax_Bottom': 2.99,
   'Ay_Bottom': 2.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4677,
   'X': 5.17,
   'Y': 10.83,
   'Ax_Bottom': 2.39,
   'Ay_Bottom': 1.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4678,
   'X': 5.64,
   'Y': 10.83,
   'Ax_Bottom': 1.12,
   'Ay_Bottom': 1.16,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4679,
   'X': 6.11,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.41,
   'Ax_Top': 0.88,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4680,
   'X': 6.58,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.4,
   'Ay_Top': 0.79
 },
 {
   'Panel': 171,
   'Node': 4681,
   'X': 10.39,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.32,
   'Ay_Top': 1.28
 },
 {
   'Panel': 171,
   'Node': 4682,
   'X': 10.85,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.49,
   'Ay_Top': 0.69
 },
 {
   'Panel': 171,
   'Node': 4683,
   'X': 11.31,
   'Y': 10.83,
   'Ax_Bottom': 0.57,
   'Ay_Bottom': 0.82,
   'Ax_Top': 0.52,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4684,
   'X': 11.77,
   'Y': 10.83,
   'Ax_Bottom': 1.42,
   'Ay_Bottom': 1.89,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4685,
   'X': 12.22,
   'Y': 10.83,
   'Ax_Bottom': 1.85,
   'Ay_Bottom': 2.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4686,
   'X': 12.68,
   'Y': 10.83,
   'Ax_Bottom': 2.15,
   'Ay_Bottom': 3.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4687,
   'X': 13.14,
   'Y': 10.83,
   'Ax_Bottom': 2.26,
   'Ay_Bottom': 3.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4688,
   'X': 13.6,
   'Y': 10.83,
   'Ax_Bottom': 2.41,
   'Ay_Bottom': 3.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4689,
   'X': 14.06,
   'Y': 10.83,
   'Ax_Bottom': 2.97,
   'Ay_Bottom': 3.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4690,
   'X': 14.51,
   'Y': 10.83,
   'Ax_Bottom': 3.44,
   'Ay_Bottom': 3.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4691,
   'X': 14.97,
   'Y': 10.83,
   'Ax_Bottom': 3.66,
   'Ay_Bottom': 3.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4692,
   'X': 15.43,
   'Y': 10.83,
   'Ax_Bottom': 3.55,
   'Ay_Bottom': 3.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4693,
   'X': 15.89,
   'Y': 10.83,
   'Ax_Bottom': 3.1,
   'Ay_Bottom': 2.73,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4694,
   'X': 16.35,
   'Y': 10.83,
   'Ax_Bottom': 2.26,
   'Ay_Bottom': 2.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4695,
   'X': 16.8,
   'Y': 10.83,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 2.01,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4696,
   'X': 17.26,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.86,
   'Ax_Top': 0.42,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4697,
   'X': 17.72,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.73,
   'Ax_Top': 1.3,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4698,
   'X': 18.18,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.43,
   'Ax_Top': 1.66,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4699,
   'X': 18.63,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.93,
   'Ax_Top': 1.61,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4700,
   'X': 19.09,
   'Y': 10.83,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.25,
   'Ax_Top': 1.3,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4701,
   'X': 0.47,
   'Y': 10.41,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 2.44,
   'Ax_Top': 0.42,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4702,
   'X': 0.94,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.43,
   'Ax_Top': 0.42,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4703,
   'X': 1.41,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.46,
   'Ax_Top': 0.2,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4704,
   'X': 1.88,
   'Y': 10.41,
   'Ax_Bottom': 0.77,
   'Ay_Bottom': 2.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4705,
   'X': 2.35,
   'Y': 10.41,
   'Ax_Bottom': 1.87,
   'Ay_Bottom': 3.04,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4706,
   'X': 2.82,
   'Y': 10.41,
   'Ax_Bottom': 2.94,
   'Ay_Bottom': 3.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4707,
   'X': 3.29,
   'Y': 10.41,
   'Ax_Bottom': 3.88,
   'Ay_Bottom': 3.06,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4708,
   'X': 3.76,
   'Y': 10.41,
   'Ax_Bottom': 3.86,
   'Ay_Bottom': 2.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4709,
   'X': 4.23,
   'Y': 10.41,
   'Ax_Bottom': 3.56,
   'Ay_Bottom': 2.46,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4710,
   'X': 4.7,
   'Y': 10.41,
   'Ax_Bottom': 3.01,
   'Ay_Bottom': 2.16,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4711,
   'X': 5.17,
   'Y': 10.41,
   'Ax_Bottom': 2.2,
   'Ay_Bottom': 1.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4712,
   'X': 5.64,
   'Y': 10.41,
   'Ax_Bottom': 1.12,
   'Ay_Bottom': 1.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4713,
   'X': 6.11,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.8,
   'Ax_Top': 1.13,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4714,
   'X': 6.58,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.3,
   'Ay_Top': 0.64
 },
 {
   'Panel': 171,
   'Node': 4715,
   'X': 10.39,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.75,
   'Ay_Top': 2.71
 },
 {
   'Panel': 171,
   'Node': 4716,
   'X': 10.85,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.44,
   'Ay_Top': 1.76
 },
 {
   'Panel': 171,
   'Node': 4717,
   'X': 11.31,
   'Y': 10.41,
   'Ax_Bottom': 1.5,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0.95,
   'Ay_Top': 0.78
 },
 {
   'Panel': 171,
   'Node': 4718,
   'X': 11.77,
   'Y': 10.41,
   'Ax_Bottom': 2.08,
   'Ay_Bottom': 2.27,
   'Ax_Top': 0.56,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4719,
   'X': 12.22,
   'Y': 10.41,
   'Ax_Bottom': 2.19,
   'Ay_Bottom': 3.04,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4720,
   'X': 12.68,
   'Y': 10.41,
   'Ax_Bottom': 2.1,
   'Ay_Bottom': 3.44,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4721,
   'X': 13.14,
   'Y': 10.41,
   'Ax_Bottom': 1.75,
   'Ay_Bottom': 3.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4722,
   'X': 13.6,
   'Y': 10.41,
   'Ax_Bottom': 1.99,
   'Ay_Bottom': 3.51,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4723,
   'X': 14.06,
   'Y': 10.41,
   'Ax_Bottom': 2.86,
   'Ay_Bottom': 3.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4724,
   'X': 14.51,
   'Y': 10.41,
   'Ax_Bottom': 3.56,
   'Ay_Bottom': 3.8,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4725,
   'X': 14.97,
   'Y': 10.41,
   'Ax_Bottom': 3.94,
   'Ay_Bottom': 3.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4726,
   'X': 15.43,
   'Y': 10.41,
   'Ax_Bottom': 3.91,
   'Ay_Bottom': 3.29,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4727,
   'X': 15.89,
   'Y': 10.41,
   'Ax_Bottom': 3.49,
   'Ay_Bottom': 2.92,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4728,
   'X': 16.35,
   'Y': 10.41,
   'Ax_Bottom': 2.51,
   'Ay_Bottom': 2.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4729,
   'X': 16.8,
   'Y': 10.41,
   'Ax_Bottom': 0.99,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4730,
   'X': 17.26,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2,
   'Ax_Top': 0.32,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4731,
   'X': 17.72,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.87,
   'Ax_Top': 1.15,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4732,
   'X': 18.18,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.58,
   'Ax_Top': 1.47,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4733,
   'X': 18.63,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.1,
   'Ax_Top': 1.33,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4734,
   'X': 19.09,
   'Y': 10.41,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.58,
   'Ax_Top': 1.09,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4735,
   'X': 0.47,
   'Y': 9.98,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 1.88,
   'Ax_Top': 0.97,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4736,
   'X': 0.93,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.68,
   'Ax_Top': 1.04,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4737,
   'X': 1.4,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.68,
   'Ax_Top': 0.82,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4738,
   'X': 1.86,
   'Y': 9.98,
   'Ax_Bottom': 0.35,
   'Ay_Bottom': 2.17,
   'Ax_Top': 0.36,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4739,
   'X': 2.33,
   'Y': 9.98,
   'Ax_Bottom': 1.68,
   'Ay_Bottom': 2.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4740,
   'X': 2.79,
   'Y': 9.98,
   'Ax_Bottom': 2.93,
   'Ay_Bottom': 2.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4741,
   'X': 3.26,
   'Y': 9.98,
   'Ax_Bottom': 4.02,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4742,
   'X': 3.72,
   'Y': 9.98,
   'Ax_Bottom': 3.99,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4743,
   'X': 4.19,
   'Y': 9.98,
   'Ax_Bottom': 3.66,
   'Ay_Bottom': 1.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4744,
   'X': 4.65,
   'Y': 9.98,
   'Ax_Bottom': 3.02,
   'Ay_Bottom': 1.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4745,
   'X': 5.12,
   'Y': 9.98,
   'Ax_Bottom': 2.11,
   'Ay_Bottom': 1.47,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4746,
   'X': 5.59,
   'Y': 9.98,
   'Ax_Bottom': 1.04,
   'Ay_Bottom': 1.4,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4747,
   'X': 6.05,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.12,
   'Ax_Top': 1.55,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4748,
   'X': 6.52,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.35,
   'Ax_Top': 3.4,
   'Ay_Top': 0.85
 },
 {
   'Panel': 171,
   'Node': 4749,
   'X': 10.24,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.02,
   'Ay_Top': 4.95
 },
 {
   'Panel': 171,
   'Node': 4750,
   'X': 10.71,
   'Y': 9.98,
   'Ax_Bottom': 1.07,
   'Ay_Bottom': 0,
   'Ax_Top': 2.19,
   'Ay_Top': 2.96
 },
 {
   'Panel': 171,
   'Node': 4751,
   'X': 11.17,
   'Y': 9.98,
   'Ax_Bottom': 2.23,
   'Ay_Bottom': 1.2,
   'Ax_Top': 1.61,
   'Ay_Top': 2.05
 },
 {
   'Panel': 171,
   'Node': 4752,
   'X': 11.64,
   'Y': 9.98,
   'Ax_Bottom': 2.66,
   'Ay_Bottom': 2.13,
   'Ax_Top': 1.53,
   'Ay_Top': 1.28
 },
 {
   'Panel': 171,
   'Node': 4753,
   'X': 12.1,
   'Y': 9.98,
   'Ax_Bottom': 2.44,
   'Ay_Bottom': 2.69,
   'Ax_Top': 1.53,
   'Ay_Top': 0.35
 },
 {
   'Panel': 171,
   'Node': 4754,
   'X': 12.57,
   'Y': 9.98,
   'Ax_Bottom': 1.8,
   'Ay_Bottom': 2.82,
   'Ax_Top': 0.63,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4755,
   'X': 13.03,
   'Y': 9.98,
   'Ax_Bottom': 1.1,
   'Ay_Bottom': 2.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4756,
   'X': 13.5,
   'Y': 9.98,
   'Ax_Bottom': 1.03,
   'Ay_Bottom': 2.37,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4757,
   'X': 13.96,
   'Y': 9.98,
   'Ax_Bottom': 2.28,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4758,
   'X': 14.43,
   'Y': 9.98,
   'Ax_Bottom': 3.34,
   'Ay_Bottom': 2.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4759,
   'X': 14.9,
   'Y': 9.98,
   'Ax_Bottom': 3.96,
   'Ay_Bottom': 2.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4760,
   'X': 15.36,
   'Y': 9.98,
   'Ax_Bottom': 4.08,
   'Ay_Bottom': 2.61,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4761,
   'X': 15.83,
   'Y': 9.98,
   'Ax_Bottom': 3.73,
   'Ay_Bottom': 2.3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4762,
   'X': 16.29,
   'Y': 9.98,
   'Ax_Bottom': 2.84,
   'Ay_Bottom': 1.92,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4763,
   'X': 16.76,
   'Y': 9.98,
   'Ax_Bottom': 1.33,
   'Ay_Bottom': 1.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4764,
   'X': 17.22,
   'Y': 9.98,
   'Ax_Bottom': 0.04,
   'Ay_Bottom': 1.78,
   'Ax_Top': 0.31,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4765,
   'X': 17.69,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.62,
   'Ax_Top': 1.28,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4766,
   'X': 18.15,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.45,
   'Ax_Top': 1.74,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4767,
   'X': 18.62,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.19,
   'Ax_Top': 1.79,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4768,
   'X': 19.08,
   'Y': 9.98,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.93,
   'Ax_Top': 1.48,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4769,
   'X': 0.47,
   'Y': 9.56,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 0.9,
   'Ax_Top': 1.94,
   'Ay_Top': 1.02
 },
 {
   'Panel': 171,
   'Node': 4770,
   'X': 0.93,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.66,
   'Ax_Top': 2.36,
   'Ay_Top': 0.36
 },
 {
   'Panel': 171,
   'Node': 4771,
   'X': 1.4,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.42,
   'Ax_Top': 1.76,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4772,
   'X': 1.86,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.02,
   'Ax_Top': 1.85,
   'Ay_Top': 0.3
 },
 {
   'Panel': 171,
   'Node': 4773,
   'X': 2.33,
   'Y': 9.56,
   'Ax_Bottom': 1.58,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0.64,
   'Ay_Top': 0.81
 },
 {
   'Panel': 171,
   'Node': 4774,
   'X': 2.79,
   'Y': 9.56,
   'Ax_Bottom': 3,
   'Ay_Bottom': 1.15,
   'Ax_Top': 0,
   'Ay_Top': 0.15
 },
 {
   'Panel': 171,
   'Node': 4775,
   'X': 3.26,
   'Y': 9.56,
   'Ax_Bottom': 4.1,
   'Ay_Bottom': 1.2,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4776,
   'X': 3.72,
   'Y': 9.56,
   'Ax_Bottom': 4.02,
   'Ay_Bottom': 1.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4777,
   'X': 4.19,
   'Y': 9.56,
   'Ax_Bottom': 3.63,
   'Ay_Bottom': 0.87,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4778,
   'X': 4.65,
   'Y': 9.56,
   'Ax_Bottom': 2.85,
   'Ay_Bottom': 0.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4779,
   'X': 5.12,
   'Y': 9.56,
   'Ax_Bottom': 1.73,
   'Ay_Bottom': 0.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4780,
   'X': 5.59,
   'Y': 9.56,
   'Ax_Bottom': 0.45,
   'Ay_Bottom': 0.78,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4781,
   'X': 6.05,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.82,
   'Ax_Top': 1.96,
   'Ay_Top': 0.04
 },
 {
   'Panel': 171,
   'Node': 4782,
   'X': 6.52,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.65,
   'Ax_Top': 3.99,
   'Ay_Top': 0.49
 },
 {
   'Panel': 171,
   'Node': 4783,
   'X': 6.98,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.56,
   'Ax_Top': 3.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4784,
   'X': 7.45,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.54,
   'Ay_Top': 0.44
 },
 {
   'Panel': 171,
   'Node': 4785,
   'X': 7.91,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.19,
   'Ay_Top': 0.65
 },
 {
   'Panel': 171,
   'Node': 4786,
   'X': 8.38,
   'Y': 9.56,
   'Ax_Bottom': 0.87,
   'Ay_Bottom': 0.37,
   'Ax_Top': 1.21,
   'Ay_Top': 1.31
 },
 {
   'Panel': 171,
   'Node': 4787,
   'X': 8.84,
   'Y': 9.56,
   'Ax_Bottom': 1.78,
   'Ay_Bottom': 0.62,
   'Ax_Top': 1.31,
   'Ay_Top': 1.98
 },
 {
   'Panel': 171,
   'Node': 4788,
   'X': 9.31,
   'Y': 9.56,
   'Ax_Bottom': 1.29,
   'Ay_Bottom': 0,
   'Ax_Top': 2.13,
   'Ay_Top': 3.08
 },
 {
   'Panel': 171,
   'Node': 4789,
   'X': 9.78,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.62,
   'Ax_Top': 2.51,
   'Ay_Top': 0.47
 },
 {
   'Panel': 171,
   'Node': 4790,
   'X': 10.24,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.72,
   'Ay_Top': 2.74
 },
 {
   'Panel': 171,
   'Node': 4791,
   'X': 10.71,
   'Y': 9.56,
   'Ax_Bottom': 1.74,
   'Ay_Bottom': 0.53,
   'Ax_Top': 2.34,
   'Ay_Top': 3.09
 },
 {
   'Panel': 171,
   'Node': 4792,
   'X': 11.17,
   'Y': 9.56,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 1.1,
   'Ax_Top': 1.88,
   'Ay_Top': 2.95
 },
 {
   'Panel': 171,
   'Node': 4793,
   'X': 11.64,
   'Y': 9.56,
   'Ax_Bottom': 2.93,
   'Ay_Bottom': 1.59,
   'Ax_Top': 2.12,
   'Ay_Top': 2.67
 },
 {
   'Panel': 171,
   'Node': 4794,
   'X': 12.1,
   'Y': 9.56,
   'Ax_Bottom': 2.3,
   'Ay_Bottom': 1.79,
   'Ax_Top': 2.63,
   'Ay_Top': 2.15
 },
 {
   'Panel': 171,
   'Node': 4795,
   'X': 12.57,
   'Y': 9.56,
   'Ax_Bottom': 1.1,
   'Ay_Bottom': 1.71,
   'Ax_Top': 2.82,
   'Ay_Top': 0.93
 },
 {
   'Panel': 171,
   'Node': 4796,
   'X': 13.03,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.19,
   'Ax_Top': 1.44,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4797,
   'X': 13.5,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.83,
   'Ax_Top': 0.7,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4798,
   'X': 13.96,
   'Y': 9.56,
   'Ax_Bottom': 1.77,
   'Ay_Bottom': 1.4,
   'Ax_Top': 0.48,
   'Ay_Top': 0.18
 },
 {
   'Panel': 171,
   'Node': 4799,
   'X': 14.43,
   'Y': 9.56,
   'Ax_Bottom': 3.18,
   'Ay_Bottom': 1.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4800,
   'X': 14.9,
   'Y': 9.56,
   'Ax_Bottom': 3.99,
   'Ay_Bottom': 1.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4801,
   'X': 15.36,
   'Y': 9.56,
   'Ax_Bottom': 4.19,
   'Ay_Bottom': 1.51,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4802,
   'X': 15.83,
   'Y': 9.56,
   'Ax_Bottom': 3.88,
   'Ay_Bottom': 1.27,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4803,
   'X': 16.29,
   'Y': 9.56,
   'Ax_Bottom': 3.02,
   'Ay_Bottom': 0.9,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4804,
   'X': 16.76,
   'Y': 9.56,
   'Ax_Bottom': 1.6,
   'Ay_Bottom': 0.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4805,
   'X': 17.22,
   'Y': 9.56,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 1.03,
   'Ax_Top': 0.73,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4806,
   'X': 17.69,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.95,
   'Ax_Top': 1.94,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4807,
   'X': 18.15,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.9,
   'Ax_Top': 2.73,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4808,
   'X': 18.62,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.02,
   'Ax_Top': 2.7,
   'Ay_Top': 0.34
 },
 {
   'Panel': 171,
   'Node': 4809,
   'X': 19.08,
   'Y': 9.56,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.98,
   'Ax_Top': 1.82,
   'Ay_Top': 0.74
 },
 {
   'Panel': 171,
   'Node': 4810,
   'X': 0.47,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.84,
   'Ay_Top': 2.51
 },
 {
   'Panel': 171,
   'Node': 4811,
   'X': 0.93,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.45,
   'Ay_Top': 3.46
 },
 {
   'Panel': 171,
   'Node': 4812,
   'X': 1.4,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.95,
   'Ay_Top': 0.46
 },
 {
   'Panel': 171,
   'Node': 4813,
   'X': 1.86,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.58,
   'Ay_Top': 3.18
 },
 {
   'Panel': 171,
   'Node': 4814,
   'X': 2.33,
   'Y': 9.13,
   'Ax_Bottom': 1.1,
   'Ay_Bottom': 0,
   'Ax_Top': 0.9,
   'Ay_Top': 2.92
 },
 {
   'Panel': 171,
   'Node': 4815,
   'X': 2.79,
   'Y': 9.13,
   'Ax_Bottom': 2.67,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.6
 },
 {
   'Panel': 171,
   'Node': 4816,
   'X': 3.26,
   'Y': 9.13,
   'Ax_Bottom': 3.73,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.9
 },
 {
   'Panel': 171,
   'Node': 4817,
   'X': 3.72,
   'Y': 9.13,
   'Ax_Bottom': 3.82,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.56
 },
 {
   'Panel': 171,
   'Node': 4818,
   'X': 4.19,
   'Y': 9.13,
   'Ax_Bottom': 3.42,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.38
 },
 {
   'Panel': 171,
   'Node': 4819,
   'X': 4.65,
   'Y': 9.13,
   'Ax_Bottom': 2.72,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.36
 },
 {
   'Panel': 171,
   'Node': 4820,
   'X': 5.12,
   'Y': 9.13,
   'Ax_Bottom': 1.56,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.42
 },
 {
   'Panel': 171,
   'Node': 4821,
   'X': 5.59,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.45,
   'Ay_Top': 0.5
 },
 {
   'Panel': 171,
   'Node': 4822,
   'X': 6.05,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.1,
   'Ax_Top': 2.36,
   'Ay_Top': 0.1
 },
 {
   'Panel': 171,
   'Node': 4823,
   'X': 6.52,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.3,
   'Ax_Top': 4.6,
   'Ay_Top': 0.52
 },
 {
   'Panel': 171,
   'Node': 4824,
   'X': 6.98,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.11,
   'Ax_Top': 3.8,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 4825,
   'X': 7.45,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.59,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 4826,
   'X': 7.91,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.15,
   'Ax_Top': 2,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4827,
   'X': 8.38,
   'Y': 9.13,
   'Ax_Bottom': 0.47,
   'Ay_Bottom': 0.28,
   'Ax_Top': 2.5,
   'Ay_Top': 2.15
 },
 {
   'Panel': 171,
   'Node': 4828,
   'X': 8.84,
   'Y': 9.13,
   'Ax_Bottom': 1.61,
   'Ay_Bottom': 0.35,
   'Ax_Top': 1.8,
   'Ay_Top': 2.58
 },
 {
   'Panel': 171,
   'Node': 4829,
   'X': 9.31,
   'Y': 9.13,
   'Ax_Bottom': 1.5,
   'Ay_Bottom': 0.44,
   'Ax_Top': 1.38,
   'Ay_Top': 2.05
 },
 {
   'Panel': 171,
   'Node': 4830,
   'X': 9.78,
   'Y': 9.13,
   'Ax_Bottom': 0.36,
   'Ay_Bottom': 0.1,
   'Ax_Top': 0.73,
   'Ay_Top': 0.87
 },
 {
   'Panel': 171,
   'Node': 4831,
   'X': 10.24,
   'Y': 9.13,
   'Ax_Bottom': 0.64,
   'Ay_Bottom': 0.45,
   'Ax_Top': 1.25,
   'Ay_Top': 1.25
 },
 {
   'Panel': 171,
   'Node': 4832,
   'X': 10.71,
   'Y': 9.13,
   'Ax_Bottom': 2.18,
   'Ay_Bottom': 0.89,
   'Ax_Top': 1.66,
   'Ay_Top': 2.53
 },
 {
   'Panel': 171,
   'Node': 4833,
   'X': 11.17,
   'Y': 9.13,
   'Ax_Bottom': 3.09,
   'Ay_Bottom': 1.07,
   'Ax_Top': 1.65,
   'Ay_Top': 3.09
 },
 {
   'Panel': 171,
   'Node': 4834,
   'X': 11.64,
   'Y': 9.13,
   'Ax_Bottom': 3.02,
   'Ay_Bottom': 0.85,
   'Ax_Top': 2.13,
   'Ay_Top': 3.62
 },
 {
   'Panel': 171,
   'Node': 4835,
   'X': 12.1,
   'Y': 9.13,
   'Ax_Bottom': 2.03,
   'Ay_Bottom': 0.53,
   'Ax_Top': 3.23,
   'Ay_Top': 3.94
 },
 {
   'Panel': 171,
   'Node': 4836,
   'X': 12.57,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.8,
   'Ay_Top': 3.89
 },
 {
   'Panel': 171,
   'Node': 4837,
   'X': 13.03,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.01,
   'Ay_Top': 0.31
 },
 {
   'Panel': 171,
   'Node': 4838,
   'X': 13.5,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.16,
   'Ay_Top': 2.2
 },
 {
   'Panel': 171,
   'Node': 4839,
   'X': 13.96,
   'Y': 9.13,
   'Ax_Bottom': 0.92,
   'Ay_Bottom': 0,
   'Ax_Top': 1.22,
   'Ay_Top': 2.34
 },
 {
   'Panel': 171,
   'Node': 4840,
   'X': 14.43,
   'Y': 9.13,
   'Ax_Bottom': 3,
   'Ay_Bottom': 0.1,
   'Ax_Top': 0,
   'Ay_Top': 1.8
 },
 {
   'Panel': 171,
   'Node': 4841,
   'X': 14.9,
   'Y': 9.13,
   'Ax_Bottom': 3.97,
   'Ay_Bottom': 0.37,
   'Ax_Top': 0,
   'Ay_Top': 1.02
 },
 {
   'Panel': 171,
   'Node': 4842,
   'X': 15.36,
   'Y': 9.13,
   'Ax_Bottom': 4.28,
   'Ay_Bottom': 0.43,
   'Ax_Top': 0,
   'Ay_Top': 0.61
 },
 {
   'Panel': 171,
   'Node': 4843,
   'X': 15.83,
   'Y': 9.13,
   'Ax_Bottom': 4.06,
   'Ay_Bottom': 0.21,
   'Ax_Top': 0,
   'Ay_Top': 0.46
 },
 {
   'Panel': 171,
   'Node': 4844,
   'X': 16.29,
   'Y': 9.13,
   'Ax_Bottom': 3.27,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.4
 },
 {
   'Panel': 171,
   'Node': 4845,
   'X': 16.76,
   'Y': 9.13,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.79
 },
 {
   'Panel': 171,
   'Node': 4846,
   'X': 17.22,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.12,
   'Ay_Top': 1.59
 },
 {
   'Panel': 171,
   'Node': 4847,
   'X': 17.69,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.65,
   'Ay_Top': 1.55
 },
 {
   'Panel': 171,
   'Node': 4848,
   'X': 18.15,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.93,
   'Ax_Top': 3.58,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4849,
   'X': 18.62,
   'Y': 9.13,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.2,
   'Ay_Top': 2.65
 },
 {
   'Panel': 171,
   'Node': 4850,
   'X': 19.08,
   'Y': 9.13,
   'Ax_Bottom': 0.07,
   'Ay_Bottom': 0,
   'Ax_Top': 1.26,
   'Ay_Top': 1.48
 },
 {
   'Panel': 171,
   'Node': 4851,
   'X': 6.68,
   'Y': 8.71,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.63,
   'Ay_Top': 2.61
 },
 {
   'Panel': 171,
   'Node': 4852,
   'X': 11.44,
   'Y': 8.71,
   'Ax_Bottom': 3.07,
   'Ay_Bottom': 0.53,
   'Ax_Top': 1.42,
   'Ay_Top': 3.42
 },
 {
   'Panel': 171,
   'Node': 4853,
   'X': 0.77,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.05,
   'Ay_Top': 6.38
 },
 {
   'Panel': 171,
   'Node': 4854,
   'X': 1.21,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.62,
   'Ay_Top': 3.8
 },
 {
   'Panel': 171,
   'Node': 4855,
   'X': 1.65,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.24,
   'Ay_Top': 4.77
 },
 {
   'Panel': 171,
   'Node': 4856,
   'X': 2.09,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.83,
   'Ay_Top': 4.48
 },
 {
   'Panel': 171,
   'Node': 4857,
   'X': 2.54,
   'Y': 7.85,
   'Ax_Bottom': 1.64,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 3.69
 },
 {
   'Panel': 171,
   'Node': 4858,
   'X': 2.98,
   'Y': 7.85,
   'Ax_Bottom': 3.07,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.45
 },
 {
   'Panel': 171,
   'Node': 4859,
   'X': 3.42,
   'Y': 7.85,
   'Ax_Bottom': 3.67,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.9
 },
 {
   'Panel': 171,
   'Node': 4860,
   'X': 3.86,
   'Y': 7.85,
   'Ax_Bottom': 3.85,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.58
 },
 {
   'Panel': 171,
   'Node': 4861,
   'X': 4.3,
   'Y': 7.85,
   'Ax_Bottom': 3.41,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.48
 },
 {
   'Panel': 171,
   'Node': 4862,
   'X': 5.63,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.85,
   'Ay_Top': 3.67
 },
 {
   'Panel': 171,
   'Node': 4863,
   'X': 6.07,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.53,
   'Ay_Top': 4.86
 },
 {
   'Panel': 171,
   'Node': 4864,
   'X': 7.3,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.46,
   'Ay_Top': 5.04
 },
 {
   'Panel': 171,
   'Node': 4865,
   'X': 7.76,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.04,
   'Ax_Top': 4.43,
   'Ay_Top': 3.17
 },
 {
   'Panel': 171,
   'Node': 4866,
   'X': 8.22,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.71,
   'Ay_Top': 2.64
 },
 {
   'Panel': 171,
   'Node': 4867,
   'X': 8.68,
   'Y': 7.85,
   'Ax_Bottom': 0.3,
   'Ay_Bottom': 0,
   'Ax_Top': 0.49,
   'Ay_Top': 1.66
 },
 {
   'Panel': 171,
   'Node': 4868,
   'X': 9.13,
   'Y': 7.85,
   'Ax_Bottom': 1.65,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.63
 },
 {
   'Panel': 171,
   'Node': 4869,
   'X': 9.59,
   'Y': 7.85,
   'Ax_Bottom': 2,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.33
 },
 {
   'Panel': 171,
   'Node': 4870,
   'X': 10.05,
   'Y': 7.85,
   'Ax_Bottom': 2.44,
   'Ay_Bottom': 0.01,
   'Ax_Top': 0,
   'Ay_Top': 0.31
 },
 {
   'Panel': 171,
   'Node': 4871,
   'X': 10.51,
   'Y': 7.85,
   'Ax_Bottom': 2.81,
   'Ay_Bottom': 0.16,
   'Ax_Top': 0,
   'Ay_Top': 0.52
 },
 {
   'Panel': 171,
   'Node': 4872,
   'X': 10.97,
   'Y': 7.85,
   'Ax_Bottom': 2.91,
   'Ay_Bottom': 0.22,
   'Ax_Top': 0,
   'Ay_Top': 1.08
 },
 {
   'Panel': 171,
   'Node': 4873,
   'X': 11.89,
   'Y': 7.85,
   'Ax_Bottom': 0.24,
   'Ay_Bottom': 0,
   'Ax_Top': 2.33,
   'Ay_Top': 4.31
 },
 {
   'Panel': 171,
   'Node': 4874,
   'X': 12.34,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.07,
   'Ay_Top': 4.61
 },
 {
   'Panel': 171,
   'Node': 4875,
   'X': 13.72,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.91,
   'Ay_Top': 5.1
 },
 {
   'Panel': 171,
   'Node': 4876,
   'X': 15.1,
   'Y': 7.85,
   'Ax_Bottom': 3.33,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.84
 },
 {
   'Panel': 171,
   'Node': 4877,
   'X': 15.56,
   'Y': 7.85,
   'Ax_Bottom': 3.85,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.8
 },
 {
   'Panel': 171,
   'Node': 4878,
   'X': 16.01,
   'Y': 7.85,
   'Ax_Bottom': 3.77,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.89
 },
 {
   'Panel': 171,
   'Node': 4879,
   'X': 16.47,
   'Y': 7.85,
   'Ax_Bottom': 3.12,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.24
 },
 {
   'Panel': 171,
   'Node': 4880,
   'X': 16.93,
   'Y': 7.85,
   'Ax_Bottom': 1.91,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.72
 },
 {
   'Panel': 171,
   'Node': 4881,
   'X': 17.39,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.53,
   'Ay_Top': 3.84
 },
 {
   'Panel': 171,
   'Node': 4882,
   'X': 17.85,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.02,
   'Ay_Top': 3.69
 },
 {
   'Panel': 171,
   'Node': 4883,
   'X': 18.31,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.86,
   'Ay_Top': 3.8
 },
 {
   'Panel': 171,
   'Node': 4884,
   'X': 18.77,
   'Y': 7.85,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.76,
   'Ay_Top': 6.25
 },
 {
   'Panel': 171,
   'Node': 4885,
   'X': 0.47,
   'Y': 7.43,
   'Ax_Bottom': 1.52,
   'Ay_Bottom': 0,
   'Ax_Top': 2.93,
   'Ay_Top': 5.19
 },
 {
   'Panel': 171,
   'Node': 4886,
   'X': 0.93,
   'Y': 7.43,
   'Ax_Bottom': 0.2,
   'Ay_Bottom': 0,
   'Ax_Top': 3.55,
   'Ay_Top': 3.77
 },
 {
   'Panel': 171,
   'Node': 4887,
   'X': 1.4,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.02,
   'Ay_Top': 2.12
 },
 {
   'Panel': 171,
   'Node': 4888,
   'X': 1.86,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.72,
   'Ay_Top': 1.85
 },
 {
   'Panel': 171,
   'Node': 4889,
   'X': 2.33,
   'Y': 7.43,
   'Ax_Bottom': 1.25,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.96
 },
 {
   'Panel': 171,
   'Node': 4890,
   'X': 2.79,
   'Y': 7.43,
   'Ax_Bottom': 2.85,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.31
 },
 {
   'Panel': 171,
   'Node': 4891,
   'X': 3.26,
   'Y': 7.43,
   'Ax_Bottom': 3.7,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1
 },
 {
   'Panel': 171,
   'Node': 4892,
   'X': 3.72,
   'Y': 7.43,
   'Ax_Bottom': 3.99,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.84
 },
 {
   'Panel': 171,
   'Node': 4893,
   'X': 4.19,
   'Y': 7.43,
   'Ax_Bottom': 3.9,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.79
 },
 {
   'Panel': 171,
   'Node': 4894,
   'X': 4.65,
   'Y': 7.43,
   'Ax_Bottom': 3.44,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.28
 },
 {
   'Panel': 171,
   'Node': 4895,
   'X': 5.12,
   'Y': 7.43,
   'Ax_Bottom': 1.75,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.93
 },
 {
   'Panel': 171,
   'Node': 4896,
   'X': 5.59,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.24,
   'Ay_Top': 3.73
 },
 {
   'Panel': 171,
   'Node': 4897,
   'X': 6.05,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.77,
   'Ay_Top': 6.27
 },
 {
   'Panel': 171,
   'Node': 4898,
   'X': 6.98,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.1,
   'Ay_Top': 6.53
 },
 {
   'Panel': 171,
   'Node': 4899,
   'X': 7.45,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.42,
   'Ay_Top': 4.4
 },
 {
   'Panel': 171,
   'Node': 4900,
   'X': 7.91,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.48,
   'Ay_Top': 2.54
 },
 {
   'Panel': 171,
   'Node': 4901,
   'X': 8.38,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.95,
   'Ay_Top': 1.14
 },
 {
   'Panel': 171,
   'Node': 4902,
   'X': 8.84,
   'Y': 7.43,
   'Ax_Bottom': 0.97,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.38
 },
 {
   'Panel': 171,
   'Node': 4903,
   'X': 9.31,
   'Y': 7.43,
   'Ax_Bottom': 1.99,
   'Ay_Bottom': 0.19,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4904,
   'X': 9.78,
   'Y': 7.43,
   'Ax_Bottom': 2.65,
   'Ay_Bottom': 0.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4905,
   'X': 10.24,
   'Y': 7.43,
   'Ax_Bottom': 2.88,
   'Ay_Bottom': 0.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4906,
   'X': 10.71,
   'Y': 7.43,
   'Ax_Bottom': 3.13,
   'Ay_Bottom': 0.59,
   'Ax_Top': 0,
   'Ay_Top': 0.03
 },
 {
   'Panel': 171,
   'Node': 4907,
   'X': 11.17,
   'Y': 7.43,
   'Ax_Bottom': 3.21,
   'Ay_Bottom': 0.28,
   'Ax_Top': 0,
   'Ay_Top': 0.61
 },
 {
   'Panel': 171,
   'Node': 4908,
   'X': 11.64,
   'Y': 7.43,
   'Ax_Bottom': 1.11,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.13
 },
 {
   'Panel': 171,
   'Node': 4909,
   'X': 12.1,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.2,
   'Ay_Top': 4.02
 },
 {
   'Panel': 171,
   'Node': 4910,
   'X': 12.57,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.44,
   'Ay_Top': 7.16
 },
 {
   'Panel': 171,
   'Node': 4911,
   'X': 13.5,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.62,
   'Ay_Top': 7.3
 },
 {
   'Panel': 171,
   'Node': 4912,
   'X': 13.96,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.43,
   'Ay_Top': 3.73
 },
 {
   'Panel': 171,
   'Node': 4913,
   'X': 14.43,
   'Y': 7.43,
   'Ax_Bottom': 1.64,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.54
 },
 {
   'Panel': 171,
   'Node': 4914,
   'X': 14.9,
   'Y': 7.43,
   'Ax_Bottom': 3.46,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 4915,
   'X': 15.36,
   'Y': 7.43,
   'Ax_Bottom': 3.84,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.07
 },
 {
   'Panel': 171,
   'Node': 4916,
   'X': 15.83,
   'Y': 7.43,
   'Ax_Bottom': 4.1,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1
 },
 {
   'Panel': 171,
   'Node': 4917,
   'X': 16.29,
   'Y': 7.43,
   'Ax_Bottom': 3.9,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.09
 },
 {
   'Panel': 171,
   'Node': 4918,
   'X': 16.76,
   'Y': 7.43,
   'Ax_Bottom': 3.03,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.43
 },
 {
   'Panel': 171,
   'Node': 4919,
   'X': 17.22,
   'Y': 7.43,
   'Ax_Bottom': 1.17,
   'Ay_Bottom': 0,
   'Ax_Top': 0.61,
   'Ay_Top': 2.06
 },
 {
   'Panel': 171,
   'Node': 4920,
   'X': 17.69,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.77,
   'Ay_Top': 1.45
 },
 {
   'Panel': 171,
   'Node': 4921,
   'X': 18.15,
   'Y': 7.43,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.11,
   'Ay_Top': 2.31
 },
 {
   'Panel': 171,
   'Node': 4922,
   'X': 18.62,
   'Y': 7.43,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 0,
   'Ax_Top': 3.38,
   'Ay_Top': 4.1
 },
 {
   'Panel': 171,
   'Node': 4923,
   'X': 19.08,
   'Y': 7.43,
   'Ax_Bottom': 1.65,
   'Ay_Bottom': 0,
   'Ax_Top': 2.74,
   'Ay_Top': 5.61
 },
 {
   'Panel': 171,
   'Node': 4924,
   'X': 0.47,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.81,
   'Ay_Top': 3.03
 },
 {
   'Panel': 171,
   'Node': 4925,
   'X': 0.93,
   'Y': 7,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 0.04,
   'Ax_Top': 1.86,
   'Ay_Top': 1.86
 },
 {
   'Panel': 171,
   'Node': 4926,
   'X': 1.4,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.16,
   'Ax_Top': 1.13,
   'Ay_Top': 0.49
 },
 {
   'Panel': 171,
   'Node': 4927,
   'X': 1.86,
   'Y': 7,
   'Ax_Bottom': 0.35,
   'Ay_Bottom': 0.47,
   'Ax_Top': 0.31,
   'Ay_Top': 0.17
 },
 {
   'Panel': 171,
   'Node': 4928,
   'X': 2.33,
   'Y': 7,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 0.75,
   'Ax_Top': 0,
   'Ay_Top': 0.32
 },
 {
   'Panel': 171,
   'Node': 4929,
   'X': 2.79,
   'Y': 7,
   'Ax_Bottom': 3.24,
   'Ay_Bottom': 0.8,
   'Ax_Top': 0,
   'Ay_Top': 0.11
 },
 {
   'Panel': 171,
   'Node': 4930,
   'X': 3.26,
   'Y': 7,
   'Ax_Bottom': 4,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4931,
   'X': 3.72,
   'Y': 7,
   'Ax_Bottom': 4.24,
   'Ay_Bottom': 0.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4932,
   'X': 4.19,
   'Y': 7,
   'Ax_Bottom': 4,
   'Ay_Bottom': 0.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4933,
   'X': 4.65,
   'Y': 7,
   'Ax_Bottom': 3.26,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.43
 },
 {
   'Panel': 171,
   'Node': 4934,
   'X': 5.12,
   'Y': 7,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.36
 },
 {
   'Panel': 171,
   'Node': 4935,
   'X': 5.59,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.58,
   'Ay_Top': 3.39
 },
 {
   'Panel': 171,
   'Node': 4936,
   'X': 6.05,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.01,
   'Ay_Top': 5.81
 },
 {
   'Panel': 171,
   'Node': 4937,
   'X': 6.98,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.76,
   'Ay_Top': 5.11
 },
 {
   'Panel': 171,
   'Node': 4938,
   'X': 7.45,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.12,
   'Ay_Top': 2.62
 },
 {
   'Panel': 171,
   'Node': 4939,
   'X': 7.91,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.14,
   'Ay_Top': 1.16
 },
 {
   'Panel': 171,
   'Node': 4940,
   'X': 8.38,
   'Y': 7,
   'Ax_Bottom': 0.39,
   'Ay_Bottom': 0.21,
   'Ax_Top': 0.07,
   'Ay_Top': 0.1
 },
 {
   'Panel': 171,
   'Node': 4941,
   'X': 8.84,
   'Y': 7,
   'Ax_Bottom': 1.37,
   'Ay_Bottom': 0.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4942,
   'X': 9.31,
   'Y': 7,
   'Ax_Bottom': 2.08,
   'Ay_Bottom': 0.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4943,
   'X': 9.78,
   'Y': 7,
   'Ax_Bottom': 3.08,
   'Ay_Bottom': 1.03,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4944,
   'X': 10.24,
   'Y': 7,
   'Ax_Bottom': 3.1,
   'Ay_Bottom': 1.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4945,
   'X': 10.71,
   'Y': 7,
   'Ax_Bottom': 3.12,
   'Ay_Bottom': 0.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4946,
   'X': 11.17,
   'Y': 7,
   'Ax_Bottom': 2.68,
   'Ay_Bottom': 0.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4947,
   'X': 11.64,
   'Y': 7,
   'Ax_Bottom': 1.14,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.81
 },
 {
   'Panel': 171,
   'Node': 4948,
   'X': 12.1,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.95,
   'Ay_Top': 2.28
 },
 {
   'Panel': 171,
   'Node': 4949,
   'X': 12.57,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.42,
   'Ay_Top': 4.84
 },
 {
   'Panel': 171,
   'Node': 4950,
   'X': 13.5,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.8,
   'Ay_Top': 5.73
 },
 {
   'Panel': 171,
   'Node': 4951,
   'X': 13.96,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.63,
   'Ay_Top': 3.37
 },
 {
   'Panel': 171,
   'Node': 4952,
   'X': 14.43,
   'Y': 7,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.56
 },
 {
   'Panel': 171,
   'Node': 4953,
   'X': 14.9,
   'Y': 7,
   'Ax_Bottom': 3.28,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.57
 },
 {
   'Panel': 171,
   'Node': 4954,
   'X': 15.36,
   'Y': 7,
   'Ax_Bottom': 3.86,
   'Ay_Bottom': 0.24,
   'Ax_Top': 0,
   'Ay_Top': 0.06
 },
 {
   'Panel': 171,
   'Node': 4955,
   'X': 15.83,
   'Y': 7,
   'Ax_Bottom': 4.15,
   'Ay_Bottom': 0.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4956,
   'X': 16.29,
   'Y': 7,
   'Ax_Bottom': 3.92,
   'Ay_Bottom': 0.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4957,
   'X': 16.76,
   'Y': 7,
   'Ax_Bottom': 3.13,
   'Ay_Bottom': 0.96,
   'Ax_Top': 0,
   'Ay_Top': 0.09
 },
 {
   'Panel': 171,
   'Node': 4958,
   'X': 17.22,
   'Y': 7,
   'Ax_Bottom': 1.78,
   'Ay_Bottom': 0.91,
   'Ax_Top': 0,
   'Ay_Top': 0.29
 },
 {
   'Panel': 171,
   'Node': 4959,
   'X': 17.69,
   'Y': 7,
   'Ax_Bottom': 0.16,
   'Ay_Bottom': 0.46,
   'Ax_Top': 0.39,
   'Ay_Top': 0.1
 },
 {
   'Panel': 171,
   'Node': 4960,
   'X': 18.15,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.33,
   'Ax_Top': 1.16,
   'Ay_Top': 0.66
 },
 {
   'Panel': 171,
   'Node': 4961,
   'X': 18.62,
   'Y': 7,
   'Ax_Bottom': 0.22,
   'Ay_Bottom': 0,
   'Ax_Top': 1.69,
   'Ay_Top': 2.1
 },
 {
   'Panel': 171,
   'Node': 4962,
   'X': 19.08,
   'Y': 7,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.59,
   'Ay_Top': 3.22
 },
 {
   'Panel': 171,
   'Node': 4963,
   'X': 0.47,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.46,
   'Ax_Top': 1.22,
   'Ay_Top': 0.57
 },
 {
   'Panel': 171,
   'Node': 4964,
   'X': 0.93,
   'Y': 6.58,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 0.96,
   'Ax_Top': 0.63,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4965,
   'X': 1.4,
   'Y': 6.58,
   'Ax_Bottom': 0.19,
   'Ay_Bottom': 1.16,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4966,
   'X': 1.86,
   'Y': 6.58,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 1.51,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4967,
   'X': 2.33,
   'Y': 6.58,
   'Ax_Bottom': 2.18,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4968,
   'X': 2.79,
   'Y': 6.58,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 1.9,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4969,
   'X': 3.26,
   'Y': 6.58,
   'Ax_Bottom': 4,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4970,
   'X': 3.72,
   'Y': 6.58,
   'Ax_Bottom': 4.16,
   'Ay_Bottom': 1.63,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4971,
   'X': 4.19,
   'Y': 6.58,
   'Ax_Bottom': 4.08,
   'Ay_Bottom': 1.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4972,
   'X': 4.65,
   'Y': 6.58,
   'Ax_Bottom': 3.44,
   'Ay_Bottom': 1.07,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4973,
   'X': 5.12,
   'Y': 6.58,
   'Ax_Bottom': 2.13,
   'Ay_Bottom': 0.73,
   'Ax_Top': 0,
   'Ay_Top': 0.47
 },
 {
   'Panel': 171,
   'Node': 4974,
   'X': 5.59,
   'Y': 6.58,
   'Ax_Bottom': 0.23,
   'Ay_Bottom': 0.3,
   'Ax_Top': 2.16,
   'Ay_Top': 1.89
 },
 {
   'Panel': 171,
   'Node': 4975,
   'X': 6.05,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.92,
   'Ay_Top': 2.8
 },
 {
   'Panel': 171,
   'Node': 4976,
   'X': 6.98,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.72,
   'Ay_Top': 2.61
 },
 {
   'Panel': 171,
   'Node': 4977,
   'X': 7.45,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.72,
   'Ay_Top': 1.37
 },
 {
   'Panel': 171,
   'Node': 4978,
   'X': 7.91,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.22,
   'Ax_Top': 1.07,
   'Ay_Top': 0.26
 },
 {
   'Panel': 171,
   'Node': 4979,
   'X': 8.38,
   'Y': 6.58,
   'Ax_Bottom': 0.53,
   'Ay_Bottom': 0.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4980,
   'X': 8.84,
   'Y': 6.58,
   'Ax_Bottom': 1.46,
   'Ay_Bottom': 1.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4981,
   'X': 9.31,
   'Y': 6.58,
   'Ax_Bottom': 2.3,
   'Ay_Bottom': 1.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4982,
   'X': 9.78,
   'Y': 6.58,
   'Ax_Bottom': 2.97,
   'Ay_Bottom': 1.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4983,
   'X': 10.24,
   'Y': 6.58,
   'Ax_Bottom': 3.49,
   'Ay_Bottom': 1.94,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4984,
   'X': 10.71,
   'Y': 6.58,
   'Ax_Bottom': 3.2,
   'Ay_Bottom': 1.8,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4985,
   'X': 11.17,
   'Y': 6.58,
   'Ax_Bottom': 2.85,
   'Ay_Bottom': 1.65,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4986,
   'X': 11.64,
   'Y': 6.58,
   'Ax_Bottom': 1.61,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4987,
   'X': 12.1,
   'Y': 6.58,
   'Ax_Bottom': 0.02,
   'Ay_Bottom': 0.61,
   'Ax_Top': 1.56,
   'Ay_Top': 1.21
 },
 {
   'Panel': 171,
   'Node': 4988,
   'X': 12.57,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.36,
   'Ay_Top': 2.72
 },
 {
   'Panel': 171,
   'Node': 4989,
   'X': 13.5,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 6.09,
   'Ay_Top': 3.07
 },
 {
   'Panel': 171,
   'Node': 4990,
   'X': 13.96,
   'Y': 6.58,
   'Ax_Bottom': 0.37,
   'Ay_Bottom': 0.68,
   'Ax_Top': 2.1,
   'Ay_Top': 1.89
 },
 {
   'Panel': 171,
   'Node': 4991,
   'X': 14.43,
   'Y': 6.58,
   'Ax_Bottom': 2.14,
   'Ay_Bottom': 1.05,
   'Ax_Top': 0,
   'Ay_Top': 0.46
 },
 {
   'Panel': 171,
   'Node': 4992,
   'X': 14.9,
   'Y': 6.58,
   'Ax_Bottom': 3.42,
   'Ay_Bottom': 1.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4993,
   'X': 15.36,
   'Y': 6.58,
   'Ax_Bottom': 3.59,
   'Ay_Bottom': 1.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4994,
   'X': 15.83,
   'Y': 6.58,
   'Ax_Bottom': 4.01,
   'Ay_Bottom': 1.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4995,
   'X': 16.29,
   'Y': 6.58,
   'Ax_Bottom': 3.87,
   'Ay_Bottom': 1.94,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4996,
   'X': 16.76,
   'Y': 6.58,
   'Ax_Bottom': 3.14,
   'Ay_Bottom': 2.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4997,
   'X': 17.22,
   'Y': 6.58,
   'Ax_Bottom': 2.05,
   'Ay_Bottom': 1.91,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4998,
   'X': 17.69,
   'Y': 6.58,
   'Ax_Bottom': 0.85,
   'Ay_Bottom': 1.55,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 4999,
   'X': 18.15,
   'Y': 6.58,
   'Ax_Bottom': 0.26,
   'Ay_Bottom': 1.15,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5000,
   'X': 18.62,
   'Y': 6.58,
   'Ax_Bottom': 0.17,
   'Ay_Bottom': 0.79,
   'Ax_Top': 0.54,
   'Ay_Top': 0.05
 },
 {
   'Panel': 171,
   'Node': 5001,
   'X': 19.08,
   'Y': 6.58,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.08,
   'Ax_Top': 1.11,
   'Ay_Top': 0.63
 },
 {
   'Panel': 171,
   'Node': 5002,
   'X': 0.47,
   'Y': 6.15,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 1.66,
   'Ax_Top': 0.27,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5003,
   'X': 0.93,
   'Y': 6.15,
   'Ax_Bottom': 0.27,
   'Ay_Bottom': 1.86,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5004,
   'X': 1.4,
   'Y': 6.15,
   'Ax_Bottom': 0.54,
   'Ay_Bottom': 2,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5005,
   'X': 1.86,
   'Y': 6.15,
   'Ax_Bottom': 1.41,
   'Ay_Bottom': 2.4,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5006,
   'X': 2.33,
   'Y': 6.15,
   'Ax_Bottom': 2.38,
   'Ay_Bottom': 2.66,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5007,
   'X': 2.79,
   'Y': 6.15,
   'Ax_Bottom': 3.27,
   'Ay_Bottom': 2.76,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5008,
   'X': 3.26,
   'Y': 6.15,
   'Ax_Bottom': 3.98,
   'Ay_Bottom': 2.77,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5009,
   'X': 3.72,
   'Y': 6.15,
   'Ax_Bottom': 4.02,
   'Ay_Bottom': 2.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5010,
   'X': 4.19,
   'Y': 6.15,
   'Ax_Bottom': 3.54,
   'Ay_Bottom': 2.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5011,
   'X': 4.65,
   'Y': 6.15,
   'Ax_Bottom': 3.32,
   'Ay_Bottom': 2.4,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5012,
   'X': 5.12,
   'Y': 6.15,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 2.29,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5013,
   'X': 5.59,
   'Y': 6.15,
   'Ax_Bottom': 0.32,
   'Ay_Bottom': 2.18,
   'Ax_Top': 2.02,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5014,
   'X': 6.05,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.31,
   'Ax_Top': 4.33,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5015,
   'X': 6.98,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.92,
   'Ax_Top': 4.57,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5016,
   'X': 7.45,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.13,
   'Ax_Top': 2.79,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5017,
   'X': 7.91,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.61,
   'Ax_Top': 1,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5018,
   'X': 8.38,
   'Y': 6.15,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 2,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5019,
   'X': 8.84,
   'Y': 6.15,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 2.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5020,
   'X': 9.31,
   'Y': 6.15,
   'Ax_Bottom': 2.46,
   'Ay_Bottom': 2.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5021,
   'X': 9.78,
   'Y': 6.15,
   'Ax_Bottom': 3.13,
   'Ay_Bottom': 2.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5022,
   'X': 10.24,
   'Y': 6.15,
   'Ax_Bottom': 3.24,
   'Ay_Bottom': 2.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5023,
   'X': 10.71,
   'Y': 6.15,
   'Ax_Bottom': 3.1,
   'Ay_Bottom': 2.76,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5024,
   'X': 11.17,
   'Y': 6.15,
   'Ax_Bottom': 2.88,
   'Ay_Bottom': 2.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5025,
   'X': 11.64,
   'Y': 6.15,
   'Ax_Bottom': 1.71,
   'Ay_Bottom': 2.69,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5026,
   'X': 12.1,
   'Y': 6.15,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 2.52,
   'Ax_Top': 1.36,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5027,
   'X': 12.57,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.79,
   'Ax_Top': 3.65,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5028,
   'X': 13.5,
   'Y': 6.15,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.9,
   'Ax_Top': 4.14,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5029,
   'X': 13.96,
   'Y': 6.15,
   'Ax_Bottom': 0.36,
   'Ay_Bottom': 2.63,
   'Ax_Top': 1.95,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5030,
   'X': 14.43,
   'Y': 6.15,
   'Ax_Bottom': 2.06,
   'Ay_Bottom': 2.65,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5031,
   'X': 14.9,
   'Y': 6.15,
   'Ax_Bottom': 3.26,
   'Ay_Bottom': 2.65,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5032,
   'X': 15.36,
   'Y': 6.15,
   'Ax_Bottom': 3.42,
   'Ay_Bottom': 2.43,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5033,
   'X': 15.83,
   'Y': 6.15,
   'Ax_Bottom': 3.84,
   'Ay_Bottom': 2.66,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5034,
   'X': 16.29,
   'Y': 6.15,
   'Ax_Bottom': 3.84,
   'Ay_Bottom': 2.89,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5035,
   'X': 16.76,
   'Y': 6.15,
   'Ax_Bottom': 3.17,
   'Ay_Bottom': 2.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5036,
   'X': 17.22,
   'Y': 6.15,
   'Ax_Bottom': 2.29,
   'Ay_Bottom': 2.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5037,
   'X': 17.69,
   'Y': 6.15,
   'Ax_Bottom': 1.38,
   'Ay_Bottom': 2.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5038,
   'X': 18.15,
   'Y': 6.15,
   'Ax_Bottom': 0.61,
   'Ay_Bottom': 1.98,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5039,
   'X': 18.62,
   'Y': 6.15,
   'Ax_Bottom': 0.2,
   'Ay_Bottom': 1.73,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5040,
   'X': 19.08,
   'Y': 6.15,
   'Ax_Bottom': 0.01,
   'Ay_Bottom': 1.49,
   'Ax_Top': 0.26,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5041,
   'X': 0.47,
   'Y': 5.72,
   'Ax_Bottom': 0.24,
   'Ay_Bottom': 2.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5042,
   'X': 0.93,
   'Y': 5.72,
   'Ax_Bottom': 0.48,
   'Ay_Bottom': 2.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5043,
   'X': 1.4,
   'Y': 5.72,
   'Ax_Bottom': 1.2,
   'Ay_Bottom': 2.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5044,
   'X': 1.86,
   'Y': 5.72,
   'Ax_Bottom': 1.7,
   'Ay_Bottom': 3.06,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5045,
   'X': 2.33,
   'Y': 5.72,
   'Ax_Bottom': 2.52,
   'Ay_Bottom': 3.24,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5046,
   'X': 2.79,
   'Y': 5.72,
   'Ax_Bottom': 3.27,
   'Ay_Bottom': 3.3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5047,
   'X': 3.26,
   'Y': 5.72,
   'Ax_Bottom': 3.84,
   'Ay_Bottom': 3.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5048,
   'X': 3.72,
   'Y': 5.72,
   'Ax_Bottom': 3.79,
   'Ay_Bottom': 3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5049,
   'X': 4.19,
   'Y': 5.72,
   'Ax_Bottom': 3.29,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5050,
   'X': 4.65,
   'Y': 5.72,
   'Ax_Bottom': 2.94,
   'Ay_Bottom': 3.1,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5051,
   'X': 5.12,
   'Y': 5.72,
   'Ax_Bottom': 1.9,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5052,
   'X': 5.59,
   'Y': 5.72,
   'Ax_Bottom': 0.31,
   'Ay_Bottom': 3.45,
   'Ax_Top': 0.93,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5053,
   'X': 6.05,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.87,
   'Ax_Top': 2.55,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5054,
   'X': 6.98,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.37,
   'Ax_Top': 3.16,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5055,
   'X': 7.45,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.36,
   'Ax_Top': 2.06,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5056,
   'X': 7.91,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.62,
   'Ax_Top': 0.83,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5057,
   'X': 8.38,
   'Y': 5.72,
   'Ax_Bottom': 0.85,
   'Ay_Bottom': 2.8,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5058,
   'X': 8.84,
   'Y': 5.72,
   'Ax_Bottom': 1.74,
   'Ay_Bottom': 2.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5059,
   'X': 9.31,
   'Y': 5.72,
   'Ax_Bottom': 2.51,
   'Ay_Bottom': 3.06,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5060,
   'X': 9.78,
   'Y': 5.72,
   'Ax_Bottom': 3.12,
   'Ay_Bottom': 3.14,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5061,
   'X': 10.24,
   'Y': 5.72,
   'Ax_Bottom': 3.16,
   'Ay_Bottom': 3.1,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5062,
   'X': 10.71,
   'Y': 5.72,
   'Ax_Bottom': 2.89,
   'Ay_Bottom': 3.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5063,
   'X': 11.17,
   'Y': 5.72,
   'Ax_Bottom': 2.54,
   'Ay_Bottom': 3.44,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5064,
   'X': 11.64,
   'Y': 5.72,
   'Ax_Bottom': 1.57,
   'Ay_Bottom': 3.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5065,
   'X': 12.1,
   'Y': 5.72,
   'Ax_Bottom': 0.1,
   'Ay_Bottom': 3.78,
   'Ax_Top': 0.76,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5066,
   'X': 12.57,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.35,
   'Ax_Top': 2.21,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5067,
   'X': 13.5,
   'Y': 5.72,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.43,
   'Ax_Top': 2.35,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5068,
   'X': 13.96,
   'Y': 5.72,
   'Ax_Bottom': 0.28,
   'Ay_Bottom': 3.91,
   'Ax_Top': 0.89,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5069,
   'X': 14.43,
   'Y': 5.72,
   'Ax_Bottom': 1.81,
   'Ay_Bottom': 3.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5070,
   'X': 14.9,
   'Y': 5.72,
   'Ax_Bottom': 2.78,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5071,
   'X': 15.36,
   'Y': 5.72,
   'Ax_Bottom': 3.12,
   'Ay_Bottom': 3.04,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5072,
   'X': 15.83,
   'Y': 5.72,
   'Ax_Bottom': 3.6,
   'Ay_Bottom': 3.15,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5073,
   'X': 16.29,
   'Y': 5.72,
   'Ax_Bottom': 3.69,
   'Ay_Bottom': 3.37,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5074,
   'X': 16.76,
   'Y': 5.72,
   'Ax_Bottom': 3.17,
   'Ay_Bottom': 3.43,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5075,
   'X': 17.22,
   'Y': 5.72,
   'Ax_Bottom': 2.46,
   'Ay_Bottom': 3.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5076,
   'X': 17.69,
   'Y': 5.72,
   'Ax_Bottom': 1.69,
   'Ay_Bottom': 3.14,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5077,
   'X': 18.15,
   'Y': 5.72,
   'Ax_Bottom': 0.96,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5078,
   'X': 18.62,
   'Y': 5.72,
   'Ax_Bottom': 0.38,
   'Ay_Bottom': 2.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5079,
   'X': 19.08,
   'Y': 5.72,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 2.31,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5080,
   'X': 0.47,
   'Y': 5.3,
   'Ax_Bottom': 0.32,
   'Ay_Bottom': 2.96,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5081,
   'X': 0.93,
   'Y': 5.3,
   'Ax_Bottom': 0.64,
   'Ay_Bottom': 3.07,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5082,
   'X': 1.4,
   'Y': 5.3,
   'Ax_Bottom': 1.49,
   'Ay_Bottom': 3.22,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5083,
   'X': 1.86,
   'Y': 5.3,
   'Ax_Bottom': 1.87,
   'Ay_Bottom': 3.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5084,
   'X': 2.33,
   'Y': 5.3,
   'Ax_Bottom': 2.58,
   'Ay_Bottom': 3.57,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5085,
   'X': 2.79,
   'Y': 5.3,
   'Ax_Bottom': 3.21,
   'Ay_Bottom': 3.59,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5086,
   'X': 3.26,
   'Y': 5.3,
   'Ax_Bottom': 3.69,
   'Ay_Bottom': 3.51,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5087,
   'X': 3.72,
   'Y': 5.3,
   'Ax_Bottom': 3.59,
   'Ay_Bottom': 3.3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5088,
   'X': 4.19,
   'Y': 5.3,
   'Ax_Bottom': 3.07,
   'Ay_Bottom': 3.19,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5089,
   'X': 4.65,
   'Y': 5.3,
   'Ax_Bottom': 2.47,
   'Ay_Bottom': 3.31,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5090,
   'X': 5.12,
   'Y': 5.3,
   'Ax_Bottom': 1.48,
   'Ay_Bottom': 3.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5091,
   'X': 5.59,
   'Y': 5.3,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 3.7,
   'Ax_Top': 0.62,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5092,
   'X': 6.05,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.38,
   'Ax_Top': 1.94,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5093,
   'X': 6.98,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.21,
   'Ax_Top': 2.52,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5094,
   'X': 7.45,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.1,
   'Ax_Top': 1.69,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5095,
   'X': 7.91,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.13,
   'Ax_Top': 0.64,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5096,
   'X': 8.38,
   'Y': 5.3,
   'Ax_Bottom': 0.78,
   'Ay_Bottom': 3.25,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5097,
   'X': 8.84,
   'Y': 5.3,
   'Ax_Bottom': 1.69,
   'Ay_Bottom': 3.3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5098,
   'X': 9.31,
   'Y': 5.3,
   'Ax_Bottom': 2.46,
   'Ay_Bottom': 3.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5099,
   'X': 9.78,
   'Y': 5.3,
   'Ax_Bottom': 3.05,
   'Ay_Bottom': 3.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5100,
   'X': 10.24,
   'Y': 5.3,
   'Ax_Bottom': 3.08,
   'Ay_Bottom': 3.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5101,
   'X': 10.71,
   'Y': 5.3,
   'Ax_Bottom': 2.66,
   'Ay_Bottom': 3.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5102,
   'X': 11.17,
   'Y': 5.3,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 3.5,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5103,
   'X': 11.64,
   'Y': 5.3,
   'Ax_Bottom': 1.16,
   'Ay_Bottom': 3.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5104,
   'X': 12.1,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.88,
   'Ax_Top': 0.52,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5105,
   'X': 12.57,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.81,
   'Ax_Top': 1.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5106,
   'X': 13.5,
   'Y': 5.3,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.87,
   'Ax_Top': 1.73,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5107,
   'X': 13.96,
   'Y': 5.3,
   'Ax_Bottom': 0.05,
   'Ay_Bottom': 4.09,
   'Ax_Top': 0.57,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5108,
   'X': 14.43,
   'Y': 5.3,
   'Ax_Bottom': 1.33,
   'Ay_Bottom': 3.87,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5109,
   'X': 14.9,
   'Y': 5.3,
   'Ax_Bottom': 2.26,
   'Ay_Bottom': 3.57,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5110,
   'X': 15.36,
   'Y': 5.3,
   'Ax_Bottom': 2.84,
   'Ay_Bottom': 3.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5111,
   'X': 15.83,
   'Y': 5.3,
   'Ax_Bottom': 3.39,
   'Ay_Bottom': 3.48,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5112,
   'X': 16.29,
   'Y': 5.3,
   'Ax_Bottom': 3.54,
   'Ay_Bottom': 3.68,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5113,
   'X': 16.76,
   'Y': 5.3,
   'Ax_Bottom': 3.11,
   'Ay_Bottom': 3.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5114,
   'X': 17.22,
   'Y': 5.3,
   'Ax_Bottom': 2.53,
   'Ay_Bottom': 3.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5115,
   'X': 17.69,
   'Y': 5.3,
   'Ax_Bottom': 1.87,
   'Ay_Bottom': 3.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5116,
   'X': 18.15,
   'Y': 5.3,
   'Ax_Bottom': 1.21,
   'Ay_Bottom': 3.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5117,
   'X': 18.62,
   'Y': 5.3,
   'Ax_Bottom': 0.81,
   'Ay_Bottom': 3.08,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5118,
   'X': 19.08,
   'Y': 5.3,
   'Ax_Bottom': 0.22,
   'Ay_Bottom': 2.9,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5119,
   'X': 0.47,
   'Y': 4.87,
   'Ax_Bottom': 0.78,
   'Ay_Bottom': 3.14,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5120,
   'X': 0.93,
   'Y': 4.87,
   'Ax_Bottom': 0.76,
   'Ay_Bottom': 3.27,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5121,
   'X': 1.4,
   'Y': 4.87,
   'Ax_Bottom': 1.47,
   'Ay_Bottom': 3.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5122,
   'X': 1.86,
   'Y': 4.87,
   'Ax_Bottom': 1.94,
   'Ay_Bottom': 3.57,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5123,
   'X': 2.33,
   'Y': 4.87,
   'Ax_Bottom': 2.56,
   'Ay_Bottom': 3.66,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5124,
   'X': 2.79,
   'Y': 4.87,
   'Ax_Bottom': 3.11,
   'Ay_Bottom': 3.67,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5125,
   'X': 3.26,
   'Y': 4.87,
   'Ax_Bottom': 3.52,
   'Ay_Bottom': 3.59,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5126,
   'X': 3.72,
   'Y': 4.87,
   'Ax_Bottom': 3.4,
   'Ay_Bottom': 3.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5127,
   'X': 4.19,
   'Y': 4.87,
   'Ax_Bottom': 2.89,
   'Ay_Bottom': 3.31,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5128,
   'X': 4.65,
   'Y': 4.87,
   'Ax_Bottom': 2.15,
   'Ay_Bottom': 3.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5129,
   'X': 5.12,
   'Y': 4.87,
   'Ax_Bottom': 1.1,
   'Ay_Bottom': 3.44,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5130,
   'X': 5.59,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.5,
   'Ax_Top': 0.5,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5131,
   'X': 6.05,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.54,
   'Ax_Top': 1.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5132,
   'X': 6.98,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.51,
   'Ax_Top': 2.2,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5133,
   'X': 7.45,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.36,
   'Ax_Top': 1.47,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5134,
   'X': 7.91,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.27,
   'Ax_Top': 0.52,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5135,
   'X': 8.38,
   'Y': 4.87,
   'Ax_Bottom': 0.65,
   'Ay_Bottom': 3.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5136,
   'X': 8.84,
   'Y': 4.87,
   'Ax_Bottom': 1.59,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5137,
   'X': 9.31,
   'Y': 4.87,
   'Ax_Bottom': 2.36,
   'Ay_Bottom': 3.42,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5138,
   'X': 9.78,
   'Y': 4.87,
   'Ax_Bottom': 2.94,
   'Ay_Bottom': 3.45,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5139,
   'X': 10.24,
   'Y': 4.87,
   'Ax_Bottom': 3.05,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5140,
   'X': 10.71,
   'Y': 4.87,
   'Ax_Bottom': 2.45,
   'Ay_Bottom': 3.32,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5141,
   'X': 11.17,
   'Y': 4.87,
   'Ax_Bottom': 1.75,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5142,
   'X': 11.64,
   'Y': 4.87,
   'Ax_Bottom': 0.76,
   'Ay_Bottom': 3.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5143,
   'X': 12.1,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.66,
   'Ax_Top': 0.43,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5144,
   'X': 12.57,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.89,
   'Ax_Top': 1.42,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5145,
   'X': 13.5,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.92,
   'Ax_Top': 1.46,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5146,
   'X': 13.96,
   'Y': 4.87,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.78,
   'Ax_Top': 0.48,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5147,
   'X': 14.43,
   'Y': 4.87,
   'Ax_Bottom': 0.9,
   'Ay_Bottom': 3.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5148,
   'X': 14.9,
   'Y': 4.87,
   'Ax_Bottom': 1.89,
   'Ay_Bottom': 3.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5149,
   'X': 15.36,
   'Y': 4.87,
   'Ax_Bottom': 2.58,
   'Ay_Bottom': 3.49,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5150,
   'X': 15.83,
   'Y': 4.87,
   'Ax_Bottom': 3.21,
   'Ay_Bottom': 3.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5151,
   'X': 16.29,
   'Y': 4.87,
   'Ax_Bottom': 3.38,
   'Ay_Bottom': 3.77,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5152,
   'X': 16.76,
   'Y': 4.87,
   'Ax_Bottom': 3.02,
   'Ay_Bottom': 3.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5153,
   'X': 17.22,
   'Y': 4.87,
   'Ax_Bottom': 2.52,
   'Ay_Bottom': 3.81,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5154,
   'X': 17.69,
   'Y': 4.87,
   'Ax_Bottom': 1.95,
   'Ay_Bottom': 3.7,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5155,
   'X': 18.15,
   'Y': 4.87,
   'Ax_Bottom': 1.35,
   'Ay_Bottom': 3.53,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5156,
   'X': 18.62,
   'Y': 4.87,
   'Ax_Bottom': 0.88,
   'Ay_Bottom': 3.32,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5157,
   'X': 19.08,
   'Y': 4.87,
   'Ax_Bottom': 0.33,
   'Ay_Bottom': 3.19,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5158,
   'X': 0.47,
   'Y': 4.45,
   'Ax_Bottom': 0.6,
   'Ay_Bottom': 3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5159,
   'X': 0.93,
   'Y': 4.45,
   'Ax_Bottom': 0.81,
   'Ay_Bottom': 3.13,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5160,
   'X': 1.4,
   'Y': 4.45,
   'Ax_Bottom': 1.45,
   'Ay_Bottom': 3.26,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5161,
   'X': 1.86,
   'Y': 4.45,
   'Ax_Bottom': 1.95,
   'Ay_Bottom': 3.44,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5162,
   'X': 2.33,
   'Y': 4.45,
   'Ax_Bottom': 2.5,
   'Ay_Bottom': 3.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5163,
   'X': 2.79,
   'Y': 4.45,
   'Ax_Bottom': 2.97,
   'Ay_Bottom': 3.55,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5164,
   'X': 3.26,
   'Y': 4.45,
   'Ax_Bottom': 3.33,
   'Ay_Bottom': 3.47,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5165,
   'X': 3.72,
   'Y': 4.45,
   'Ax_Bottom': 3.39,
   'Ay_Bottom': 3.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5166,
   'X': 4.19,
   'Y': 4.45,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 3.21,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5167,
   'X': 4.65,
   'Y': 4.45,
   'Ax_Bottom': 1.95,
   'Ay_Bottom': 3.08,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5168,
   'X': 5.12,
   'Y': 4.45,
   'Ax_Bottom': 1.21,
   'Ay_Bottom': 3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5169,
   'X': 5.59,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.1,
   'Ax_Top': 0.49,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5170,
   'X': 6.05,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.28,
   'Ax_Top': 1.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5171,
   'X': 6.98,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.31,
   'Ax_Top': 2.17,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5172,
   'X': 7.45,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.18,
   'Ax_Top': 1.38,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5173,
   'X': 7.91,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.09,
   'Ax_Top': 0.42,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5174,
   'X': 8.38,
   'Y': 4.45,
   'Ax_Bottom': 0.54,
   'Ay_Bottom': 3.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5175,
   'X': 8.84,
   'Y': 4.45,
   'Ax_Bottom': 1.48,
   'Ay_Bottom': 3.19,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5176,
   'X': 9.31,
   'Y': 4.45,
   'Ax_Bottom': 2.23,
   'Ay_Bottom': 3.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5177,
   'X': 9.78,
   'Y': 4.45,
   'Ax_Bottom': 2.8,
   'Ay_Bottom': 3.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5178,
   'X': 10.24,
   'Y': 4.45,
   'Ax_Bottom': 2.88,
   'Ay_Bottom': 3.24,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5179,
   'X': 10.71,
   'Y': 4.45,
   'Ax_Bottom': 2.38,
   'Ay_Bottom': 3.13,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5180,
   'X': 11.17,
   'Y': 4.45,
   'Ax_Bottom': 1.94,
   'Ay_Bottom': 3.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5181,
   'X': 11.64,
   'Y': 4.45,
   'Ax_Bottom': 0.7,
   'Ay_Bottom': 3.22,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5182,
   'X': 12.1,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.35,
   'Ax_Top': 0.47,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5183,
   'X': 12.57,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.55,
   'Ax_Top': 1.49,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5184,
   'X': 13.5,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.56,
   'Ax_Top': 1.51,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5185,
   'X': 13.96,
   'Y': 4.45,
   'Ax_Bottom': 0,
   'Ay_Bottom': 3.36,
   'Ax_Top': 0.5,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5186,
   'X': 14.43,
   'Y': 4.45,
   'Ax_Bottom': 0.56,
   'Ay_Bottom': 3.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5187,
   'X': 14.9,
   'Y': 4.45,
   'Ax_Bottom': 1.79,
   'Ay_Bottom': 3.21,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5188,
   'X': 15.36,
   'Y': 4.45,
   'Ax_Bottom': 2.44,
   'Ay_Bottom': 3.31,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5189,
   'X': 15.83,
   'Y': 4.45,
   'Ax_Bottom': 3.04,
   'Ay_Bottom': 3.47,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5190,
   'X': 16.29,
   'Y': 4.45,
   'Ax_Bottom': 3.2,
   'Ay_Bottom': 3.65,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5191,
   'X': 16.76,
   'Y': 4.45,
   'Ax_Bottom': 2.89,
   'Ay_Bottom': 3.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5192,
   'X': 17.22,
   'Y': 4.45,
   'Ax_Bottom': 2.48,
   'Ay_Bottom': 3.69,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5193,
   'X': 17.69,
   'Y': 4.45,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 3.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5194,
   'X': 18.15,
   'Y': 4.45,
   'Ax_Bottom': 1.41,
   'Ay_Bottom': 3.42,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5195,
   'X': 18.62,
   'Y': 4.45,
   'Ax_Bottom': 0.99,
   'Ay_Bottom': 3.21,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5196,
   'X': 19.08,
   'Y': 4.45,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 3.1,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5197,
   'X': 0.47,
   'Y': 4.02,
   'Ax_Bottom': 0.3,
   'Ay_Bottom': 2.48,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5198,
   'X': 0.93,
   'Y': 4.02,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 2.67,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5199,
   'X': 1.4,
   'Y': 4.02,
   'Ax_Bottom': 1.75,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5200,
   'X': 1.86,
   'Y': 4.02,
   'Ax_Bottom': 1.95,
   'Ay_Bottom': 3.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5201,
   'X': 2.33,
   'Y': 4.02,
   'Ax_Bottom': 2.41,
   'Ay_Bottom': 3.24,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5202,
   'X': 2.79,
   'Y': 4.02,
   'Ax_Bottom': 2.8,
   'Ay_Bottom': 3.25,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5203,
   'X': 3.26,
   'Y': 4.02,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 3.29,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5204,
   'X': 3.72,
   'Y': 4.02,
   'Ax_Bottom': 3.34,
   'Ay_Bottom': 3.21,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5205,
   'X': 4.19,
   'Y': 4.02,
   'Ax_Bottom': 2.81,
   'Ay_Bottom': 2.94,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5206,
   'X': 4.65,
   'Y': 4.02,
   'Ax_Bottom': 2.22,
   'Ay_Bottom': 2.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5207,
   'X': 5.12,
   'Y': 4.02,
   'Ax_Bottom': 0.83,
   'Ay_Bottom': 2.54,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5208,
   'X': 5.59,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.54,
   'Ax_Top': 0.58,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5209,
   'X': 6.05,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.58,
   'Ax_Top': 1.98,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5210,
   'X': 6.98,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.64,
   'Ax_Top': 2.44,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5211,
   'X': 7.45,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.61,
   'Ax_Top': 1.41,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5212,
   'X': 7.91,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.61,
   'Ax_Top': 0.36,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5213,
   'X': 8.38,
   'Y': 4.02,
   'Ax_Bottom': 0.62,
   'Ay_Bottom': 2.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5214,
   'X': 8.84,
   'Y': 4.02,
   'Ax_Bottom': 1.66,
   'Ay_Bottom': 2.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5215,
   'X': 9.31,
   'Y': 4.02,
   'Ax_Bottom': 2.38,
   'Ay_Bottom': 2.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5216,
   'X': 9.78,
   'Y': 4.02,
   'Ax_Bottom': 2.74,
   'Ay_Bottom': 2.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5217,
   'X': 10.24,
   'Y': 4.02,
   'Ax_Bottom': 2.78,
   'Ay_Bottom': 2.92,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5218,
   'X': 10.71,
   'Y': 4.02,
   'Ax_Bottom': 2.34,
   'Ay_Bottom': 2.74,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5219,
   'X': 11.17,
   'Y': 4.02,
   'Ax_Bottom': 1.76,
   'Ay_Bottom': 2.69,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5220,
   'X': 11.64,
   'Y': 4.02,
   'Ax_Bottom': 0.93,
   'Ay_Bottom': 2.78,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5221,
   'X': 12.1,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.86,
   'Ax_Top': 0.63,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5222,
   'X': 12.57,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.79,
   'Ax_Top': 1.91,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5223,
   'X': 13.5,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.73,
   'Ax_Top': 1.88,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5224,
   'X': 13.96,
   'Y': 4.02,
   'Ax_Bottom': 0,
   'Ay_Bottom': 2.69,
   'Ax_Top': 0.62,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5225,
   'X': 14.43,
   'Y': 4.02,
   'Ax_Bottom': 0.65,
   'Ay_Bottom': 2.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5226,
   'X': 14.9,
   'Y': 4.02,
   'Ax_Bottom': 1.55,
   'Ay_Bottom': 2.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5227,
   'X': 15.36,
   'Y': 4.02,
   'Ax_Bottom': 2.36,
   'Ay_Bottom': 2.98,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5228,
   'X': 15.83,
   'Y': 4.02,
   'Ax_Bottom': 2.96,
   'Ay_Bottom': 3.17,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5229,
   'X': 16.29,
   'Y': 4.02,
   'Ax_Bottom': 3.18,
   'Ay_Bottom': 3.3,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5230,
   'X': 16.76,
   'Y': 4.02,
   'Ax_Bottom': 2.72,
   'Ay_Bottom': 3.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5231,
   'X': 17.22,
   'Y': 4.02,
   'Ax_Bottom': 2.4,
   'Ay_Bottom': 3.38,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5232,
   'X': 17.69,
   'Y': 4.02,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 3.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5233,
   'X': 18.15,
   'Y': 4.02,
   'Ax_Bottom': 1.43,
   'Ay_Bottom': 3.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5234,
   'X': 18.62,
   'Y': 4.02,
   'Ax_Bottom': 0.87,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5235,
   'X': 19.08,
   'Y': 4.02,
   'Ax_Bottom': 0.67,
   'Ay_Bottom': 2.63,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5236,
   'X': 0.47,
   'Y': 3.6,
   'Ax_Bottom': 0.28,
   'Ay_Bottom': 1.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5237,
   'X': 0.93,
   'Y': 3.6,
   'Ax_Bottom': 0.78,
   'Ay_Bottom': 1.88,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5238,
   'X': 1.4,
   'Y': 3.6,
   'Ax_Bottom': 1.43,
   'Ay_Bottom': 2.23,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5239,
   'X': 1.86,
   'Y': 3.6,
   'Ax_Bottom': 1.98,
   'Ay_Bottom': 2.59,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5240,
   'X': 2.33,
   'Y': 3.6,
   'Ax_Bottom': 2.32,
   'Ay_Bottom': 2.82,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5241,
   'X': 2.79,
   'Y': 3.6,
   'Ax_Bottom': 2.53,
   'Ay_Bottom': 2.85,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5242,
   'X': 3.26,
   'Y': 3.6,
   'Ax_Bottom': 3.13,
   'Ay_Bottom': 3.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5243,
   'X': 3.72,
   'Y': 3.6,
   'Ax_Bottom': 3.37,
   'Ay_Bottom': 2.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5244,
   'X': 4.19,
   'Y': 3.6,
   'Ax_Bottom': 2.97,
   'Ay_Bottom': 2.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5245,
   'X': 4.65,
   'Y': 3.6,
   'Ax_Bottom': 2.1,
   'Ay_Bottom': 2.03,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5246,
   'X': 5.12,
   'Y': 3.6,
   'Ax_Bottom': 1.06,
   'Ay_Bottom': 1.73,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5247,
   'X': 5.59,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.69,
   'Ax_Top': 0.84,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5248,
   'X': 6.05,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.56,
   'Ax_Top': 2.5,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5249,
   'X': 6.98,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.55,
   'Ax_Top': 2.84,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5250,
   'X': 7.45,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.59,
   'Ax_Top': 1.57,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5251,
   'X': 7.91,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.79,
   'Ax_Top': 0.27,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5252,
   'X': 8.38,
   'Y': 3.6,
   'Ax_Bottom': 0.6,
   'Ay_Bottom': 1.94,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5253,
   'X': 8.84,
   'Y': 3.6,
   'Ax_Bottom': 1.4,
   'Ay_Bottom': 2.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5254,
   'X': 9.31,
   'Y': 3.6,
   'Ax_Bottom': 1.93,
   'Ay_Bottom': 2.55,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5255,
   'X': 9.78,
   'Y': 3.6,
   'Ax_Bottom': 2.75,
   'Ay_Bottom': 2.59,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5256,
   'X': 10.24,
   'Y': 3.6,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 2.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5257,
   'X': 10.71,
   'Y': 3.6,
   'Ax_Bottom': 2.42,
   'Ay_Bottom': 2.25,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5258,
   'X': 11.17,
   'Y': 3.6,
   'Ax_Bottom': 1.83,
   'Ay_Bottom': 1.93,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5259,
   'X': 11.64,
   'Y': 3.6,
   'Ax_Bottom': 1.14,
   'Ay_Bottom': 1.92,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5260,
   'X': 12.1,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.98,
   'Ax_Top': 1.12,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5261,
   'X': 12.57,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.67,
   'Ax_Top': 2.67,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5262,
   'X': 13.5,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.56,
   'Ax_Top': 2.44,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5263,
   'X': 13.96,
   'Y': 3.6,
   'Ax_Bottom': 0,
   'Ay_Bottom': 1.67,
   'Ax_Top': 0.94,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5264,
   'X': 14.43,
   'Y': 3.6,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 1.79,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5265,
   'X': 14.9,
   'Y': 3.6,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 2.01,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5266,
   'X': 15.36,
   'Y': 3.6,
   'Ax_Bottom': 2.45,
   'Ay_Bottom': 2.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5267,
   'X': 15.83,
   'Y': 3.6,
   'Ax_Bottom': 2.84,
   'Ay_Bottom': 2.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5268,
   'X': 16.29,
   'Y': 3.6,
   'Ax_Bottom': 2.66,
   'Ay_Bottom': 2.86,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5269,
   'X': 16.76,
   'Y': 3.6,
   'Ax_Bottom': 2.48,
   'Ay_Bottom': 2.96,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5270,
   'X': 17.22,
   'Y': 3.6,
   'Ax_Bottom': 2.31,
   'Ay_Bottom': 2.91,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5271,
   'X': 17.69,
   'Y': 3.6,
   'Ax_Bottom': 2,
   'Ay_Bottom': 2.69,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5272,
   'X': 18.15,
   'Y': 3.6,
   'Ax_Bottom': 1.48,
   'Ay_Bottom': 2.37,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5273,
   'X': 18.62,
   'Y': 3.6,
   'Ax_Bottom': 0.81,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5274,
   'X': 19.08,
   'Y': 3.6,
   'Ax_Bottom': 0.37,
   'Ay_Bottom': 1.98,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5275,
   'X': 0.47,
   'Y': 3.17,
   'Ax_Bottom': 0.02,
   'Ay_Bottom': 0.59,
   'Ax_Top': 0.46,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5276,
   'X': 0.93,
   'Y': 3.17,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 0.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5277,
   'X': 1.4,
   'Y': 3.17,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 1.49,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5278,
   'X': 1.86,
   'Y': 3.17,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 2.01,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5279,
   'X': 2.33,
   'Y': 3.17,
   'Ax_Bottom': 2.22,
   'Ay_Bottom': 2.33,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5280,
   'X': 2.79,
   'Y': 3.17,
   'Ax_Bottom': 2.19,
   'Ay_Bottom': 2.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5281,
   'X': 3.26,
   'Y': 3.17,
   'Ax_Bottom': 2.87,
   'Ay_Bottom': 2.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5282,
   'X': 3.72,
   'Y': 3.17,
   'Ax_Bottom': 3.4,
   'Ay_Bottom': 2.65,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5283,
   'X': 4.19,
   'Y': 3.17,
   'Ax_Bottom': 3.29,
   'Ay_Bottom': 2.22,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5284,
   'X': 4.65,
   'Y': 3.17,
   'Ax_Bottom': 2.55,
   'Ay_Bottom': 1.52,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5285,
   'X': 5.12,
   'Y': 3.17,
   'Ax_Bottom': 1.47,
   'Ay_Bottom': 0.56,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5286,
   'X': 5.59,
   'Y': 3.17,
   'Ax_Bottom': 0.01,
   'Ay_Bottom': 0.37,
   'Ax_Top': 1.11,
   'Ay_Top': 0.81
 },
 {
   'Panel': 171,
   'Node': 5287,
   'X': 6.05,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.7,
   'Ay_Top': 1.07
 },
 {
   'Panel': 171,
   'Node': 5288,
   'X': 6.98,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.93,
   'Ay_Top': 0.99
 },
 {
   'Panel': 171,
   'Node': 5289,
   'X': 7.45,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.75,
   'Ay_Top': 0.64
 },
 {
   'Panel': 171,
   'Node': 5290,
   'X': 7.91,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.56,
   'Ax_Top': 0.08,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5291,
   'X': 8.38,
   'Y': 3.17,
   'Ax_Bottom': 0.87,
   'Ay_Bottom': 1.28,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5292,
   'X': 8.84,
   'Y': 3.17,
   'Ax_Bottom': 1.45,
   'Ay_Bottom': 1.84,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5293,
   'X': 9.31,
   'Y': 3.17,
   'Ax_Bottom': 1.74,
   'Ay_Bottom': 2.07,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5294,
   'X': 9.78,
   'Y': 3.17,
   'Ax_Bottom': 2.26,
   'Ay_Bottom': 2.2,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5295,
   'X': 10.24,
   'Y': 3.17,
   'Ax_Bottom': 2.79,
   'Ay_Bottom': 2.24,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5296,
   'X': 10.71,
   'Y': 3.17,
   'Ax_Bottom': 2.67,
   'Ay_Bottom': 1.87,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5297,
   'X': 11.17,
   'Y': 3.17,
   'Ax_Bottom': 2.02,
   'Ay_Bottom': 1.18,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5298,
   'X': 11.64,
   'Y': 3.17,
   'Ax_Bottom': 1.26,
   'Ay_Bottom': 0.71,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5299,
   'X': 12.1,
   'Y': 3.17,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 0.46,
   'Ax_Top': 1.34,
   'Ay_Top': 1.23
 },
 {
   'Panel': 171,
   'Node': 5300,
   'X': 12.57,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.93,
   'Ay_Top': 1.49
 },
 {
   'Panel': 171,
   'Node': 5301,
   'X': 13.5,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 3.68,
   'Ay_Top': 1.27
 },
 {
   'Panel': 171,
   'Node': 5302,
   'X': 13.96,
   'Y': 3.17,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.08,
   'Ax_Top': 1.16,
   'Ay_Top': 0.97
 },
 {
   'Panel': 171,
   'Node': 5303,
   'X': 14.43,
   'Y': 3.17,
   'Ax_Bottom': 1.09,
   'Ay_Bottom': 0.49,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5304,
   'X': 14.9,
   'Y': 3.17,
   'Ax_Bottom': 2.04,
   'Ay_Bottom': 1.43,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5305,
   'X': 15.36,
   'Y': 3.17,
   'Ax_Bottom': 2.62,
   'Ay_Bottom': 2.09,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5306,
   'X': 15.83,
   'Y': 3.17,
   'Ax_Bottom': 2.75,
   'Ay_Bottom': 2.42,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5307,
   'X': 16.29,
   'Y': 3.17,
   'Ax_Bottom': 2.33,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5308,
   'X': 16.76,
   'Y': 3.17,
   'Ax_Bottom': 2.17,
   'Ay_Bottom': 2.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5309,
   'X': 17.22,
   'Y': 3.17,
   'Ax_Bottom': 2.22,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5310,
   'X': 17.69,
   'Y': 3.17,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 2.05,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5311,
   'X': 18.15,
   'Y': 3.17,
   'Ax_Bottom': 1.65,
   'Ay_Bottom': 1.58,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5312,
   'X': 18.62,
   'Y': 3.17,
   'Ax_Bottom': 0.85,
   'Ay_Bottom': 1.03,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5313,
   'X': 19.08,
   'Y': 3.17,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 0.88,
   'Ax_Top': 0.66,
   'Ay_Top': 0.01
 },
 {
   'Panel': 171,
   'Node': 5314,
   'X': 0.47,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.3,
   'Ay_Top': 2.25
 },
 {
   'Panel': 171,
   'Node': 5315,
   'X': 0.93,
   'Y': 2.74,
   'Ax_Bottom': 1.19,
   'Ay_Bottom': 0,
   'Ax_Top': 0.15,
   'Ay_Top': 1.37
 },
 {
   'Panel': 171,
   'Node': 5316,
   'X': 1.4,
   'Y': 2.74,
   'Ax_Bottom': 2,
   'Ay_Bottom': 0.87,
   'Ax_Top': 0,
   'Ay_Top': 0.37
 },
 {
   'Panel': 171,
   'Node': 5317,
   'X': 1.86,
   'Y': 2.74,
   'Ax_Bottom': 2.27,
   'Ay_Bottom': 1.41,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5318,
   'X': 2.33,
   'Y': 2.74,
   'Ax_Bottom': 2.11,
   'Ay_Bottom': 1.78,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5319,
   'X': 2.79,
   'Y': 2.74,
   'Ax_Bottom': 1.71,
   'Ay_Bottom': 1.83,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5320,
   'X': 3.26,
   'Y': 2.74,
   'Ax_Bottom': 2.35,
   'Ay_Bottom': 2.15,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5321,
   'X': 3.72,
   'Y': 2.74,
   'Ax_Bottom': 3.35,
   'Ay_Bottom': 2.34,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5322,
   'X': 4.19,
   'Y': 2.74,
   'Ax_Bottom': 3.61,
   'Ay_Bottom': 1.99,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5323,
   'X': 4.65,
   'Y': 2.74,
   'Ax_Bottom': 3.18,
   'Ay_Bottom': 1.25,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5324,
   'X': 5.12,
   'Y': 2.74,
   'Ax_Bottom': 2.03,
   'Ay_Bottom': 0.19,
   'Ax_Top': 0,
   'Ay_Top': 0.41
 },
 {
   'Panel': 171,
   'Node': 5325,
   'X': 5.59,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.08,
   'Ay_Top': 1.79
 },
 {
   'Panel': 171,
   'Node': 5326,
   'X': 6.05,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.16,
   'Ay_Top': 4.05
 },
 {
   'Panel': 171,
   'Node': 5327,
   'X': 6.98,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.14,
   'Ay_Top': 3.86
 },
 {
   'Panel': 171,
   'Node': 5328,
   'X': 7.45,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.07,
   'Ay_Top': 1.9
 },
 {
   'Panel': 171,
   'Node': 5329,
   'X': 7.91,
   'Y': 2.74,
   'Ax_Bottom': 0.39,
   'Ay_Bottom': 0,
   'Ax_Top': 0.38,
   'Ay_Top': 1.01
 },
 {
   'Panel': 171,
   'Node': 5330,
   'X': 8.38,
   'Y': 2.74,
   'Ax_Bottom': 1.28,
   'Ay_Bottom': 0.75,
   'Ax_Top': 0.04,
   'Ay_Top': 0.51
 },
 {
   'Panel': 171,
   'Node': 5331,
   'X': 8.84,
   'Y': 2.74,
   'Ax_Bottom': 1.54,
   'Ay_Bottom': 1.36,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5332,
   'X': 9.31,
   'Y': 2.74,
   'Ax_Bottom': 1.44,
   'Ay_Bottom': 1.62,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5333,
   'X': 9.78,
   'Y': 2.74,
   'Ax_Bottom': 1.73,
   'Ay_Bottom': 1.68,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5334,
   'X': 10.24,
   'Y': 2.74,
   'Ax_Bottom': 2.7,
   'Ay_Bottom': 1.92,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5335,
   'X': 10.71,
   'Y': 2.74,
   'Ax_Bottom': 2.97,
   'Ay_Bottom': 1.64,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5336,
   'X': 11.17,
   'Y': 2.74,
   'Ax_Bottom': 2.62,
   'Ay_Bottom': 0.91,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5337,
   'X': 11.64,
   'Y': 2.74,
   'Ax_Bottom': 1.45,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 0.56
 },
 {
   'Panel': 171,
   'Node': 5338,
   'X': 12.1,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.29,
   'Ay_Top': 2.23
 },
 {
   'Panel': 171,
   'Node': 5339,
   'X': 12.57,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.34,
   'Ay_Top': 4.61
 },
 {
   'Panel': 171,
   'Node': 5340,
   'X': 13.5,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.04,
   'Ay_Top': 4.38
 },
 {
   'Panel': 171,
   'Node': 5341,
   'X': 13.96,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.13,
   'Ay_Top': 2.04
 },
 {
   'Panel': 171,
   'Node': 5342,
   'X': 14.43,
   'Y': 2.74,
   'Ax_Bottom': 1.65,
   'Ay_Bottom': 0.06,
   'Ax_Top': 0,
   'Ay_Top': 0.74
 },
 {
   'Panel': 171,
   'Node': 5343,
   'X': 14.9,
   'Y': 2.74,
   'Ax_Bottom': 2.57,
   'Ay_Bottom': 1.11,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5344,
   'X': 15.36,
   'Y': 2.74,
   'Ax_Bottom': 2.81,
   'Ay_Bottom': 1.75,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5345,
   'X': 15.83,
   'Y': 2.74,
   'Ax_Bottom': 2.53,
   'Ay_Bottom': 1.95,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5346,
   'X': 16.29,
   'Y': 2.74,
   'Ax_Bottom': 1.78,
   'Ay_Bottom': 1.67,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5347,
   'X': 16.76,
   'Y': 2.74,
   'Ax_Bottom': 1.76,
   'Ay_Bottom': 1.72,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5348,
   'X': 17.22,
   'Y': 2.74,
   'Ax_Bottom': 2.11,
   'Ay_Bottom': 1.66,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5349,
   'X': 17.69,
   'Y': 2.74,
   'Ax_Bottom': 2.21,
   'Ay_Bottom': 1.35,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5350,
   'X': 18.15,
   'Y': 2.74,
   'Ax_Bottom': 1.95,
   'Ay_Bottom': 0.89,
   'Ax_Top': 0,
   'Ay_Top': 0.49
 },
 {
   'Panel': 171,
   'Node': 5351,
   'X': 18.62,
   'Y': 2.74,
   'Ax_Bottom': 1.23,
   'Ay_Bottom': 0.08,
   'Ax_Top': 0.27,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 5352,
   'X': 19.08,
   'Y': 2.74,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.35,
   'Ay_Top': 2.15
 },
 {
   'Panel': 171,
   'Node': 5353,
   'X': 0.47,
   'Y': 2.32,
   'Ax_Bottom': 1.1,
   'Ay_Bottom': 0,
   'Ax_Top': 1.95,
   'Ay_Top': 4.63
 },
 {
   'Panel': 171,
   'Node': 5354,
   'X': 0.93,
   'Y': 2.32,
   'Ax_Bottom': 1.83,
   'Ay_Bottom': 0,
   'Ax_Top': 1.14,
   'Ay_Top': 2.67
 },
 {
   'Panel': 171,
   'Node': 5355,
   'X': 1.4,
   'Y': 2.32,
   'Ax_Bottom': 2.24,
   'Ay_Bottom': 0.44,
   'Ax_Top': 0.25,
   'Ay_Top': 1.64
 },
 {
   'Panel': 171,
   'Node': 5356,
   'X': 1.86,
   'Y': 2.32,
   'Ax_Bottom': 2.45,
   'Ay_Bottom': 0.77,
   'Ax_Top': 0,
   'Ay_Top': 1.2
 },
 {
   'Panel': 171,
   'Node': 5357,
   'X': 2.33,
   'Y': 2.32,
   'Ax_Bottom': 2.08,
   'Ay_Bottom': 1.04,
   'Ax_Top': 0.2,
   'Ay_Top': 0.86
 },
 {
   'Panel': 171,
   'Node': 5358,
   'X': 2.79,
   'Y': 2.32,
   'Ax_Bottom': 0.97,
   'Ay_Bottom': 1.21,
   'Ax_Top': 0.15,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5359,
   'X': 3.26,
   'Y': 2.32,
   'Ax_Bottom': 1.54,
   'Ay_Bottom': 1.5,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5360,
   'X': 3.72,
   'Y': 2.32,
   'Ax_Bottom': 3.25,
   'Ay_Bottom': 2.02,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5361,
   'X': 4.19,
   'Y': 2.32,
   'Ax_Bottom': 3.91,
   'Ay_Bottom': 1.71,
   'Ax_Top': 0,
   'Ay_Top': 0.05
 },
 {
   'Panel': 171,
   'Node': 5362,
   'X': 4.65,
   'Y': 2.32,
   'Ax_Bottom': 3.8,
   'Ay_Bottom': 1.29,
   'Ax_Top': 0,
   'Ay_Top': 0.27
 },
 {
   'Panel': 171,
   'Node': 5363,
   'X': 5.12,
   'Y': 2.32,
   'Ax_Bottom': 2.89,
   'Ay_Bottom': 0.48,
   'Ax_Top': 0,
   'Ay_Top': 1.02
 },
 {
   'Panel': 171,
   'Node': 5364,
   'X': 5.59,
   'Y': 2.32,
   'Ax_Bottom': 0.94,
   'Ay_Bottom': 0,
   'Ax_Top': 0.59,
   'Ay_Top': 2.66
 },
 {
   'Panel': 171,
   'Node': 5365,
   'X': 6.05,
   'Y': 2.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.3,
   'Ay_Top': 5.33
 },
 {
   'Panel': 171,
   'Node': 5366,
   'X': 6.98,
   'Y': 2.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.77,
   'Ay_Top': 5.53
 },
 {
   'Panel': 171,
   'Node': 5367,
   'X': 7.45,
   'Y': 2.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.97,
   'Ay_Top': 3.01
 },
 {
   'Panel': 171,
   'Node': 5368,
   'X': 7.91,
   'Y': 2.32,
   'Ax_Bottom': 0.8,
   'Ay_Bottom': 0,
   'Ax_Top': 0.78,
   'Ay_Top': 2
 },
 {
   'Panel': 171,
   'Node': 5369,
   'X': 8.38,
   'Y': 2.32,
   'Ax_Bottom': 1.67,
   'Ay_Bottom': 0.33,
   'Ax_Top': 0.37,
   'Ay_Top': 1.54
 },
 {
   'Panel': 171,
   'Node': 5370,
   'X': 8.84,
   'Y': 2.32,
   'Ax_Bottom': 1.61,
   'Ay_Bottom': 0.73,
   'Ax_Top': 0.48,
   'Ay_Top': 1.21
 },
 {
   'Panel': 171,
   'Node': 5371,
   'X': 9.31,
   'Y': 2.32,
   'Ax_Bottom': 0.88,
   'Ay_Bottom': 1.04,
   'Ax_Top': 0.52,
   'Ay_Top': 0.37
 },
 {
   'Panel': 171,
   'Node': 5372,
   'X': 9.78,
   'Y': 2.32,
   'Ax_Bottom': 0.93,
   'Ay_Bottom': 1.08,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5373,
   'X': 10.24,
   'Y': 2.32,
   'Ax_Bottom': 2.54,
   'Ay_Bottom': 1.67,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5374,
   'X': 10.71,
   'Y': 2.32,
   'Ax_Bottom': 3.27,
   'Ay_Bottom': 1.42,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5375,
   'X': 11.17,
   'Y': 2.32,
   'Ax_Bottom': 3.22,
   'Ay_Bottom': 0.99,
   'Ax_Top': 0,
   'Ay_Top': 0.31
 },
 {
   'Panel': 171,
   'Node': 5376,
   'X': 11.64,
   'Y': 2.32,
   'Ax_Bottom': 2.4,
   'Ay_Bottom': 0.16,
   'Ax_Top': 0,
   'Ay_Top': 1.1
 },
 {
   'Panel': 171,
   'Node': 5377,
   'X': 12.1,
   'Y': 2.32,
   'Ax_Bottom': 0.47,
   'Ay_Bottom': 0,
   'Ax_Top': 0.51,
   'Ay_Top': 2.86
 },
 {
   'Panel': 171,
   'Node': 5378,
   'X': 12.57,
   'Y': 2.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.87,
   'Ay_Top': 5.19
 },
 {
   'Panel': 171,
   'Node': 5379,
   'X': 13.5,
   'Y': 2.32,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.1,
   'Ay_Top': 5.49
 },
 {
   'Panel': 171,
   'Node': 5380,
   'X': 13.96,
   'Y': 2.32,
   'Ax_Bottom': 0.65,
   'Ay_Bottom': 0,
   'Ax_Top': 0.91,
   'Ay_Top': 3.2
 },
 {
   'Panel': 171,
   'Node': 5381,
   'X': 14.43,
   'Y': 2.32,
   'Ax_Bottom': 2.48,
   'Ay_Bottom': 0.3,
   'Ax_Top': 0,
   'Ay_Top': 1.65
 },
 {
   'Panel': 171,
   'Node': 5382,
   'X': 14.9,
   'Y': 2.32,
   'Ax_Bottom': 3.08,
   'Ay_Bottom': 1.04,
   'Ax_Top': 0,
   'Ay_Top': 0.84
 },
 {
   'Panel': 171,
   'Node': 5383,
   'X': 15.36,
   'Y': 2.32,
   'Ax_Bottom': 2.87,
   'Ay_Bottom': 1.46,
   'Ax_Top': 0,
   'Ay_Top': 0.26
 },
 {
   'Panel': 171,
   'Node': 5384,
   'X': 15.83,
   'Y': 2.32,
   'Ax_Bottom': 2.09,
   'Ay_Bottom': 1.39,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5385,
   'X': 16.29,
   'Y': 2.32,
   'Ax_Bottom': 1.09,
   'Ay_Bottom': 0.6,
   'Ax_Top': 0,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5386,
   'X': 16.76,
   'Y': 2.32,
   'Ax_Bottom': 1.22,
   'Ay_Bottom': 0.77,
   'Ax_Top': 0.1,
   'Ay_Top': 0.52
 },
 {
   'Panel': 171,
   'Node': 5387,
   'X': 17.22,
   'Y': 2.32,
   'Ax_Bottom': 1.96,
   'Ay_Bottom': 0.79,
   'Ax_Top': 0.11,
   'Ay_Top': 1.02
 },
 {
   'Panel': 171,
   'Node': 5388,
   'X': 17.69,
   'Y': 2.32,
   'Ax_Bottom': 2.29,
   'Ay_Bottom': 0.61,
   'Ax_Top': 0.01,
   'Ay_Top': 1.3
 },
 {
   'Panel': 171,
   'Node': 5389,
   'X': 18.15,
   'Y': 2.32,
   'Ax_Bottom': 2.12,
   'Ay_Bottom': 0.32,
   'Ax_Top': 0.26,
   'Ay_Top': 1.66
 },
 {
   'Panel': 171,
   'Node': 5390,
   'X': 18.62,
   'Y': 2.32,
   'Ax_Bottom': 1.7,
   'Ay_Bottom': 0,
   'Ax_Top': 1.09,
   'Ay_Top': 2.49
 },
 {
   'Panel': 171,
   'Node': 5391,
   'X': 19.08,
   'Y': 2.32,
   'Ax_Bottom': 0.95,
   'Ay_Bottom': 0,
   'Ax_Top': 1.92,
   'Ay_Top': 4.34
 },
 {
   'Panel': 171,
   'Node': 5392,
   'X': 0.47,
   'Y': 1.89,
   'Ax_Bottom': 0.24,
   'Ay_Bottom': 0.26,
   'Ax_Top': 4.69,
   'Ay_Top': 4.14
 },
 {
   'Panel': 171,
   'Node': 5393,
   'X': 0.93,
   'Y': 1.89,
   'Ax_Bottom': 1.99,
   'Ay_Bottom': 0.49,
   'Ax_Top': 1.93,
   'Ay_Top': 2.81
 },
 {
   'Panel': 171,
   'Node': 5394,
   'X': 1.4,
   'Y': 1.89,
   'Ax_Bottom': 2.23,
   'Ay_Bottom': 0.14,
   'Ax_Top': 0.74,
   'Ay_Top': 2.29
 },
 {
   'Panel': 171,
   'Node': 5395,
   'X': 1.86,
   'Y': 1.89,
   'Ax_Bottom': 2.41,
   'Ay_Bottom': 0.14,
   'Ax_Top': 0.14,
   'Ay_Top': 1.97
 },
 {
   'Panel': 171,
   'Node': 5396,
   'X': 2.33,
   'Y': 1.89,
   'Ax_Bottom': 1.61,
   'Ay_Bottom': 0,
   'Ax_Top': 0.64,
   'Ay_Top': 2.38
 },
 {
   'Panel': 171,
   'Node': 5397,
   'X': 2.79,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.25,
   'Ay_Top': 2.51
 },
 {
   'Panel': 171,
   'Node': 5398,
   'X': 3.26,
   'Y': 1.89,
   'Ax_Bottom': 0.36,
   'Ay_Bottom': 1.66,
   'Ax_Top': 0.91,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5399,
   'X': 3.72,
   'Y': 1.89,
   'Ax_Bottom': 2.37,
   'Ay_Bottom': 0,
   'Ax_Top': 0.55,
   'Ay_Top': 3.2
 },
 {
   'Panel': 171,
   'Node': 5400,
   'X': 4.19,
   'Y': 1.89,
   'Ax_Bottom': 3.97,
   'Ay_Bottom': 0.64,
   'Ax_Top': 0,
   'Ay_Top': 1.04
 },
 {
   'Panel': 171,
   'Node': 5401,
   'X': 4.65,
   'Y': 1.89,
   'Ax_Bottom': 3.88,
   'Ay_Bottom': 0.74,
   'Ax_Top': 0,
   'Ay_Top': 1.16
 },
 {
   'Panel': 171,
   'Node': 5402,
   'X': 5.12,
   'Y': 1.89,
   'Ax_Bottom': 3.24,
   'Ay_Bottom': 0.48,
   'Ax_Top': 0,
   'Ay_Top': 1.91
 },
 {
   'Panel': 171,
   'Node': 5403,
   'X': 5.59,
   'Y': 1.89,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 0.06,
   'Ax_Top': 1.34,
   'Ay_Top': 2.91
 },
 {
   'Panel': 171,
   'Node': 5404,
   'X': 6.05,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.66,
   'Ay_Top': 4.16
 },
 {
   'Panel': 171,
   'Node': 5405,
   'X': 6.98,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.26,
   'Ax_Top': 4.74,
   'Ay_Top': 2.37
 },
 {
   'Panel': 171,
   'Node': 5406,
   'X': 7.45,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 2.45,
   'Ay_Top': 2.98
 },
 {
   'Panel': 171,
   'Node': 5407,
   'X': 7.91,
   'Y': 1.89,
   'Ax_Bottom': 1.31,
   'Ay_Bottom': 0,
   'Ax_Top': 1.08,
   'Ay_Top': 2.36
 },
 {
   'Panel': 171,
   'Node': 5408,
   'X': 8.38,
   'Y': 1.89,
   'Ax_Bottom': 1.83,
   'Ay_Bottom': 0.1,
   'Ax_Top': 0.47,
   'Ay_Top': 2
 },
 {
   'Panel': 171,
   'Node': 5409,
   'X': 8.84,
   'Y': 1.89,
   'Ax_Bottom': 1.57,
   'Ay_Bottom': 0,
   'Ax_Top': 0.52,
   'Ay_Top': 2.21
 },
 {
   'Panel': 171,
   'Node': 5410,
   'X': 9.31,
   'Y': 1.89,
   'Ax_Bottom': 0.05,
   'Ay_Bottom': 0,
   'Ax_Top': 1.8,
   'Ay_Top': 2.8
 },
 {
   'Panel': 171,
   'Node': 5411,
   'X': 9.78,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.68,
   'Ax_Top': 0.89,
   'Ay_Top': 0
 },
 {
   'Panel': 171,
   'Node': 5412,
   'X': 10.24,
   'Y': 1.89,
   'Ax_Bottom': 2,
   'Ay_Bottom': 0.08,
   'Ax_Top': 0.55,
   'Ay_Top': 2.3
 },
 {
   'Panel': 171,
   'Node': 5413,
   'X': 10.71,
   'Y': 1.89,
   'Ax_Bottom': 3.28,
   'Ay_Bottom': 0.51,
   'Ax_Top': 0,
   'Ay_Top': 1.05
 },
 {
   'Panel': 171,
   'Node': 5414,
   'X': 11.17,
   'Y': 1.89,
   'Ax_Bottom': 3.33,
   'Ay_Bottom': 0.46,
   'Ax_Top': 0,
   'Ay_Top': 1.24
 },
 {
   'Panel': 171,
   'Node': 5415,
   'X': 11.64,
   'Y': 1.89,
   'Ax_Bottom': 2.74,
   'Ay_Bottom': 0.19,
   'Ax_Top': 0,
   'Ay_Top': 2.01
 },
 {
   'Panel': 171,
   'Node': 5416,
   'X': 12.1,
   'Y': 1.89,
   'Ax_Bottom': 1.41,
   'Ay_Bottom': 0,
   'Ax_Top': 1.29,
   'Ay_Top': 3.11
 },
 {
   'Panel': 171,
   'Node': 5417,
   'X': 12.57,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 4.96,
   'Ay_Top': 4.83
 },
 {
   'Panel': 171,
   'Node': 5418,
   'X': 13.5,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 5.1,
   'Ay_Top': 5.03
 },
 {
   'Panel': 171,
   'Node': 5419,
   'X': 13.96,
   'Y': 1.89,
   'Ax_Bottom': 1.72,
   'Ay_Bottom': 0,
   'Ax_Top': 1.66,
   'Ay_Top': 3.44
 },
 {
   'Panel': 171,
   'Node': 5420,
   'X': 14.43,
   'Y': 1.89,
   'Ax_Bottom': 2.72,
   'Ay_Bottom': 0.2,
   'Ax_Top': 0.27,
   'Ay_Top': 2.64
 },
 {
   'Panel': 171,
   'Node': 5421,
   'X': 14.9,
   'Y': 1.89,
   'Ax_Bottom': 3.11,
   'Ay_Bottom': 0.36,
   'Ax_Top': 0,
   'Ay_Top': 1.96
 },
 {
   'Panel': 171,
   'Node': 5422,
   'X': 15.36,
   'Y': 1.89,
   'Ax_Bottom': 2.6,
   'Ay_Bottom': 0.09,
   'Ax_Top': 0.26,
   'Ay_Top': 2.48
 },
 {
   'Panel': 171,
   'Node': 5423,
   'X': 15.83,
   'Y': 1.89,
   'Ax_Bottom': 0.97,
   'Ay_Bottom': 0.01,
   'Ax_Top': 0.58,
   'Ay_Top': 1.31
 },
 {
   'Panel': 171,
   'Node': 5424,
   'X': 16.29,
   'Y': 1.89,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0.99,
   'Ay_Top': 1.9
 },
 {
   'Panel': 171,
   'Node': 5425,
   'X': 16.76,
   'Y': 1.89,
   'Ax_Bottom': 0.13,
   'Ay_Bottom': 0,
   'Ax_Top': 0.98,
   'Ay_Top': 2.4
 },
 {
   'Panel': 171,
   'Node': 5426,
   'X': 17.22,
   'Y': 1.89,
   'Ax_Bottom': 1.19,
   'Ay_Bottom': 0,
   'Ax_Top': 0.58,
   'Ay_Top': 2.35
 },
 {
   'Panel': 171,
   'Node': 5427,
   'X': 17.69,
   'Y': 1.89,
   'Ax_Bottom': 1.85,
   'Ay_Bottom': 0,
   'Ax_Top': 0.14,
   'Ay_Top': 2.19
 },
 {
   'Panel': 171,
   'Node': 5428,
   'X': 18.15,
   'Y': 1.89,
   'Ax_Bottom': 1.97,
   'Ay_Bottom': 0,
   'Ax_Top': 0.47,
   'Ay_Top': 2.19
 },
 {
   'Panel': 171,
   'Node': 5429,
   'X': 18.62,
   'Y': 1.89,
   'Ax_Bottom': 1.48,
   'Ay_Bottom': 0.06,
   'Ax_Top': 1.72,
   'Ay_Top': 2.71
 },
 {
   'Panel': 171,
   'Node': 5430,
   'X': 19.08,
   'Y': 1.89,
   'Ax_Bottom': 0.44,
   'Ay_Bottom': 0.63,
   'Ax_Top': 4.1,
   'Ay_Top': 3.5
 },
 {
   'Panel': 171,
   'Node': 5431,
   'X': 2.79,
   'Y': 1.47,
   'Ax_Bottom': 0.33,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.57
 },
 {
   'Panel': 171,
   'Node': 5432,
   'X': 4.19,
   'Y': 1.47,
   'Ax_Bottom': 3.21,
   'Ay_Bottom': 0.15,
   'Ax_Top': 0,
   'Ay_Top': 1.57
 },
 {
   'Panel': 171,
   'Node': 5433,
   'X': 4.65,
   'Y': 1.47,
   'Ax_Bottom': 3.59,
   'Ay_Bottom': 0.38,
   'Ax_Top': 0,
   'Ay_Top': 1.37
 },
 {
   'Panel': 171,
   'Node': 5434,
   'X': 5.12,
   'Y': 1.47,
   'Ax_Bottom': 3.09,
   'Ay_Bottom': 0.69,
   'Ax_Top': 0,
   'Ay_Top': 1.75
 },
 {
   'Panel': 171,
   'Node': 5435,
   'X': 5.59,
   'Y': 1.47,
   'Ax_Bottom': 1.83,
   'Ay_Bottom': 0.85,
   'Ax_Top': 1.44,
   'Ay_Top': 1.99
 },
 {
   'Panel': 171,
   'Node': 5436,
   'X': 6.05,
   'Y': 1.47,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.54,
   'Ax_Top': 2.96,
   'Ay_Top': 1.13
 },
 {
   'Panel': 171,
   'Node': 5437,
   'X': 10.24,
   'Y': 1.47,
   'Ax_Bottom': 1.78,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.38
 },
 {
   'Panel': 171,
   'Node': 5438,
   'X': 10.71,
   'Y': 1.47,
   'Ax_Bottom': 2.74,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.58
 },
 {
   'Panel': 171,
   'Node': 5439,
   'X': 11.17,
   'Y': 1.47,
   'Ax_Bottom': 3.03,
   'Ay_Bottom': 0.16,
   'Ax_Top': 0,
   'Ay_Top': 1.39
 },
 {
   'Panel': 171,
   'Node': 5440,
   'X': 11.64,
   'Y': 1.47,
   'Ax_Bottom': 2.59,
   'Ay_Bottom': 0.4,
   'Ax_Top': 0,
   'Ay_Top': 1.97
 },
 {
   'Panel': 171,
   'Node': 5441,
   'X': 12.1,
   'Y': 1.47,
   'Ax_Bottom': 1.33,
   'Ay_Bottom': 0.54,
   'Ax_Top': 1.55,
   'Ay_Top': 2.28
 },
 {
   'Panel': 171,
   'Node': 5442,
   'X': 12.57,
   'Y': 1.47,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.23,
   'Ax_Top': 3.11,
   'Ay_Top': 1.9
 },
 {
   'Panel': 171,
   'Node': 5443,
   'X': 13.5,
   'Y': 1.47,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.57,
   'Ax_Top': 3.19,
   'Ay_Top': 2.02
 },
 {
   'Panel': 171,
   'Node': 5444,
   'X': 13.96,
   'Y': 1.47,
   'Ax_Bottom': 1.43,
   'Ay_Bottom': 0.62,
   'Ax_Top': 1.87,
   'Ay_Top': 2.56
 },
 {
   'Panel': 171,
   'Node': 5445,
   'X': 14.43,
   'Y': 1.47,
   'Ax_Bottom': 2.41,
   'Ay_Bottom': 0.28,
   'Ax_Top': 0.39,
   'Ay_Top': 2.39
 },
 {
   'Panel': 171,
   'Node': 5446,
   'X': 14.9,
   'Y': 1.47,
   'Ax_Bottom': 2.5,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.23
 },
 {
   'Panel': 171,
   'Node': 5447,
   'X': 15.36,
   'Y': 1.47,
   'Ax_Bottom': 1.48,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 2.62
 },
 {
   'Panel': 171,
   'Node': 5448,
   'X': 16.29,
   'Y': 1.47,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.75,
   'Ay_Top': 6.05
 },
 {
   'Panel': 171,
   'Node': 5449,
   'X': 16.76,
   'Y': 1.47,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 1.97,
   'Ay_Top': 5.88
 },
 {
   'Panel': 171,
   'Node': 5450,
   'X': 4.03,
   'Y': 1.04,
   'Ax_Bottom': 2.44,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.33
 },
 {
   'Panel': 171,
   'Node': 5451,
   'X': 4.45,
   'Y': 1.04,
   'Ax_Bottom': 3.16,
   'Ay_Bottom': 0.36,
   'Ax_Top': 0,
   'Ay_Top': 0.91
 },
 {
   'Panel': 171,
   'Node': 5452,
   'X': 4.86,
   'Y': 1.04,
   'Ax_Bottom': 3.16,
   'Ay_Bottom': 0.78,
   'Ax_Top': 0,
   'Ay_Top': 0.88
 },
 {
   'Panel': 171,
   'Node': 5453,
   'X': 5.27,
   'Y': 1.04,
   'Ax_Bottom': 2.39,
   'Ay_Bottom': 0.77,
   'Ax_Top': 0,
   'Ay_Top': 1.26
 },
 {
   'Panel': 171,
   'Node': 5454,
   'X': 5.69,
   'Y': 1.04,
   'Ax_Bottom': 1.33,
   'Ay_Bottom': 0.99,
   'Ax_Top': 0.71,
   'Ay_Top': 0.79
 },
 {
   'Panel': 171,
   'Node': 5455,
   'X': 6.1,
   'Y': 1.04,
   'Ax_Bottom': 0.12,
   'Ay_Bottom': 0.62,
   'Ax_Top': 0.79,
   'Ay_Top': 0.04
 },
 {
   'Panel': 171,
   'Node': 5456,
   'X': 10.59,
   'Y': 1.04,
   'Ax_Bottom': 1.51,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.23
 },
 {
   'Panel': 171,
   'Node': 5457,
   'X': 11.03,
   'Y': 1.04,
   'Ax_Bottom': 2.64,
   'Ay_Bottom': 0.25,
   'Ax_Top': 0,
   'Ay_Top': 0.91
 },
 {
   'Panel': 171,
   'Node': 5458,
   'X': 11.48,
   'Y': 1.04,
   'Ax_Bottom': 2.47,
   'Ay_Bottom': 0.59,
   'Ax_Top': 0,
   'Ay_Top': 1.09
 },
 {
   'Panel': 171,
   'Node': 5459,
   'X': 11.93,
   'Y': 1.04,
   'Ax_Bottom': 1.63,
   'Ay_Bottom': 0.87,
   'Ax_Top': 0.51,
   'Ay_Top': 1.24
 },
 {
   'Panel': 171,
   'Node': 5460,
   'X': 12.38,
   'Y': 1.04,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0.74,
   'Ax_Top': 1.51,
   'Ay_Top': 0.9
 },
 {
   'Panel': 171,
   'Node': 5461,
   'X': 13.72,
   'Y': 1.04,
   'Ax_Bottom': 0.23,
   'Ay_Bottom': 0.9,
   'Ax_Top': 1.63,
   'Ay_Top': 1.05
 },
 {
   'Panel': 171,
   'Node': 5462,
   'X': 14.16,
   'Y': 1.04,
   'Ax_Bottom': 1.62,
   'Ay_Bottom': 0.91,
   'Ax_Top': 0.8,
   'Ay_Top': 1.45
 },
 {
   'Panel': 171,
   'Node': 5463,
   'X': 14.61,
   'Y': 1.04,
   'Ax_Bottom': 2.11,
   'Ay_Bottom': 0.49,
   'Ax_Top': 0,
   'Ay_Top': 1.59
 },
 {
   'Panel': 171,
   'Node': 5464,
   'X': 15.06,
   'Y': 1.04,
   'Ax_Bottom': 1.49,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.41
 },
 {
   'Panel': 171,
   'Node': 5465,
   'X': 15.5,
   'Y': 1.04,
   'Ax_Bottom': 0,
   'Ay_Bottom': 0,
   'Ax_Top': 0,
   'Ay_Top': 1.45
 }
]";


    }

    

   
}

