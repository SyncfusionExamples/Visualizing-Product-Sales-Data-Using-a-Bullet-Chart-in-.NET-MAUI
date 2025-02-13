using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletChartSample
{
    public class GaugeModel
    {
        public string Category { get; set; }

        public double ObservedValue { get; set; }

        public double TargetValue { get; set; }

        public double LowRange { get; set; }

        public double MidRange { get; set; }

        public double HighRange { get; set; }

        public bool IsAxisVisible { get; set; } = false;

        public GaugeModel(string text, double actual, double target, double low, double mid, double high)
        {
            Category = text;
            ObservedValue = actual;
            TargetValue = target;
            LowRange = low;
            MidRange = mid;
            HighRange = high; 
        }
    }
}
