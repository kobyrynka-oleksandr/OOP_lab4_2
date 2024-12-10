using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4_2
{
    public class Garland : IGarlandControl
    {
        private List<Lamp> lamps;

        public Garland(List<Lamp> lamps)
        {
            this.lamps = lamps;
        }

        public void ApplyPattern(string pattern)
        {
            switch (pattern)
            {
                case "AllOn":
                    Patterns.AllOn(lamps);
                    break;

                case "Alternate":
                    Patterns.Alternate(lamps);
                    break;

                case "Blink":
                    Patterns.Blink(lamps);
                    break;

                case "AllOff":
                    Patterns.AllOff(lamps);
                    break;
            }
        }

        public List<Lamp> GetLamps()
        {
            return lamps;
        }
    }

}
