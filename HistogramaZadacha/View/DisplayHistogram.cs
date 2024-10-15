using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramaZadacha.View
{
    public class DisplayHistogram
    {
        public int[] Numbers { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }

        public void Input()
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            Numbers = new int[n];
            Console.WriteLine("Въведи числата:");
            for (int i = 0; i < n; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Output()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"|<200|-> {P1:F2}%");
            Console.WriteLine($"|200 ... 399|-> {P2:F2}%");
            Console.WriteLine($"|400 ... 599|-> {P3:F2}%");
            Console.WriteLine($"|600 ... 799|-> {P4:F2}%");
            Console.WriteLine($"|>= 800|-> {P5:F2}%");
        }
    }
}
