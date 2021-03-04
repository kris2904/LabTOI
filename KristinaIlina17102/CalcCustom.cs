using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KristinaIlina17102
{
    public static class CalcCustom
    {
    
        /// <summary>
        /// Функция Sin(кореньиз(1+t^2)
        /// </summary>
        public static Function getSinFunc()
        {
            Function function = new Function();
            List<Coordinate> coordinates = new List<Coordinate>();
            for (int i = 0; i < Const.pointCount; i++)
            {
                double x = i * Const.period;
                double y = Math.Sin(Math.Sqrt(1 + Math.Pow(x, 2)));
                coordinates.Add(new Coordinate(x, y));
            }
            function.setCoordinateList(coordinates);
            return function;
        }


        /// <summary>
        /// Функция Sin(кореньиз(1+t^2)
        /// </summary>
        public static double sin(double x)
        {
            return Math.Sin(Math.Sqrt(1 + Math.Pow(x, 2)));
        }

        /// <summary>
        /// Функция Waveler(кореньиз(1+t^2)
        /// </summary>
        public static Function getWaveletFunc()
        {
            Function function = new Function();
            List<Coordinate> coordinates = new List<Coordinate>();
            for (int i = -Const.pointCount; i <= Const.pointCount; i++)
            {
                double x = i * Const.period;
                double y = -1 / Math.Sqrt(2 * Math.PI) * x * Math.Exp(-Math.Pow(x, 2) / 2);
                coordinates.Add(new Coordinate(x, y));
            }
            function.setCoordinateList(coordinates);
            return function;
        }


        /// <summary>
        /// Wave
        /// </summary>
        public static double wave(double x)
        {
            return -1 / Math.Sqrt(2 * Math.PI) * x * Math.Exp(-Math.Pow(x, 2) / 2);
        }

        /// <summary>
        /// Функция Sombrero(кореньиз(1+t^2)
        /// </summary>
        public static Function getSombreroFunc()
        {
            Function function = new Function();
            List<Coordinate> coordinates = new List<Coordinate>();
            for (int i = -Const.pointCount; i <= Const.pointCount; i++)
            {
                double x = i * Const.period;
                double y = -1 / Math.Sqrt(2 * Math.PI) * (Math.Pow(x, 2) + 1) * Math.Exp(-Math.Pow(x, 2) / 2);
                coordinates.Add(new Coordinate(x, y));
            }
            function.setCoordinateList(coordinates);
            return function;
        }

        public static double getIntegral(double move, double scale)
        {
            double shag = (move + 20) / Const.period;
            double result = 0;

            for (double x = 0; x < 10 * Math.PI + 10; x += 0.1)
            {
                result += sin(x) * wave((x - move) / scale);// интеграл с формулы вейвлета
            }

            return result;
        }

        public static ImageWave WaweinPicture(int width, int height)
        {
            //Создаем матрицу значений
            WaveletMatrix matrix = new WaveletMatrix();
            List<Node> nodeList = new List<Node>();

            double chastot = Const.Chastota / width;
            double step = Const.step / height;
            double move, scale;

            //Вычисление матрицы значений
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    move = x * chastot;
                    scale = y * step + 0.1;
                    Coordinate coordinate = new Coordinate(x, y);
                    double value = 1.0 / Math.Sqrt(Math.Abs(scale)) * getIntegral(move, scale);
                    nodeList.Add(new Node(coordinate, value));
                }
            }

            //Задаем список элементов значений матрицs посчитаных
            matrix.setNodeList(nodeList);

            //Приводим матрицу вычисленных значений к пиксельной матрице
            //** в пиксельной max = 255(белый цвет), min = 0(черный)
            double min = matrix.getMinNode(nodeList);
            double max = matrix.getMaxNode(nodeList);
            

            //Создаем изображение
            ImageWave image = new ImageWave(width, height);
            List<Pixels> pixelsList = new List<Pixels>();

            foreach (Node node in matrix.getNodeList())
            {
                Coordinate coordinate = node.getCoordinate();
                int color = (int)((node.getValue() - min) * (255 / (max - min)));
                pixelsList.Add(new Pixels(coordinate, color));

            }
            image.setPixels(pixelsList);

            return image;
        }


      

    }
}

