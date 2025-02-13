using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletChartSample
{
    public class ViewModel
    {
        public ObservableCollection<GaugeModel> BulletChartData { get; set; }

        public ViewModel()
        {
            BulletChartData = new ObservableCollection<GaugeModel>()
            {
              new GaugeModel("Product A", 190, 220, 150, 180, 210),
              new GaugeModel("Product B", 175, 180, 130, 160, 190 ),
              new GaugeModel("Product C", 195, 200, 130, 170, 210),
              new GaugeModel("Product D", 205, 180, 140, 170, 210),
              new GaugeModel("Product E", 215, 220, 150, 190, 220),
              new GaugeModel("Product F", 185, 200, 140, 170, 210),
              new GaugeModel("Product G", 208, 200, 150, 190, 220){ IsAxisVisible = true }
            };
        }
    }
}
