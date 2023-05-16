using System;
using System.Runtime.InteropServices;

public class Util
{
    [DllImport("ImageFlip")]
    public static extern void FlipImageVertically(IntPtr imageData, int width, int height, int bytesPerPixel);
}