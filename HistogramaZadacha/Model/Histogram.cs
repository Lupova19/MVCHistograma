using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramaZadacha.Model
{
    public class Histogram
    {
        private double p1;

        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        private double p2;

        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        private double p3;

        public double P3
        {
            get { return p3; }
            set { p3 = value; }
        }

        private double p4;

        public double P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        private double p5;

        public double P5
        {
            get { return p5; }
            set { p5 = value; }
        }

        public void CalculatePercentages(int[] numbers)
        {
            int totalCountNums = numbers.Length;

            if (totalCountNums == 0)
            {
                return;
            }

            int countNums1 = 0;
            int countNums2 = 0;
            int countNums3 = 0;
            int countNums4 = 0;
            int countNums5 = 0;

            foreach (int number in numbers)
            {
                if (number >= 0 && number <= 199)
                {
                    countNums1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    countNums2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    countNums3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    countNums4++;
                }
                else if (number >= 800)
                {
                    countNums5++;
                }
            }

            P1 = (double)countNums1 / totalCountNums * 100;
            P2 = (double)countNums2 / totalCountNums * 100;
            P3 = (double)countNums3 / totalCountNums * 100;
            P4 = (double)countNums4 / totalCountNums * 100;
            P5 = (double)countNums5 / totalCountNums * 100;
        }
    }
}
