using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatticeAerodynamicRudder;

namespace ChartsVisualisation
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Характерная площадь в зависимости от угла наклона" };
            a.Height = 0.7;
            a.Width = 0.35;
            a.Depth = 0.05;
            a.BorderThickness = 0.01;
            a.InnerEdgeThickness = 0.005;
            a.BorderDistance = 0.05;
            this.MyModel.Series.Add(new FunctionSeries(a.GetAreaWithCurrentAngel, 0, 15, 0.1, "S"));
        }

        LatticeAeroRudder a = new LatticeAeroRudder();
        

        public PlotModel MyModel { get; private set; }
    }
}
