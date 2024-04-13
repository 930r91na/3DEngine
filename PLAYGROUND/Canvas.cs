using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLAYGROUND
{
    public class Canvas
    {
        static PictureBox pctCanvas;

        Size size;
        Bitmap bmp;
        public int Width, Height;
        byte[] _bits;
        Graphics g;
        int _pixelFormatSize, _stride;
        Rectangle rect;

        public Canvas(PictureBox pctCanvas)
        {
            Canvas.pctCanvas = pctCanvas;
            this.size = pctCanvas.Size;
            Init(size.Width, size.Height);
            pctCanvas.Image = bmp;
        }

        private void Init(int width, int height)
        {
            PixelFormat format;
            GCHandle handle;
            IntPtr bitPtr;
            int padding;

            format = PixelFormat.Format32bppArgb;
            this.Width = width;
            this.Height = height;
            _pixelFormatSize = Image.GetPixelFormatSize(format) / 8; // 8 bits = 1 byte
            _stride = width * _pixelFormatSize; // total pixels (Width) times ARGB (4)
            padding = (_stride % 4); // PADD = move every pixel in bytes
            _stride += padding == 0 ? 0 : 4 - padding; // 4 byte multiple Alpha, Red, Green, Blue
            _bits = new byte[_stride * height]; // total pixels (Width) times ARGB (4) times Height
            handle = GCHandle.Alloc(_bits, GCHandleType.Pinned); // TO LOCK THE MEMORY
            bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(_bits, 0);
            bmp = new Bitmap(width, height, _stride, format, bitPtr);
            g = Graphics.FromImage(bmp); // Para hacer pruebas regulares
            rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        }

        public void SetPixel(int x, int y, Color c)
        {
            long res = (x * _pixelFormatSize) + (y * _stride);

            _bits[res + 0] = c.B; // (byte)Blue;
            _bits[res + 1] = c.G; // (byte)Green;
            _bits[res + 2] = c.R; // (byte)Red;
            _bits[res + 3] = c.A; // (byte)Alpha;
        }


        public void FastClear()
        {
            int div = 16;

            Parallel.For(0, _bits.Length / div, i => // unrolling 
            {
                _bits[(i * div) + 0] = 0;
                _bits[(i * div) + 1] = 0;
                _bits[(i * div) + 2] = 0;
                _bits[(i * div) + 3] = 0;

                _bits[(i * div) + 4] = 0;
                _bits[(i * div) + 5] = 0;
                _bits[(i * div) + 6] = 0;
                _bits[(i * div) + 7] = 0;

                _bits[(i * div) + 8] = 0;
                _bits[(i * div) + 9] = 0;
                _bits[(i * div) + 10] = 0;
                _bits[(i * div) + 11] = 0;

                _bits[(i * div) + 12] = 0;
                _bits[(i * div) + 13] = 0;
                _bits[(i * div) + 14] = 0;
                _bits[(i * div) + 15] = 0;
            });
        }

        public void Refresh()
        {
            pctCanvas.Invalidate();
        }
    }
}