using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace Projem
{
    public partial class Form2 : Form
    {
        string[] dizi;
        string sonuc;

        public Form2()
        {
            InitializeComponent();
        }

        /*public static double testStatistic(double meanTreatmentSumOfSquares, double meanErrorSumOfSquares)
        {
            return (meanTreatmentSumOfSquares / meanErrorSumOfSquares);
        }

        public static double pValue(double fStatistic, int degreeNum, int degreeDenom)
        {
            double pValue = 0;
            pValue = integrate(0, fStatistic, degreeNum, degreeDenom);

            return pValue;

        }

        public static double integrate(double start, double end, int degreeFreedomT, int degreeFreedomE)
        {
            int iterations = 100000;
            double x, dist, sum = 0, sumT = 0;
            dist = (end - start) / iterations;
            for (int i = 1; i <= iterations; i++)
            {
                x = start + i * dist;
                sumT += integralFunction(x - dist / 2, degreeFreedomT, degreeFreedomE);
                if (i < iterations)
                {
                    sum += integralFunction(x, degreeFreedomT, degreeFreedomE);
                }
            }
            sum = (dist / 6) * (integralFunction(start, degreeFreedomT, degreeFreedomE) + integralFunction(end, degreeFreedomT, degreeFreedomE) + 2 * sum + 4 * sumT);
            return sum;
        }

        public static double integralFunction(double x, int degreeFreedomT, int degreeFreedomE)
        {
            double temp = 0;
            temp = ((Math.Pow(degreeFreedomE, degreeFreedomE / 2) * Math.Pow(degreeFreedomT, degreeFreedomT / 2)) / (factorial(degreeFreedomE / 2 - 1) * factorial(degreeFreedomT / 2 - 1))) * (factorial(((degreeFreedomT + degreeFreedomE) / 2 - 1))) * ((Math.Pow(x, degreeFreedomE / 2 - 1)) / (Math.Pow((degreeFreedomT + degreeFreedomE * x), ((degreeFreedomE + degreeFreedomT) / 2))));
            return temp;
        }

        public static double factorial(double n)
        {
            if (n == 0)
            {
                return 1.0;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }*/
        //private void ciz()
        //{
        //    var graph = new Bitmap(400, 400);
        //    var g = Graphics.FromImage(graph);

        //    //grid
        //    for (int i = 0; i < 400; i += 10)
        //    {
        //        g.DrawLine(Pens.SkyBlue, i, 0, i, 400);
        //        g.DrawLine(Pens.SkyBlue, 0, i, 400, i);
        //    }

        //    //eksen
        //    g.DrawLine(Pens.Black, 0, 200, 400, 200);
        //    g.DrawLine(Pens.Black, 200, 0, 200, 400);

        //    //sayılar
        //    for (int i = -200; i <= 200; i += 40)
        //    {
        //        g.DrawString((i / 10).ToString(), new Font(FontFamily.GenericMonospace, 6, FontStyle.Regular), Brushes.Black, i + 200, 200);
        //        g.DrawString((-i / 10).ToString(), new Font(FontFamily.GenericMonospace, 6, FontStyle.Regular), Brushes.Black, 200, i + 200);
        //    }

        //    //y = 2x  - 4 'nin grafiği
        //    for (int x = -1000; x <= 1000; x++)
        //        g.DrawEllipse(Pens.Red, x + 200, ((x * x  - 4) * -1) + 200, 1, 1);
        //    pictureBox.Image = graph;
        //}
        private void DrawBackGround()
        {
            int sizeX = 400;
            int sizeY = 400;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = -5;
            maxX = 5;
            minY = -5;
            maxY = 5;
            var graph = new Bitmap(400, 400);
            //var g = Graphics.FromImage(graph);
            Graphics g = Graphics.FromImage(graph);
            g.Clear(Color.White);

            for (int i = 0; i < sizeX; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 20)
            {
                g.DrawLine(new Pen(Color.Blue), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.Black), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.Black), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));

            for (int i = 40; i < sizeX; i += 40)
            {
                if (i == sizeX / 2) continue;
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(i - 15, sizeY / 2 + 4));
            }
            for (int i = 40; i < sizeY; i += 40)
            {
                if (i == sizeY / 2) continue;
                string st = (minX + (sizeY - i) * ((maxY - minY) / sizeY)).ToString();
                g.DrawLine(new Pen(Color.Black, 2), new Point(sizeX / 2 + 5, i), new Point(sizeX / 2 - 5, i));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, i + 4));
            }
            string point = "(" + (minX + (maxX - minX) / 2) + "; " + (minX + (maxY - minY) / 2) + ")";
            g.DrawString(point, new Font("Arial", 8), new SolidBrush(Color.Black), new PointF(sizeX / 2 - 15, sizeY / 2 + 4));

            pictureBox.Image=graph;
        }
        private void DrawFunction()
        {
            int sizeX = 400;
            int sizeY =400;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = -5;
            maxX = 5;
            minY = -5;
            maxY = 5;

            var graph = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(graph);

            Point currentPoint = new Point();
            Point previousPoint = new Point();
            bool isCurentPoint = false;
            bool isPreviousPoint = false;
            for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
            {
                double y = x*x;

                

                if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                if (isCurentPoint)
                {
                    currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                    currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                    if (isPreviousPoint)
                    {
                        g.DrawLine(new Pen(Color.Black, 2), previousPoint, currentPoint);
                    }
                }
                previousPoint = currentPoint;
                isPreviousPoint = isCurentPoint;
            }
                for (int z = -1000; z <= 1000; z++)
                    g.DrawEllipse(Pens.Red, z + 200, ((z * z * z - 4) * -1) + 200, 1, 1);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void parcala(string Text)
        {
            char[] karakter = { '+', '-'};
            dizi=Text.Split(karakter);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void sonucyazdır()
        {
            TextBox sonucyz = new TextBox();
            sonucyz.Name = "snc" ;
            sonucyz.ReadOnly = true;
            sonucyz.Size = new Size(100, 200);

            sonucyz.Location = new Point(100, 240);
            sonucyz.Text = sonuc;
            this.Controls.Add(sonucyz);

        }
        private void usayarla()
        {
            int i = 0;
            git:
            for (; i < dizi.Length; i++)
            {

                if (dizi[i].Contains("x^10"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 4, 4);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 10) + "x^9";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^9"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 9) + "x^8";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^8"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 8) + "x^7";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^7"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 7) + "x^6";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^6"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 6) + "x^5";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^5"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 5) + "x^4";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^4"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 4) + "x^3";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^3"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 3) + "x^2";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x^2"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 3, 3);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1"; if (dizi[i].Length == 0)
                        {
                            dizi[i] = "1";
                        }
                    }
                    dizi[i] = Convert.ToString(Convert.ToDouble(dizi[i]) * 2) + "x";
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }
                if (dizi[i].Contains("x"))
                {
                    dizi[i] = dizi[i].Remove(dizi[i].Length - 1, 1);
                    if (dizi[i].Length == 0)
                    {
                        dizi[i] = "1";
                    }
                    sonuc += dizi[i];
                    i++;
                    goto git;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parcala(textBox1.Text);
            usayarla();
            DrawBackGround();
            DrawFunction();
            sonucyazdır();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
