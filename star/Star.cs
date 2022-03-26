namespace star
{
    public partial class Star : Form
    {
        static int XMAX = 700;
        static int YMAX = 700;
        static int XORG = XMAX / 2;
        static int YORG = YMAX / 2;
        static int RADIUS = XMAX / 2 - 50;
        static int NDOTS = 5;

        static void drawPoint(Graphics g, int x, int y)
        {
            Pen pen = new Pen(Color.Black) ;

            g.DrawEllipse(pen, x, y, 1, 1) ;
        }

        static void drawCircle(Graphics g)
        {
            int i;
            double step = 2* Math.PI / NDOTS;
            double theta = 0.0;
            Pen pen = new Pen(Color.Black);

            int oldX = (int)(RADIUS * Math.Cos(theta - Math.PI / 2)) + XORG;
            int oldY = (int)(RADIUS * Math.Sin(theta - Math.PI / 2)) + YORG;

            for (i = 0; i < NDOTS + 1; i++)
            {
                int x, y;

                x = (int)(RADIUS * Math.Cos(theta - Math.PI / 2)) + XORG;
                y = (int)(RADIUS * Math.Sin(theta - Math.PI / 2)) + YORG;

                g.DrawLine(pen, oldX, oldY, x, y) ;

                oldX = x;
                oldY = y;

                theta += step;
            
            }

            RADIUS = (int)(0.38 * RADIUS);
            oldX = (int)(RADIUS * Math.Cos(theta - Math.PI / 2 - Math.PI)) + XORG;
            oldY = (int)(RADIUS * Math.Sin(theta - Math.PI / 2 - Math.PI)) + YORG;

            for (i = 0; i < NDOTS + 1; i++)
            {
                int x, y;

                x = (int)(RADIUS * Math.Cos(theta - Math.PI / 2 - Math.PI)) + XORG;
                y = (int)(RADIUS * Math.Sin(theta - Math.PI / 2 - Math.PI)) + YORG;

                g.DrawLine(pen, oldX, oldY, x, y);

                oldX = x;
                oldY = y;

                theta += step;

            }
        }




        public Star()
        {
            InitializeComponent();
        }


        private void Star_Paint(object sender, PaintEventArgs e)
        {
            drawCircle(e.Graphics);
        }   
        
        private void Star_Load(object sender, EventArgs e)
        {

        }
    }
}