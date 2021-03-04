using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KristinaIlina17102
{
    public class ImageWave
    {
        private List<Pixels> pixels;
        private int width, height;

        public ImageWave() { }
        public ImageWave(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        

        public List<Pixels> getPixels() { return pixels; }

        public void setPixels(List<Pixels> pixels)
        {
            this.pixels = pixels;
        }

        public int getWidth() { return width; }

        public void setWidth(int width)
        {
            this.width = width;
        }
        public int getHeight() { return height; }

        public void setHeight(int height)
        {
            this.height = height;
        }

    }
}
