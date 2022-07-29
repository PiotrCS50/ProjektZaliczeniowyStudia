using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy
{
    public partial class ZakupyZrealizowaneForm : Form
    {
        private Pen p;
        List<Point> punkty;
        List<Point> punkty2;
        int k = 0;
        int i = 0;
        int j = 1;
        public ZakupyZrealizowaneForm()
        {
            InitializeComponent();
            punkty = new List<Point>();
            punkty2 = new List<Point>();
        }

        public void Bad_Paint(object sender, PaintEventArgs e)
        {
            p = new Pen(Brushes.Red);
            p.Width = 18.0F;
            e.Graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
            if (punkty.Count() > 1)
                e.Graphics.DrawCurve(p, punkty.ToArray());
            if (punkty2.Count() > 1)
                e.Graphics.DrawCurve(p, punkty2.ToArray());

            for (int l = 0; l < k; l++)
            {
                e.Graphics.FillRectangle(Brushes.Red, -7, 55, 14, 5);
                e.Graphics.RotateTransform(10);
            }
        }
        public void Ok_Paint(object sender, PaintEventArgs e)
        {
            p = new Pen(Brushes.Green);
            p.Width = 18.0F;
            e.Graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
            if (punkty.Count() > 1)
                e.Graphics.DrawCurve(p, punkty.ToArray());
            for (int l = 0; l < k; l++)
            {
                e.Graphics.FillRectangle(Brushes.Green, -7, 55, 14, 5);
                e.Graphics.RotateTransform(10);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (k > 36)
            {
                if (i <= 2)
                {
                    punkty.Add(new Point(-50 + i * 25, -25 + i * 25));
                    i++;
                }
                else if (i <= 5)
                {
                    punkty.Add(new Point(j * 20, 25 - j * 35));
                    j++;
                    i++;
                }
                else { 
                    TimerOk.Enabled = false; 
                }
            }
            else
            {
                k++;
            }
            Refresh();
        }

        private void TimerBad_Tick(object sender, EventArgs e)
        {
            if (k > 36)
            {
                if (i <= 4)
                {
                    punkty.Add(new Point(-50 + i * 25, -50 +i* 25));
                    i++;
                }
                else if (i <= 9)
                {
                    punkty2.Add(new Point(75 - j * 25, -75 + j * 25));
                    j++;
                    i++;
                }
                else
                {
                    TimerBad.Enabled = false;
                }
            }
            else
            {
                k++;
            }
            Refresh();
        }
    }
}
