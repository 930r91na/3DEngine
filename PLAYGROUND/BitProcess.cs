using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLAYGROUND
{
    public class BitProcess
    {
        //private static byte a = 3;
        private static byte r = 2;
        private static byte g = 1;
        private static byte b = 0;

        public static byte[] Invert(byte[] bits)
        {
            int div = 16;
            Parallel.For(0, bits.Length / div, i => // unrolling 
            {
                bits[(i * div) + 0] = (byte)(255 - bits[(i * div) + 0]);
                bits[(i * div) + 1] = (byte)(255 - bits[(i * div) + 1]);
                bits[(i * div) + 2] = (byte)(255 - bits[(i * div) + 2]);
                //bits[(i * div) + 3] = (byte)(255 - bits[(i * div) + 3]);

                bits[(i * div) + 4] = (byte)(255 - bits[(i * div) + 4]);
                bits[(i * div) + 5] = (byte)(255 - bits[(i * div) + 5]);
                bits[(i * div) + 6] = (byte)(255 - bits[(i * div) + 6]);
                //bits[(i * div) + 7] = (byte)(255 - bits[(i * div) + 7]);

                bits[(i * div) + 8] = (byte)(255 - bits[(i * div) + 8]);
                bits[(i * div) + 9] = (byte)(255 - bits[(i * div) + 9]);
                bits[(i * div) + 10] = (byte)(255 - bits[(i * div) + 10]);
                //bits[(i * div) + 11] = (byte)(255 - bits[(i * div) + 11]);

                bits[(i * div) + 12] = (byte)(255 - bits[(i * div) + 12]);
                bits[(i * div) + 13] = (byte)(255 - bits[(i * div) + 13]);
                bits[(i * div) + 14] = (byte)(255 - bits[(i * div) + 14]);
                //bits[(i * div) + 15] = (byte)(255 - bits[(i * div) + 15]);
            });

            return bits;
        }

        private static void GrayPixel(byte[] bits, int div, int i, int idx)
        {
            float val;

            val = bits[(i * div) + idx + r] + bits[(i * div) + idx + g] + bits[(i * div) + idx + b];
            val /= 3;

            bits[(i * div) + idx + r] = (byte)val;
            bits[(i * div) + idx + g] = (byte)val;
            bits[(i * div) + idx + b] = (byte)val;
        }

        private static void SepiaPixel(byte[] bits, int div, int i, int idx)
        {
            int newRed;
            int newBlue;
            int newGreen;

            newRed = (int)((bits[(i * div) + idx + r] * 0.393) + (bits[(i * div) + idx + g] * 0.769) + (bits[(i * div) + idx + b] * 0.189));
            newGreen = (int)((bits[(i * div) + idx + r] * 0.349) + (bits[(i * div) + idx + g] * 0.686) + (bits[(i * div) + idx + b] * 0.168));
            newBlue = (int)((bits[(i * div) + idx + r] * 0.272) + (bits[(i * div) + idx + g] * 0.534) + (bits[(i * div) + idx + b] * 0.131));

            newRed = Math.Min(255, newRed);
            newGreen = Math.Min(255, newGreen);
            newBlue = Math.Min(255, newBlue);

            bits[(i * div) + idx + r] = (byte)newRed;
            bits[(i * div) + idx + g] = (byte)newGreen;
            bits[(i * div) + idx + b] = (byte)newBlue;
        }
        private static void BrightnessPixel(byte[] bits, int div, int i, int idx, int value)
        {
            int newRed;
            int newBlue;
            int newGreen;

            newRed = bits[(i * div) + idx + r] + value;
            newGreen = bits[(i * div) + idx + g] + value;
            newBlue = bits[(i * div) + idx + b] + value;

            newRed = Math.Min(255, newRed);
            newGreen = Math.Min(255, newGreen);
            newBlue = Math.Min(255, newBlue);

            bits[(i * div) + idx + r] = (byte)newRed;
            bits[(i * div) + idx + g] = (byte)newGreen;
            bits[(i * div) + idx + b] = (byte)newBlue;
        }
        private static void ContrastePixel(byte[] bits, int div, int i, int idx, float value)
        {
            float newRed;
            float newBlue;
            float newGreen;

            newRed = value * (bits[(i * div) + idx + r] - 128) + 128;
            newBlue = value * (bits[(i * div) + idx + b] - 128) + 128;
            newGreen = value * (bits[(i * div) + idx + g] - 128) + 128;

            newRed = Math.Min(255, Math.Max(0, newRed));
            newGreen = Math.Min(255, Math.Max(0, newGreen));
            newBlue = Math.Min(255, Math.Max(0, newBlue));


            bits[(i * div) + idx + r] = (byte)newRed;
            bits[(i * div) + idx + g] = (byte)newGreen;
            bits[(i * div) + idx + b] = (byte)newBlue;
        }

        public static byte[] Contraste(byte[] bits, float value)
        {
            int div = 16;
            Parallel.For(0, bits.Length / div, i =>
            {
                ContrastePixel(bits, div, i, 0, value);
                ContrastePixel(bits, div, i, 4, value);
                ContrastePixel(bits, div, i, 8, value);
                ContrastePixel(bits, div, i, 12, value);
            });
            return bits;
        }



        public static byte[] Gray(byte[] bits)
        {
            int div = 16;
            Parallel.For(0, bits.Length / div, i => // unrolling 
            {
                GrayPixel(bits, div, i, 0);
                GrayPixel(bits, div, i, 4);
                GrayPixel(bits, div, i, 8);
                GrayPixel(bits, div, i, 12);
            });

            return bits;
        }

        public static byte[] Sepia(byte[] bits)
        {
            int div = 16;

            Parallel.For(0, bits.Length / div, i => // unrolling 
            {
                SepiaPixel(bits, div, i, 0);
                SepiaPixel(bits, div, i, 4);
                SepiaPixel(bits, div, i, 8);
                SepiaPixel(bits, div, i, 12);
            });

            return bits;
        }

        public static byte[] Brightness(byte[] bits, int value)
        {
            int div = 16;

            Parallel.For(0, bits.Length / div, i => // unrolling
            {
                BrightnessPixel(bits, div, i, 0, value);
                BrightnessPixel(bits, div, i, 4, value);
                BrightnessPixel(bits, div, i, 8, value);
                BrightnessPixel(bits, div, i, 12, value);
            });
            return bits;
        }
    }
}
