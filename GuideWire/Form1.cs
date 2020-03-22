using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuideWire
{
    public partial class Form1 : Form
    {

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();


        public Form1()
        {
            InitializeComponent();
            SetUpMovingObject();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1;
            myTimer.Start();


            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.TopMost = true;

            Console.WriteLine("Hello");
        }

        private Point firstPoint = new Point();

        private void TimerEventProcessor(Object myObject,
                                            EventArgs myEventArgs)
        {
            Invalidate();
            Console.WriteLine("Timer");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Red)
            {
                Width = 10
            };

            // Console.WriteLine(GetLineCoordinates().Item1);

            // Debug.DrawLine(transform.position, transform.position + Vector3.up * maxRayDistance, Color.red);

            Console.WriteLine("Invalidato");
            Console.WriteLine("Height of form: " + ClientSize.Height);


            g.DrawLine(myPen, ballPosition.Location.X, ballPosition.Location.Y, Cursor.Position.X, Cursor.Position.Y);

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) {
            Invalidate();
            Console.WriteLine("Raised: {0}", e.SignalTime);
        }


        private Tuple<int, int> GetLineCoordinates(double originX, int originY)
        {
            return Tuple.Create(2, 2);
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        private void SetUpMovingObject()
        {

            ballPosition.MouseDown += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };

            ballPosition.MouseMove += (ss, ee) =>
            {
                if (ee.Button == MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    ballPosition.Location = new Point(ballPosition.Location.X - res.X, ballPosition.Location.Y - res.Y);
                    firstPoint = temp;
                    Invalidate();
                }
            };
        }

     
        //const byte WM_NCHITTEST = 0x84;
        //const int HTTRANSPARENT = -1;

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == (int)WM_NCHITTEST)
        //        m.Result = (IntPtr)HTTRANSPARENT;
        //    else
        //        base.WndProc(ref m);
        //}

        //[DllImport("user32.dll", SetLastError = true)]
        //static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        //[DllImport("user32.dll")]
        //static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        //const int GWL_EXSTYLE = -20;
        //const int WS_EX_LAYERED = 0x80000;
        //const int WS_EX_TRANSPARENT = 0x20;
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
        //    SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        //}
    }
}
