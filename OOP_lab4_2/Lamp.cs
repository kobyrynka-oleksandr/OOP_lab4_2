using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab4_2
{
    public class Lamp
    {
        public bool IsOn { get; set; }
        public Color LampColor { get; set; }
        public int x { get; set; }
        public int y { get; set; }


        public Lamp(Color color, int x, int y)
        {
            IsOn = false;
            LampColor = color;
            this.x = x;
            this.y = y;
        }

        public void Toggle()
        {
            IsOn = !IsOn;
        }
    }

}
