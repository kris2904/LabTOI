using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KristinaIlina17102
{
    public partial class Form1 : Form
    {
        int width, height;
        double[,] mass; //двумерный массив
        double min = 0;
        double max = 0;
        double k; //коеф

        public Form1()
        {
            InitializeComponent();
            chart_graf.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        private void button_function_Click(object sender, EventArgs e)
        {
            Function funcSin = CalcCustom.getSinFunc();
            Draw(funcSin);
        }
        private void button_WAVE_Wavelet_Click(object sender, EventArgs e)
        {
            Function funcWavelet = CalcCustom.getWaveletFunc();
            Draw(funcWavelet);
        }
        public void Draw(Function function)
        {
            chart_graf.Series[0].Points.Clear();
            foreach(Coordinate coordinate in function.getCoordinateList())
            {
                chart_graf.Series[0].ChartType= SeriesChartType.Spline;
                chart_graf.Series[0].Points.AddXY(coordinate.getX(), coordinate.getY());
            }
        }

        private void button_Sombrero_Click(object sender, EventArgs e)
        {
            Function funcSombrero = CalcCustom.getSombreroFunc();
            Draw(funcSombrero);
        }



        private void button_Converting_Click(object sender, EventArgs e)
        {


            width = pictureBox_Wavelet.Width;
            height = pictureBox_Wavelet.Height;
            ImageWave image = CalcCustom.WaweinPicture(width, height);


            Bitmap bmp = new Bitmap(width, height);
            int r, g, b;
            foreach (Pixels pixel in image.getPixels()) {
                r = g = b = pixel.getColor();
                bmp.SetPixel((int)pixel.getCoordinate().getX(), (int)pixel.getCoordinate().getY(), Color.FromArgb(r, g, b));
                pictureBox_Wavelet.Image = bmp;
            }
        }
    }
}
