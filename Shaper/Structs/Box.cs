﻿namespace Shaper.Structs
{
    public struct Box
    {
        public double X;
        public double Y;
        public double Width;
        public double Height;

        public Box(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
