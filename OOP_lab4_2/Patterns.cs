using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4_2
{
    public class Patterns
    {
        public static void AllOn(List<Lamp> lamps)
        {
            foreach (var lamp in lamps)
            {
                lamp.IsOn = true;
            }
        }

        public static void Alternate(List<Lamp> lamps)
        {
            for (int i = 0; i < lamps.Count; i++)
            {
                lamps[i].IsOn = (i % 2 == 0);
            }
        }

        public static void Blink(List<Lamp> lamps)
        {
            foreach (var lamp in lamps)
            {
                lamp.Toggle();
            }
        }
        public static void AllOff(List<Lamp> lamps)
        {
            for (int i = 0; i < lamps.Count; i++)
            {
                foreach (var lamp in lamps)
                {
                    lamp.IsOn = false;
                }
            }
        }
    }

}
