﻿using System;
using System.Drawing;
using SkiaSharp;

namespace Modern.Forms
{
    public class PaintEventArgs : EventArgs
    {
        public PaintEventArgs (SKImageInfo info, SKCanvas canvas, double scaling)
        {
            Info = info;
            Canvas = canvas;
            Scaling = scaling;
        }

        public SKImageInfo Info { get; }

        public SKCanvas Canvas { get; set; }

        public double Scaling { get; }

        /// <summary>
        /// Transforms a horizontal or vertical integer coordinate from logical to device units
        /// by scaling it up  for current DPI and rounding to nearest integer value
        /// </summary>
        /// <param name="value">value in logical units</param>
        /// <returns>value in device units</returns>
        public int LogicalToDeviceUnits (int value) => (int)Math.Round (Scaling * value);

        public Size LogicalToDeviceUnits (Size value) => new Size (LogicalToDeviceUnits (value.Width), LogicalToDeviceUnits (value.Height));

        public Padding LogicalToDeviceUnits (Padding logicalPadding)
        {
            return new Padding (LogicalToDeviceUnits (logicalPadding.Left),
                                LogicalToDeviceUnits (logicalPadding.Top),
                                LogicalToDeviceUnits (logicalPadding.Right),
                                LogicalToDeviceUnits (logicalPadding.Bottom));
        }
    }
}
