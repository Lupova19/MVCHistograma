using HistogramaZadacha.Model;
using HistogramaZadacha.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramaZadacha.Controller
{
    public class HistogramController
    {
        private DisplayHistogram myDisplay = new DisplayHistogram();
        private Histogram myHistogram = new Histogram();

        public HistogramController()
        {
            myDisplay.Input();
            myHistogram.CalculatePercentages(myDisplay.Numbers);

            myDisplay.P1 = myHistogram.P1;
            myDisplay.P2 = myHistogram.P2;
            myDisplay.P3 = myHistogram.P3;
            myDisplay.P4 = myHistogram.P4;
            myDisplay.P5 = myHistogram.P5;

            myDisplay.Output();
        }
    }
}
