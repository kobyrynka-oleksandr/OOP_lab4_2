namespace OOP_lab4_2
{
    public partial class Form1 : Form
    {
        private Garland garland;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeGarland();
            InitializeTimer();
        }

        private void InitializeGarland()
        {
            var lamps = new List<Lamp>
        {
            new Lamp(Color.Red, 10, 10),
            new Lamp(Color.Green, 50, 10),
            new Lamp(Color.Blue, 90, 10),
            new Lamp(Color.Red, 130, 10),
            new Lamp(Color.Green, 170, 10),
            new Lamp(Color.Blue, 210, 10),
            new Lamp(Color.Red, 250, 10),
            new Lamp(Color.Green, 290, 10),
            new Lamp(Color.Blue, 330, 10),
            new Lamp(Color.Red, 370, 10),
            new Lamp(Color.Green, 410, 10),
            new Lamp(Color.Blue, 450, 10),
        };

            garland = new Garland(lamps);
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            garland.ApplyPattern("Blink");
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var lamp in garland.GetLamps())
            {
                Brush brush = new SolidBrush(lamp.IsOn ? lamp.LampColor : Color.Gray);
                e.Graphics.FillEllipse(brush, lamp.x, lamp.y, 30, 30);
            }
        }
        private void btnAllOn_Click(object sender, EventArgs e)
        {
            garland.ApplyPattern("AllOn");
            Invalidate();
        }
        private void btnBlink_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnAlternate_Click(object sender, EventArgs e)
        {
            garland.ApplyPattern("Alternate");
            Invalidate();
        }

        private void btnAllOff_Click(object sender, EventArgs e)
        {
            timer.Stop();
            garland.ApplyPattern("AllOff");
            Invalidate();
        }
    }

}
