using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class Filters
    {
        private bool _blur;
        private bool _horizontaledgeDetection;
        private bool _verticalEdgeDetection;
        private bool _sepia;
        private int _sepiaIntensity;
        private bool _grayscale;
        private bool _invert;
        private bool _twilight;
        private bool _blackAndWhite;
        private int _umbral;
        private int _brightness;
        private bool _reset;

        // Getters and Setters
        public bool Blur { get => _blur; set => _blur = value; }
        public bool HorizontaledgeDetection { get => _horizontaledgeDetection; set => _horizontaledgeDetection = value; }
        public bool VerticalEdgeDetection { get => _verticalEdgeDetection; set => _verticalEdgeDetection = value; }
        public bool Sepia { get => _sepia; set => _sepia = value; }
        public int SepiaIntensity { get => _sepiaIntensity; set => _sepiaIntensity = value; }
        public bool Grayscale { get => _grayscale; set => _grayscale = value; }
        public bool Invert { get => _invert; set => _invert = value; }
        public int Umbral { get => _umbral; set => _umbral = value; }
        public bool Twilight { get => _twilight; set => _twilight = value; }
        public bool BlackAndWhite { get => _blackAndWhite; set => _blackAndWhite = value; }

        public int Brightness { get => _brightness; set => _brightness = value; }
        public bool Reset { get => _reset; set => _reset = value; }

        public Filters()
        {
            _blur = false;
            _horizontaledgeDetection = false;
            _verticalEdgeDetection = false;
            _sepia = false;
            _sepiaIntensity = 0;
            _grayscale = false;
            _invert = false;
            _umbral = 255/2;
            _brightness = 0;
            _reset = false;
        }

        public Color BrightnessColor(Color color)
        {
            var newR = Math.Min(255, color.R + _brightness);
            var newG = Math.Min(255, color.G + _brightness);
            var newB = Math.Min(255, color.B + _brightness);
            return Color.FromArgb(newR, newG, newB);
        }

        public Color InvertColor(Color color)
        {
            return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }

        public Color GrayscaleColor(Color color)
        {
            int gray = (color.R + color.G + color.B) / 3;
            return Color.FromArgb(gray, gray, gray);
        }

        public Color SepiaColor(Color color)
        {
            int newRed = (int)(color.R * 0.393 + color.G * 0.769 + color.B * 0.189);
            int newGreen = (int)(color.R * 0.349 + color.G * 0.686 + color.B * 0.168);
            int newBlue = (int)(color.R * 0.272 + color.G * 0.534 + color.B * 0.131);

            // Clamp the values to 255
            newRed = Math.Min(255, newRed);
            newGreen = Math.Min(255, newGreen);
            newBlue = Math.Min(255, newBlue);

            return Color.FromArgb(newRed, newGreen, newBlue);
        }
        public Color BlackAndWhiteColor(Color color)
        {
            int gray = (color.R + color.G + color.B) / 3;
            if (gray > _umbral)
                return Color.White;
            else
                return Color.Black;
        }
        public Color TwilightColor(Color color)
        {
            // The twilight filter is where the blue channel is increased and the red channel is decreased
            int newRed = color.R - 50;
            int newGreen = color.G;
            int newBlue = color.B + 50;

            // Clamp the values to 255
            newRed = Math.Max(0, newRed);
            newGreen = Math.Max(0, newGreen);
            newBlue = Math.Min(255, newBlue);

            return Color.FromArgb(newRed, newGreen, newBlue);
        }
            
        public Color ApplyFilters(int toX, int toY, Buffer[][] buffer)
        {
            Color color = buffer[toX][toY].c;

            if (_reset)
                return color;

            if (_invert)
                color = InvertColor(color);

            if (_grayscale)
                color = GrayscaleColor(color);

            if (_sepia)
                color = SepiaColor(color);

            if (_twilight)
            {
                color = TwilightColor(color);
            }

            if (_brightness != 0)
            {
                color = BrightnessColor(color);
            }

            if (_blackAndWhite)
            {
                if ((color.R + color.G + color.B) / 3 > _umbral)
                {
                    color = Color.Black;
                }
                else
                {
                    color = Color.White;
                }
            }

                
            return color;
        }

    }
}
